from pathlib import Path
from config import PathPrefix

def grocery_endpoint(category):
    if(category == "Completa"):
        endpoint = PathPrefix + "grocery/getall"
    elif(category == "Urgenti"):
        endpoint = PathPrefix + "grocery/geturgent"
    else:
        endpoint = PathPrefix + "grocery/getbycategory/" + category.lower()

    return endpoint

def upt_item_endpoint():
    return PathPrefix + "grocery/updatequantity"

def add_item_endpoint():
    return PathPrefix + "grocery/insert" 

def get_turns(room):
    return PathPrefix + "rooms/getturns/" + room

def get_user(username):
    return PathPrefix + "users/search/username/" + username

def get_room(room):
    return PathPrefix + "rooms/getroom/" + room

def post_cleaning():
    return PathPrefix + "cleaning/insert"

def put_turns():
    return PathPrefix + "room/update"