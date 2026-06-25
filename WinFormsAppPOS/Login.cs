using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WinFormsAppPOS
{
    public partial class frmLogin : Form
    {
        string connectionString = "Server=localhost;Database=pos_db;Uid=root;Pwd=;";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Users WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "' ";

                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IDvalues.UserID = reader.GetInt32("UserID");

                                MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmMain main = new frmMain();
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            }
                        }
                        conn.Dispose();
                    }
                }

                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message + "\nLOGIN ERROR");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmReg = new frmRegister();
            frmReg.Show();
            this.Hide();
        }
    }
}
