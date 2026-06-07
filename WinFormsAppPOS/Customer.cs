using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsAppPOS
{
    public partial class frmCustomer : Form
    {
        string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=;";

        
        public string getId()
        {
            string customerID = "001";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "SELECT MAX(CustomerID) FROM Customers";

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

            return txtCustomerID.Text = customerID;
        }

        public void disable()
        {
            txtCustomerID.Enabled = false;
            txtCustomerName.Enabled = false;
            txtAddress.Enabled = false;
            txtContact.Enabled = false;
            txtEmail.Enabled = false;
        }

        public void enable()
        {
            txtCustomerID.Enabled = false;
            txtCustomerName.Enabled = true;
            txtAddress.Enabled = true;
            txtContact.Enabled = true;
            txtEmail.Enabled = true;
        }

        public void clear()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        public void showData()
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nCustomer ERROR");
                    conn.Dispose();
                }
            }
        }

        public frmCustomer()
        {
            InitializeComponent();
            disable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("New"))
            {
                getId();
                btnAdd.Text = "Add";
                enable();
                txtCustomerName.Focus();
                return;

            }
            else if (btnAdd.Text.Equals("Add"))
            {
                txtCustomerID.Enabled = false;

                if (string.IsNullOrEmpty(txtCustomerName.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtCustomerName.Focus();
                }

                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtAddress.Focus();
                }

                else if (string.IsNullOrEmpty(txtContact.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtContact.Focus();
                }

                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtEmail.Focus();
                }

                else
                {

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();

                            string sqlQuery = "INSERT INTO Customers (CustomerID, CustomerName, Address, ContactNumber, Email)" +
                            "VALUES (@CustomerID, @CustomerName, @Address, @ContactNumber, @Email)";

                            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                                cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text);
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Customer added successfully!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                conn.Dispose();
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nCustomer ERROR");
                        }

                    }
                    disable();
                    clear();
                    showData();
                    btnAdd.Text = "New";
                    return;
                }
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0)
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
                        string sqlQuery = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                        using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Customer deleted successfully!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nCustomer ERROR");
                    }
                    clear();
                    showData();
                    return;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("Edit"))
            {
                txtCustomerID.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
                txtCustomerName.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
                txtAddress.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
                txtContact.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
                txtEmail.Text = dgvCustomer.SelectedRows[0].Cells[4].Value.ToString();
                enable();
                btnEdit.Text = "Update";
                txtCustomerName.Focus();
                return;
            }

            else if (btnEdit.Text.Equals("Update"))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string sqlQuery = "UPDATE Customers " +
                                          "SET CustomerName = @CustomerName, " +
                                          "Address = @Address, " +
                                          "ContactNumber = @ContactNumber, " +
                                          "Email = @Email " +
                                          "WHERE CustomerID = @CustomerID";

                        using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                            cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                            cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Customer updated successfully!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            conn.Dispose();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nCustomer ERROR");
                    }
                }

                disable();
                clear();
                showData();
                btnEdit.Text = "Edit";
                return;
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtContact.Text = row.Cells["ContactNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}
