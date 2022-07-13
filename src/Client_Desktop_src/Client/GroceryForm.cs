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
    public partial class GroceryForm : Form
    {

        public GroceryForm()
        {
            InitializeComponent();
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            GroceryListForm TotalList = new GroceryListForm();
            TotalList.txt_category = "Totale";
            TotalList.ShowDialog();
        }

        private void BtnFood_Click(object sender, EventArgs e)
        {
            GroceryListForm TotalList = new GroceryListForm();
            TotalList.txt_category = "Alimentari";
            TotalList.ShowDialog();
        }

        private void BtnMedicine_Click(object sender, EventArgs e)
        {
            GroceryListForm TotalList = new GroceryListForm();
            TotalList.txt_category = "Medicine";
            TotalList.ShowDialog();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            GroceryListForm TotalList = new GroceryListForm();
            TotalList.txt_category = "Pulizia della casa";
            TotalList.ShowDialog();
        }

        private void BtnSoap_Click(object sender, EventArgs e)
        {
            GroceryListForm TotalList = new GroceryListForm();
            TotalList.txt_category = "Igiene personale";
            TotalList.ShowDialog();
        }

        private void BtnUrgent_Click(object sender, EventArgs e)
        {
            GroceryListForm TotalList = new GroceryListForm();
            TotalList.txt_category = "Urgenti";
            TotalList.ShowDialog();
        }
    }
}
