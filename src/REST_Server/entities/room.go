package entities

type Room struct {
	ID        int64  `json:"id"`
	Name      string `json:"name"`
	UsersList string `json:"userlist"`
}
