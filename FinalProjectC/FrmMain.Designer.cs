using System.Drawing;
using System;
using System.Windows.Forms;

namespace cc103InventoryFinalProj
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnaboutus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.btnCustomerregistration = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Location = new System.Drawing.Point(290, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 631);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnMinimized);
            this.panel2.Controls.Add(this.btnMaximized);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 62);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1131, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 52);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Location = new System.Drawing.Point(993, 2);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(57, 55);
            this.btnMinimized.TabIndex = 0;
            this.btnMinimized.Text = "-";
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Location = new System.Drawing.Point(1059, 2);
            this.btnMaximized.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(63, 54);
            this.btnMaximized.TabIndex = 1;
            this.btnMaximized.Text = "🗖";
            this.btnMaximized.UseVisualStyleBackColor = true;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnaboutus);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnSales);
            this.panel3.Controls.Add(this.btnCustomers);
            this.panel3.Controls.Add(this.btnPurchases);
            this.panel3.Controls.Add(this.btnCustomerregistration);
            this.panel3.Controls.Add(this.btnProduct);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 427);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::cc103InventoryFinalProj.Properties.Resources.Screenshot_2025_04_06_1751131;
            this.button1.Location = new System.Drawing.Point(56, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 111);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnaboutus
            // 
            this.btnaboutus.BackColor = System.Drawing.Color.Khaki;
            this.btnaboutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaboutus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnaboutus.Image = global::cc103InventoryFinalProj.Properties.Resources.Screenshot_2025_04_06_180641;
            this.btnaboutus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaboutus.Location = new System.Drawing.Point(21, 518);
            this.btnaboutus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnaboutus.Name = "btnaboutus";
            this.btnaboutus.Size = new System.Drawing.Size(258, 40);
            this.btnaboutus.TabIndex = 11;
            this.btnaboutus.Text = "About us";
            this.btnaboutus.UseVisualStyleBackColor = false;
            this.btnaboutus.Click += new System.EventHandler(this.btnaboutus_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Khaki;
            this.btnExit.Location = new System.Drawing.Point(4, 591);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Khaki;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSales.Image = global::cc103InventoryFinalProj.Properties.Resources.Screenshot_2025_04_04_183807;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(18, 462);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(261, 46);
            this.btnSales.TabIndex = 9;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Khaki;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCustomers.Image = global::cc103InventoryFinalProj.Properties.Resources.Screenshot_2025_04_04_183639;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(16, 406);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(262, 46);
            this.btnCustomers.TabIndex = 8;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnPurchases
            // 
            this.btnPurchases.BackColor = System.Drawing.Color.Khaki;
            this.btnPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchases.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPurchases.Image = global::cc103InventoryFinalProj.Properties.Resources.Screenshot_2025_04_04_183443;
            this.btnPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchases.Location = new System.Drawing.Point(16, 352);
            this.btnPurchases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(262, 45);
            this.btnPurchases.TabIndex = 7;
            this.btnPurchases.Text = "      Purchases";
            this.btnPurchases.UseVisualStyleBackColor = false;
            this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // btnCustomerregistration
            // 
            this.btnCustomerregistration.BackColor = System.Drawing.Color.Khaki;
            this.btnCustomerregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerregistration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCustomerregistration.Image = global::cc103InventoryFinalProj.Properties.Resources.Screenshot_2025_04_04_183231;
            this.btnCustomerregistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerregistration.Location = new System.Drawing.Point(21, 300);
            this.btnCustomerregistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomerregistration.Name = "btnCustomerregistration";
            this.btnCustomerregistration.Size = new System.Drawing.Size(260, 43);
            this.btnCustomerregistration.TabIndex = 6;
            this.btnCustomerregistration.Text = "Customer Registration";
            this.btnCustomerregistration.UseVisualStyleBackColor = false;
            this.btnCustomerregistration.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Khaki;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnProduct.Image = global::cc103InventoryFinalProj.Properties.Resources.Screenshot_2025_04_04_181908;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(18, 243);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(261, 48);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Khaki;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Image = global::cc103InventoryFinalProj.Properties.Resources.Screenshot_2025_04_04_180120;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(18, 183);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(261, 51);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(92, 126);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(110, 25);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 489);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximized;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnPurchases;
        private System.Windows.Forms.Button btnCustomerregistration;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnaboutus;
        private System.Windows.Forms.Button button1;

    }
    
}