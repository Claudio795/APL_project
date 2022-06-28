package entities

type Clean_id struct {
	Id        int64  `json:"id"`
	RoomId    int64  `json:"roomid"`
	UserId    int64  `json:"userid"`
	CleanDate string `json:"cleandate"`
}
