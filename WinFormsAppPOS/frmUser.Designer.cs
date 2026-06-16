namespace WinFormsAppPOS
{
    partial class frmUser
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
            txtLname = new TextBox();
            txtAge = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtFname = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtMname = new TextBox();
            label6 = new Label();
            dgvUser = new DataGridView();
            btnView = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            txtUserID = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 90);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Lname:";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(82, 87);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(221, 23);
            txtLname.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(82, 125);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(221, 23);
            txtAge.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 128);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Age:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(410, 125);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 23);
            txtUsername.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 128);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Username:";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(410, 87);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(220, 23);
            txtFname.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 90);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 4;
            label4.Text = "Fname:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(729, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 23);
            txtPassword.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(675, 128);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Pwd:";
            // 
            // txtMname
            // 
            txtMname.Location = new Point(729, 87);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(234, 23);
            txtMname.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(675, 90);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 8;
            label6.Text = "Mname:";
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(28, 166);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(935, 264);
            dgvUser.TabIndex = 12;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // btnView
            // 
            btnView.Location = new Point(41, 436);
            btnView.Name = "btnView";
            btnView.Size = new Size(154, 32);
            btnView.TabIndex = 13;
            btnView.Text = "VIEW";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(238, 436);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 32);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(427, 436);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 32);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(616, 436);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(154, 32);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(470, 46);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(127, 23);
            txtUserID.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 49);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 17;
            label7.Text = "User ID:";
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(995, 480);
            Controls.Add(txtUserID);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnView);
            Controls.Add(dgvUser);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtMname);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtFname);
            Controls.Add(label4);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(txtLname);
            Controls.Add(label1);
            Name = "frmUser";
            Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLname;
        private TextBox txtAge;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtFname;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtMname;
        private Label label6;
        private DataGridView dgvUser;
        private Button btnView;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCancel;
        private TextBox txtUserID;
        private Label label7;
    }
}