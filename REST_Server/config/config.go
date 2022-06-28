package config

import (
	"database/sql"
	"fmt"

	_ "github.com/denisenkom/go-mssqldb"
)

//db connection
func DbConnect() (db *sql.DB, err error) {

	//connString := fmt.Sprintf("server=%s; port=%d; database=%s", server, port, database)
	connString := fmt.Sprintf("server=%s; database=%s", server, database)

	db, err = sql.Open("sqlserver", connString)
	return

}

func DbDisconnect(db *sql.DB) {
	db.Close()
}
