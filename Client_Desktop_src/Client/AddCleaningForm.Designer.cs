namespace Client
{
    partial class AddCleaningForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.RBToday = new System.Windows.Forms.RadioButton();
            this.RBAnotherDay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnAddCleaning = new System.Windows.Forms.Button();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TopBorder.Controls.Add(this.BtnExit);
            this.TopBorder.Controls.Add(this.label2);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(2, 2);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(291, 30);
            this.TopBorder.TabIndex = 0;
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            this.TopBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseUp);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(261, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inserisci turno completato";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseUp);
            // 
            // RBToday
            // 
            this.RBToday.AutoSize = true;
            this.RBToday.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RBToday.Location = new System.Drawing.Point(156, 96);
            this.RBToday.Name = "RBToday";
            this.RBToday.Size = new System.Drawing.Size(52, 20);
            this.RBToday.TabIndex = 1;
            this.RBToday.TabStop = true;
            this.RBToday.Text = "oggi";
            this.RBToday.UseVisualStyleBackColor = true;
            this.RBToday.CheckedChanged += new System.EventHandler(this.RBToday_CheckedChanged);
            // 
            // RBAnotherDay
            // 
            this.RBAnotherDay.AutoSize = true;
            this.RBAnotherDay.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RBAnotherDay.Location = new System.Drawing.Point(156, 121);
            this.RBAnotherDay.Name = "RBAnotherDay";
            this.RBAnotherDay.Size = new System.Drawing.Size(118, 20);
            this.RBAnotherDay.TabIndex = 1;
            this.RBAnotherDay.TabStop = true;
            this.RBAnotherDay.Text = "un altro giorno";
            this.RBAnotherDay.UseVisualStyleBackColor = true;
            this.RBAnotherDay.CheckedChanged += new System.EventHandler(this.RBAnotherDay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turno completato:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(154, 144);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // BtnAddCleaning
            // 
            this.BtnAddCleaning.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAddCleaning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAddCleaning.FlatAppearance.BorderSize = 0;
            this.BtnAddCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddCleaning.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddCleaning.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnAddCleaning.Location = new System.Drawing.Point(2, 287);
            this.BtnAddCleaning.Name = "BtnAddCleaning";
            this.BtnAddCleaning.Size = new System.Drawing.Size(291, 63);
            this.BtnAddCleaning.TabIndex = 4;
            this.BtnAddCleaning.Text = "Invio";
            this.BtnAddCleaning.UseVisualStyleBackColor = false;
            this.BtnAddCleaning.Click += new System.EventHandler(this.BtnAddCleaning_Click);
            // 
            // AddCleaningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(295, 352);
            this.Controls.Add(this.BtnAddCleaning);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBAnotherDay);
            this.Controls.Add(this.RBToday);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCleaningForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCleaningForm";
            this.Load += new System.EventHandler(this.AddCleaningForm_Load);
            this.TopBorder.ResumeLayout(false);
            this.TopBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TopBorder;
        private Button BtnExit;
        private RadioButton RBToday;
        private RadioButton RBAnotherDay;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private Button BtnAddCleaning;
        private Label label2;
    }
}