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
    public partial class AddUserForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        
        public AddUserForm()
        {
            InitializeComponent();
            
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

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
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void TopBorder_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            // TODO: add code if we click without add parameters
            using (HttpClient client = new HttpClient())
            {
                Uri endpoint = new Uri("http://localhost:8081/users/create");
                User newUser = new User()
                {
                    name = TxtName.Text,
                    username = TxtUsername.Text,
                    password = TxtPassword.Text,
                };
                string json = JsonConvert.SerializeObject(newUser);
                // stringContent fa parte della libreria Net.Http e ci permette
                // di specificare una stringa da aggiungere come payload alla POST
                StringContent payload = new StringContent(json, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoint, payload).Result;
                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show("ERROR: " + result, "ERRORE", MessageBoxButtons.OK);
                }
                string resp_json = result.Content.ReadAsStringAsync().Result;
                UsersForm.usersList = JsonConvert.DeserializeObject<List<User>>(resp_json);

                Close();
            }
        }

    }
}
