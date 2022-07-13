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
    public partial class UserControlDays : UserControl
    {
        private static Dictionary<string, string> NameToSimbol = new()
        {
            { "Cucina", "K" },
            { "Aree_comuni", "CA" },
            { "Bagno", "B" },
            { "Lavanderia", "CL" },
        };
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            DisplayCleaning();
        }
        public void days(int numday)
        {
            LblNumDay.Text = numday.ToString();
        }

        private void DisplayCleaning()
        {
            using var client = new HttpClient();
            var cleandate = CleaningForm.pass_year.ToString() + "-" + CleaningForm.pass_month + "-" + LblNumDay.Text;
            Uri endpoint = new("http://localhost:8081/cleaning/getclean/" + cleandate);
            var result = client.GetAsync(endpoint).Result;
            var json = result.Content.ReadAsStringAsync().Result;
            var cleanList = JsonConvert.DeserializeObject<List<Cleaning>>(json);
            if (cleanList != null)
            {
                BackColor = Color.Green;
                List<string> rooms = new();
                foreach(var clean in cleanList)
                {
                    rooms.Add(NameToSimbol[clean.room]);
                }
                LblRooms.Text = string.Join('-', rooms);
            }

        }
    }
}
