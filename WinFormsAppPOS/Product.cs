using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace WinFormsAppPOS
{
    public partial class frmProduct : Form
    {
        string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=;";

        public frmProduct()
        {
            InitializeComponent();
            Reset();
        }
        int idNum = 0;
        public int getProductId(int _id)
        {
            idNum = idNum + 1;
            return idNum;
        }
        public void Reset()
        {
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtPrice.Enabled = false;
            cmbCategory.Enabled = false;
            cmbCategory.SelectedIndex = 0;
        }
        public void Clear()
        {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cmbCategory.SelectedIndex = 0;
        }
        public void InputEnable()
        {
            txtProductId.Enabled = false;
            txtProductName.Enabled = true;
            txtPrice.Enabled = true;
            cmbCategory.Enabled = true;
            cmbCategory.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                idNum = getProductId(idNum);
                txtProductId.Text = "00" + idNum;
                btnAdd.Text = "SAVE";
                InputEnable();
            }
            else if (btnAdd.Text == "SAVE")
            {
                string id = txtProductId.Text;
                string name = txtProductName.Text;
                string price = txtPrice.Text;
                string category = cmbCategory.Text;
                dgvProducts.Rows.Add(id, name, price, category);
                btnAdd.Text = "ADD";
                Clear();
                Reset();
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "EDIT")
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    btnEdit.Text = "UPDATE";
                    InputEnable();
                    txtProductId.Text = dgvProducts.SelectedRows[0].Cells["ID"].Value.ToString();
                    txtProductName.Text = dgvProducts.SelectedRows[0].Cells["NAME"].Value.ToString();
                    txtPrice.Text = dgvProducts.SelectedRows[0].Cells["PRICE"].Value.ToString();
                    cmbCategory.Text = dgvProducts.SelectedRows[0].Cells["CATEGORY"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please select data on the list.");
                }
            }
            else if (btnEdit.Text == "UPDATE")
            {
                for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
                {
                    if (dgvProducts.Rows[i].Cells["ID"].Value.ToString() == txtProductId.Text)
                    {
                        dgvProducts.Rows[i].Cells["ID"].Value = txtProductId.Text;
                        dgvProducts.Rows[i].Cells["NAME"].Value = txtProductName.Text;
                        dgvProducts.Rows[i].Cells["PRICE"].Value = txtPrice.Text;
                        dgvProducts.Rows[i].Cells["CATEGORY"].Value = cmbCategory.Text;

                        MessageBox.Show("SUCCESSFULLY UPDATED");
                    }
                }
                btnEdit.Text = "EDIT";
                Clear();
                Reset();
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            dgvProducts.Rows.Add(001, "Coke", 25, "Drinks");
            dgvProducts.Rows.Add(002, "Sprite", 25, "Drinks");
            dgvProducts.Rows.Add(003, "Royal", 25, "Drinks");
            dgvProducts.Rows.Add(004, "RC", 25, "Drinks");
            dgvProducts.Rows.Add(005, "C2", 25, "Drinks");
            dgvProducts.Rows.Add(006, "Coke", 25, "Drinks");
            idNum = 6;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
               MessageBox.Show("Please select row to delete","No selection",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
                
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete the selected row(s)?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvProducts.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvProducts.Rows.Remove(row);
                        MessageBox.Show("Selected row(s) deleted successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
