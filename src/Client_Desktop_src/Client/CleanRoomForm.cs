using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class CleanRoomForm : Form
    {

        private static List<Cleaning> CleaningList = new();
        private static List<User> UsersList = new();
        private static Dictionary<string, string> RoomTurnDict = new();
        private static Dictionary<string, int> RoomIdDict = new();
        public static Dictionary<string, Queue<string>> DictQueue;

        private readonly DateTime now = DateTime.Now;
        public CleanRoomForm()
        {
            InitializeComponent();
        }

        private void CleanRoomForm_Load(object sender, EventArgs e)
        {

            using var client = new HttpClient();
            // get all cleaning data
            Uri endpoint = new("http://localhost:8081/cleaning/getlast");
            var result = client.GetAsync(endpoint).Result;
            string json = result.Content.ReadAsStringAsync().Result;
            CleaningList = JsonConvert.DeserializeObject<List<Cleaning>>(json);

            // get all rooms 
            Uri room_endpoint = new("http://localhost:8081/rooms/getall");
            var room_result = client.GetAsync(room_endpoint).Result;
            string room_json = room_result.Content.ReadAsStringAsync().Result;
            var RoomList = JsonConvert.DeserializeObject<List<Room>>(room_json);

            // save a dictionary [room name: turns] for laterì
            RoomTurnDict = RoomList.ToDictionary(room => room.name, room => room.userList);
            RoomIdDict = RoomList.ToDictionary(room => room.name, room => room.id);
            DictQueue = new() {
                    { RoomList[0].name, new() },
                    { RoomList[1].name, new() },
                    { RoomList[2].name, new() },
                    { RoomList[3].name, new() },
                    };

            foreach (Cleaning cleaningData in CleaningList)
            {
                DateTime myDate = DateTime.ParseExact(cleaningData.cleandate, "yyyy-MM-dd",
                   System.Globalization.CultureInfo.InvariantCulture);

                switch (cleaningData.room)
                {
                    case "Cucina":
                        Lbl_LastClean_K.Text = cleaningData.cleandate;
                        Lbl_LastTurn_K.Text = cleaningData.user;                        
                        if((now - myDate).TotalDays < 7)
                        {
                            Ck_Clean_K.Checked = true;
                        }
                        break;
                    case "Aree_comuni":
                        Lbl_LastClean_CA.Text = cleaningData.cleandate;
                        Lbl_LastTurn_CA.Text = cleaningData.user;
                        if ((now - myDate).TotalDays < 7)
                        {
                            Ck_Clean_CA.Checked = true;
                        }
                        break;
                    case "Bagno":
                        Lbl_LastClean_B.Text = cleaningData.cleandate;
                        Lbl_LastTurn_B.Text = cleaningData.user;
                        if ((now - myDate).TotalDays < 7)
                        {
                            Ck_Clean_B.Checked = true;
                        }
                        break;
                    case "Lavanderia":
                        Lbl_LastClean_CL.Text = cleaningData.cleandate;
                        Lbl_LastTurn_CL.Text = cleaningData.user;
                        if ((now - myDate).TotalDays < 7)
                        {
                            Ck_Clean_CL.Checked = true;
                        }
                        break;
                }
            }
            CbRooms.Text = "Cucina";
        }

        private void CbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get turns
            var stringTurns = RoomTurnDict[CbRooms.Text];
            var listTurns = stringTurns.Split('-');

            // build turns queues if empty
            if(DictQueue[CbRooms.Text].Count == 0)
            {
                foreach (var turn in listTurns)
                {
                    DictQueue[CbRooms.Text].Enqueue(turn);
                }
            };
            Lt_Turns.DataSource = DictQueue[CbRooms.Text].ToArray();
            LblTurn.Text = DictQueue[CbRooms.Text].Peek();


        }

        private void BtnComputeTurns_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CbRooms.Text))
            {
                MessageBox.Show("Errore: nessuna stanza selezionata", "Errore: turni");
                return;
            }
            using var client = new HttpClient();
            var endpoint = new Uri("http://localhost:8081/users/getall");
            var result = client.GetAsync(endpoint).Result;
            string json = result.Content.ReadAsStringAsync().Result;

            UsersList = JsonConvert.DeserializeObject<List<User>>(json);
            Random rand = new();
            var shuffled = UsersList.OrderBy(_ => rand.Next()).ToList();

            // save new turns in the db
            List<string> ListTurns = new();
            foreach(var user in shuffled)
            {
                ListTurns.Add(user.name);
            }
            string turns = string.Join('-', ListTurns.ToArray());
            
            var room = new Room()
            {
                name = CbRooms.Text,
                userList = turns,
            };
            var upd_endpoint = new Uri("http://localhost:8081/rooms/update");
            string upd_json = JsonConvert.SerializeObject(room);
            StringContent payload = new(upd_json, Encoding.UTF8, "application/json");
            var upd_result = client.PutAsync(upd_endpoint, payload).Result;

            if (!upd_result.IsSuccessStatusCode)
            {
                MessageBox.Show("ERROR: " + upd_result, "ERRORE", MessageBoxButtons.OK);
                return;
            }
            // update RoomDict
            RoomTurnDict[CbRooms.Text] = turns;

            // show turns
            var arrayTurns = turns.Split('-');
            Lt_Turns.DataSource = arrayTurns;
            LblTurn.Text = arrayTurns[0];

            // Clear the queue
            DictQueue[CbRooms.Text].Clear();
            foreach (var turn in arrayTurns)
            {
                DictQueue[CbRooms.Text].Enqueue(turn);
            }
        }

        private void BtnCompletedTurn_Click(object sender, EventArgs e)
        {
            AddCleaningForm addForm = new()
            {
                room = CbRooms.Text,
                id = RoomIdDict[CbRooms.Text]
            };
            addForm.FormClosed += AddCleaningForm_Closed;
            addForm.ShowDialog();
        }

        private void AddCleaningForm_Closed(object sender, EventArgs e)
        {
            Lt_Turns.DataSource = DictQueue[CbRooms.Text].ToArray();
            LblTurn.Text = DictQueue[CbRooms.Text].ToArray()[0];

            using var client = new HttpClient();
            // get all cleaning data
            Uri endpoint = new("http://localhost:8081/cleaning/getlast");
            var result = client.GetAsync(endpoint).Result;
            string json = result.Content.ReadAsStringAsync().Result;
            CleaningList = JsonConvert.DeserializeObject<List<Cleaning>>(json);

            foreach (Cleaning cleaningData in CleaningList)
            {
                DateTime myDate = DateTime.ParseExact(cleaningData.cleandate, "yyyy-MM-dd",
                   System.Globalization.CultureInfo.InvariantCulture);

                switch (cleaningData.room)
                {
                    case "Cucina":
                        Lbl_LastClean_K.Text = cleaningData.cleandate;
                        Lbl_LastTurn_K.Text = cleaningData.user;                        
                        if((now - myDate).TotalDays < 7)
                        {
                            Ck_Clean_K.Checked = true;
                        }
                        break;
                    case "Aree_comuni":
                        Lbl_LastClean_CA.Text = cleaningData.cleandate;
                        Lbl_LastTurn_CA.Text = cleaningData.user;
                        if ((now - myDate).TotalDays < 7)
                        {
                            Ck_Clean_CA.Checked = true;
                        }
                        break;
                    case "Bagno":
                        Lbl_LastClean_B.Text = cleaningData.cleandate;
                        Lbl_LastTurn_B.Text = cleaningData.user;
                        if ((now - myDate).TotalDays < 7)
                        {
                            Ck_Clean_B.Checked = true;
                        }
                        break;
                    case "Lavanderia":
                        Lbl_LastClean_CL.Text = cleaningData.cleandate;
                        Lbl_LastTurn_CL.Text = cleaningData.user;
                        if ((now - myDate).TotalDays < 7)
                        {
                            Ck_Clean_CL.Checked = true;
                        }
                        break;
                }
            }
        }
    }
}
