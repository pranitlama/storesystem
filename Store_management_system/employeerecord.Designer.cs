﻿
namespace Store_management_system
{
    partial class Required5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.em_fname = new System.Windows.Forms.TextBox();
            this.em_male = new System.Windows.Forms.RadioButton();
            this.em_female = new System.Windows.Forms.RadioButton();
            this.em_dob = new System.Windows.Forms.DateTimePicker();
            this.em_mname = new System.Windows.Forms.TextBox();
            this.employeelist = new System.Windows.Forms.DataGridView();
            this.em_address = new System.Windows.Forms.TextBox();
            this.em_pn = new System.Windows.Forms.TextBox();
            this.em_age = new System.Windows.Forms.TextBox();
            this.em_lname = new System.Windows.Forms.TextBox();
            this.em_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.eupdate = new ePOSOne.btnProduct.Button_WOC();
            this.edelete = new ePOSOne.btnProduct.Button_WOC();
            this.eadd = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Required1 = new System.Windows.Forms.Label();
            this.Required4 = new System.Windows.Forms.Label();
            this.Required3 = new System.Windows.Forms.Label();
            this.Required7 = new System.Windows.Forms.Label();
            this.Required6 = new System.Windows.Forms.Label();
            this.Required9 = new System.Windows.Forms.Label();
            this.Required10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.eclear = new ePOSOne.btnProduct.Button_WOC();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeelist)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // em_fname
            // 
            this.em_fname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_fname.Location = new System.Drawing.Point(131, 42);
            this.em_fname.Multiline = true;
            this.em_fname.Name = "em_fname";
            this.em_fname.Size = new System.Drawing.Size(230, 23);
            this.em_fname.TabIndex = 1;
            // 
            // em_male
            // 
            this.em_male.AutoSize = true;
            this.em_male.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_male.Location = new System.Drawing.Point(124, 142);
            this.em_male.Name = "em_male";
            this.em_male.Size = new System.Drawing.Size(57, 21);
            this.em_male.TabIndex = 7;
            this.em_male.TabStop = true;
            this.em_male.Text = "Male";
            this.em_male.UseVisualStyleBackColor = true;
            this.em_male.CheckedChanged += new System.EventHandler(this.em_male_CheckedChanged);
            // 
            // em_female
            // 
            this.em_female.AutoSize = true;
            this.em_female.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_female.Location = new System.Drawing.Point(215, 142);
            this.em_female.Name = "em_female";
            this.em_female.Size = new System.Drawing.Size(73, 21);
            this.em_female.TabIndex = 8;
            this.em_female.TabStop = true;
            this.em_female.Text = "Female";
            this.em_female.UseVisualStyleBackColor = true;
            this.em_female.CheckedChanged += new System.EventHandler(this.em_female_CheckedChanged);
            // 
            // em_dob
            // 
            this.em_dob.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.em_dob.Location = new System.Drawing.Point(498, 133);
            this.em_dob.Name = "em_dob";
            this.em_dob.Size = new System.Drawing.Size(230, 23);
            this.em_dob.TabIndex = 9;
            // 
            // em_mname
            // 
            this.em_mname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_mname.Location = new System.Drawing.Point(498, 42);
            this.em_mname.Multiline = true;
            this.em_mname.Name = "em_mname";
            this.em_mname.Size = new System.Drawing.Size(230, 23);
            this.em_mname.TabIndex = 2;
            // 
            // employeelist
            // 
            this.employeelist.AllowUserToAddRows = false;
            this.employeelist.AllowUserToDeleteRows = false;
            this.employeelist.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.employeelist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.eid,
            this.efname,
            this.emname,
            this.elname,
            this.ename,
            this.eaddress,
            this.epn,
            this.eage,
            this.egender,
            this.edob,
            this.eemail,
            this.Action});
            this.employeelist.GridColor = System.Drawing.SystemColors.Info;
            this.employeelist.Location = new System.Drawing.Point(40, 239);
            this.employeelist.Name = "employeelist";
            this.employeelist.ReadOnly = true;
            this.employeelist.Size = new System.Drawing.Size(1128, 301);
            this.employeelist.TabIndex = 10;
            this.employeelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeelist_CellClick);
            // 
            // em_address
            // 
            this.em_address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_address.Location = new System.Drawing.Point(124, 89);
            this.em_address.Multiline = true;
            this.em_address.Name = "em_address";
            this.em_address.Size = new System.Drawing.Size(230, 23);
            this.em_address.TabIndex = 4;
            // 
            // em_pn
            // 
            this.em_pn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_pn.Location = new System.Drawing.Point(498, 89);
            this.em_pn.Multiline = true;
            this.em_pn.Name = "em_pn";
            this.em_pn.Size = new System.Drawing.Size(230, 23);
            this.em_pn.TabIndex = 5;
            // 
            // em_age
            // 
            this.em_age.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_age.Location = new System.Drawing.Point(853, 91);
            this.em_age.Multiline = true;
            this.em_age.Name = "em_age";
            this.em_age.Size = new System.Drawing.Size(230, 23);
            this.em_age.TabIndex = 6;
            // 
            // em_lname
            // 
            this.em_lname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_lname.Location = new System.Drawing.Point(853, 45);
            this.em_lname.Multiline = true;
            this.em_lname.Name = "em_lname";
            this.em_lname.Size = new System.Drawing.Size(230, 23);
            this.em_lname.TabIndex = 3;
            // 
            // em_email
            // 
            this.em_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_email.Location = new System.Drawing.Point(853, 138);
            this.em_email.Multiline = true;
            this.em_email.Name = "em_email";
            this.em_email.Size = new System.Drawing.Size(295, 23);
            this.em_email.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Middle Name";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date of Birth";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phone no";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(761, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Last Name";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(775, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Age";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(775, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Email";
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // eupdate
            // 
            this.eupdate.BackColor = System.Drawing.SystemColors.Info;
            this.eupdate.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.eupdate.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.eupdate.Enabled = false;
            this.eupdate.FlatAppearance.BorderSize = 0;
            this.eupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.eupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.eupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eupdate.Location = new System.Drawing.Point(462, 183);
            this.eupdate.Name = "eupdate";
            this.eupdate.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.eupdate.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.eupdate.OnHoverTextColor = System.Drawing.Color.Black;
            this.eupdate.Size = new System.Drawing.Size(99, 36);
            this.eupdate.TabIndex = 12;
            this.eupdate.Text = "Update";
            this.eupdate.TextColor = System.Drawing.Color.White;
            this.eupdate.UseVisualStyleBackColor = false;
            this.eupdate.Click += new System.EventHandler(this.eupdate_Click);
            // 
            // edelete
            // 
            this.edelete.BackColor = System.Drawing.SystemColors.Info;
            this.edelete.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.edelete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.edelete.FlatAppearance.BorderSize = 0;
            this.edelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.edelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.edelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edelete.Location = new System.Drawing.Point(586, 183);
            this.edelete.Name = "edelete";
            this.edelete.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.edelete.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.edelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.edelete.Size = new System.Drawing.Size(99, 36);
            this.edelete.TabIndex = 13;
            this.edelete.Text = "Delete";
            this.edelete.TextColor = System.Drawing.Color.White;
            this.edelete.UseVisualStyleBackColor = false;
            this.edelete.Click += new System.EventHandler(this.edelete_Click);
            // 
            // eadd
            // 
            this.eadd.BackColor = System.Drawing.SystemColors.Info;
            this.eadd.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.eadd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.eadd.FlatAppearance.BorderSize = 0;
            this.eadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.eadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.eadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eadd.Location = new System.Drawing.Point(324, 183);
            this.eadd.Name = "eadd";
            this.eadd.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.eadd.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.eadd.OnHoverTextColor = System.Drawing.Color.Black;
            this.eadd.Size = new System.Drawing.Size(99, 36);
            this.eadd.TabIndex = 11;
            this.eadd.Text = "Add";
            this.eadd.TextColor = System.Drawing.Color.White;
            this.eadd.UseVisualStyleBackColor = false;
            this.eadd.Click += new System.EventHandler(this.eadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(118, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(833, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(104, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(104, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 18);
            this.label13.TabIndex = 14;
            this.label13.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(473, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(480, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 18);
            this.label16.TabIndex = 14;
            this.label16.Text = "*";
            // 
            // Required1
            // 
            this.Required1.AutoSize = true;
            this.Required1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Required1.ForeColor = System.Drawing.Color.Red;
            this.Required1.Location = new System.Drawing.Point(128, 68);
            this.Required1.Name = "Required1";
            this.Required1.Size = new System.Drawing.Size(64, 16);
            this.Required1.TabIndex = 15;
            this.Required1.Text = "Required";
            this.Required1.Visible = false;
            this.Required1.Click += new System.EventHandler(this.label17_Click);
            // 
            // Required4
            // 
            this.Required4.AutoSize = true;
            this.Required4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Required4.ForeColor = System.Drawing.Color.Red;
            this.Required4.Location = new System.Drawing.Point(128, 115);
            this.Required4.Name = "Required4";
            this.Required4.Size = new System.Drawing.Size(64, 16);
            this.Required4.TabIndex = 15;
            this.Required4.Text = "Required";
            this.Required4.Visible = false;
            // 
            // Required3
            // 
            this.Required3.AutoSize = true;
            this.Required3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Required3.ForeColor = System.Drawing.Color.Red;
            this.Required3.Location = new System.Drawing.Point(864, 72);
            this.Required3.Name = "Required3";
            this.Required3.Size = new System.Drawing.Size(64, 16);
            this.Required3.TabIndex = 15;
            this.Required3.Text = "Required";
            this.Required3.Visible = false;
            this.Required3.Click += new System.EventHandler(this.label17_Click);
            // 
            // Required7
            // 
            this.Required7.AutoSize = true;
            this.Required7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Required7.ForeColor = System.Drawing.Color.Red;
            this.Required7.Location = new System.Drawing.Point(511, 159);
            this.Required7.Name = "Required7";
            this.Required7.Size = new System.Drawing.Size(64, 16);
            this.Required7.TabIndex = 15;
            this.Required7.Text = "Required";
            this.Required7.Visible = false;
            this.Required7.Click += new System.EventHandler(this.label17_Click);
            // 
            // Required6
            // 
            this.Required6.AutoSize = true;
            this.Required6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Required6.ForeColor = System.Drawing.Color.Red;
            this.Required6.Location = new System.Drawing.Point(128, 166);
            this.Required6.Name = "Required6";
            this.Required6.Size = new System.Drawing.Size(64, 16);
            this.Required6.TabIndex = 15;
            this.Required6.Text = "Required";
            this.Required6.Visible = false;
            // 
            // Required9
            // 
            this.Required9.AutoSize = true;
            this.Required9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Required9.ForeColor = System.Drawing.Color.Red;
            this.Required9.Location = new System.Drawing.Point(511, 114);
            this.Required9.Name = "Required9";
            this.Required9.Size = new System.Drawing.Size(64, 16);
            this.Required9.TabIndex = 15;
            this.Required9.Text = "Required";
            this.Required9.Visible = false;
            this.Required9.Click += new System.EventHandler(this.label17_Click);
            // 
            // Required10
            // 
            this.Required10.AutoSize = true;
            this.Required10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Required10.ForeColor = System.Drawing.Color.Red;
            this.Required10.Location = new System.Drawing.Point(864, 119);
            this.Required10.Name = "Required10";
            this.Required10.Size = new System.Drawing.Size(64, 16);
            this.Required10.TabIndex = 15;
            this.Required10.Text = "Required";
            this.Required10.Visible = false;
            this.Required10.Click += new System.EventHandler(this.label17_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(815, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "*";
            // 
            // eclear
            // 
            this.eclear.BackColor = System.Drawing.SystemColors.Info;
            this.eclear.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.eclear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.eclear.FlatAppearance.BorderSize = 0;
            this.eclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.eclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.eclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclear.Location = new System.Drawing.Point(719, 183);
            this.eclear.Name = "eclear";
            this.eclear.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.eclear.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.eclear.OnHoverTextColor = System.Drawing.Color.Black;
            this.eclear.Size = new System.Drawing.Size(99, 36);
            this.eclear.TabIndex = 13;
            this.eclear.Text = "Clear";
            this.eclear.TextColor = System.Drawing.Color.White;
            this.eclear.UseVisualStyleBackColor = false;
            this.eclear.Click += new System.EventHandler(this.eclear_Click);
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 50;
            // 
            // eid
            // 
            this.eid.HeaderText = "EID";
            this.eid.MinimumWidth = 10;
            this.eid.Name = "eid";
            this.eid.ReadOnly = true;
            this.eid.Visible = false;
            this.eid.Width = 50;
            // 
            // efname
            // 
            this.efname.HeaderText = "First Name";
            this.efname.Name = "efname";
            this.efname.ReadOnly = true;
            this.efname.Visible = false;
            // 
            // emname
            // 
            this.emname.HeaderText = "Middle Name";
            this.emname.Name = "emname";
            this.emname.ReadOnly = true;
            this.emname.Visible = false;
            // 
            // elname
            // 
            this.elname.HeaderText = "Last Name";
            this.elname.Name = "elname";
            this.elname.ReadOnly = true;
            this.elname.Visible = false;
            // 
            // ename
            // 
            this.ename.HeaderText = "Employee Name";
            this.ename.Name = "ename";
            this.ename.ReadOnly = true;
            this.ename.Width = 150;
            // 
            // eaddress
            // 
            this.eaddress.HeaderText = "Address";
            this.eaddress.Name = "eaddress";
            this.eaddress.ReadOnly = true;
            this.eaddress.Width = 150;
            // 
            // epn
            // 
            this.epn.HeaderText = "Phone no";
            this.epn.Name = "epn";
            this.epn.ReadOnly = true;
            this.epn.Width = 150;
            // 
            // eage
            // 
            this.eage.HeaderText = "Age";
            this.eage.Name = "eage";
            this.eage.ReadOnly = true;
            this.eage.Width = 50;
            // 
            // egender
            // 
            this.egender.HeaderText = "Gender";
            this.egender.Name = "egender";
            this.egender.ReadOnly = true;
            // 
            // edob
            // 
            this.edob.HeaderText = "Date of Birth";
            this.edob.Name = "edob";
            this.edob.ReadOnly = true;
            this.edob.Width = 150;
            // 
            // eemail
            // 
            this.eemail.HeaderText = "Email Address";
            this.eemail.Name = "eemail";
            this.eemail.ReadOnly = true;
            this.eemail.Width = 200;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 98;
            // 
            // Required5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.Required6);
            this.Controls.Add(this.Required4);
            this.Controls.Add(this.Required7);
            this.Controls.Add(this.Required10);
            this.Controls.Add(this.Required3);
            this.Controls.Add(this.Required9);
            this.Controls.Add(this.Required1);
            this.Controls.Add(this.eupdate);
            this.Controls.Add(this.eclear);
            this.Controls.Add(this.edelete);
            this.Controls.Add(this.eadd);
            this.Controls.Add(this.employeelist);
            this.Controls.Add(this.em_dob);
            this.Controls.Add(this.em_female);
            this.Controls.Add(this.em_male);
            this.Controls.Add(this.em_lname);
            this.Controls.Add(this.em_email);
            this.Controls.Add(this.em_age);
            this.Controls.Add(this.em_pn);
            this.Controls.Add(this.em_mname);
            this.Controls.Add(this.em_address);
            this.Controls.Add(this.em_fname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "Required5";
            this.Size = new System.Drawing.Size(1194, 600);
            this.Load += new System.EventHandler(this.employeerecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox em_fname;
        private System.Windows.Forms.RadioButton em_male;
        private System.Windows.Forms.RadioButton em_female;
        private System.Windows.Forms.DateTimePicker em_dob;
        private System.Windows.Forms.TextBox em_mname;
        private System.Windows.Forms.DataGridView employeelist;
        private ePOSOne.btnProduct.Button_WOC eadd;
        private ePOSOne.btnProduct.Button_WOC edelete;
        private ePOSOne.btnProduct.Button_WOC eupdate;
        private System.Windows.Forms.TextBox em_address;
        private System.Windows.Forms.TextBox em_pn;
        private System.Windows.Forms.TextBox em_age;
        private System.Windows.Forms.TextBox em_lname;
        private System.Windows.Forms.TextBox em_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Required1;
        private System.Windows.Forms.Label Required4;
        private System.Windows.Forms.Label Required3;
        private System.Windows.Forms.Label Required7;
        private System.Windows.Forms.Label Required6;
        private System.Windows.Forms.Label Required9;
        private System.Windows.Forms.Label Required10;
        private System.Windows.Forms.Label label14;
        private ePOSOne.btnProduct.Button_WOC eclear;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn eid;
        private System.Windows.Forms.DataGridViewTextBoxColumn efname;
        private System.Windows.Forms.DataGridViewTextBoxColumn emname;
        private System.Windows.Forms.DataGridViewTextBoxColumn elname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ename;
        private System.Windows.Forms.DataGridViewTextBoxColumn eaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn epn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eage;
        private System.Windows.Forms.DataGridViewTextBoxColumn egender;
        private System.Windows.Forms.DataGridViewTextBoxColumn edob;
        private System.Windows.Forms.DataGridViewTextBoxColumn eemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}