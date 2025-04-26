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

        public FrmMain()
        {
            InitializeComponent();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            bool a = this.WindowState == FormWindowState.Minimized;
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

        }
      

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnaboutus_Click(object sender, EventArgs e)
        {
            AboutUs aboutForm = new AboutUs();
            aboutForm.ShowDialog();
        }
    }
}
