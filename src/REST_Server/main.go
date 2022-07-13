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
