namespace Client
{
    partial class GroceryForm
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
            this.BtnFood = new System.Windows.Forms.Button();
            this.BtnMedicine = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnSoap = new System.Windows.Forms.Button();
            this.BtnUrgent = new System.Windows.Forms.Button();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista della spesa";
            // 
            // BtnFood
            // 
            this.BtnFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFood.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFood.Image = global::Client.Properties.Resources.food1;
            this.BtnFood.Location = new System.Drawing.Point(230, 91);
            this.BtnFood.MaximumSize = new System.Drawing.Size(130, 130);
            this.BtnFood.MinimumSize = new System.Drawing.Size(130, 130);
            this.BtnFood.Name = "BtnFood";
            this.BtnFood.Size = new System.Drawing.Size(130, 130);
            this.BtnFood.TabIndex = 2;
            this.BtnFood.Text = "Alimentari";
            this.BtnFood.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnFood.UseVisualStyleBackColor = true;
            this.BtnFood.Click += new System.EventHandler(this.BtnFood_Click);
            // 
            // BtnMedicine
            // 
            this.BtnMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedicine.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMedicine.Image = global::Client.Properties.Resources.medicine;
            this.BtnMedicine.Location = new System.Drawing.Point(399, 91);
            this.BtnMedicine.MaximumSize = new System.Drawing.Size(130, 130);
            this.BtnMedicine.MinimumSize = new System.Drawing.Size(130, 130);
            this.BtnMedicine.Name = "BtnMedicine";
            this.BtnMedicine.Size = new System.Drawing.Size(130, 130);
            this.BtnMedicine.TabIndex = 3;
            this.BtnMedicine.Text = "Medicine";
            this.BtnMedicine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnMedicine.UseVisualStyleBackColor = true;
            this.BtnMedicine.Click += new System.EventHandler(this.BtnMedicine_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClean.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClean.Image = global::Client.Properties.Resources.cleaning;
            this.BtnClean.Location = new System.Drawing.Point(59, 264);
            this.BtnClean.MaximumSize = new System.Drawing.Size(130, 130);
            this.BtnClean.MinimumSize = new System.Drawing.Size(130, 130);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(130, 130);
            this.BtnClean.TabIndex = 4;
            this.BtnClean.Text = "Pulizia della casa";
            this.BtnClean.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnSoap
            // 
            this.BtnSoap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSoap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSoap.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSoap.Image = global::Client.Properties.Resources.soap;
            this.BtnSoap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSoap.Location = new System.Drawing.Point(230, 264);
            this.BtnSoap.MaximumSize = new System.Drawing.Size(130, 130);
            this.BtnSoap.MinimumSize = new System.Drawing.Size(130, 130);
            this.BtnSoap.Name = "BtnSoap";
            this.BtnSoap.Size = new System.Drawing.Size(130, 130);
            this.BtnSoap.TabIndex = 5;
            this.BtnSoap.Text = "Igiene personale";
            this.BtnSoap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSoap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSoap.UseVisualStyleBackColor = true;
            this.BtnSoap.Click += new System.EventHandler(this.BtnSoap_Click);
            // 
            // BtnUrgent
            // 
            this.BtnUrgent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUrgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUrgent.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUrgent.Image = global::Client.Properties.Resources.important;
            this.BtnUrgent.Location = new System.Drawing.Point(399, 264);
            this.BtnUrgent.MaximumSize = new System.Drawing.Size(130, 130);
            this.BtnUrgent.MinimumSize = new System.Drawing.Size(130, 130);
            this.BtnUrgent.Name = "BtnUrgent";
            this.BtnUrgent.Size = new System.Drawing.Size(130, 130);
            this.BtnUrgent.TabIndex = 6;
            this.BtnUrgent.Text = "Urgenti";
            this.BtnUrgent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUrgent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnUrgent.UseVisualStyleBackColor = true;
            this.BtnUrgent.Click += new System.EventHandler(this.BtnUrgent_Click);
            // 
            // BtnTotal
            // 
            this.BtnTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTotal.Image = global::Client.Properties.Resources.grocery;
            this.BtnTotal.Location = new System.Drawing.Point(59, 91);
            this.BtnTotal.MaximumSize = new System.Drawing.Size(130, 130);
            this.BtnTotal.MinimumSize = new System.Drawing.Size(130, 130);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(130, 130);
            this.BtnTotal.TabIndex = 1;
            this.BtnTotal.Text = "Totale";
            this.BtnTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTotal.UseVisualStyleBackColor = true;
            this.BtnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // GroceryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.BtnTotal);
            this.Controls.Add(this.BtnMedicine);
            this.Controls.Add(this.BtnUrgent);
            this.Controls.Add(this.BtnSoap);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnFood);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroceryForm";
            this.Text = "GroceryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BtnFood;
        private Button BtnMedicine;
        private Button BtnClean;
        private Button BtnSoap;
        private Button BtnUrgent;
        private Button BtnTotal;
    }
}