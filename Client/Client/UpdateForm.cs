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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            TxtPassword1.Text = "";
            TxtPassword2.Text = "";
            TxtPassword1.Focus();
        }

        private void CkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CkPassword.Checked)
            {
                TxtPassword1.PasswordChar = '\0';
                TxtPassword2.PasswordChar = '\0';
            }
            else
            {
                TxtPassword1.PasswordChar = '•';
                TxtPassword2.PasswordChar = '•';
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtPassword1.Text != TxtPassword2.Text)
            {
                MessageBox.Show("Errore: le password non coincidono", "Errore");
                Clear();
            }
            else
            {
                using (HttpClient client = new())
                {
                    User updatedUser = new()
                    {
                        id = LoggedUser.id,
                        password = TxtPassword1.Text,
                    };

                    var endpoint = new Uri("http://localhost:8081/users/updatepw");
                    string json = JsonConvert.SerializeObject(updatedUser);
                    // stringContent fa parte della libreria Net.Http e ci permette
                    // di specificare una stringa da aggiungere come payload alla PUT
                    StringContent payload = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = client.PutAsync(endpoint, payload).Result;

                    MessageBox.Show("Password aggiornata!", "SUCCESSO");
                    Clear();
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
