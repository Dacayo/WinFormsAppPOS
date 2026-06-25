using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsAppPOS
{
    public partial class frmSales : Form
    {
        string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=;";
        string customerID;
        string productID;
        public frmSales()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtCustomerName.Enabled = false;
            txtProductName.Enabled = false;
            txtPrice.Enabled = false;
        }

        public void clear()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        public void showProducts()
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

                    dgvProduct.DataSource = dt;
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nProducts ERROR");

                }
            }
        }

        public void showCustomer()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * from Customers";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCustomer.DataSource = dt;
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nCustomer ERROR");

                }
            }
        }

        public void showCart()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * from salesdetails";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCart.DataSource = dt;
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nProducts ERROR");

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
                    string sqlQuery = "SELECT MAX(SaleDetailID) FROM Salesdetails";

                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int lastID = Convert.ToInt32(result);
                            customerID = (lastID + 1).ToString("000");
                        }
                    }
                }

                catch (Exception ex)
                {

                }
            }
            return txtSaleDetailID.Text = customerID;
        }

        public decimal CalculateTotalAmount()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;

                total += Convert.ToDecimal(row.Cells["subtotal"].Value);
            }

            return total;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            showCustomer();
            showProducts();
            Reset();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double subtotal = price * quantity;

            dgvCart.Rows.Add(
                productID,
                txtProductName.Text,
                price,
                quantity,
                subtotal
            );
            clear();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];

                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                customerID = row.Cells["CustomerID"].Value.ToString();
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];

                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                productID = row.Cells["ProductID"].Value.ToString();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int saleID;
                    decimal totalAmount = CalculateTotalAmount();
                    string salesQuery = "INSERT INTO sales (CustomerID, UserID, TotalAmount) " +
                                        "VALUES (@CustomerID, @UserID, @TotalAmount)";

                    string detailsQuery = "INSERT INTO salesdetails (SaleID, ProductID, Quantity, UnitPrice, SubTotal) " +
                                          "VALUES (@SaleID, @ProductID, @Quantity, @UnitPrice, @SubTotal)";

                    using (MySqlCommand cmd = new MySqlCommand(salesQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(customerID));
                        cmd.Parameters.AddWithValue("@UserID", IDvalues.UserID);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.ExecuteNonQuery();

                        saleID = Convert.ToInt32(cmd.LastInsertedId);
                    }

                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        if (row.IsNewRow) continue;

                        using (MySqlCommand cmd = new MySqlCommand(detailsQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@SaleID", saleID);
                            cmd.Parameters.AddWithValue("@ProductID", row.Cells["ID"].Value);
                            cmd.Parameters.AddWithValue("@Quantity", row.Cells["quantity"].Value);
                            cmd.Parameters.AddWithValue("@UnitPrice", row.Cells["price"].Value);
                            cmd.Parameters.AddWithValue("@SubTotal", row.Cells["subtotal"].Value);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Product added successfully!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvCart.Rows.Clear();
                    txtCustomerName.Clear();
                    clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nsales ERROR");
                }
            }
        }
    }
}
