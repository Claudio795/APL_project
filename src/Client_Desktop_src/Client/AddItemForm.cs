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
    public partial class AddItemForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new(0, 0);

        public string txt_category;

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            string category = "";
            if (txt_category != "Totale" && txt_category != "Urgenti")
            {
                switch (txt_category)
                {
                    case "Alimentari":
                        category = "alimentari";
                        break;
                    case "Medicine":
                        category = "medicine";
                        break;
                    case "Pulizia della casa":
                        category = "pulizia_casa";
                        break;
                    case "Igiene personale":
                        category = "igiene_personale";
                        break;
                }

                CbCategory.Text = category;
                CbCategory.Enabled = false;
            }
            if (txt_category == "Urgenti")
            {
                CkUrgent.Checked = true;
                CkUrgent.Enabled = false;
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

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // restrict the digit to only integer
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (new object[] {TxtName.Text, TxtQuantity.Text, CbCategory.Text}.Any(v => v==null))
            {
                MessageBox.Show("Errore: riempire tutti i campi", "ERRORE", MessageBoxButtons.OK);
            } else
            {
                using var client = new HttpClient();
                Item newItem = new()
                {
                    name = TxtName.Text,
                    category = CbCategory.Text,
                    quantity = Int32.Parse(TxtQuantity.Text),
                    isurgent = CkUrgent.Checked,
                };

                var add_endpoint = new Uri("http://localhost:8081/grocery/insert");
                string add_json = JsonConvert.SerializeObject(newItem);
                // stringContent fa parte della libreria Net.Http e ci permette
                // di specificare una stringa da aggiungere come payload alla POST
                StringContent payload = new(add_json, Encoding.UTF8, "application/json");
                var add_result = client.PostAsync(add_endpoint, payload).Result;

                if (!add_result.IsSuccessStatusCode)
                {
                    MessageBox.Show("ERROR: " + add_result, "ERRORE", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(newItem.name + " inserito!", "Inserisci oggetto", MessageBoxButtons.OK);
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
                //Close();
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
 }
