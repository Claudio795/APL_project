namespace Client
{
    partial class AddItemForm
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
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.CkUrgent = new System.Windows.Forms.CheckBox();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TopBorder.Controls.Add(this.label1);
            this.TopBorder.Controls.Add(this.BtnExit);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(2, 2);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(301, 30);
            this.TopBorder.TabIndex = 0;
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            this.TopBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci elemento";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(271, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnAddItem.Location = new System.Drawing.Point(92, 337);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(124, 50);
            this.BtnAddItem.TabIndex = 1;
            this.BtnAddItem.Text = "Invio";
            this.BtnAddItem.UseVisualStyleBackColor = false;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantità";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Urgente";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(50, 88);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(211, 23);
            this.TxtName.TabIndex = 3;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(50, 216);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(81, 23);
            this.TxtQuantity.TabIndex = 3;
            this.TxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantity_KeyPress);
            // 
            // CbCategory
            // 
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Items.AddRange(new object[] {
            "alimentari",
            "medicine",
            "pulizia_casa",
            "igiene_personale"});
            this.CbCategory.Location = new System.Drawing.Point(50, 151);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(211, 23);
            this.CbCategory.TabIndex = 4;
            // 
            // CkUrgent
            // 
            this.CkUrgent.AutoSize = true;
            this.CkUrgent.Location = new System.Drawing.Point(133, 260);
            this.CkUrgent.Name = "CkUrgent";
            this.CkUrgent.Size = new System.Drawing.Size(15, 14);
            this.CkUrgent.TabIndex = 5;
            this.CkUrgent.UseVisualStyleBackColor = true;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(305, 404);
            this.Controls.Add(this.CkUrgent);
            this.Controls.Add(this.CbCategory);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAddItem);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItemForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.TopBorder.ResumeLayout(false);
            this.TopBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TopBorder;
        private Button BtnExit;
        private Label label1;
        private Button BtnAddItem;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtName;
        private TextBox TxtQuantity;
        private ComboBox CbCategory;
        private CheckBox CkUrgent;
    }
}