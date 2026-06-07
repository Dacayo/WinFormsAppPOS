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

        public void showData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * from Products";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProducts.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nProducts ERROR");
                    conn.Dispose();
                }
            }
        }

        public string getId()
        {
            string customerID = "001";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "SELECT MAX(ProductID) FROM Products";

                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int lastID = Convert.ToInt32(result);
                            customerID = (lastID + 1).ToString("D3");
                        }
                    }
                }

                catch (Exception ex)
                {

                }

            }

            return txtProductID.Text = customerID;
        }
        public void Reset()
        {
            txtProductID.Enabled = false;
            txtProductName.Enabled = false;
            txtDescription.Enabled = false;
            txtPrice.Enabled = false;
            txtStockQuantity.Enabled = false;
        }
        public void Clear()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtStockQuantity.Clear();
        }
        public void enable()
        {
            txtProductID.Enabled = false;
            txtProductName.Enabled = true;
            txtDescription.Enabled = true;
            txtPrice.Enabled = true;
            txtStockQuantity.Enabled = true;
        }

        public void inputValue()
        {
            txtProductID.Text = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
            txtDescription.Text = dgvProducts.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = dgvProducts.SelectedRows[0].Cells[3].Value.ToString();
            txtStockQuantity.Text = dgvProducts.SelectedRows[0].Cells[4].Value.ToString();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("ADD"))
            {
                getId();
                enable();
                btnAdd.Text = "SAVE";
                txtProductName.Focus();
                return;
            }

            if (btnAdd.Text.Equals("SAVE"))
            {
                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtProductName.Focus();
                }

                else if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtPrice.Focus();
                }

                else if (string.IsNullOrEmpty(txtStockQuantity.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtStockQuantity.Focus();
                }

                else
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string sqlQuery = "INSERT INTO Products (ProductID, ProductName, Description, UnitPrice, StockQuantity)" +
                                              "VALUES (@ProductID, @ProductName, @Description, @UnitPrice, @StockQuantity)";

                            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                                cmd.Parameters.AddWithValue("@UnitPrice", txtPrice.Text);
                                cmd.Parameters.AddWithValue("@StockQuantity", txtStockQuantity.Text);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Product added successfully!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                conn.Dispose();
                            }

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nProducts ERROR");
                        }
                    }
                    Reset();
                    Clear();
                    showData();
                    btnAdd.Text = "ADD";
                    return;
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("EDIT"))
            {
                inputValue();
                enable();
                btnEdit.Text = "UPDATE";
                txtProductName.Focus();
                return;
            }

            else if (btnEdit.Text.Equals("UPDATE"))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string sqlQuery = "UPDATE Products " +
                                          "SET ProductName = @ProductName, " +
                                            "Description = @Description, " +
                                            "UnitPrice = @UnitPrice, " +
                                            "StockQuantity = @StockQuantity " +
                                          "WHERE ProductID = @ProductID";

                        using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                            cmd.Parameters.AddWithValue("@UnitPrice", txtPrice.Text);
                            cmd.Parameters.AddWithValue("@StockQuantity", txtStockQuantity.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Product updated successfully!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            conn.Dispose();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nProduct ERROR");
                    }
                    Reset();
                    Clear();
                    showData();
                    btnEdit.Text = "EDIT";
                    return;
                }
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select row to delete", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string sqlQuery = "DELETE FROM Products WHERE ProductID = @ProductID";

                        using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Product deleted successfully!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            conn.Dispose();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nProduct ERROR");
                    }
                    Clear();
                    showData();
                    return;
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                txtStockQuantity.Text = row.Cells["StockQuantity"].Value.ToString();
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
