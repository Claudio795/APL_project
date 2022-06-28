package models

import (
	"REST_Server/entities"
	"database/sql"
)

type CleanModel struct {
	DB *sql.DB
}

//=============================== GET ALL CLEANING =====================================================
func (cleanModel CleanModel) FindAll() ([]entities.Cleaning, error) {
	query := `SELECT c.Id, r.Name AS Room, u.Name, c.CleanDate FROM dbo.Cleaning AS c 
			INNER JOIN dbo.Rooms AS r ON c.RoomId = r.Id INNER JOIN dbo.Users AS u ON c.UserId = u.Id`
	rows, err := cleanModel.DB.Query(query)
	defer rows.Close()

	if err != nil {
		return nil, err
	}

	var cleaningData []entities.Cleaning
	for rows.Next() {
		var id int64
		var room string
		var user string
		var date string
		err2 := rows.Scan(&id, &room, &user, &date)
		if err2 != nil {
			return nil, err2
		}
		cleanData := entities.Cleaning{
			Id:        id,
			Room:      room,
			User:      user,
			CleanDate: date[:10],
		}
		cleaningData = append(cleaningData, cleanData)
	}
	return cleaningData, nil
}

//=============================== GET LAST CLEANING =====================================================
func (cleanModel CleanModel) GetLast() ([]entities.Cleaning, error) {
	query := `SELECT c.Id,Room, u.Name, c.CleanDate	FROM dbo.Cleaning AS c	INNER JOIN dbo.Users AS u 
			ON c.UserId = u.Id INNER JOIN (SELECT r.Name AS Room, MAX(c.CleanDate) AS LatestDate 
			FROM	dbo.Cleaning AS c INNER JOIN dbo.Rooms As r ON c.RoomId = r.Id GROUP BY r.Name)SubMax 
			ON c.CleanDate = SubMax.LatestDate`
	rows, err := cleanModel.DB.Query(query)
	defer rows.Close()

	if err != nil {
		return nil, err
	}

	var cleaningData []entities.Cleaning
	for rows.Next() {
		var id int64
		var room string
		var user string
		var date string
		err2 := rows.Scan(&id, &room, &user, &date)
		if err2 != nil {
			return nil, err2
		}
		cleanData := entities.Cleaning{
			Id:        id,
			Room:      room,
			User:      user,
			CleanDate: date[:10],
		}
		cleaningData = append(cleaningData, cleanData)
	}
	return cleaningData, nil
}

//================================ GET SINGLE CLEANING ======================================================
func (cleanModel CleanModel) GetCleaningByDate(dateClean string) ([]entities.Cleaning, error) {
	query := `SELECT c.Id, r.Name AS Room, u.Name, c.CleanDate FROM dbo.Cleaning AS c 
				INNER JOIN dbo.Rooms AS r ON c.RoomId = r.Id INNER JOIN dbo.Users AS u 
				ON c.UserId = u.Id WHERE c.CleanDate = @p1`
	rows, err := cleanModel.DB.Query(query, dateClean)
	defer rows.Close()

	if err != nil {
		return nil, err
	}

	var cleaningData []entities.Cleaning
	for rows.Next() {
		var id int64
		var room string
		var user string
		var date string
		err2 := rows.Scan(&id, &room, &user, &date)
		if err2 != nil {
			return nil, err2
		}
		cleanData := entities.Cleaning{
			Id:        id,
			Room:      room,
			User:      user,
			CleanDate: date[:10],
		}
		cleaningData = append(cleaningData, cleanData)
	}
	return cleaningData, nil
}

//============================= ADD NEW CLEANING =======================================================
func (cleanModel CleanModel) AddClean(clean *entities.Clean_id) (int64, error) {
	query := "INSERT INTO dbo.Cleaning VALUES (@p1, @p2, @p3)"
	_, err := cleanModel.DB.Exec(query, clean.RoomId, clean.UserId, clean.CleanDate)
	if err != nil {
		return 0, err
	}
	return 1, nil
}

//=============================== RESET CLEANING TABLE =====================================================
func (cleanModel CleanModel) ResetClean() (int64, error) {
	query := "DELETE FROM dbo.Cleaning"
	_, err := cleanModel.DB.Exec(query)
	if err != nil {
		return 0, err
	}
	return 1, nil
}

//=============================== RESET CLEANING MONTH =====================================================
func (cleanModel CleanModel) ResetCleanMonth(month string) (int64, error) {
	query := "DELETE FROM dbo.Cleaning WHERE MONTH(CleanDate) = @p1"
	_, err := cleanModel.DB.Exec(query, month)
	if err != nil {
		return 0, err
	}
	return 1, nil
}
