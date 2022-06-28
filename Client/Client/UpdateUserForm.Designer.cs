namespace Client
{
    partial class UpdateUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassword1 = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword2 = new System.Windows.Forms.TextBox();
            this.CkPassword2 = new System.Windows.Forms.CheckBox();
            this.CkPassword1 = new System.Windows.Forms.CheckBox();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TopBorder.Controls.Add(this.label1);
            this.TopBorder.Controls.Add(this.BtnExit);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(323, 30);
            this.TopBorder.TabIndex = 0;
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            this.TopBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modifica Utente";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnExit.Location = new System.Drawing.Point(293, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nuova Password";
            // 
            // TxtPassword1
            // 
            this.TxtPassword1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword1.Location = new System.Drawing.Point(37, 107);
            this.TxtPassword1.Name = "TxtPassword1";
            this.TxtPassword1.PasswordChar = '•';
            this.TxtPassword1.Size = new System.Drawing.Size(258, 23);
            this.TxtPassword1.TabIndex = 3;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnUpdate.Location = new System.Drawing.Point(111, 312);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 40);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Invio";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conferma Password";
            // 
            // TxtPassword2
            // 
            this.TxtPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword2.Location = new System.Drawing.Point(37, 206);
            this.TxtPassword2.Name = "TxtPassword2";
            this.TxtPassword2.PasswordChar = '•';
            this.TxtPassword2.Size = new System.Drawing.Size(258, 23);
            this.TxtPassword2.TabIndex = 3;
            // 
            // CkPassword2
            // 
            this.CkPassword2.AutoSize = true;
            this.CkPassword2.BackColor = System.Drawing.Color.AliceBlue;
            this.CkPassword2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CkPassword2.Location = new System.Drawing.Point(179, 235);
            this.CkPassword2.Name = "CkPassword2";
            this.CkPassword2.Size = new System.Drawing.Size(116, 19);
            this.CkPassword2.TabIndex = 5;
            this.CkPassword2.Text = "Mostra password";
            this.CkPassword2.UseVisualStyleBackColor = false;
            this.CkPassword2.CheckedChanged += new System.EventHandler(this.CkPassword2_CheckedChanged);
            // 
            // CkPassword1
            // 
            this.CkPassword1.AutoSize = true;
            this.CkPassword1.BackColor = System.Drawing.Color.AliceBlue;
            this.CkPassword1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CkPassword1.Location = new System.Drawing.Point(179, 136);
            this.CkPassword1.Name = "CkPassword1";
            this.CkPassword1.Size = new System.Drawing.Size(116, 19);
            this.CkPassword1.TabIndex = 5;
            this.CkPassword1.Text = "Mostra password";
            this.CkPassword1.UseVisualStyleBackColor = false;
            this.CkPassword1.CheckedChanged += new System.EventHandler(this.CkPassword1_CheckedChanged);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(323, 381);
            this.Controls.Add(this.CkPassword2);
            this.Controls.Add(this.CkPassword1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtPassword2);
            this.Controls.Add(this.TxtPassword1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateUserForm";
            this.TopBorder.ResumeLayout(false);
            this.TopBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TopBorder;
        private Button BtnExit;
        private Label label1;
        private Label label3;
        private TextBox TxtPassword1;
        private Button BtnUpdate;
        private Label label2;
        private TextBox TxtPassword2;
        private CheckBox CkPassword2;
        private CheckBox CkPassword1;
    }
}