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
    public partial class UpdateUserForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public int Id;
        public UpdateUserForm()
        {
            InitializeComponent();
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtPassword1.Text != TxtPassword2.Text)
            {
                MessageBox.Show("Errore: le password non coincidono", "Errore", MessageBoxButtons.OK);
            }
            else { 
            using (HttpClient client = new HttpClient())
            {
                User user = new User()
                {
                    id = Id,
                    password = TxtPassword1.Text,
                };

                Uri endpoint = new Uri("http://localhost:8081/users/updatepw");
                string json = JsonConvert.SerializeObject(user);
                // stringContent fa parte della libreria Net.Http e ci permette
                // di specificare una stringa da aggiungere come payload alla PUT
                StringContent payload = new StringContent(json, Encoding.UTF8, "application/json");
                var result = client.PutAsync(endpoint, payload).Result;

                MessageBox.Show("Password aggiornata!", "SUCCESSO", MessageBoxButtons.OK);
                Close();
             }

            }
           

        }

        private void CkPassword1_CheckedChanged(object sender, EventArgs e)
        {
            if (CkPassword1.Checked)
            {
                TxtPassword1.PasswordChar = '\0';
            } else
            {
                TxtPassword1.PasswordChar = '•';
            }
        }

        private void CkPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (CkPassword2.Checked)
            {
                TxtPassword2.PasswordChar = '\0';
            }
            else
            {
                TxtPassword2.PasswordChar = '•';
            }
        }
    }
}
