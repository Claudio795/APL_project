import json
from ntpath import join
from statistics import quantiles
from threading import Thread
from time import sleep
from datetime import date
import requests

from telegram import ReplyKeyboardMarkup, ReplyKeyboardRemove
from telegram.ext import (
    Updater,
    CommandHandler,
    MessageHandler,
    Filters,
    ConversationHandler,
    CallbackContext
)

from config import CHAT_ID, PathPrefix
from utils import utils, endpoints

# RETURN STATES
GETLIST = 0
UPTITEM = 1
GETITEM = 2
GETQNTY = 3
ADDQNTY = 4
ADDCAT = 5
ADDURGET = 6
GETTURNS = 7
GETUSER = 8
UPTTURN = 9
# -------------------------------------------- CLASSE BOT TELEGRAM ----------------------------------------------------------
class TelegramBot(object):
    
    def __init__(self, token):
        self.token = token
        #thread = Thread(target=self.run, args=())
        #thread.daemon = True
        #thread.start()
     
    # Avvio ------------------------------------------------------------------------------------------------------------------
    def start(self, update, context):
        # messaggio di risposta dal bot
        update.message.reply_text('Bot avviato, usa /help per visualizzare i comandi disponibili')

    # Comando per richiedere la lista dei turni per una data stanza ----------------------------------------------------------
    def get_room(self, update, context):
        reply_keyboard = [['Cucina'],
                          ['Aree_comuni'],
                          ['Bagno'],
                          ['Lavanderia'],
                          ['/annulla']]
        update.message.reply_text("Scegliere la stanza per la quale visualizzare i turni",
                                    reply_markup = ReplyKeyboardMarkup(
                                        reply_keyboard, one_time_keyboard=True
                                        ),
                                    )
        return GETTURNS

    def get_turns(self, update, context):
        room = update.message.text
        endpoint = endpoints.get_turns(room)
        r = str(requests.get(endpoint).text)[1:-2]
        turns = r.split('-')
        text_turns = '\n'.join(turns)
        update.message.reply_text(text_turns, reply_markup=ReplyKeyboardRemove())
        update.message.reply_text(f"Questa settimana tocca a {turns[0]}")
        return ConversationHandler.END

    # Comando per completare un turno ----------------------------------------------------------------------------------------
    def post_turn(self, update, context):
        reply_keyboard = [['Cucina'],
                    ['Aree_comuni'],
                    ['Bagno'],
                    ['Lavanderia'],
                    ['/annulla']]
        update.message.reply_text("Seleziona la stanza che hai pulito",
                            reply_markup = ReplyKeyboardMarkup(
                                reply_keyboard, one_time_keyboard=True
                                ),)
        return GETUSER

    def get_user(self, update, context):
        room = update.message.text
        context.user_data["room"] = room
        reply_keyboard = [['Si'],
                          ['No'],
                          ['/annulla']]
        update.message.reply_text("È il tuo turno?", 
                                reply_markup = ReplyKeyboardMarkup(
                                reply_keyboard, one_time_keyboard=True
                                ),)
        return UPTTURN

    def upd_turns(self, update, context):
        room = context.user_data['room']

        if(update.message.text == 'Si'): 
            upt_turns = True
            message = 'Turno aggiunto e lista aggiornata'
        else: 
            upt_turns = False
            message = 'Turno aggiunto'

        result = utils.update_turns(update, room, upt_turns)
        if(result == 200):
            update.message.reply_text(message, reply_markup=ReplyKeyboardRemove())
        else:
            update.message.reply_text("Qualcosa è andato storto", reply_markup=ReplyKeyboardRemove())

        return ConversationHandler.END
    
    # Comando per richiedere la lista della spesa ----------------------------------------------------------------------------
    # Richiedi la categoria della lista
    def send_category(self, update, context):
        reply_keyboard = [["Completa"],
                            ["Alimentari"],
                            ["Medicine"],
                            ["Pulizia_casa"],
                            ["Igiene_personale"],
                            ["Urgenti"],
                            ["/annulla"]]
        update.message.reply_text("Quale lista ti interessa?",
                                    reply_markup = ReplyKeyboardMarkup(
                                        reply_keyboard, one_time_keyboard=True
                                        ),
                                    )
        return GETLIST
    # Usa la categoria per ottenere la lista corretta
    def get_list(self, update, context):
        category = update.message.text
        endpoint = endpoints.grocery_endpoint(category)
        #print(endpoint)
        r = requests.get(endpoint)
        #print(r)
        input = r.json()
        #print(input)
        grocery_list = utils.get_grocery_list(input)
        print(grocery_list)
        update.message.reply_text(''.join(grocery_list), reply_markup=ReplyKeyboardRemove())
        return ConversationHandler.END


    # Comando per modificare la quantità di un elemento della lista della spesa ----------------------------------------------
    # Sfrutta la categoria per ottenere la lista da cui scegliere l'oggetto da modificare
    def get_item(self, update, context):
        try:
            category = str(context.args[0])
            list_endpoint = endpoints.grocery_endpoint(category)
            r_list = requests.get(list_endpoint).json()
            reply_keyboard = [[item['name'] + ': ' + str(item['quantity'])] for item in r_list]
            reply_keyboard.append(["/annulla"])

            update.message.reply_text("Quale oggetto hai acquistato/vuoi modificare?",
                                        reply_markup = ReplyKeyboardMarkup(
                                            reply_keyboard, one_time_keyboard=True
                                            ),
                                        )
        except:
            update.message.reply_text("Invia insieme al comando, la categoria dell'oggetto acquistato")
            return ConversationHandler.END

        return GETQNTY

    def get_quantity(self, update, context):
        name = update.message.text
        context.user_data["name"] = name.split(':')[0]
        update.message.reply_text("Inserisci la quantità da aggiungere o sottrarre al totale (indicare la quantità col segno meno [-] se è da sottrarre)",
                                    reply_markup=ReplyKeyboardRemove()
                                    )
        return UPTITEM

    def upt_item(self, update, context):
        endpoint = endpoints.upt_item_endpoint()
        quantity = int(update.message.text)
        name = context.user_data["name"]
        updated_item = {
            'name': name,
            'quantity': quantity
        }
        r = requests.put(endpoint, data=json.dumps(updated_item))
        print(r.status_code)
        if(r.status_code == 200):
            update.message.reply_text("Oggetto aggiornato")
        else:
            update.message.reply_text("Qualcosa è andato storto")

        return ConversationHandler.END

    # Comando per inserire un elemento nella lista della spesa ---------------------------------------------------------------
    def add_item(self, update, context):
        try:
            name = str(context.args[0])
            context.user_data["name"] = name
            reply_keyboard = [['Alimentari'],
                              ['Medicine'],
                              ['Pulizia_casa'],
                              ['Igiene_personale'],
                              ['/annulla']]
            update.message.reply_text("Inserisci la categoria",
                                        reply_markup = ReplyKeyboardMarkup(                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                                            reply_keyboard, one_time_keyboard=True
                                            ),)

        except:
            update.message.reply_text("Invia il nome dell'oggetto insieme al comando")
            return ConversationHandler.END

        return ADDCAT

    def add_category(self, update, context):
        category = update.message.text
        name = context.user_data['name']

        endpoint = endpoints.grocery_endpoint(category)
        r_list = requests.get(endpoint).json()

        if any(item['name'] == name for item in r_list):
            update.message.reply_text("Oggetto già presente",
                                        reply_markup=ReplyKeyboardRemove())
            return ConversationHandler.END

        context.user_data["category"] = category.lower()
        update.message.reply_text("Inserisci la quantità",
                                    reply_markup=ReplyKeyboardRemove())
        return ADDQNTY

    def add_quantity(self, update, context):
        quantity = update.message.text
        try:
            quantity = int(quantity)
            context.user_data["quantity"] = quantity

            reply_keyboard = [["Si"],
                            ["No"],
                            ["/annulla"]]

            update.message.reply_text("È urgente?", 
                                    reply_markup = ReplyKeyboardMarkup(
                                            reply_keyboard, one_time_keyboard=True
                                            ),
                                        )
        except:
            update.message.reply_text("Inserisci un numero intero")
            return ConversationHandler.END                                
        return ADDURGET

    def add_urgent(self, update, context):
        name = context.user_data["name"]
        category = context.user_data["category"]
        quantity = context.user_data["quantity"]
        urgent = update.message.text
        if(urgent == 'Si'): urgent = True
        else: urgent = False

        item = {
            "name": name,
            "category": category,
            "quantity": quantity,
            "isurgent": urgent
        }
        
        endpoint = endpoints.add_item_endpoint()
        r = requests.post(endpoint, data=json.dumps(item))
        if(r.status_code == 200):
            update.message.reply_text(f"{item['name']} aggiunto alla lista della spesa",
                                        reply_markup=ReplyKeyboardRemove())
        else:
            update.message.reply_text("Qualcosa è andato storto",
                                        reply_markup=ReplyKeyboardRemove())

        return ConversationHandler.END

    # Comando per annullare --------------------------------------------------------------------------------------------------
    def help(self, update, context):
        with open("commands.txt", "r") as f:
            lines = []
            for line in f:
                lines.append(line)

            message = '\n'.join(lines)
        update.message.reply_text(message)
        return ConversationHandler.END

    # Comando per annullare --------------------------------------------------------------------------------------------------
    def cancel(self, update, context):
        update.message.reply_text("Operazione annullata.",
        reply_markup=ReplyKeyboardRemove()
        )
        return ConversationHandler.END
    
    # run --------------------------------------------------------------------------------------------------------------------
    def run(self):
        self.upd = Updater(self.token, use_context=True)
        self.disp = self.upd.dispatcher

        chat_filter = Filters.chat(chat_id=CHAT_ID)
        start_handler = CommandHandler("start", self.start, filters=chat_filter)
        help_handler = CommandHandler("help", self.help, filters=chat_filter)

        get_grocery_list_handler = ConversationHandler(
            entry_points=[CommandHandler("lista_spesa", self.send_category, filters=chat_filter)], 
            states= {
                GETLIST: [
                    MessageHandler(Filters.text & ~Filters.command, self.get_list)]
            },
            fallbacks=[CommandHandler("annulla", self.cancel)]
        )

        upt_item_handler = ConversationHandler(
            entry_points=[CommandHandler("modifica_quantita", self.get_item, filters=chat_filter)], 
            states= {
                GETQNTY: [
                    MessageHandler(Filters.text & ~Filters.command, self.get_quantity)
                ],
                UPTITEM: [
                    MessageHandler(Filters.text & ~Filters.command, self.upt_item)
                    ]
            },
            fallbacks=[CommandHandler("annulla", self.cancel)]
        )

        add_item_handler = ConversationHandler(
            entry_points=[CommandHandler("aggiungi", self.add_item, filters=chat_filter)],
            states= {
                ADDCAT: [
                    MessageHandler(Filters.text & ~Filters.command, self.add_category)
                ],
                ADDQNTY: [
                    MessageHandler(Filters.text & ~Filters.command, self.add_quantity)
                ],
                ADDURGET: [
                    MessageHandler(Filters.text & ~Filters.command, self.add_urgent)
                ]
            },
            fallbacks=[CommandHandler("annulla", self.cancel)]
        )

        get_turns_handler = ConversationHandler(
            entry_points=[CommandHandler("turni", self.get_room, filters=chat_filter)],
            states= {
                GETTURNS: [
                     MessageHandler(Filters.text & ~Filters.command, self.get_turns)
                ]
            },
            fallbacks=[CommandHandler("annulla", self.cancel)]
        )

        add_turn_handler = ConversationHandler(
            entry_points=[CommandHandler("pulizia", self.post_turn, filters=chat_filter)],
            states= {
                GETUSER: [
                    MessageHandler(Filters.text & ~Filters.command, self.get_user)
                ],
                UPTTURN: [
                    MessageHandler(Filters.text & ~Filters.command, self.upd_turns)
                ]
            },
            fallbacks=[CommandHandler("annulla", self.cancel)]
        )

        self.disp.add_handler(start_handler)
        self.disp.add_handler(help_handler)
        self.disp.add_handler(get_grocery_list_handler)
        self.disp.add_handler(upt_item_handler)
        self.disp.add_handler(add_item_handler)
        self.disp.add_handler(get_turns_handler)
        self.disp.add_handler(add_turn_handler)

        # avvio del bot, resta in esecuzione fino ad quando non
        #riceve un CTRL+C, SIGTERM O SIGABRT
        self.upd.start_polling()