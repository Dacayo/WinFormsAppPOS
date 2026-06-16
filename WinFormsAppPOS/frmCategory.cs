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
    public partial class frmCategory : Form
    {
        string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=;";
        public void showData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * from Categories";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCategory.DataSource = dt;
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nUser ERROR");

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
                    string sqlQuery = "SELECT MAX(CategoryID) FROM Categories";

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
            return txtCategoryID.Text = customerID;
        }

        public void Reset()
        {
            txtCategoryID.Enabled = false;
            txtCategory.Enabled = false;
            txtDescription.Enabled = false;
        }
        public void Clear()
        {
            txtCategoryID.Clear();
            txtCategory.Clear();
            txtDescription.Clear();
        }
        public void enable()
        {
            txtCategoryID.Enabled = false;
            txtCategory.Enabled = true;
            txtDescription.Enabled = true;

        }
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            Reset();
            showData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("ADD"))
            {
                getId();
                enable();
                btnAdd.Text = "SAVE";
                txtCategory.Focus();
                return;
            }

            if (btnAdd.Text.Equals("SAVE"))
            {
                if (string.IsNullOrEmpty(txtCategory.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtCategory.Focus();
                }

                else if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("Fill up required field.");
                    txtDescription.Focus();
                }

                else
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string sqlQuery = "INSERT INTO Categories (CategoryName, Description)" +
                                              "VALUES (@CategoryName, @Description)";

                            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@CategoryName", txtCategory.Text);
                                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Category added successfully!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                conn.Dispose();
                            }

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nCategory ERROR");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("EDIT"))
            {
                enable();
                btnEdit.Text = "UPDATE";
                txtCategory.Focus();
                return;
            }

            else if (btnEdit.Text.Equals("UPDATE"))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string sqlQuery = "UPDATE Categories " +
                                          "SET CategoryName = @CategoryName, " +
                                          "Description = @Description " +
                                          "WHERE CategoryID = @CategoryID";

                        using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@CategoryID", txtCategoryID.Text);
                            cmd.Parameters.AddWithValue("@CategoryName", txtCategory.Text);
                            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Category updated successfully!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            conn.Dispose();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nCategory ERROR");
                    }
                    Reset();
                    Clear();
                    showData();
                    btnEdit.Text = "EDIT";
                }
            }
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategory.Rows[e.RowIndex];

                txtCategoryID.Text = row.Cells["CategoryID"].Value.ToString();
                txtCategory.Text = row.Cells["CategoryName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count == 0)
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
                        string sqlQuery = "DELETE FROM Categories WHERE CategoryID = @CategoryID";

                        using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@CategoryID", txtCategoryID.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Category deleted successfully!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            conn.Dispose();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nCategory ERROR");
                    }
                    Clear();
                    showData();
                    return;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
