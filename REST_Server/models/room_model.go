package models

import (
	"REST_Server/entities"
	"database/sql"
)

type RoomModel struct {
	DB *sql.DB
}

//====================== GET ALL ROOMS ==========================================
func (roomModel RoomModel) FindAll() ([]entities.Room, error) {
	rows, err := roomModel.DB.Query("SELECT * FROM dbo.Rooms")
	defer rows.Close()

	if err != nil {
		return nil, err
	}
	var rooms []entities.Room
	for rows.Next() {
		var id int64
		var name string
		var userList string
		err2 := rows.Scan(&id, &name, &userList)
		if err2 != nil {
			return nil, err2
		}
		room := entities.Room{
			ID:        id,
			Name:      name,
			UsersList: userList,
		}
		rooms = append(rooms, room)
	}
	return rooms, nil
}

//====================== UPDATE TURNS ==========================================================
func (roomModel RoomModel) UpdateTurns(newTurns string, keyword string) (int64, error) {
	_, err := roomModel.DB.Exec("UPDATE dbo.Rooms SET UserList = @p1 WHERE Name = @p2",
		newTurns, keyword)

	if err != nil {
		return 0, err
	}

	return 1, nil
}

//====================== GET TURNS BY NAME 	======================================================
func (roomModel RoomModel) GetTurnsByName(keyword string) (string, error) {
	var userList string
	row := roomModel.DB.QueryRow("SELECT UserList FROM dbo.Rooms WHERE Name = @p1",
		keyword)
	result := row.Scan(&userList)

	if result == sql.ErrNoRows {
		return "", result
	}
	return userList, nil
}
