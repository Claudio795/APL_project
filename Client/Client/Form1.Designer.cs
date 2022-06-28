namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnGrocery = new System.Windows.Forms.Button();
            this.BtnCleaning = new System.Windows.Forms.Button();
            this.BtnRoomClean = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.LblUsername = new System.Windows.Forms.Label();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.CkPassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TopBorder = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnResize = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SidePanel.Controls.Add(this.BtnUpdate);
            this.SidePanel.Controls.Add(this.BtnUsers);
            this.SidePanel.Controls.Add(this.BtnGrocery);
            this.SidePanel.Controls.Add(this.BtnCleaning);
            this.SidePanel.Controls.Add(this.BtnRoomClean);
            this.SidePanel.Controls.Add(this.UserPanel);
            resources.ApplyResources(this.SidePanel, "SidePanel");
            this.SidePanel.Name = "SidePanel";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.BtnUpdate, "BtnUpdate");
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.ForeColor = System.Drawing.Color.Aqua;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            this.BtnUpdate.Leave += new System.EventHandler(this.BtnUpdate_Leave);
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.BtnUsers, "BtnUsers");
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.ForeColor = System.Drawing.Color.Aqua;
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            this.BtnUsers.Leave += new System.EventHandler(this.BtnUsers_Leave);
            // 
            // BtnGrocery
            // 
            this.BtnGrocery.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.BtnGrocery, "BtnGrocery");
            this.BtnGrocery.FlatAppearance.BorderSize = 0;
            this.BtnGrocery.ForeColor = System.Drawing.Color.Aqua;
            this.BtnGrocery.Name = "BtnGrocery";
            this.BtnGrocery.UseVisualStyleBackColor = false;
            this.BtnGrocery.Click += new System.EventHandler(this.BtnGrocery_Click);
            this.BtnGrocery.Leave += new System.EventHandler(this.BtnGrocery_Leave);
            // 
            // BtnCleaning
            // 
            this.BtnCleaning.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.BtnCleaning, "BtnCleaning");
            this.BtnCleaning.FlatAppearance.BorderSize = 0;
            this.BtnCleaning.ForeColor = System.Drawing.Color.Aqua;
            this.BtnCleaning.Name = "BtnCleaning";
            this.BtnCleaning.UseVisualStyleBackColor = false;
            this.BtnCleaning.Click += new System.EventHandler(this.BtnCleaning_Click);
            this.BtnCleaning.Leave += new System.EventHandler(this.BtnCleaning_Leave);
            // 
            // BtnRoomClean
            // 
            this.BtnRoomClean.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.BtnRoomClean, "BtnRoomClean");
            this.BtnRoomClean.FlatAppearance.BorderSize = 0;
            this.BtnRoomClean.ForeColor = System.Drawing.Color.Aqua;
            this.BtnRoomClean.Name = "BtnRoomClean";
            this.BtnRoomClean.UseVisualStyleBackColor = false;
            this.BtnRoomClean.Click += new System.EventHandler(this.BtnRoomClean_Click);
            this.BtnRoomClean.Leave += new System.EventHandler(this.BtnRoomClean_Leave);
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.BtnLogout);
            this.UserPanel.Controls.Add(this.LblUsername);
            this.UserPanel.Controls.Add(this.UserIcon);
            resources.ApplyResources(this.UserPanel, "UserPanel");
            this.UserPanel.Name = "UserPanel";
            // 
            // BtnLogout
            // 
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnLogout, "BtnLogout");
            this.BtnLogout.ForeColor = System.Drawing.Color.LightBlue;
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // LblUsername
            // 
            resources.ApplyResources(this.LblUsername, "LblUsername");
            this.LblUsername.ForeColor = System.Drawing.Color.Aqua;
            this.LblUsername.Name = "LblUsername";
            // 
            // UserIcon
            // 
            resources.ApplyResources(this.UserIcon, "UserIcon");
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.TabStop = false;
            // 
            // BtnExit
            // 
            resources.ApplyResources(this.BtnExit, "BtnExit");
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.TabStop = false;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.PnlNav, "PnlNav");
            this.PnlNav.Name = "PnlNav";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel1);
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Name = "MainPanel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TxtUsername);
            this.panel1.Controls.Add(this.CkPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.label3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Name = "label1";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnLogin, "BtnLogin");
            this.BtnLogin.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUsername
            // 
            resources.ApplyResources(this.TxtUsername, "TxtUsername");
            this.TxtUsername.Name = "TxtUsername";
            // 
            // CkPassword
            // 
            resources.ApplyResources(this.CkPassword, "CkPassword");
            this.CkPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CkPassword.Name = "CkPassword";
            this.CkPassword.TabStop = false;
            this.CkPassword.UseVisualStyleBackColor = true;
            this.CkPassword.CheckedChanged += new System.EventHandler(this.CkPassword_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Name = "label2";
            // 
            // TxtPassword
            // 
            resources.ApplyResources(this.TxtPassword, "TxtPassword");
            this.TxtPassword.Name = "TxtPassword";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Name = "label3";
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TopBorder.Controls.Add(this.BtnMin);
            this.TopBorder.Controls.Add(this.BtnResize);
            this.TopBorder.Controls.Add(this.BtnExit);
            resources.ApplyResources(this.TopBorder, "TopBorder");
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            this.TopBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseUp);
            // 
            // BtnMin
            // 
            resources.ApplyResources(this.BtnMin, "BtnMin");
            this.BtnMin.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.TabStop = false;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnResize
            // 
            resources.ApplyResources(this.BtnResize, "BtnResize");
            this.BtnResize.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnResize.FlatAppearance.BorderSize = 0;
            this.BtnResize.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnResize.Name = "BtnResize";
            this.BtnResize.TabStop = false;
            this.BtnResize.UseVisualStyleBackColor = false;
            this.BtnResize.Click += new System.EventHandler(this.BtnResize_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.TopBorder);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.PnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TopBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SidePanel;
        private Panel UserPanel;
        private PictureBox UserIcon;
        private Label LblUsername;
        private Button BtnRoomClean;
        private Button BtnUsers;
        private Button BtnGrocery;
        private Button BtnCleaning;
        private Panel PnlNav;
        private Button BtnExit;
        private Button BtnLogout;
        private Panel MainPanel;
        private Panel TopBorder;
        private Button BtnResize;
        private Button BtnMin;
        private Button BtnUpdate;
        private Panel panel1;
        private Button BtnLogin;
        private TextBox TxtUsername;
        private CheckBox CkPassword;
        private Label label2;
        private TextBox TxtPassword;
        private Label label3;
        private Label label1;
    }
}