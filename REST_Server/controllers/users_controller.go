package controllers

import (
	"REST_Server/config"
	"REST_Server/entities"
	"REST_Server/models"
	"strconv"

	"fmt"
	"log"

	"encoding/json"
	"net/http"

	"github.com/gorilla/mux"
)

//=========================== HANDLER =========================================================================
func UserHandler(userRouter *mux.Router) {

	// CRUD user
	userRouter.HandleFunc("/getall", GetAllUsers).Methods("GET")
	userRouter.HandleFunc("/search/id/{id}", SearchById).Methods("GET")
	userRouter.HandleFunc("/search/username/{username}", SearchByUsername).Methods("GET")
	userRouter.HandleFunc("/auth", AuthUser).Methods("POST")
	userRouter.HandleFunc("/create", CreatetUser).Methods("POST")
	userRouter.HandleFunc("/delete/{id}", DeleteUser).Methods("DELETE")
	userRouter.HandleFunc("/updatepw", UpdatePassword).Methods("PUT")

}

//========================= GET ALL ===========================================================================
func GetAllUsers(w http.ResponseWriter, r *http.Request) {
	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	UserModel := models.UserModel{
		DB: db,
	}

	allUsers, err2 := UserModel.FindAll()
	if err2 != nil {
		fmt.Println(err2)
	} else {
		w.WriteHeader(http.StatusOK)
		json.NewEncoder(w).Encode(allUsers)

	}
}

//======================== SEARCH BY ID ============================================================================
func SearchById(w http.ResponseWriter, r *http.Request) {

	id, _ := strconv.ParseInt(mux.Vars(r)["id"], 0, 64)

	db, err := config.DbConnect()
	defer config.DbDisconnect(db)

	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	UserModel := models.UserModel{
		DB: db,
	}

	user, err2 := UserModel.SearchById(id)
	if err2 != nil {
		fmt.Println(err2)
	} else {
		if user == nil {
			http.Error(w, "User not found", http.StatusNotFound)
			return
		}
		w.WriteHeader(http.StatusOK)
		json.NewEncoder(w).Encode(user)
	}

}

//======================== SEARCH BY USERNAME ============================================================================
func SearchByUsername(w http.ResponseWriter, r *http.Request) {

	username, _ := mux.Vars(r)["username"]

	db, err := config.DbConnect()
	defer config.DbDisconnect(db)

	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	UserModel := models.UserModel{
		DB: db,
	}

	user, err2 := UserModel.SearchByUsername(username)
	if err2 != nil {
		http.Error(w, "User not found", http.StatusNotFound)
		fmt.Println(err2)
		return
	}
	w.WriteHeader(http.StatusOK)
	json.NewEncoder(w).Encode(user)
}

//============================== AUTH =============================================================================
func AuthUser(w http.ResponseWriter, r *http.Request) {
	authData := new(entities.AuthData)
	err := json.NewDecoder(r.Body).Decode(&authData)
	if err != nil {
		fmt.Println(err)
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	db, err2 := config.DbConnect()
	defer config.DbDisconnect(db)

	if err2 != nil {
		log.Fatal("Error connecting to database: " + err2.Error())
		return
	}
	log.Printf("Connected!\n")
	UserModel := models.UserModel{
		DB: db,
	}

	// check if the user is present
	isPresent, _ := UserModel.SearchByUsername(authData.Username)
	if isPresent == nil {
		http.Error(w, "User doesn't exists", http.StatusForbidden)
		return
	}
	// chech password
	if authData.Password != isPresent.Password {
		http.Error(w, "Password incorrect", http.StatusBadRequest)
		return
	}
	json.NewEncoder(w).Encode(isPresent)
}

//============================== CREATE USER ======================================================================
func CreatetUser(w http.ResponseWriter, r *http.Request) {
	user := new(entities.User)
	err := json.NewDecoder(r.Body).Decode(&user)
	if err != nil {
		fmt.Println(err)
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	db, err2 := config.DbConnect()
	defer config.DbDisconnect(db)

	if err2 != nil {
		log.Fatal("Error connecting to database: " + err2.Error())
		return
	}
	log.Printf("Connected!\n")
	UserModel := models.UserModel{
		DB: db,
	}

	// check if the user is present in the db
	id := user.ID
	isPresent, _ := UserModel.SearchById(id)
	if isPresent != nil {
		http.Error(w, "User already exists", http.StatusForbidden)
		return
	}

	// if not present, create row in the db
	allUsers, err3 := UserModel.InsertNewUser(user)
	if err3 != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	json.NewEncoder(w).Encode(allUsers)
}

//============================= UPDATE PASSWORD =======================================================================
func UpdatePassword(w http.ResponseWriter, r *http.Request) {

	user := new(entities.User)
	err := json.NewDecoder(r.Body).Decode(&user)

	db, err := config.DbConnect()
	defer config.DbDisconnect(db)

	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	UserModel := models.UserModel{
		DB: db,
	}

	// check if the user is present in the db
	isPresent, _ := UserModel.SearchById(user.ID)
	if isPresent == nil {
		http.Error(w, "User doesn't exists", http.StatusForbidden)
		return
	}

	user.Name = isPresent.Name
	user.Username = isPresent.Username

	_, err2 := UserModel.UpdatePassword(user)
	if err2 != nil {
		http.Error(w, err2.Error(), http.StatusInternalServerError)
		return
	}
	w.WriteHeader(http.StatusOK)
	return
}

//============================== DELETE USER ======================================================================
func DeleteUser(w http.ResponseWriter, r *http.Request) {

	id, _ := strconv.ParseInt(mux.Vars(r)["id"], 0, 64)

	db, err := config.DbConnect()
	defer config.DbDisconnect(db)
	if err != nil {
		log.Fatal("Error connecting to database: " + err.Error())
		return
	}
	log.Printf("Connected!\n")
	UserModel := models.UserModel{
		DB: db,
	}
	// check if the user is present in the db
	isPresent, _ := UserModel.SearchById(id)
	if isPresent == nil {
		http.Error(w, "User doesn't exists", http.StatusForbidden)
		return
	}
	allUsers, err2 := UserModel.DeleteUser(id)
	if err2 != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	json.NewEncoder(w).Encode(allUsers)

}
