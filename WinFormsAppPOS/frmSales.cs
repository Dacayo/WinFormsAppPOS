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
        public frmSales()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtSaleDetailID.Enabled = false;
            txtProductName.Enabled = false;
            cmbCategory.Enabled = false;
            txtPrice.Enabled = false;
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

                    dgvSales.DataSource = dt;
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nProducts ERROR");

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            getId();
            Reset();
            showData();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "INSERT INTO salesdetails (SaleDetailID, SaleID, ProductID, Quantity, UnitPrice, SubTotal)" +
                                      "VALUES (@SaleDetailID, @SaleID, @ProductID, @Quantity, @UnitPrice, @SubTotal)";

                    double result = Convert.ToDouble(txtPrice.Text) + Convert.ToDouble(txtQuantity.Text);

                    using ( MySqlCommand cmd = new MySqlCommand( sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SaleDetailID", txtSaleDetailID.Text);
                        cmd.Parameters.AddWithValue("@SaleID", txtSaleID.Text);
                        cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                        cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                        cmd.Parameters.AddWithValue("@UnitPrice", txtPrice.Text);
                        cmd.Parameters.AddWithValue("@SubTotal", result);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nCart ERROR");
                }
            }
        }
    }
}
