namespace WinFormsAppPOS
{
    partial class frmProduct
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtProductId = new TextBox();
            cmbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 22);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Product id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Product Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 89);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 120);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Category :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(75, 159);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(156, 159);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(237, 159);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(318, 159);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = SystemColors.Control;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { id, name, price, category });
            dgvProducts.Location = new Point(40, 188);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(403, 217);
            dgvProducts.TabIndex = 8;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 50;
            // 
            // name
            // 
            name.HeaderText = "NAME";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 155;
            // 
            // price
            // 
            price.HeaderText = "PRICE";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 125;
            // 
            // category
            // 
            category.HeaderText = "CATEGORY";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.Width = 127;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(130, 46);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(305, 23);
            txtProductName.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(130, 81);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(174, 23);
            txtPrice.TabIndex = 11;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(130, 14);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(305, 23);
            txtProductId.TabIndex = 9;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "-Select Category-", "Drinks", "Bread & Pastry", "Snacks", "Vegetables" });
            cmbCategory.Location = new Point(130, 112);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(174, 23);
            cmbCategory.TabIndex = 12;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(493, 416);
            Controls.Add(cmbCategory);
            Controls.Add(dgvProducts);
            Controls.Add(txtPrice);
            Controls.Add(txtProductId);
            Controls.Add(txtProductName);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Maintenance";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtProductId;
        private ComboBox cmbCategory;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn category;
    }
}