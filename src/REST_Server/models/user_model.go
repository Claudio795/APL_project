package models

import (
	"database/sql"

	"REST_Server/entities"
)

//====================================================================================================
type UserModel struct {
	DB *sql.DB
}

//=========================== GET ALL =========================================================================
func (userModel UserModel) FindAll() (users []entities.User, err error) {
	rows, err := userModel.DB.Query("SELECT * FROM dbo.Users")
	// if crash, close connection
	defer rows.Close()

	if err != nil {
		return nil, err
	} else {
		var users []entities.User
		for rows.Next() {
			var id int64
			var name string
			var username string
			var password string
			var isadmin bool
			err2 := rows.Scan(&id, &name, &username, &password, &isadmin)
			if err2 != nil {
				return nil, err2
			} else {
				user := entities.User{
					ID:       id,
					Name:     name,
					Username: username,
					Password: password,
					IsAdmin:  isadmin,
				}
				users = append(users, user)
			}
		}
		return users, nil
	}
}

//=============================== SEARCH BY ID =====================================================================
func (userModel UserModel) SearchById(identifier int64) (*entities.User, error) {
	var id int64
	var name string
	var username string
	var password string
	var isadmin bool

	// if the user is present in the db, then errCheck is 'true'
	row := userModel.DB.QueryRow("SELECT * FROM dbo.Users WHERE Id = @p1", identifier)
	result := row.Scan(&id, &name, &username, &password, &isadmin)

	if result == sql.ErrNoRows {
		return nil, result

	}
	user := entities.User{
		ID:       id,
		Name:     name,
		Username: username,
		Password: password,
		IsAdmin:  isadmin,
	}
	return &user, nil
}

//=============================== SEARCH BY USERNAME =====================================================================
func (userModel UserModel) SearchByUsername(keyword string) (*entities.User, error) {
	var id int64
	var name string
	var username string
	var password string
	var isadmin bool

	// if the user is present in the db, then errCheck is 'true'
	row := userModel.DB.QueryRow("SELECT * FROM dbo.Users WHERE Username = @p1", keyword)
	result := row.Scan(&id, &name, &username, &password, &isadmin)

	if result == sql.ErrNoRows {
		return nil, result

	}
	user := entities.User{
		ID:       id,
		Name:     name,
		Username: username,
		Password: password,
		IsAdmin:  isadmin,
	}
	return &user, nil
}

//=============================== INSERT USER =====================================================================
func (userModel UserModel) InsertNewUser(user *entities.User) ([]entities.User, error) {
	_, err := userModel.DB.Exec("INSERT INTO dbo.Users VALUES (@p1, @p2, @p3, @p4)",
		user.Name, user.Username, user.Password, user.IsAdmin)
	if err != nil {
		return nil, err
	}
	// return a list of all user in the table
	users, _ := userModel.FindAll()
	return users, nil
}

//=============================== UPDATE PASSWORD =====================================================================
func (userModel UserModel) UpdatePassword(user *entities.User) (int64, error) {
	result, err := userModel.DB.Exec("UPDATE dbo.Users SET Password = @p1 WHERE Id = @p2", user.Password, user.ID)
	if err != nil {
		return 0, err
	}
	rowsAffected, _ := result.RowsAffected()
	return rowsAffected, nil
}

//================================= DELETE USER ===================================================================
func (userModel UserModel) DeleteUser(identifier int64) ([]entities.User, error) {
	_, err := userModel.DB.Exec("DELETE FROM dbo.Users WHERE Id = @p1 ", identifier)

	if err != nil {
		return nil, err
	}
	users, _ := userModel.FindAll()
	return users, nil
}
