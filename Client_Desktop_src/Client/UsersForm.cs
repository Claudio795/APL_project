using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Client.Properties;

namespace Client
{
    public partial class UsersForm : Form
    {
        Image refresh = Resources.refresh;
        public static List<User> usersList = new();
        public UsersForm()
        {
            InitializeComponent();
            BtnRefresh.Image = refresh;

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            var endpoint = new Uri("http://localhost:8081/users/getall");
            var result = client.GetAsync(endpoint).Result;
            string json = result.Content.ReadAsStringAsync().Result;

            usersList = JsonConvert.DeserializeObject<List<User>>(json);
            UsersTable.DataSource = usersList;

            if (LoggedUser.isadmin == true)
            {
                UsersTable.Columns[3].Visible = true;
                UsersTable.Columns[4].Visible = true;
                BtnInsertNew.Visible = true;
            }
        } // END OF: UsersForm_Load 

        private void UsersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // UPDATE user and reload users table
            if (UsersTable.Columns[e.ColumnIndex].Name == "Update")
            {
                var Id = UsersTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                UpdateUserForm UpdForm = new();
                UpdForm.Id = Int32.Parse(Id);
                UpdForm.ShowDialog();


            }

            // DELETE user and reload users table
            if (UsersTable.Columns[e.ColumnIndex].Name == "Delete")
            {
                var username = UsersTable.Rows[e.RowIndex].Cells[2].Value;
                if (MessageBox.Show("Sei sicuro di voler eliminare " + username + "?", "Elimina utente",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var Id = UsersTable.Rows[e.RowIndex].Cells[0].Value;
                    using var client = new HttpClient();
                    var del_endpoint = new Uri("http://localhost:8081/users/delete/" + Id);
                    var del_result = client.DeleteAsync(del_endpoint).Result;
                    if (!del_result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("ERROR: " + del_result, "ERRORE", MessageBoxButtons.OK);
                    }
                    else
                    {
                        // TODO: semplificare
                        string json = del_result.Content.ReadAsStringAsync().Result;

                        usersList = JsonConvert.DeserializeObject<List<User>>(json);
                        UsersTable.DataSource = usersList;
                    }
                }
            }
        } // END OF: UsersTable_CellContentClick

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("http://localhost:8081/users/getall");
                var result = client.GetAsync(endpoint).Result;
                string json = result.Content.ReadAsStringAsync().Result;

                usersList = JsonConvert.DeserializeObject<List<User>>(json);
                UsersTable.DataSource = usersList;
            }
        } // END OF: BtnRefresh_Click

        // TODO: fix
        private void BtnRefresh_MouseHover(object sender, EventArgs e)
        {
            int RefreshWidth = refresh.Width + ((refresh.Width * 20) / 100);
            int RefreshHeight = refresh.Height + ((refresh.Height * 20) / 100);

            Bitmap Refresh_1 = new Bitmap(RefreshWidth, RefreshHeight);
            Graphics g = Graphics.FromImage(Refresh_1);
            g.DrawImage(refresh, new Rectangle(Point.Empty, Refresh_1.Size));
        } // END OF: BtnRefresh_MouseHover

        //TODO: open form for insert new user
        private void BtnInsertNew_Click(object sender, EventArgs e)
        {
            AddUserForm addForm = new AddUserForm();
            addForm.FormClosed += addForm_Closed;
            addForm.ShowDialog();

        } // END OF: BtnInsertNew_Click

        private void addForm_Closed(object sender, FormClosedEventArgs e)
        {
            UsersTable.DataSource = usersList;
        }

    }
}
