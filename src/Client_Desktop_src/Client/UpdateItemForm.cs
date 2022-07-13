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
    public partial class UpdateItemForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public int Id;
        public string txt_category;
        public Item selectedItem;

        public UpdateItemForm(int id, string name, string category, int quantity, bool isurgent)
        {
            InitializeComponent();
            selectedItem = new Item()
            {
                id = id,
                name = name,
                category = category,
                quantity = quantity,
                isurgent = isurgent
            };
        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            LblName.Text = "Modifica '" + selectedItem.name + "':";
            CbCategory.Text = selectedItem.category;
            TxtQuantity.Text = selectedItem.quantity.ToString();
            CkUrgent.Checked = selectedItem.isurgent;
            /*
            if(txt_category != "Totale")
            { 
                CbCategory.Enabled = false;
                CbCategory.BackColor = Color.Gray;
            }
            */
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

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // restrict the digit to only integer
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            { 
            int id = selectedItem.id;
            string name = selectedItem.name;
            string category = CbCategory.Text;
            int quantity = Int32.Parse(TxtQuantity.Text);
            if(String.IsNullOrWhiteSpace(TxtQuantity.Text)) {
                quantity = selectedItem.quantity;
            }
            bool isurgent = CkUrgent.Checked;

            // update item
            Item UpdatedItem = new Item()
            {
                id = id,
                name = name,
                category = category,
                quantity = quantity,
                isurgent = isurgent,
            };

            var upd_endpoint = new Uri("http://localhost:8081/grocery/updateitem");
            string upd_json = JsonConvert.SerializeObject(UpdatedItem);
            // stringContent fa parte della libreria Net.Http e ci permette
            // di specificare una stringa da aggiungere come payload alla PUT
            StringContent payload = new StringContent(upd_json, Encoding.UTF8, "application/json");
            var upd_result = client.PutAsync(upd_endpoint, payload).Result;

            if (!upd_result.IsSuccessStatusCode)
            {
                MessageBox.Show("ERROR: " + upd_result, "ERRORE", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(name + " aggiornato!", "Modifica oggetto", MessageBoxButtons.OK);
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
                var itemsList = JsonConvert.DeserializeObject<List<Item>>(json);
                GroceryListForm.itemsList = itemsList;
            }
            }
            Close();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
