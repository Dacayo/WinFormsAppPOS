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
            txtCustomerName.Enabled = true;
            txtAddress.Enabled = true;
            txtContact.Enabled = true;
            txtEmail.Enabled = true;
        }

        public void add()
        {
            dgvCustomer.Rows.Add(txtCustomerID.Text, txtCustomerName.Text, txtAddress.Text, txtContact.Text, txtEmail.Text);
        }

        public frmCustomer()
        {
            InitializeComponent();
            disable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("New")) {
                btnAdd.Text = "Add";
                enable();
                txtCustomerName.Focus();
                return;
                
            }
            if (btnAdd.Text.Equals("Add"))
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

                                add();
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
                    btnAdd.Text = "New";
                    return;
                }
            }
        }
    }
}
