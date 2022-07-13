namespace Client
{
    partial class UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword2 = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.CkPassword = new System.Windows.Forms.CheckBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(188, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuova password";
            // 
            // TxtPassword1
            // 
            this.TxtPassword1.Location = new System.Drawing.Point(125, 97);
            this.TxtPassword1.Name = "TxtPassword1";
            this.TxtPassword1.PasswordChar = '•';
            this.TxtPassword1.Size = new System.Drawing.Size(231, 23);
            this.TxtPassword1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(179, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Conferma password";
            // 
            // TxtPassword2
            // 
            this.TxtPassword2.Location = new System.Drawing.Point(125, 171);
            this.TxtPassword2.Name = "TxtPassword2";
            this.TxtPassword2.PasswordChar = '•';
            this.TxtPassword2.Size = new System.Drawing.Size(231, 23);
            this.TxtPassword2.TabIndex = 1;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnUpdate.Location = new System.Drawing.Point(188, 288);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(113, 59);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Invio";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // CkPassword
            // 
            this.CkPassword.AutoSize = true;
            this.CkPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CkPassword.Location = new System.Drawing.Point(188, 200);
            this.CkPassword.Name = "CkPassword";
            this.CkPassword.Size = new System.Drawing.Size(122, 19);
            this.CkPassword.TabIndex = 3;
            this.CkPassword.Text = "Mostra password";
            this.CkPassword.UseVisualStyleBackColor = true;
            this.CkPassword.CheckedChanged += new System.EventHandler(this.CkPassword_CheckedChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnClear.Location = new System.Drawing.Point(188, 241);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(113, 28);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.CkPassword);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtPassword1;
        private Label label2;
        private TextBox TxtPassword2;
        private Button BtnUpdate;
        private CheckBox CkPassword;
        private Button BtnClear;
    }
}