package entities

type User struct {
	ID       int64  `json:"id"`
	Name     string `json:"name"`
	Username string `json:"username"`
	Password string `json:"password"`
	IsAdmin  bool   `json:"isadmin"`
}
