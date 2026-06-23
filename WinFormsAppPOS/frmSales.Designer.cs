namespace WinFormsAppPOS
{
    partial class frmSales
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
            dgvSales = new DataGridView();
            dgvCart = new DataGridView();
            lblProductName = new Label();
            label1 = new Label();
            label2 = new Label();
            txtSaleDetailID = new TextBox();
            txtProductName = new TextBox();
            cmbCategory = new ComboBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSearch = new TextBox();
            label5 = new Label();
            btnAddToCart = new Button();
            btnEdit = new Button();
            btnOrder = new Button();
            btnDelete = new Button();
            label6 = new Label();
            label7 = new Label();
            txtProductID = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(12, 185);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersVisible = false;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(428, 285);
            dgvSales.TabIndex = 0;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(446, 135);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(467, 241);
            dgvCart.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(23, 83);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(87, 15);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 117);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Category:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 19);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Sale Detail ID:";
            // 
            // txtSaleDetailID
            // 
            txtSaleDetailID.Location = new Point(115, 16);
            txtSaleDetailID.Name = "txtSaleDetailID";
            txtSaleDetailID.Size = new Size(100, 23);
            txtSaleDetailID.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(115, 80);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(303, 23);
            txtProductName.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(115, 114);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(303, 23);
            cmbCategory.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(521, 52);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(243, 23);
            txtQuantity.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(521, 16);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(243, 23);
            txtPrice.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 19);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 55);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 8;
            label4.Text = "Quantity:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(128, 156);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(303, 23);
            txtSearch.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 159);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 12;
            label5.Text = "Product Search:";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(704, 99);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(193, 29);
            btnAddToCart.TabIndex = 14;
            btnAddToCart.Text = "ADD TO CART";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(491, 440);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 31);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(777, 440);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(136, 31);
            btnOrder.TabIndex = 16;
            btnOrder.Text = "PLACE ORDER";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(633, 440);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 31);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(751, 392);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 18;
            label6.Text = "TOTAL: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(803, 383);
            label7.Name = "label7";
            label7.Size = new Size(71, 32);
            label7.TabIndex = 19;
            label7.Text = "P0.00";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(115, 47);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(100, 23);
            txtProductID.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 50);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 20;
            label8.Text = "Product ID:";
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(925, 482);
            Controls.Add(txtProductID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(btnOrder);
            Controls.Add(btnEdit);
            Controls.Add(btnAddToCart);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(cmbCategory);
            Controls.Add(txtProductName);
            Controls.Add(txtSaleDetailID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblProductName);
            Controls.Add(dgvCart);
            Controls.Add(dgvSales);
            Name = "frmSales";
            Text = "frmSales";
            Load += frmSales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSales;
        private DataGridView dgvCart;
        private Label lblProductName;
        private Label label1;
        private Label label2;
        private TextBox txtSaleDetailID;
        private TextBox txtProductName;
        private ComboBox cmbCategory;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label3;
        private Label label4;
        private TextBox txtSearch;
        private Label label5;
        private Button btnAddToCart;
        private Button btnEdit;
        private Button btnOrder;
        private Button btnDelete;
        private Label label6;
        private Label label7;
        private TextBox txtProductID;
        private Label label8;
    }
}