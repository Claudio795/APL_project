using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class CleaningForm : Form
    {
        private static bool Prev = false;
        private static int current_month;
        private int month, year;
        public static int pass_month, pass_year; 
        public CleaningForm()
        {
            InitializeComponent();
            if(LoggedUser.isadmin == true)
            {
                BtnReset.Visible = true;
            }
        }

        private void CleaningForm_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            // if is the first day of the month, delete the data two months old
            if(now.Day == 1)
            {
                using var client = new HttpClient();
                Uri endpoint = new("http://localhost:8081/cleaning/resetmonth/" + (now.Month - 2));
                var result = client.DeleteAsync(endpoint).Result;
                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show("ERROR: " + result, "ERRORE", MessageBoxButtons.OK);
                }


            }

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblMonthYear.Text = char.ToUpper(monthName[0]) + monthName.Substring(1) + " " + year;

            pass_month = month;
            pass_year = year;
            
            // first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            // days in the month
            int days = DateTime.DaysInMonth(year, month) + 1;
            //
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // create blank user control
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DaysContainer.Controls.Add(ucblank);
            }
            // create user control for days
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                DaysContainer.Controls.Add(ucDays);
            }
        }

        private void BtnPrevMonth_Click(object sender, EventArgs e)
        {
            if (Prev == false)
            {
                Prev = true;
                BtnPrevMonth.Text = "Mese attuale";
                if (month == 1)
                {
                    month = 12;
                    year--;
                }
                else
                {
                    month--;
                }
            } else
            {
                Prev = false;
                BtnPrevMonth.Text = "Mese precedente";
                if (month == 12)
                {
                    month = 1;
                    year++;
                }
                else
                {
                    month++;
                }
            }
            current_month = month;
            pass_month = month;
            pass_year = year;

            DaysContainer.Controls.Clear();
            
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblMonthYear.Text = char.ToUpper(monthName[0]) + monthName.Substring(1) + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            // days in the month
            int days = DateTime.DaysInMonth(year, month) + 1;
            //
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // create blank user control
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DaysContainer.Controls.Add(ucblank);
            }
            // create user control for days
            for (int i = 1; i < days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                DaysContainer.Controls.Add(ucDays);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler resettare il mese corrente?", "Reset mese",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using var client = new HttpClient();
                var endpoint = new Uri("http://localhost:8081/cleaning/resetmonth/" + current_month);
                var result = client.DeleteAsync(endpoint).Result;
                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show("ERROR: " + result, "ERRORE", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}