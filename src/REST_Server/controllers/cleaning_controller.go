package controllers

import (
	"REST_Server/config"
	"REST_Server/entities"
	"REST_Server/models"

	"fmt"
	"log"

	"encoding/json"
	"net/http"

	"github.com/gorilla/mux"
)

//=========================== HANDLER =========================================================================
func CleanHandler(cleanRouter *mux.Router) {

	// CRUD Clean
	cleanRouter.HandleFunc("/getall", GetAllCleaning).Methods("GET")
	cleanRouter.HandleFunc("/getlast", GetLast).Methods("GET")
	cleanRouter.HandleFunc("/getclean/{cleandate}", GetCleaningByDate).Methods("GET")
	cleanRouter.HandleFunc("/insert", InsertNewCleaning).Methods("POST")
	cleanRouter.HandleFunc("/reset", ResetCleaning).Methods("DELETE")
	cleanRouter.HandleFunc("/resetmonth/{month}", ResetMonth).Methods("DELETE")
}

//================================ GET ALL ========================================
func GetAllCleaning(w http.ResponseWriter, r *http.Request) {
	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	CleanModel := models.CleanModel{
		DB: db,
	}

	cleanList, err2 := CleanModel.FindAll()
	if err2 != nil {
		fmt.Println(err2)
	} else {
		w.WriteHeader(http.StatusOK)
		json.NewEncoder(w).Encode(cleanList)
	}
}

//================================ GET LAST CLEANING ========================================
func GetLast(w http.ResponseWriter, r *http.Request) {

	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	CleanModel := models.CleanModel{
		DB: db,
	}

	cleanData, err2 := CleanModel.GetLast()
	if err2 != nil {
		fmt.Println(err2)
	} else {
		w.WriteHeader(http.StatusOK)
		json.NewEncoder(w).Encode(cleanData)
	}
}

//================================ GET SINGLE CLEANING ========================================
func GetCleaningByDate(w http.ResponseWriter, r *http.Request) {
	cleandate, _ := mux.Vars(r)["cleandate"]
	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	CleanModel := models.CleanModel{
		DB: db,
	}

	cleanData, err2 := CleanModel.GetCleaningByDate(cleandate)
	if err2 != nil {
		fmt.Println(err2)
	} else {
		w.WriteHeader(http.StatusOK)
		json.NewEncoder(w).Encode(cleanData)
	}
}

//================================ INSERT NEW CLEANING ========================================
func InsertNewCleaning(w http.ResponseWriter, r *http.Request) {
	cleaning := new(entities.Clean_id)
	err := json.NewDecoder(r.Body).Decode(cleaning)
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
	CleanModel := models.CleanModel{
		DB: db,
	}

	_, err3 := CleanModel.AddClean(cleaning)
	if err3 != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	w.WriteHeader(http.StatusOK)

}

//================================ RESET CLEANING ========================================
func ResetCleaning(w http.ResponseWriter, r *http.Request) {
	db, err := config.DbConnect()
	defer config.DbDisconnect(db)

	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	CleanModel := models.CleanModel{
		DB: db,
	}

	_, err2 := CleanModel.ResetClean()
	if err2 != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	w.WriteHeader(http.StatusOK)
}

//================================ RESET CLEAN MONTH ========================================
func ResetMonth(w http.ResponseWriter, r *http.Request) {
	month, _ := mux.Vars(r)["month"]
	db, err := config.DbConnect()
	defer config.DbDisconnect(db)

	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	CleanModel := models.CleanModel{
		DB: db,
	}

	_, err2 := CleanModel.ResetCleanMonth(month)
	if err2 != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	w.WriteHeader(http.StatusOK)
}
