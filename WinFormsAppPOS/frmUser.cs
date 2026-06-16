using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppPOS
{
    public partial class frmUser : Form
    {
        string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=;";
        public void showData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * from Users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUser.DataSource = dt;
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nUser ERROR");

                }
            }
        }

        public void Reset()
        {
            txtUserID.Enabled = false;
            txtLname.Enabled = false;
            txtFname.Enabled = false;
            txtMname.Enabled = false;
            txtAge.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
        }
        public void Clear()
        {
            txtUserID.Clear();
            txtLname.Clear();
            txtFname.Clear();
            txtMname.Clear();
            txtAge.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
        public void enable()
        {
            txtUserID.Enabled = false;
            txtLname.Enabled = true;
            txtFname.Enabled = true;
            txtMname.Enabled = true;
            txtAge.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
        }
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("EDIT"))
            {
                enable();
                btnEdit.Text = "UPDATE";
                txtLname.Focus();
                return;
            }

            else if (btnEdit.Text.Equals("UPDATE"))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string sqlQuery = "UPDATE Users " +
                                          "SET lastName = @lastName, " +
                                          "firstName = @firstName, " +
                                          "middleName = @middleName, " +
                                          "Age = @Age, " +
                                          "Username = @Username, " +
                                          "Password = @Password " +
                                          "WHERE UserID = @UserID";

                        using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
                            cmd.Parameters.AddWithValue("@lastName", txtLname.Text);
                            cmd.Parameters.AddWithValue("@firstName", txtFname.Text);
                            cmd.Parameters.AddWithValue("@middleName", txtMname.Text);
                            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
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
                }
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];

                txtUserID.Text = row.Cells["UserID"].Value.ToString();
                txtLname.Text = row.Cells["lastName"].Value.ToString();
                txtFname.Text = row.Cells["firstName"].Value.ToString();
                txtMname.Text = row.Cells["middleName"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count == 0)
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
                        string sqlQuery = "DELETE FROM Users WHERE UserID = @UserID";

                        using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Product deleted successfully!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            conn.Dispose();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nUsers ERROR");
                    }
                    Clear();
                    showData();
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
