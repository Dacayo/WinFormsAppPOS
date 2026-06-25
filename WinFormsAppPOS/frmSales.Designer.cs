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
            dgvCustomer = new DataGridView();
            dgvProduct = new DataGridView();
            lblProductName = new Label();
            label1 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtProductSearch = new TextBox();
            label5 = new Label();
            btnAddToCart = new Button();
            btnEdit = new Button();
            btnOrder = new Button();
            btnDelete = new Button();
            label6 = new Label();
            label7 = new Label();
            txtCustomerSearch = new TextBox();
            label2 = new Label();
            dgvCart = new DataGridView();
            txtCustomerName = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            productsname = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(12, 241);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(367, 281);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(385, 202);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(379, 320);
            dgvProduct.TabIndex = 1;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(21, 79);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(87, 15);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 43);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Customer Name:";
            label1.Click += label1_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(113, 76);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(393, 23);
            txtProductName.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(770, 76);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(182, 23);
            txtQuantity.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(770, 40);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(182, 23);
            txtPrice.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(708, 43);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(708, 79);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 8;
            label4.Text = "Quantity:";
            // 
            // txtProductSearch
            // 
            txtProductSearch.Location = new Point(480, 173);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(284, 23);
            txtProductSearch.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 176);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 12;
            label5.Text = "Search:";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(1002, 114);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(193, 29);
            btnAddToCart.TabIndex = 14;
            btnAddToCart.Text = "ADD TO CART";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(588, 542);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 31);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(874, 542);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(136, 31);
            btnOrder.TabIndex = 16;
            btnOrder.Text = "PLACE ORDER";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(730, 542);
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
            label6.Location = new Point(1073, 552);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 18;
            label6.Text = "TOTAL: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1125, 543);
            label7.Name = "label7";
            label7.Size = new Size(71, 32);
            label7.TabIndex = 19;
            label7.Text = "P0.00";
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.Location = new Point(113, 212);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new Size(266, 23);
            txtCustomerSearch.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 215);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 20;
            label2.Text = "Search:";
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { ID, productsname, price, quantity, subtotal });
            dgvCart.Location = new Point(770, 149);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(439, 373);
            dgvCart.TabIndex = 22;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(114, 40);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(392, 23);
            txtCustomerName.TabIndex = 23;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "Product ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // productsname
            // 
            productsname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productsname.HeaderText = "Product Name";
            productsname.Name = "productsname";
            productsname.ReadOnly = true;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price.HeaderText = "Price";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantity.HeaderText = "Quantity";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // subtotal
            // 
            subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtotal.HeaderText = "SubTotal";
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1221, 580);
            Controls.Add(txtCustomerName);
            Controls.Add(dgvCart);
            Controls.Add(txtCustomerSearch);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(btnOrder);
            Controls.Add(btnEdit);
            Controls.Add(btnAddToCart);
            Controls.Add(txtProductSearch);
            Controls.Add(label5);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Controls.Add(lblProductName);
            Controls.Add(dgvProduct);
            Controls.Add(dgvCustomer);
            Name = "frmSales";
            Text = "frmSales";
            Load += frmSales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomer;
        private DataGridView dgvProduct;
        private Label lblProductName;
        private Label label1;
        private TextBox txtSaleDetailID;
        private TextBox txtProductName;
        private ComboBox cmbCategory;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label3;
        private Label label4;
        private TextBox txtProductSearch;
        private Label label5;
        private Button btnAddToCart;
        private Button btnEdit;
        private Button btnOrder;
        private Button btnDelete;
        private Label label6;
        private Label label7;
        private TextBox txtCustomerSearch;
        private Label label2;
        private DataGridView dgvCart;
        private TextBox txtCustomerName;
        private TextBox txtProductID;
        private Label label8;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn productsname;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn subtotal;
    }
}