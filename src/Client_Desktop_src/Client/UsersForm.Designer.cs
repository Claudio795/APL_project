namespace Client
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnInsertNew = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coinquilini";
            // 
            // UsersTable
            // 
            this.UsersTable.AllowUserToAddRows = false;
            this.UsersTable.AllowUserToResizeColumns = false;
            this.UsersTable.AllowUserToResizeRows = false;
            this.UsersTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersTable.AutoGenerateColumns = false;
            this.UsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersTable.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.UsersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.UsersTable.DataSource = this.userBindingSource;
            this.UsersTable.Location = new System.Drawing.Point(12, 127);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.ReadOnly = true;
            this.UsersTable.RowTemplate.Height = 25;
            this.UsersTable.Size = new System.Drawing.Size(576, 167);
            this.UsersTable.TabIndex = 1;
            this.UsersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersTable_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Update
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.Update.DefaultCellStyle = dataGridViewCellStyle1;
            this.Update.FillWeight = 50F;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.HeaderText = "";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "Modifica";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Visible = false;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FillWeight = 50F;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Elimina";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Visible = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Client.User);
            // 
            // BtnInsertNew
            // 
            this.BtnInsertNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsertNew.AutoSize = true;
            this.BtnInsertNew.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnInsertNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertNew.FlatAppearance.BorderSize = 0;
            this.BtnInsertNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertNew.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.BtnInsertNew.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnInsertNew.Location = new System.Drawing.Point(406, 300);
            this.BtnInsertNew.Name = "BtnInsertNew";
            this.BtnInsertNew.Size = new System.Drawing.Size(182, 26);
            this.BtnInsertNew.TabIndex = 2;
            this.BtnInsertNew.Text = "Inserisci nuovo coinquilino";
            this.BtnInsertNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInsertNew.UseVisualStyleBackColor = false;
            this.BtnInsertNew.Visible = false;
            this.BtnInsertNew.Click += new System.EventHandler(this.BtnInsertNew_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Image = global::Client.Properties.Resources.refresh;
            this.BtnRefresh.Location = new System.Drawing.Point(558, 91);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(30, 30);
            this.BtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.TabStop = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            this.BtnRefresh.MouseHover += new System.EventHandler(this.BtnRefresh_MouseHover);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnInsertNew);
            this.Controls.Add(this.UsersTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView UsersTable;
        private Button BtnInsertNew;
        private PictureBox BtnRefresh;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
    }
}