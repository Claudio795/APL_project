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
    public partial class AddCleaningForm : Form
    {

        private bool dragging = false;
        private Point startPoint = new(0, 0);
        public string room = "";
        public int id;

        public AddCleaningForm()
        {
            InitializeComponent();
            int minYear, minMonth;
            if(DateTime.Now.Month == 1)
            {
                minYear = DateTime.Now.Year - 1;
                minMonth = 12;
            } else
            {
                minYear = DateTime.Now.Year;
                minMonth = DateTime.Now.Month;
            }
            dateTimePicker.MinDate = new DateTime(minYear, minMonth - 1, 1);
            dateTimePicker.MaxDate = DateTime.Today;
        }

        private void AddCleaningForm_Load(object sender, EventArgs e)
        {
            RBToday.Checked = true;
        }

        private void RBToday_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = false;
        }

        private void RBAnotherDay_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void TopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void TopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void TopBorder_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BtnAddCleaning_Click(object sender, EventArgs e)
        {
            string datetime;
            if(RBToday.Checked == true)
            {
                datetime = DateTime.Now.ToString();
            } else
            {
                datetime = dateTimePicker.Text;
            };

            Clean_id cleaning = new()
            {
                roomid = id,
                userid = LoggedUser.id,
                cleandate = datetime,
            };
            // insert cleanining in db
            using var client = new HttpClient();
            Uri endpoint = new("http://localhost:8081/cleaning/insert");
            string json = JsonConvert.SerializeObject(cleaning);
            // stringContent fa parte della libreria Net.Http e ci permette
            // di specificare una stringa da aggiungere come payload alla POST
            StringContent payload = new StringContent(json, Encoding.UTF8, "application/json");
            var result = client.PostAsync(endpoint, payload).Result;
            if (!result.IsSuccessStatusCode)
            {
                MessageBox.Show("ERROR: " + result, "ERRORE", MessageBoxButtons.OK);
                return;
            }

            // if the current user is in charge of cleaning, update turns
            if(CleanRoomForm.DictQueue[room].Peek() == LoggedUser.name)
            {
                var user = CleanRoomForm.DictQueue[room].Dequeue();
                CleanRoomForm.DictQueue[room].Enqueue(user);

                var ArrTurns = CleanRoomForm.DictQueue[room].ToArray();
                var newTurns = string.Join('-', ArrTurns);
                var newRoom = new Room()
                {
                    name = room,
                    userList = newTurns,
                };
                Uri upt_endpoint = new("http://localhost:8081/rooms/update");
                string upt_json = JsonConvert.SerializeObject(newRoom);
                StringContent upt_payload = new(upt_json, Encoding.UTF8, "application/json");
                var upt_result = client.PutAsync(upt_endpoint, upt_payload).Result;
                if (!upt_result.IsSuccessStatusCode)
                {
                    MessageBox.Show("ERROR: " + result, "ERRORE", MessageBoxButtons.OK);
                    return;
                }
                // delete old turns from queue 


            }

            Close();

        }
    }
}
