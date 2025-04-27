using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cc103InventoryFinalProj
{
    public partial class CustomerRegistration : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Database=login_system;Uid=root;Pwd=password;";

        public CustomerRegistration()
        {
            InitializeComponent();

            // Add this to calculate age automatically when birthdate changes
            dtpbithdate.ValueChanged += DtpBirthdate_ValueChanged;

            // Add event handlers for buttons
            btnClose.Click += BtnClose_Click;
            btnMinimized.Click += BtnMinimized_Click;
            btnMaximized.Click += BtnMaximized_Click;
            btnregnow.Click += BtnRegNow_Click;
            btnaccount.Click += BtnAccount_Click;

            // Add resize event handler
            this.Resize += new EventHandler(Form_Resize);

            // Calculate age initially
            CalculateAge();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            // Adjust controls as needed when form is resized
            AdjustControlPositions();
        }

        private void AdjustControlPositions()
        {
            // This method can be expanded to handle more complex responsive adjustments
            // For now, we'll rely primarily on anchoring defined in the Designer
        }

        private void DtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            // Calculate age automatically
            CalculateAge();
        }

        private void CalculateAge()
        {
            DateTime today = DateTime.Today;
            DateTime birthDate = dtpbithdate.Value;
            int age = today.Year - birthDate.Year;

            // Adjust age if birthday hasn't occurred yet this year
            if (birthDate.Date > today.AddYears(-age))
                age--;

            txtage.Text = age.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel)
            {
                // If inside a panel (child form), we might not want to minimize
                // Maybe hide this button in child form mode
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void BtnMaximized_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel)
            {
                // If inside a panel (child form), we might not want to maximize
                // Maybe hide this button in child form mode
            }
            else
            {
                if (this.WindowState == FormWindowState.Normal)
                    this.WindowState = FormWindowState.Maximized;
                else
                    this.WindowState = FormWindowState.Normal;
            }
        }

        private bool CustomerExists(string email)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Customers WHERE Email = @Email";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool SaveCustomerToDatabase()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Customers (FullName, BirthDate, Age, PhoneNo, Gender, Email, Address)
                                   VALUES (@FullName, @BirthDate, @Age, @PhoneNo, @Gender, @Email, @Address)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FullName", txt2fullname.Text.Trim());
                    command.Parameters.AddWithValue("@BirthDate", dtpbithdate.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Age", Convert.ToInt32(txtage.Text));
                    command.Parameters.AddWithValue("@PhoneNo", txtphoneno.Text.Trim());
                    command.Parameters.AddWithValue("@Gender", rbmale.Checked ? "Male" : "Female");
                    command.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                    command.Parameters.AddWithValue("@Address", txtaddress.Text.Trim());

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void BtnRegNow_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txt2fullname.Text))
            {
                MessageBox.Show("Please enter your full name.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtage.Text))
            {
                MessageBox.Show("Please enter your age.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtphoneno.Text))
            {
                MessageBox.Show("Please enter your phone number.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rbmale.Checked && !rbfemale.Checked)
            {
                MessageBox.Show("Please select your gender.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Please enter your email address.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtaddress.Text))
            {
                MessageBox.Show("Please enter your address.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if email already exists
            if (CustomerExists(txtemail.Text.Trim()))
            {
                MessageBox.Show("A customer with this email already exists.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save to database
            if (SaveCustomerToDatabase())
            {
                MessageBox.Show("Registration successful!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            // Navigate to login form
            // LoginForm loginForm = new LoginForm();
            // loginForm.Show();
            // this.Hide();
            MessageBox.Show("This would navigate to the login form.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearForm()
        {
            txt2fullname.Clear();
            dtpbithdate.Value = DateTime.Today;
            txtage.Clear();
            txtphoneno.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            txtemail.Clear();
            txtaddress.Clear();
        }

        // Keep these methods for compatibility with the designer
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt2fullname_TextChanged(object sender, EventArgs e)
        {
        }
    }
}