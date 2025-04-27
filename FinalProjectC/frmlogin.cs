using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cc103InventoryFinalProj
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();

            btnsignup.Click += new EventHandler(btnsignup_Click);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ValidateLogin(username, password))
            {
                FrmMain mainForm = new FrmMain();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            bool isValid = false;
            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=login_system;Uid=root;Pwd=password;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM users WHERE username=@Username AND password=@Password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    isValid = (count > 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}