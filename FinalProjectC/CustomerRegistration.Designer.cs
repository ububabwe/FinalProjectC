using System.Windows.Forms;

namespace cc103InventoryFinalProj
{
    partial class CustomerRegistration
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt2fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpbithdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btnregnow = new System.Windows.Forms.Button();
            this.btnaccount = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnMinimized);
            this.panel2.Controls.Add(this.btnMaximized);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 62);
            this.panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1238, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 52);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.Location = new System.Drawing.Point(1100, 2);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(57, 55);
            this.btnMinimized.TabIndex = 0;
            this.btnMinimized.Text = "-";
            this.btnMinimized.UseVisualStyleBackColor = true;
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximized.Location = new System.Drawing.Point(1166, 2);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(63, 54);
            this.btnMaximized.TabIndex = 1;
            this.btnMaximized.Text = "🗖";
            this.btnMaximized.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(242, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fullname";
            // 
            // txt2fullname
            // 
            this.txt2fullname.Location = new System.Drawing.Point(116, 92);
            this.txt2fullname.Name = "txt2fullname";
            this.txt2fullname.Size = new System.Drawing.Size(295, 26);
            this.txt2fullname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(231, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Birthdate";
            // 
            // dtpbithdate
            // 
            this.dtpbithdate.Location = new System.Drawing.Point(116, 189);
            this.dtpbithdate.Name = "dtpbithdate";
            this.dtpbithdate.Size = new System.Drawing.Size(298, 26);
            this.dtpbithdate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(256, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(236, 277);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(78, 26);
            this.txtage.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(228, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone No.";
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(188, 357);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(172, 26);
            this.txtphoneno.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(176, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.ForeColor = System.Drawing.Color.Black;
            this.rbmale.Location = new System.Drawing.Point(72, 92);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(68, 24);
            this.rbmale.TabIndex = 12;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.ForeColor = System.Drawing.Color.Black;
            this.rbfemale.Location = new System.Drawing.Point(264, 92);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(87, 24);
            this.rbfemale.TabIndex = 13;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(159, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email Adress";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(72, 188);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(265, 26);
            this.txtemail.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(176, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(87, 277);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(250, 26);
            this.txtaddress.TabIndex = 17;
            // 
            // btnregnow
            // 
            this.btnregnow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnregnow.ForeColor = System.Drawing.Color.Black;
            this.btnregnow.Location = new System.Drawing.Point(154, 538);
            this.btnregnow.Name = "btnregnow";
            this.btnregnow.Size = new System.Drawing.Size(182, 35);
            this.btnregnow.TabIndex = 18;
            this.btnregnow.Text = "Register Now";
            this.btnregnow.UseVisualStyleBackColor = true;
            // 
            // btnaccount
            // 
            this.btnaccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaccount.ForeColor = System.Drawing.Color.Black;
            this.btnaccount.Location = new System.Drawing.Point(102, 538);
            this.btnaccount.Name = "btnaccount";
            this.btnaccount.Size = new System.Drawing.Size(224, 35);
            this.btnaccount.TabIndex = 19;
            this.btnaccount.Text = "Do you have an account?";
            this.btnaccount.UseVisualStyleBackColor = true;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.Controls.Add(this.txt2fullname);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.dtpbithdate);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.txtage);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.txtphoneno);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.btnregnow);
            this.leftPanel.Location = new System.Drawing.Point(18, 71);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(525, 603);
            this.leftPanel.TabIndex = 20;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Controls.Add(this.rbmale);
            this.rightPanel.Controls.Add(this.rbfemale);
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.txtemail);
            this.rightPanel.Controls.Add(this.label6);
            this.rightPanel.Controls.Add(this.txtaddress);
            this.rightPanel.Controls.Add(this.label7);
            this.rightPanel.Controls.Add(this.btnaccount);
            this.rightPanel.Location = new System.Drawing.Point(802, 71);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(520, 603);
            this.rightPanel.TabIndex = 21;
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "CustomerRegistration";
            this.Text = "Customer Registration";
            this.panel2.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnMaximized;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpbithdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btnregnow;
        private System.Windows.Forms.Button btnaccount;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
    }
}