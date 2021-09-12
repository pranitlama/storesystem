
namespace Store_management_system
{
    partial class Employeewindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employeewindow));
            this.panelleft = new System.Windows.Forms.Panel();
            this.emp_addproduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Button();
            this.panelsides = new System.Windows.Forms.Panel();
            this.emp_logout = new System.Windows.Forms.Button();
            this.emp_cpass = new System.Windows.Forms.Button();
            this.emp_bill = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.employeerecords = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelleft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panelleft.Controls.Add(this.emp_addproduct);
            this.panelleft.Controls.Add(this.panel2);
            this.panelleft.Controls.Add(this.panelsides);
            this.panelleft.Controls.Add(this.emp_logout);
            this.panelleft.Controls.Add(this.emp_cpass);
            this.panelleft.Controls.Add(this.emp_bill);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(230, 487);
            this.panelleft.TabIndex = 1;
            // 
            // emp_addproduct
            // 
            this.emp_addproduct.FlatAppearance.BorderSize = 0;
            this.emp_addproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_addproduct.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_addproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_addproduct.Image = ((System.Drawing.Image)(resources.GetObject("emp_addproduct.Image")));
            this.emp_addproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emp_addproduct.Location = new System.Drawing.Point(17, 169);
            this.emp_addproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emp_addproduct.Name = "emp_addproduct";
            this.emp_addproduct.Size = new System.Drawing.Size(177, 50);
            this.emp_addproduct.TabIndex = 2;
            this.emp_addproduct.Text = "     ADD PRODUCT";
            this.emp_addproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emp_addproduct.UseVisualStyleBackColor = true;
            this.emp_addproduct.Click += new System.EventHandler(this.emp_addproduct_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.menu);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 105);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SAMP STORE";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(11, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.menu.Location = new System.Drawing.Point(198, 74);
            this.menu.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(30, 30);
            this.menu.TabIndex = 3;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panelsides
            // 
            this.panelsides.BackColor = System.Drawing.Color.White;
            this.panelsides.Location = new System.Drawing.Point(11, 169);
            this.panelsides.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelsides.Name = "panelsides";
            this.panelsides.Size = new System.Drawing.Size(7, 50);
            this.panelsides.TabIndex = 3;
            // 
            // emp_logout
            // 
            this.emp_logout.FlatAppearance.BorderSize = 0;
            this.emp_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_logout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_logout.Image = ((System.Drawing.Image)(resources.GetObject("emp_logout.Image")));
            this.emp_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emp_logout.Location = new System.Drawing.Point(21, 426);
            this.emp_logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emp_logout.Name = "emp_logout";
            this.emp_logout.Size = new System.Drawing.Size(177, 50);
            this.emp_logout.TabIndex = 2;
            this.emp_logout.Text = "     LOG OUT";
            this.emp_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emp_logout.UseVisualStyleBackColor = true;
            this.emp_logout.Click += new System.EventHandler(this.emp_logout_Click);
            // 
            // emp_cpass
            // 
            this.emp_cpass.FlatAppearance.BorderSize = 0;
            this.emp_cpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_cpass.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_cpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_cpass.Image = ((System.Drawing.Image)(resources.GetObject("emp_cpass.Image")));
            this.emp_cpass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emp_cpass.Location = new System.Drawing.Point(21, 341);
            this.emp_cpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emp_cpass.Name = "emp_cpass";
            this.emp_cpass.Size = new System.Drawing.Size(207, 50);
            this.emp_cpass.TabIndex = 2;
            this.emp_cpass.Text = "    CHANGE PASSWORD";
            this.emp_cpass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emp_cpass.UseVisualStyleBackColor = true;
            this.emp_cpass.Click += new System.EventHandler(this.emp_cpass_Click);
            // 
            // emp_bill
            // 
            this.emp_bill.FlatAppearance.BorderSize = 0;
            this.emp_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_bill.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_bill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emp_bill.Image = ((System.Drawing.Image)(resources.GetObject("emp_bill.Image")));
            this.emp_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emp_bill.Location = new System.Drawing.Point(21, 255);
            this.emp_bill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emp_bill.Name = "emp_bill";
            this.emp_bill.Size = new System.Drawing.Size(177, 50);
            this.emp_bill.TabIndex = 2;
            this.emp_bill.Text = "     BILLING SYSTEM";
            this.emp_bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emp_bill.UseVisualStyleBackColor = true;
            this.emp_bill.Click += new System.EventHandler(this.emp_bill_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.employeerecords);
            this.panel3.Controls.Add(this.close);
            this.panel3.Controls.Add(this.minimize);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(230, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 62);
            this.panel3.TabIndex = 2;
            // 
            // employeerecords
            // 
            this.employeerecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.employeerecords.AutoSize = true;
            this.employeerecords.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeerecords.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.employeerecords.Location = new System.Drawing.Point(183, 18);
            this.employeerecords.Name = "employeerecords";
            this.employeerecords.Size = new System.Drawing.Size(330, 29);
            this.employeerecords.TabIndex = 10;
            this.employeerecords.Text = "Store Management System";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(653, 2);
            this.close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 9;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(625, 2);
            this.minimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(24, 24);
            this.minimize.TabIndex = 8;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(230, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(683, 41);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(230, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 384);
            this.panel1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Employeewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelleft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Employeewindow";
            this.Text = "Employeewindow";
            this.Load += new System.EventHandler(this.Employeewindow_Load);
            this.panelleft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button emp_addproduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panelsides;
        private System.Windows.Forms.Button emp_logout;
        private System.Windows.Forms.Button emp_cpass;
        private System.Windows.Forms.Button emp_bill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label employeerecords;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}