namespace Client
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNumDay = new System.Windows.Forms.Label();
            this.LblRooms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNumDay
            // 
            this.LblNumDay.AutoSize = true;
            this.LblNumDay.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNumDay.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblNumDay.Location = new System.Drawing.Point(0, 0);
            this.LblNumDay.Name = "LblNumDay";
            this.LblNumDay.Size = new System.Drawing.Size(25, 16);
            this.LblNumDay.TabIndex = 0;
            this.LblNumDay.Text = "00";
            // 
            // LblRooms
            // 
            this.LblRooms.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblRooms.ForeColor = System.Drawing.Color.White;
            this.LblRooms.Location = new System.Drawing.Point(3, 33);
            this.LblRooms.Name = "LblRooms";
            this.LblRooms.Size = new System.Drawing.Size(79, 23);
            this.LblRooms.TabIndex = 1;
            this.LblRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.LblRooms);
            this.Controls.Add(this.LblNumDay);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(85, 65);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNumDay;
        private Label LblRooms;
    }
}
