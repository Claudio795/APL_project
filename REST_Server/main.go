package main

import (
	"REST_Server/controllers"

	"log"
	"net/http"

	"github.com/gorilla/mux"
)

func handleRequest() {
	requestHandler := mux.NewRouter()

	// users router
	UserSubrouter := requestHandler.PathPrefix("/users").Subrouter()
	GrocerySubrouter := requestHandler.PathPrefix("/grocery").Subrouter()
	CleaningSubrouter := requestHandler.PathPrefix("/cleaning").Subrouter()
	RoomSubrouter := requestHandler.PathPrefix("/rooms").Subrouter()

	controllers.UserHandler(UserSubrouter)
	controllers.GroceryHandler(GrocerySubrouter)
	controllers.CleanHandler(CleaningSubrouter)
	controllers.RoomHandler(RoomSubrouter)

	/*
		ListenAndServe listens on the TCP network address addr and then calls Serve
		with handler to handle requests on incoming connections. Accepted connections
		are configured to enable TCP keep-alives.
	*/
	log.Fatal(http.ListenAndServe(":8081", requestHandler))
}

func main() {
	handleRequest()

}

// ====================================================================================
// test query
// ====================================================================================
/*
func demo1() {

	db, err := config.DbConnect()
	if err != nil {
		log.Fatal("Errore durante la connessione al database: " + err.Error())
	} else {
		log.Printf("Connesso!\n")
		UserModel := models.UserModel{
			DB: db,
		}
		users, err2 := UserModel.FindAll()
		if err2 != nil {
			fmt.Println(err2)
		} else {
			for _, user := range users {
				fmt.Println(user.ToString())
				fmt.Println("------------------------------")
			}
		}
	}

}



func demo3() {

	db, err := config.DbConnect()
	if err != nil {
		log.Fatal("Errore durante la connessione al database: " + err.Error())
	} else {
		log.Printf("Connesso!\n")
		UserModel := models.UserModel{
			DB: db,
		}
		user, err2 := UserModel.SearchByUsername("isenberg")
		if err2 != nil {
			fmt.Println(err2)
		} else {
			fmt.Println(user.ToString())
		}
	}

}

func demo4() {

	db, err := config.DbConnect()
	if err != nil {
		log.Fatal("Errore durante la connessione al database: " + err.Error())
	} else {
		log.Printf("Connesso!\n")
		UserModel := models.UserModel{
			DB: db,
		}
		user := entities.User{
			Name:     "Roberto",
			Username: "roberto_curto",
			Password: "5678",
		}
		rowsAffected, err2 := UserModel.InsertNewUser(&user)
		if err2 != nil {
			fmt.Println(err2)
		} else {
			fmt.Println("rowsAffected: ", rowsAffected)
			fmt.Println("User")
			fmt.Println(user.ToString())

		}
	}
}

func demo5() {

	db, err := config.DbConnect()
	if err != nil {
		log.Fatal("Errore durante la connessione al database: " + err.Error())
	} else {
		log.Printf("Connesso!\n")
		UserModel := models.UserModel{
			DB: db,
		}
		var id int64 = 2

		rowsAffected, err2 := UserModel.DeleteUser(id)
		if err2 != nil {
			fmt.Println(err2)
		} else {
			fmt.Println("Utente rimosso\nrowsAffected: ", rowsAffected)
		}
	}
}

func demo6() {

	db, err := config.DbConnect()
	if err != nil {
		log.Fatal("Errore durante la connessione al database: " + err.Error())
	} else {
		log.Printf("Connesso!\n")
		GroceryModel := models.GroceryModel{
			DB: db,
		}
		items, err2 := GroceryModel.FindAll()
		if err2 != nil {
			fmt.Println(err2)
		} else {
			for _, user := range items {
				fmt.Println(user.ToString())
				fmt.Println("------------------------------")
			}
		}
	}

}

func demo7() {

	db, err := config.DbConnect()
	if err != nil {
		log.Fatal("Errore durante la connessione al database: " + err.Error())
	} else {
		log.Printf("Connesso!\n")
		GroceryModel := models.GroceryModel{
			DB: db,
		}
		item := entities.Grocery{
			Name:     "Spugne",
			Quantity: 5,
		}
		rowsAffected, err2 := GroceryModel.InsertNewItem(&item)
		if err2 != nil {
			fmt.Println(err2)
		} else {
			fmt.Println("rowsAffected: ", rowsAffected)
			fmt.Println("User")
			fmt.Println(item.ToString())

		}
	}
}

func demo8() {

	db, err := config.DbConnect()
	if err != nil {
		log.Fatal("Errore durante la connessione al database: " + err.Error())
	} else {
		log.Printf("Connesso!\n")
		GroceryModel := models.GroceryModel{
			DB: db,
		}
		var Name string = "Spugne"
		var Quantity int64 = 2

		_, err2 := GroceryModel.UpdateItem(Name, Quantity)
		if err2 != nil {
			fmt.Println(err2)
		} else {
			fmt.Println("------------------------------")
		}
	}
}
*/
