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
            lblProductID = new Label();
            lblProductName = new Label();
            lblPrice = new Label();
            lblStockQuantity = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtProductID = new TextBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtStockQuantity = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(40, 22);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(68, 15);
            lblProductID.TabIndex = 0;
            lblProductID.Text = "Product id :";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(40, 54);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(90, 15);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name :";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(40, 131);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(39, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price :";
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Location = new Point(40, 162);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(91, 15);
            lblStockQuantity.TabIndex = 3;
            lblStockQuantity.Text = "Stock Quantity :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(501, 63);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 54);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(681, 63);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(174, 54);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(501, 123);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 54);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(681, 123);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(174, 54);
            btnClear.TabIndex = 7;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.Control;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(40, 193);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(835, 250);
            dgvProducts.TabIndex = 8;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(136, 46);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(305, 23);
            txtProductName.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(136, 123);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(174, 23);
            txtPrice.TabIndex = 11;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(136, 14);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(305, 23);
            txtProductID.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(136, 85);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(305, 23);
            txtDescription.TabIndex = 14;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(40, 93);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(73, 15);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description :";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(136, 159);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(174, 23);
            txtStockQuantity.TabIndex = 15;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(502, 17);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 16;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(566, 14);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(245, 23);
            cmbCategory.TabIndex = 17;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(900, 455);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtStockQuantity);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(dgvProducts);
            Controls.Add(txtPrice);
            Controls.Add(txtProductID);
            Controls.Add(txtProductName);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lblStockQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Controls.Add(lblProductID);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Maintenance";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductID;
        private Label lblProductName;
        private Label lblPrice;
        private Label lblStockQuantity;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtProductID;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtStockQuantity;
        private Label lblCategory;
        private ComboBox cmbCategory;
    }
}