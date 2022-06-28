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
func RoomHandler(roomRouter *mux.Router) {

	// CRUD Clean
	roomRouter.HandleFunc("/getall", GetAllRooms).Methods("GET")
	roomRouter.HandleFunc("/getturns/{room}", GetTurns).Methods("GET")
	roomRouter.HandleFunc("/update", UpdateTurns).Methods("PUT")
}

//================================ GET ALL ========================================
func GetAllRooms(w http.ResponseWriter, r *http.Request) {
	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	RoomModel := models.RoomModel{
		DB: db,
	}

	roomList, err2 := RoomModel.FindAll()
	if err2 != nil {
		fmt.Println(err2)
	} else {
		w.WriteHeader(http.StatusOK)
		json.NewEncoder(w).Encode(roomList)
	}
}

//================================ UPDATE TURNS ========================================
func UpdateTurns(w http.ResponseWriter, r *http.Request) {
	room := new(entities.Room)
	err := json.NewDecoder(r.Body).Decode(&room)

	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	RoomModel := models.RoomModel{
		DB: db,
	}
	//fmt.Println(room.UsersList, room.Name)
	_, err2 := RoomModel.UpdateTurns(room.UsersList, room.Name)
	if err2 != nil {
		return
	}
	w.WriteHeader(http.StatusOK)
}

//================================ GET TURNS ========================================
func GetTurns(w http.ResponseWriter, r *http.Request) {
	room, _ := mux.Vars(r)["room"]

	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	RoomModel := models.RoomModel{
		DB: db,
	}

	userList, err2 := RoomModel.GetTurnsByName(room)
	if err2 != nil {
		return
	}
	w.WriteHeader(http.StatusOK)
	json.NewEncoder(w).Encode(userList)

}
