using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppPOS
{
    public partial class frmRegister : Form
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
                    string sqlQuery = "SELECT MAX(UserID) FROM Users";

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

            return txtUserId.Text = customerID;
        }
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
            txtUserId.Enabled = false;
            getId();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           if (cmbRole.SelectedIndex != 0)
            {
                if (string.IsNullOrEmpty(txtFullname.Text))
                {
                    MessageBox.Show("Please fill up required field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullname.Focus();
                }
                else if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Please fill up required field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please fill up required field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else if (txtConfirm.Text != txtPassword.Text)
                {
                    MessageBox.Show("Password do not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirm.Focus();
                }
                else
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string sqlQuery = "INSERT INTO Users (UserID, Username, Password, FullName, Role) VALUES (@UserID, @Username, @Password, @FullName, @Role)";

                            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@UserID", txtUserId.Text);
                                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                                cmd.Parameters.AddWithValue("@FullName", txtFullname.Text);
                                cmd.Parameters.AddWithValue("@Role", cmbRole.Text);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                frmLogin login = new frmLogin();
                                login.Show();
                                this.Hide();
                                conn.Dispose();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nREGISTER ERROR");
                        }
                    }
                }

            }
           else
            {
                MessageBox.Show("Please select a role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRole.Focus();
            }
        }
    }
}
