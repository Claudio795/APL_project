package controllers

import (
	"REST_Server/config"
	"REST_Server/entities"
	"REST_Server/models"

	"fmt"
	"log"
	"strconv"

	"encoding/json"
	"net/http"

	"github.com/gorilla/mux"
)

//================================ HANDLER ====================================================================
func GroceryHandler(groceryRouter *mux.Router) {

	// CRUD grocery
	groceryRouter.HandleFunc("/getall", GetGroceryList).Methods("GET")
	groceryRouter.HandleFunc("/getbycategory/{category}", GetByCategory).Methods("GET")
	groceryRouter.HandleFunc("/geturgent", GetUrgent).Methods("GET")
	groceryRouter.HandleFunc("/insert", InsertNewItem).Methods("POST")
	groceryRouter.HandleFunc("/delete/{id}", DeleteItem).Methods("DELETE")
	groceryRouter.HandleFunc("/updatequantity", UpdateQuantity).Methods("PUT")
	//groceryRouter.HandleFunc("/updateurgency/{id}", UpdateUrgency).Methods("PUT")
	groceryRouter.HandleFunc("/updateitem", UpdateItem).Methods("PUT")
}

//================================ GET ALL ====================================================================
func GetGroceryList(w http.ResponseWriter, r *http.Request) {
	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	GroceryModel := models.GroceryModel{
		DB: db,
	}

	groceryList, err2 := GroceryModel.FindAll()
	if err2 != nil {
		fmt.Println(err2)
	} else {
		w.WriteHeader(http.StatusOK)
		json.NewEncoder(w).Encode(groceryList)

	}

}

//=============================== GET BY CATEGORY =====================================================================
func GetByCategory(w http.ResponseWriter, r *http.Request) {
	category := mux.Vars(r)["category"]
	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	GroceryModel := models.GroceryModel{
		DB: db,
	}

	groceryList, err2 := GroceryModel.GetByCategory(category)
	if err2 != nil {
		fmt.Println(err2)
	} else {
		w.WriteHeader(http.StatusOK)
		json.NewEncoder(w).Encode(groceryList)

	}

}

//=============================== GET URGENT =====================================================================
func GetUrgent(w http.ResponseWriter, r *http.Request) {
	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	GroceryModel := models.GroceryModel{
		DB: db,
	}

	groceryList, err2 := GroceryModel.GetUrgent()
	if err2 != nil {
		fmt.Println(err2)
	} else {
		w.WriteHeader(http.StatusOK)
		json.NewEncoder(w).Encode(groceryList)

	}

}

//============================= INSERT NEW ITEM =======================================================================
func InsertNewItem(w http.ResponseWriter, r *http.Request) {
	item := new(entities.Grocery)
	err := json.NewDecoder(r.Body).Decode(item)
	if err != nil {
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	db, err2 := config.DbConnect()
	defer config.DbDisconnect(db)

	if err2 != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	GroceryModel := models.GroceryModel{
		DB: db,
	}

	// check if the item is present in the db
	name := item.Name
	isPresent, _ := GroceryModel.SearchItemByName(name)
	if isPresent != nil {
		http.Error(w, "Item already exists, try to update his quantity instead", http.StatusForbidden)
		return
	}

	// if not present, create row in the db
	_, err3 := GroceryModel.InsertNewItem(item)
	if err3 != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	w.WriteHeader(http.StatusOK)
}

//================================== UPDATE QUANTITY ==================================================================
func UpdateQuantity(w http.ResponseWriter, r *http.Request) {
	item := new(entities.Grocery)
	err := json.NewDecoder(r.Body).Decode(&item)

	if err != nil {
		fmt.Print("sei qui")
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	db, err2 := config.DbConnect()
	defer config.DbDisconnect(db)

	if err2 != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	GroceryModel := models.GroceryModel{
		DB: db,
	}

	name := item.Name
	/*
		isPresent, _ := GroceryModel.SearchItem(id)
		if isPresent == nil {
			fmt.Println("Item missing, I'm adding it to the cart")
			_, err3 := GroceryModel.InsertNewItem(item)
			if err3 != nil {
				http.Error(w, err.Error(), http.StatusInternalServerError)
				return
			}
			w.WriteHeader(http.StatusOK)
			return
		}
	*/

	quantity := item.Quantity
	_, err3 := GroceryModel.UpdateQuantity(name, quantity)
	if err3 != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	w.WriteHeader(http.StatusOK)
	return
}

//================================= UPDATE URGENCY ===================================================================
func UpdateUrgency(w http.ResponseWriter, r *http.Request) {
	id, _ := strconv.ParseInt(mux.Vars(r)["id"], 0, 64)

	db, err := config.DbConnect()
	defer config.DbDisconnect(db)

	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	GroceryModel := models.GroceryModel{
		DB: db,
	}

	_, err3 := GroceryModel.UpdateUrgency(id)
	if err3 != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	w.WriteHeader(http.StatusOK)
}

//================================= UPDATE ITEM ===============================================================================
func UpdateItem(w http.ResponseWriter, r *http.Request) {
	item := new(entities.Grocery)
	err := json.NewDecoder(r.Body).Decode(item)
	if err != nil {
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	db, err2 := config.DbConnect()
	defer config.DbDisconnect(db)

	if err2 != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	GroceryModel := models.GroceryModel{
		DB: db,
	}

	_, err3 := GroceryModel.UpdateItem(item)
	if err3 != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	w.WriteHeader(http.StatusOK)

}

//=========================== DELETE ITEM =========================================================================
func DeleteItem(w http.ResponseWriter, r *http.Request) {
	id, _ := strconv.ParseInt(mux.Vars(r)["id"], 0, 64)

	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	GroceryModel := models.GroceryModel{
		DB: db,
	}
	// check if the user is present in the db
	isPresent, _ := GroceryModel.SearchItem(id)
	if isPresent == nil {
		http.Error(w, "User doesn't exists", http.StatusForbidden)
		return
	}
	_, err2 := GroceryModel.DeleteItem(id)
	if err2 != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	w.WriteHeader(http.StatusOK)
}
