using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace Client
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new(0,0);

        private const int cGrip = 16;
        private const int cCaption = 32;

        private readonly int borderSize = 2;

        public Form1()
        {
            InitializeComponent();
            Padding = new Padding(borderSize);
            SetStyle(ControlStyles.ResizeRedraw, true);

        }

        private void Clear()
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtUsername.Focus();
        }

        public void LoadForm(object Form)
        {
            if (MainPanel.Controls.Count > 0)
                MainPanel.Controls.RemoveAt(0);
            // approfondire
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(f);
            MainPanel.Tag = f;
            f.Show();
        }

        public void SetVisibility(bool value)
        {
            UserIcon.Visible = value;
            BtnLogout.Visible = value;
            BtnRoomClean.Visible = value;
            BtnUpdate.Visible = value;
            BtnCleaning.Visible = value;
            BtnGrocery.Visible = value;
            BtnUsers.Visible = value;
            LblUsername.Visible = value;
            SidePanel.Visible = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // hide controls before loggin in
            SetVisibility(false);
            TxtUsername.Focus();

        }

        private void BtnRoomClean_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnRoomClean.Height;
            PnlNav.Left = BtnRoomClean.Left;
            PnlNav.Top = BtnRoomClean.Top;
            BtnRoomClean.BackColor = Color.AliceBlue;

            LoadForm(new CleanRoomForm());

        }

        private void BtnCleaning_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnCleaning.Height;
            PnlNav.Left = BtnCleaning.Left;
            PnlNav.Top = BtnCleaning.Top;
            BtnCleaning.BackColor = Color.AliceBlue;
            BtnRoomClean.BackColor = Color.CornflowerBlue;

            LoadForm(new CleaningForm());
        }

        private void BtnGrocery_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnGrocery.Height;
            PnlNav.Left = BtnGrocery.Left;
            PnlNav.Top = BtnGrocery.Top;
            BtnGrocery.BackColor = Color.AliceBlue;
            BtnRoomClean.BackColor = Color.CornflowerBlue;

            LoadForm(new GroceryForm());
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnUsers.Height;
            PnlNav.Left = BtnUsers.Left;
            PnlNav.Top = BtnUsers.Top;
            BtnUsers.BackColor = Color.AliceBlue;
            BtnRoomClean.BackColor = Color.CornflowerBlue;

            LoadForm(new UsersForm());
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnUpdate.Height;
            PnlNav.Left = BtnUpdate.Left;
            PnlNav.Top = BtnUpdate.Top;
            BtnUpdate.BackColor = Color.AliceBlue;
            BtnRoomClean.BackColor = Color.CornflowerBlue;

            LoadForm(new UpdateForm());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRoomClean_Leave(object sender, EventArgs e)
        {
            BtnRoomClean.BackColor = Color.CornflowerBlue;
        }

        private void BtnCleaning_Leave(object sender, EventArgs e)
        {
            BtnCleaning.BackColor = Color.CornflowerBlue;
        }

        private void BtnGrocery_Leave(object sender, EventArgs e)
        {
            BtnGrocery.BackColor = Color.CornflowerBlue;
        }

        private void BtnUsers_Leave(object sender, EventArgs e)
        {
            BtnUsers.BackColor = Color.CornflowerBlue;
        }

        private void BtnUpdate_Leave(object sender, EventArgs e)
        {
            BtnUpdate.BackColor = Color.CornflowerBlue;
        }


        private void TopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void TopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void TopBorder_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        
        private void BtnResize_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                WindowState = FormWindowState.Maximized;
            } else
            {
                WindowState = FormWindowState.Normal;
            }
            
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        // override method for window resize
        protected override void WndProc(ref Message m)
        {
            const int win_message = 0x84;
            if (m.Msg == win_message)
            {
                Point pos = new(m.LParam.ToInt32());
                pos = PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LoggedUser.Clear();
            //MessageBox.Show("Arrivederci!", "Logout");
            SetVisibility(false);
            //LoginForm login = new();
            Form1 form = new();
            form.Show();
            Hide();
        }

        private void CkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CkPassword.Checked)
            {
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '•';
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (new string[] { TxtUsername.Text, TxtPassword.Text }.Any(v => String.IsNullOrEmpty(v)))
            {
                MessageBox.Show("Errore: campi mancanti", "Login: errore", MessageBoxButtons.OK);
                Clear();
            }
            else
            {
                using var client = new HttpClient();
                // send auth data to server
                var endpoint = new Uri("http://localhost:8081/users/auth");
                LogUser logUser = new()
                {
                    username = TxtUsername.Text,
                    password = TxtPassword.Text,
                };
                string json = JsonConvert.SerializeObject(logUser);
                StringContent payload = new StringContent(json, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoint, payload).Result;
                switch (result.StatusCode)
                {
                    case System.Net.HttpStatusCode.Forbidden:
                        MessageBox.Show("Errore: utente inesistente", "Login: errore");
                        Clear();
                        break;
                    case System.Net.HttpStatusCode.BadRequest:
                        MessageBox.Show("Errore: password errata", "Login: errore");
                        Clear();
                        break;
                    case System.Net.HttpStatusCode.OK:
                        string resJson = result.Content.ReadAsStringAsync().Result;

                        var resUser = JsonConvert.DeserializeObject<User>(resJson);
                        LoggedUser.id = resUser.id;
                        LoggedUser.name = resUser.name;
                        LoggedUser.username = resUser.username;
                        LoggedUser.isadmin = resUser.isadmin;
                        //MessageBox.Show("Benvenuto/a " + LoggedUser.name + "!", "Login: successo");

                        //ENABLE BUTTONS
                        SetVisibility(true);
                        LblUsername.Text = LoggedUser.username;
                        // load CleanRoomForm
                        PnlNav.Height = BtnRoomClean.Height;
                        PnlNav.Left = BtnRoomClean.Left;
                        PnlNav.Top = BtnRoomClean.Top;
                        BtnRoomClean.BackColor = Color.AliceBlue;

                        LoadForm(new CleanRoomForm());
                        

                        break;
                    default:
                        MessageBox.Show("Errore: errore sconosciuto", "Login: errore");
                        Clear();
                        break;
                }
            }
        }
    }
}