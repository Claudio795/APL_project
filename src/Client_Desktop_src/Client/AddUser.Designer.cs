namespace Client
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopBorder = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TopBorder.Controls.Add(this.BtnExit);
            this.TopBorder.Controls.Add(this.label3);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(2, 2);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(288, 30);
            this.TopBorder.TabIndex = 0;
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            this.TopBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseUp);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(258, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nuovo Utente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.BackColor = System.Drawing.Color.White;
            this.TxtName.Location = new System.Drawing.Point(37, 79);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(204, 23);
            this.TxtName.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.BackColor = System.Drawing.Color.White;
            this.TxtPassword.Location = new System.Drawing.Point(34, 220);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(207, 23);
            this.TxtPassword.TabIndex = 4;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAddUser.FlatAppearance.BorderSize = 0;
            this.BtnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddUser.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnAddUser.Location = new System.Drawing.Point(99, 285);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(100, 40);
            this.BtnAddUser.TabIndex = 5;
            this.BtnAddUser.Text = "Invio";
            this.BtnAddUser.UseVisualStyleBackColor = false;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUsername.BackColor = System.Drawing.Color.White;
            this.TxtUsername.Location = new System.Drawing.Point(34, 145);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(207, 23);
            this.TxtUsername.TabIndex = 4;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(292, 351);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.TopBorder.ResumeLayout(false);
            this.TopBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TopBorder;
        private Label label1;
        private Label label2;
        private Button BtnExit;
        private Label label3;
        private TextBox TxtName;
        private TextBox TxtPassword;
        private Button BtnAddUser;
        private Label label4;
        private TextBox TxtUsername;
    }
}