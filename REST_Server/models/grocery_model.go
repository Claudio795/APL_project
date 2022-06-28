package models

import (
	"REST_Server/entities"
	"database/sql"
	"fmt"
)

//====================================================================================================
type GroceryModel struct {
	DB *sql.DB
}

//======================================== GET ALL ============================================================
func (groceryModel GroceryModel) FindAll() (grocery_list []entities.Grocery, err error) {
	rows, err := groceryModel.DB.Query("SELECT * FROM dbo.Grocery")
	defer rows.Close()

	if err != nil {
		return nil, err
	} else {
		var grocery_list []entities.Grocery
		for rows.Next() {
			var id int64
			var name string
			var category string
			var quantity int64
			var isurgent bool
			err2 := rows.Scan(&id, &name, &category, &quantity, &isurgent)
			if err2 != nil {
				return nil, err2
			} else {
				grocery := entities.Grocery{
					ID:       id,
					Name:     name,
					Category: category,
					Quantity: quantity,
					IsUrgent: isurgent,
				}
				grocery_list = append(grocery_list, grocery)
			}
		}
		return grocery_list, nil
	}
}

//======================================== GET BY CATEGORY ============================================================
func (groceryModel GroceryModel) GetByCategory(category string) (grocery_list []entities.Grocery, err error) {
	rows, err := groceryModel.DB.Query("SELECT * FROM dbo.Grocery WHERE Category = @p1", category)
	if err != nil {
		return nil, err
	} else {
		var grocery_list []entities.Grocery
		for rows.Next() {
			var id int64
			var name string
			var category string
			var quantity int64
			var isurgent bool
			err2 := rows.Scan(&id, &name, &category, &quantity, &isurgent)
			if err2 != nil {
				return nil, err2
			} else {
				grocery := entities.Grocery{
					ID:       id,
					Name:     name,
					Category: category,
					Quantity: quantity,
					IsUrgent: isurgent,
				}
				grocery_list = append(grocery_list, grocery)
			}
		}
		return grocery_list, nil
	}
}

//======================================= GET URGENT =============================================================
func (groceryModel GroceryModel) GetUrgent() (grocery_list []entities.Grocery, err error) {
	rows, err := groceryModel.DB.Query("SELECT * FROM dbo.Grocery WHERE IsUrgent = 1")
	defer rows.Close()

	if err != nil {
		return nil, err
	} else {
		var grocery_list []entities.Grocery
		for rows.Next() {
			var id int64
			var name string
			var category string
			var quantity int64
			var isurgent bool
			err2 := rows.Scan(&id, &name, &category, &quantity, &isurgent)
			if err2 != nil {
				return nil, err2
			} else {
				grocery := entities.Grocery{
					ID:       id,
					Name:     name,
					Category: category,
					Quantity: quantity,
					IsUrgent: isurgent,
				}
				grocery_list = append(grocery_list, grocery)
			}
		}
		return grocery_list, nil
	}
}

//================================== INSERT NEW ITEM ==================================================================
func (groceryModel GroceryModel) InsertNewItem(item *entities.Grocery) (int64, error) {
	_, err := groceryModel.DB.Exec("INSERT INTO dbo.Grocery VALUES (@p1, @p2, @p3, @p4)",
		item.Name, item.Category, item.Quantity, item.IsUrgent)

	if err != nil {
		return 0, err
	} else {
		return 1, nil
	}
}

//=================================== 	SEARCH ITEM BY ID ================================================================
func (groceryModel GroceryModel) SearchItem(identifier int64) (*entities.Grocery, error) {
	var id int64
	var name string
	var category string
	var quantity int64
	var isurgent bool

	row := groceryModel.DB.QueryRow("SELECT * FROM dbo.Grocery WHERE Id = @p1", identifier)
	result := row.Scan(&id, &name, &category, &quantity, &isurgent)

	if result == sql.ErrNoRows {
		// item not found
		return nil, result
	}

	item := entities.Grocery{
		ID:       id,
		Name:     name,
		Category: category,
		Quantity: quantity,
		IsUrgent: isurgent,
	}
	return &item, nil

}

//====================================== SEARCH ITEM BY NAME ==============================================================
func (groceryModel GroceryModel) SearchItemByName(identifier string) (*entities.Grocery, error) {
	var id int64
	var name string
	var category string
	var quantity int64
	var isurgent bool

	row := groceryModel.DB.QueryRow("SELECT * FROM dbo.Grocery WHERE Name = @p1", identifier)
	result := row.Scan(&id, &name, &category, &quantity, &isurgent)

	if result == sql.ErrNoRows {
		// item not found
		return nil, result
	}

	item := entities.Grocery{
		ID:       id,
		Name:     name,
		Category: category,
		Quantity: quantity,
		IsUrgent: isurgent,
	}
	return &item, nil

}

//================================== DELETE ITEM ==================================================================
func (groceryModel GroceryModel) DeleteItem(identifer int64) (int64, error) {
	_, err := groceryModel.DB.Exec("DELETE FROM dbo.Grocery WHERE Id = @p1 ", identifer)

	if err != nil {
		return 0, err
	} else {
		return 1, nil
	}
}

//===================================== UPDATE QUANTITY ===============================================================
func (groceryModel GroceryModel) UpdateQuantity(identifer int64, Quantity int64) (int64, error) {

	row := groceryModel.DB.QueryRow("SELECT Quantity FROM dbo.Grocery WHERE Id = @p1", identifer)
	var initial_quantity int64

	err := row.Scan(&initial_quantity)
	if err != nil {
		return 0, err
	}

	Quantity_total := initial_quantity + Quantity
	fmt.Printf("%d\n", Quantity_total)

	if Quantity_total <= 0 {
		_, err1 := groceryModel.DeleteItem(identifer)
		if err1 != nil {
			return 0, err1
		}
		fmt.Printf("Item removed from list\n")
		return 1, nil
	}
	_, err2 := groceryModel.DB.Exec("UPDATE dbo.Grocery SET Quantity = @p1 WHERE Id = @p2 ", Quantity_total, identifer)
	if err2 != nil {
		return 0, err2
	}
	fmt.Printf("Quantity as been updated to %d\n", Quantity_total)
	return 1, nil
}

//=================================== UPDATE URGENCY =================================================================
func (groceryModel GroceryModel) UpdateUrgency(identifier int64) (int64, error) {
	var initial_urgent int8
	var isurgent int8
	row := groceryModel.DB.QueryRow("SELECT IsUrgent FROM dbo.Grocery WHERE Id = @p1", identifier)
	err := row.Scan(&initial_urgent)
	if err != nil {
		return 0, err
	}
	if initial_urgent == 1 {
		isurgent = 0
	} else {
		isurgent = 1
	}
	_, err2 := groceryModel.DB.Exec("UPDATE dbo.Grocery SET IsUrgent = @p1 WHERE Id = @p2", isurgent, identifier)
	if err2 != nil {
		return 0, err2
	}
	return 1, nil
}

//======================== UPDATE ITEM =========================================================================
func (groceryModel GroceryModel) UpdateItem(item *entities.Grocery) (int64, error) {
	_, err := groceryModel.DB.Exec("UPDATE dbo.Grocery SET Category = @p1, Quantity = @p2, IsUrgent = @p3 WHERE Id = @p4",
		item.Category, item.Quantity, item.IsUrgent, item.ID)

	if err != nil {
		return 0, err
	}
	return 1, nil
}
