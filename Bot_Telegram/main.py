from config import TOKEN
from apl_home_bot import TelegramBot

# ------------------------------------------- MAIN -----------------------------------------------------------------------
def main():

    bot = TelegramBot(TOKEN)
    bot.run()

if __name__ == "__main__":
    main()