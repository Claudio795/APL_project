namespace Client
{
    partial class UpdateItemForm
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CkUrgent = new System.Windows.Forms.CheckBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
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
            this.TopBorder.Size = new System.Drawing.Size(426, 32);
            this.TopBorder.TabIndex = 0;
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            this.TopBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modifica elemento";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(392, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(34, 32);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Location = new System.Drawing.Point(146, 398);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(127, 49);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Invio";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.ForeColor = System.Drawing.Color.Black;
            this.LblName.Location = new System.Drawing.Point(12, 95);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(160, 16);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Elemento da modificare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(92, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(99, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantità";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(103, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Urgente";
            // 
            // CkUrgent
            // 
            this.CkUrgent.AutoSize = true;
            this.CkUrgent.ForeColor = System.Drawing.Color.White;
            this.CkUrgent.Location = new System.Drawing.Point(245, 238);
            this.CkUrgent.Name = "CkUrgent";
            this.CkUrgent.Size = new System.Drawing.Size(92, 20);
            this.CkUrgent.TabIndex = 3;
            this.CkUrgent.Text = "checkBox1";
            this.CkUrgent.UseVisualStyleBackColor = true;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(237, 183);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(53, 22);
            this.TxtQuantity.TabIndex = 4;
            this.TxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantity_KeyPress);
            // 
            // CbCategory
            // 
            this.CbCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "alimenti",
            "medicine",
            "pulizia_casa",
            "igiene_personale"});
            this.CbCategory.BackColor = System.Drawing.SystemColors.Window;
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Items.AddRange(new object[] {
            "alimentari",
            "medicine",
            "pulizia_casa",
            "igiene_personale"});
            this.CbCategory.Location = new System.Drawing.Point(237, 131);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(121, 24);
            this.CbCategory.TabIndex = 5;
            // 
            // UpdateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(426, 480);
            this.Controls.Add(this.CbCategory);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.CkUrgent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TopBorder);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateItem";
            this.Load += new System.EventHandler(this.UpdateItemForm_Load);
            this.TopBorder.ResumeLayout(false);
            this.TopBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TopBorder;
        private Label label1;
        private Button BtnExit;
        private Button BtnUpdate;
        private Label LblName;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox CkUrgent;
        private TextBox TxtQuantity;
        private ComboBox CbCategory;
    }
}