namespace WinFormsAppPOS
{
    partial class frmCustomer
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
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            button1 = new Button();
            dgvCustomer = new DataGridView();
            txtContact = new TextBox();
            lblContact = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtCustomerID = new TextBox();
            lblCustomerID = new Label();
            ID = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(53, 91);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(97, 15);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(156, 88);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(370, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(156, 116);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(370, 23);
            txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(53, 119);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(41, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(170, 220);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 31);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(299, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 31);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(428, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 31);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(41, 36);
            button1.TabIndex = 8;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { ID, dgvName, Address, Contact, Email });
            dgvCustomer.Location = new Point(27, 257);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.Size = new Size(543, 181);
            dgvCustomer.TabIndex = 9;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(156, 145);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(230, 23);
            txtContact.TabIndex = 11;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(53, 148);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(52, 15);
            lblContact.TabIndex = 10;
            lblContact.Text = "Contact:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(156, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 23);
            txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(53, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(156, 59);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(230, 23);
            txtCustomerID.TabIndex = 15;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(53, 62);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(76, 15);
            lblCustomerID.TabIndex = 14;
            lblCustomerID.Text = "Customer ID:";
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // dgvName
            // 
            dgvName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvName.HeaderText = "Name";
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Contact
            // 
            Contact.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            Contact.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(599, 450);
            Controls.Add(txtCustomerID);
            Controls.Add(lblCustomerID);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(dgvCustomer);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Name = "frmCustomer";
            Text = "Customer Maintenance";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private TextBox txtAddress;
        private Label lblAddress;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Button button1;
        private DataGridView dgvCustomer;
        private TextBox txtContact;
        private Label lblContact;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtCustomerID;
        private Label lblCustomerID;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Email;
    }
}