import json
from utils import endpoints
import requests
from datetime import date

def get_grocery_list(input):
    grocery_list = []
    for item in input:
        row = item['name'] + ": " + str(item["quantity"])
        if(item["isurgent"]==True):
            row = "[Urgente] " + row 
        row = row + "\n"
        grocery_list.append(row)
    return grocery_list


def update_turns(update, room, upt_turns):
    username = update.message.from_user['username']
    user_endpoint = endpoints.get_user(username)
    req_user = requests.get(user_endpoint)
    user_id = req_user.json()['id']
    # prendi l'id della stanza
    room_endpoint = endpoints.get_room(room)
    req_room = requests.get(room_endpoint)
    room_id = req_room.json()['id']
    # ottieni la data odierna
    today = date.today().strftime("%d/%m/%Y")
    # inserisci il nuovo giorno di pulizia
    clean_data = {
        'roomid': room_id,
        'userid': user_id,
        'cleandate': today
    }
    clean_endpoint = endpoints.post_cleaning()
    r_post = requests.post(clean_endpoint, data=json.dumps(clean_data))

    if(r_post.status_code != 200):
        return r_post.status_code

    if(upt_turns):
        # aggiorna lista turni
        turns_endpoint = endpoints.get_turns(room)
        req_turns = str(requests.get(turns_endpoint).text)[1:-2]
        turns = req_turns.split('-')
        user = turns.pop(0)
        turns.append(user)
        text_turns = '-'.join(turns)
        room_data = {
            'name': room,
            'userlist': text_turns
        }
        put_endpoint = endpoints.put_turns()
        put_turns = requests.put(put_endpoint, data=json.dumps(room_data))

        return put_turns.status_code
    else:
        return r_post.status_code