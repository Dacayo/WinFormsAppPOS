namespace WinFormsAppPOS
{
    partial class frmCategory
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
            lblCategory = new Label();
            txtCategory = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvCategory = new DataGridView();
            txtDescription = new TextBox();
            label1 = new Label();
            txtCategoryID = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(36, 112);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(112, 109);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(286, 23);
            txtCategory.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(128, 190);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 28);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(220, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 28);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(312, 190);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 28);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(36, 237);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(362, 314);
            dgvCategory.TabIndex = 6;
            dgvCategory.CellClick += dgvCategory_CellClick;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(112, 150);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(286, 23);
            txtDescription.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 153);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 7;
            label1.Text = "Description:";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(112, 69);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(139, 23);
            txtCategoryID.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 72);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 9;
            label2.Text = "Category ID:";
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(440, 563);
            Controls.Add(txtCategoryID);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(dgvCategory);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Name = "frmCategory";
            Text = "frmCategory";
            Load += frmCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private TextBox txtCategory;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvCategory;
        private TextBox txtDescription;
        private Label label1;
        private TextBox txtCategoryID;
        private Label label2;
    }
}