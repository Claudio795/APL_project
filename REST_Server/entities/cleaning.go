package entities

type Cleaning struct {
	Id        int64  `json:"id"`
	Room      string `json:"room"`
	User      string `json:"user"`
	CleanDate string `json:"cleandate"`
}
