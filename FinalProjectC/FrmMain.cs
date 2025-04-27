using cc103InventoryFinalProj;
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
    public partial class FrmMain : Form
    {
        public object CenterPanel { get; private set; }

        // Add this field to track the active form
        private Form activeForm = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        // Method to open child forms in the panel
        private void OpenChildForm(Form childForm)
        {
            // Close the current active form if it exists
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Set up the child form to fit exactly in panel1
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            // Set the exact size of the child form to match panel1
            childForm.Width = panel1.Width;
            childForm.Height = panel1.Height;

            // Ensure the form fills the entire panel
            childForm.Dock = DockStyle.Fill;

            // Clear any existing controls in panel1
            panel1.Controls.Clear();

            // Add the child form to panel1
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;

            // Bring the form to the front and show it
            childForm.BringToFront();
            childForm.Show();
        }

        // This is your Customer Registration button click handler
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerRegistration());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Close the active form to return to home
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            // Optional: Display home/dashboard content
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new PurchasesForm());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new SalesForm());
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Panel paint event - can be left empty
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new ProductForm());
        }

        private void btnaboutus_Click(object sender, EventArgs e)
        {
            AboutUs aboutForm = new AboutUs();
            aboutForm.ShowDialog();
        }

        // Add a new event handler for the Customers button
        // You'll need to connect this in the designer
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new CustomersForm());
        }
    }
}