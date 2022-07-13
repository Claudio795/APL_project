namespace Client
{
    partial class GroceryListForm
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
            this.TopBorder = new System.Windows.Forms.Panel();
            this.LblNameForm = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroceryTable = new System.Windows.Forms.DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblCatName = new System.Windows.Forms.Label();
            this.BtnNewItem = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isurgentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TopBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroceryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TopBorder.Controls.Add(this.LblNameForm);
            this.TopBorder.Controls.Add(this.BtnExit);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(2, 2);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(618, 30);
            this.TopBorder.TabIndex = 0;
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            this.TopBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseUp);
            // 
            // LblNameForm
            // 
            this.LblNameForm.AutoSize = true;
            this.LblNameForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNameForm.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblNameForm.Location = new System.Drawing.Point(3, 8);
            this.LblNameForm.Name = "LblNameForm";
            this.LblNameForm.Size = new System.Drawing.Size(130, 16);
            this.LblNameForm.TabIndex = 2;
            this.LblNameForm.Text = "Lista della spesa";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(588, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GroceryTable
            // 
            this.GroceryTable.AllowUserToAddRows = false;
            this.GroceryTable.AllowUserToDeleteRows = false;
            this.GroceryTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroceryTable.AutoGenerateColumns = false;
            this.GroceryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GroceryTable.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.GroceryTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroceryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroceryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.category,
            this.quantityDataGridViewTextBoxColumn,
            this.isurgentDataGridViewCheckBoxColumn,
            this.Update,
            this.Delete});
            this.GroceryTable.DataSource = this.itemBindingSource;
            this.GroceryTable.Location = new System.Drawing.Point(26, 75);
            this.GroceryTable.Name = "GroceryTable";
            this.GroceryTable.ReadOnly = true;
            this.GroceryTable.RowTemplate.Height = 25;
            this.GroceryTable.Size = new System.Drawing.Size(569, 310);
            this.GroceryTable.TabIndex = 1;
            this.GroceryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroceryTable_CellContentClick);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(Client.Item);
            // 
            // LblCatName
            // 
            this.LblCatName.AutoSize = true;
            this.LblCatName.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCatName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblCatName.Location = new System.Drawing.Point(26, 48);
            this.LblCatName.Name = "LblCatName";
            this.LblCatName.Size = new System.Drawing.Size(108, 19);
            this.LblCatName.TabIndex = 2;
            this.LblCatName.Text = "Nome Form";
            // 
            // BtnNewItem
            // 
            this.BtnNewItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnNewItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnNewItem.FlatAppearance.BorderSize = 0;
            this.BtnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNewItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnNewItem.Location = new System.Drawing.Point(2, 391);
            this.BtnNewItem.Name = "BtnNewItem";
            this.BtnNewItem.Size = new System.Drawing.Size(618, 50);
            this.BtnNewItem.TabIndex = 3;
            this.BtnNewItem.Text = "Inserisci nuovo elemento";
            this.BtnNewItem.UseVisualStyleBackColor = false;
            this.BtnNewItem.Click += new System.EventHandler(this.BtnNewItem_Click);
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
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Categoria";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantità";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isurgentDataGridViewCheckBoxColumn
            // 
            this.isurgentDataGridViewCheckBoxColumn.DataPropertyName = "isurgent";
            this.isurgentDataGridViewCheckBoxColumn.HeaderText = "Urgente";
            this.isurgentDataGridViewCheckBoxColumn.Name = "isurgentDataGridViewCheckBoxColumn";
            this.isurgentDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Update
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.Update.DefaultCellStyle = dataGridViewCellStyle1;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.HeaderText = "";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Modifica";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Elimina";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // GroceryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(622, 443);
            this.Controls.Add(this.BtnNewItem);
            this.Controls.Add(this.LblCatName);
            this.Controls.Add(this.GroceryTable);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroceryListForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroceryListForm";
            this.Load += new System.EventHandler(this.GroceryListForm_Load);
            this.TopBorder.ResumeLayout(false);
            this.TopBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroceryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TopBorder;
        private Button BtnExit;
        private Label LblNameForm;
        private DataGridView GroceryTable;
        private Label LblCatName;
        private Button BtnNewItem;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private BindingSource itemBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isurgentDataGridViewCheckBoxColumn;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
    }
}