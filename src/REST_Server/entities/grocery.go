package entities

type Grocery struct {
	ID       int64  `json:"id"`
	Name     string `json:"name"`
	Category string `json:"category"`
	Quantity int64  `json:"quantity"`
	IsUrgent bool   `json:"isurgent"`
}
