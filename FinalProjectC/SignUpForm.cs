using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cc103InventoryFinalProj
{
    public partial class SignUpForm : Form
    {
        private string connectionString = "Server=localhost;Database=login_system;Uid=root;Pwd=password;";

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter an email address.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UsernameExists(txtUsername.Text))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EmailExists(txtEmail.Text))
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RegisterUser())
            {
                MessageBox.Show("Registration successful! You can now log in.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmMain mainForm = new FrmMain();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UsernameExists(string username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM users WHERE username = @username";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool EmailExists(string email)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM users WHERE email = @email";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool RegisterUser()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string createTableQuery = @"CREATE TABLE IF NOT EXISTS users (
                        id INT PRIMARY KEY AUTO_INCREMENT,
                        username VARCHAR(50) NOT NULL UNIQUE,
                        password VARCHAR(255) NOT NULL,
                        email VARCHAR(100) NOT NULL UNIQUE,
                        created_at DATETIME DEFAULT CURRENT_TIMESTAMP
                    )";

                    MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
                    connection.Open();
                    createTableCommand.ExecuteNonQuery();

                    string insertQuery = @"INSERT INTO users (username, password, email) 
                                          VALUES (@username, @password, @email)";

                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    insertCommand.Parameters.AddWithValue("@password", txtPassword.Text); // In production, use password hashing
                    insertCommand.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                    int result = insertCommand.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmlogin loginForm = new frmlogin();
            loginForm.Show();

            this.Close();
        }
    }
}