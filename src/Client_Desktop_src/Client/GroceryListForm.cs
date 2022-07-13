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
    public partial class GroceryListForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public string txt_category;
        public static List<Item> itemsList = new List<Item>();
        public GroceryListForm()
        {
            InitializeComponent();
            txt_category = "Form base";
        }

        private void GroceryListForm_Load(object sender, EventArgs e)
        {
            LblCatName.Text = txt_category;

            using (var client = new HttpClient())
            {
                string string_endpoint = "";
                switch (txt_category)
                {
                    case "Totale":
                        string_endpoint = "http://localhost:8081/grocery/getall";
                        break;
                    case "Alimentari":
                        string_endpoint = "http://localhost:8081/grocery/getbycategory/alimentari";
                        break;
                    case "Medicine":
                        string_endpoint = "http://localhost:8081/grocery/getbycategory/medicine";
                        break;
                    case "Pulizia della casa":
                        string_endpoint = "http://localhost:8081/grocery/getbycategory/pulizia_casa";
                        break;
                    case "Igiene personale":
                        string_endpoint = "http://localhost:8081/grocery/getbycategory/igiene_personale";
                        break;
                    case "Urgenti":
                        string_endpoint = "http://localhost:8081/grocery/geturgent";
                        break;
                    default:
                        MessageBox.Show("ERRORE: categoria non presente", "CATEGORIA NON PRESENTE", MessageBoxButtons.OK);
                        break;
                }

                var endpoint = new Uri(string_endpoint);
                var result = client.GetAsync(endpoint).Result;
                string json = result.Content.ReadAsStringAsync().Result;
                itemsList = JsonConvert.DeserializeObject<List<Item>>(json);
                GroceryTable.DataSource = itemsList;
            }
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

        private void GroceryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // UPDATE user and reload users table
            if (GroceryTable.Columns[e.ColumnIndex].Name == "Update")
            {
                // parse argument from selected row
                var id_str = GroceryTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                var id = Int32.Parse(id_str);
                var name = GroceryTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                var category = GroceryTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                var quantity_str = GroceryTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                var quantity = Int32.Parse(quantity_str);
                var urgent_str = GroceryTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                var isurgent = Convert.ToBoolean(urgent_str);

                UpdateItemForm UpdItemForm = new UpdateItemForm(id, name, category, quantity, isurgent);
                UpdItemForm.txt_category = txt_category;
                UpdItemForm.FormClosed += UpdForm_Closed;
                UpdItemForm.ShowDialog();
            }

            // DELETE item and reload items table
            if (GroceryTable.Columns[e.ColumnIndex].Name == "Delete")
            {
                var name = GroceryTable.Rows[e.RowIndex].Cells[1].Value;
                if (MessageBox.Show("Sei sicuro di voler rimuovere " + name + "?", "Rimuovi elemento",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var Id = GroceryTable.Rows[e.RowIndex].Cells[0].Value;
                    using (var client = new HttpClient())
                    {
                        var del_endpoint = new Uri("http://localhost:8081/grocery/delete/" + Id);
                        var del_result = client.DeleteAsync(del_endpoint).Result;
                        if (!del_result.IsSuccessStatusCode)
                        {
                            MessageBox.Show("ERROR: " + del_result, "ERRORE", MessageBoxButtons.OK);
                        }
                        else
                        {
                            var string_endpoint = "";
                            switch (txt_category.ToLower())
                            {
                                case "totale":
                                    string_endpoint = "http://localhost:8081/grocery/getall";
                                    break;
                                case "urgenti":
                                    string_endpoint = "http://localhost:8081/grocery/guturgent";
                                    break;
                                default:
                                    string_endpoint = "http://localhost:8081/grocery/getbycategory/" + txt_category.ToLower();
                                    break;
                            }

                            var endpoint = new Uri(string_endpoint);
                            var result = client.GetAsync(endpoint).Result;
                            string json = result.Content.ReadAsStringAsync().Result;
                            itemsList = JsonConvert.DeserializeObject<List<Item>>(json);
                            GroceryTable.DataSource = itemsList;
                        }

                    }
                }
            }
        } // END OF: UsersTable_CellContentClick

        private void UpdForm_Closed(object sender, EventArgs e)
        {
            GroceryTable.DataSource = itemsList;
        }

        private void BtnNewItem_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.txt_category = txt_category;
            addItemForm.FormClosed += AddForm_Closed;
            addItemForm.ShowDialog();
        }

        private void AddForm_Closed(object sender, EventArgs e)
        {
            GroceryTable.DataSource = itemsList;
        }

    }
}
