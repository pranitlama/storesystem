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
            this.label14 = new System.Windows.Forms.Label();
            this.eclear = new ePOSOne.btnProduct.Button_WOC();
            this.pnerror = new System.Windows.Forms.Label();
            this.emailerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeelist)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // em_fname
            // 
            this.em_fname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_fname.Location = new System.Drawing.Point(196, 65);
            this.em_fname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.em_fname.Multiline = true;
            this.em_fname.Name = "em_fname";
            this.em_fname.Size = new System.Drawing.Size(343, 33);
            this.em_fname.TabIndex = 1;
            // 
            // em_male
            // 
            this.em_male.AutoSize = true;
            this.em_male.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_male.Location = new System.Drawing.Point(186, 218);
            this.em_male.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.em_male.Name = "em_male";
            this.em_male.Size = new System.Drawing.Size(84, 27);
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
            this.em_female.Location = new System.Drawing.Point(322, 218);
            this.em_female.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.em_female.Name = "em_female";
            this.em_female.Size = new System.Drawing.Size(109, 27);
            this.em_female.TabIndex = 8;
            this.em_female.TabStop = true;
            this.em_female.Text = "Female";
            this.em_female.UseVisualStyleBackColor = true;
            this.em_female.CheckedChanged += new System.EventHandler(this.em_female_CheckedChanged);
            // 
            // em_dob
            // 
            this.em_dob.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.em_dob.Location = new System.Drawing.Point(747, 205);
            this.em_dob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.em_dob.Name = "em_dob";
            this.em_dob.Size = new System.Drawing.Size(343, 31);
            this.em_dob.TabIndex = 9;
            this.em_dob.Value = new System.DateTime(2021, 8, 27, 0, 0, 0, 0);
            // 
            // em_mname
            // 
            this.em_mname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_mname.Location = new System.Drawing.Point(747, 65);
            this.em_mname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.em_mname.Multiline = true;
            this.em_mname.Name = "em_mname";
            this.em_mname.Size = new System.Drawing.Size(343, 33);
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
            this.employeelist.Location = new System.Drawing.Point(60, 368);
            this.employeelist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeelist.Name = "employeelist";
            this.employeelist.ReadOnly = true;
            this.employeelist.RowHeadersWidth = 62;
            this.employeelist.Size = new System.Drawing.Size(1593, 463);
            this.employeelist.TabIndex = 10;
            this.employeelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeelist_CellClick);
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.MinimumWidth = 8;
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
            this.efname.MinimumWidth = 8;
            this.efname.Name = "efname";
            this.efname.ReadOnly = true;
            this.efname.Visible = false;
            this.efname.Width = 150;
            // 
            // emname
            // 
            this.emname.HeaderText = "Middle Name";
            this.emname.MinimumWidth = 8;
            this.emname.Name = "emname";
            this.emname.ReadOnly = true;
            this.emname.Visible = false;
            this.emname.Width = 150;
            // 
            // elname
            // 
            this.elname.HeaderText = "Last Name";
            this.elname.MinimumWidth = 8;
            this.elname.Name = "elname";
            this.elname.ReadOnly = true;
            this.elname.Visible = false;
            this.elname.Width = 150;
            // 
            // ename
            // 
            this.ename.HeaderText = "Employee Name";
            this.ename.MinimumWidth = 8;
            this.ename.Name = "ename";
            this.ename.ReadOnly = true;
            this.ename.Width = 150;
            // 
            // eaddress
            // 
            this.eaddress.HeaderText = "Address";
            this.eaddress.MinimumWidth = 8;
            this.eaddress.Name = "eaddress";
            this.eaddress.ReadOnly = true;
            this.eaddress.Width = 150;
            // 
            // epn
            // 
            this.epn.HeaderText = "Phone no";
            this.epn.MinimumWidth = 8;
            this.epn.Name = "epn";
            this.epn.ReadOnly = true;
            this.epn.Width = 150;
            // 
            // eage
            // 
            this.eage.HeaderText = "Age";
            this.eage.MinimumWidth = 8;
            this.eage.Name = "eage";
            this.eage.ReadOnly = true;
            this.eage.Width = 50;
            // 
            // egender
            // 
            this.egender.HeaderText = "Gender";
            this.egender.MinimumWidth = 8;
            this.egender.Name = "egender";
            this.egender.ReadOnly = true;
            this.egender.Width = 150;
            // 
            // edob
            // 
            this.edob.HeaderText = "Date of Birth";
            this.edob.MinimumWidth = 8;
            this.edob.Name = "edob";
            this.edob.ReadOnly = true;
            this.edob.Width = 150;
            // 
            // eemail
            // 
            this.eemail.HeaderText = "Email Address";
            this.eemail.MinimumWidth = 8;
            this.eemail.Name = "eemail";
            this.eemail.ReadOnly = true;
            this.eemail.Width = 200;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 8;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 98;
            // 
            // em_address
            // 
            this.em_address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_address.Location = new System.Drawing.Point(186, 137);
            this.em_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.em_address.Multiline = true;
            this.em_address.Name = "em_address";
            this.em_address.Size = new System.Drawing.Size(343, 33);
            this.em_address.TabIndex = 4;
            // 
            // em_pn
            // 
            this.em_pn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_pn.Location = new System.Drawing.Point(747, 137);
            this.em_pn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.em_pn.Multiline = true;
            this.em_pn.Name = "em_pn";
            this.em_pn.Size = new System.Drawing.Size(343, 33);
            this.em_pn.TabIndex = 5;
            this.em_pn.TextChanged += new System.EventHandler(this.em_pn_TextChanged);
            this.em_pn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.em_pn_KeyPress);
            // 
            // em_age
            // 
            this.em_age.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_age.Location = new System.Drawing.Point(1280, 140);
            this.em_age.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.em_age.Multiline = true;
            this.em_age.Name = "em_age";
            this.em_age.Size = new System.Drawing.Size(343, 33);
            this.em_age.TabIndex = 6;
            this.em_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.em_age_KeyPress);
            // 
            // em_lname
            // 
            this.em_lname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_lname.Location = new System.Drawing.Point(1280, 69);
            this.em_lname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.em_lname.Multiline = true;
            this.em_lname.Name = "em_lname";
            this.em_lname.Size = new System.Drawing.Size(343, 33);
            this.em_lname.TabIndex = 3;
            // 
            // em_email
            // 
            this.em_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.em_email.Location = new System.Drawing.Point(1280, 212);
            this.em_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.em_email.Multiline = true;
            this.em_email.Name = "em_email";
            this.em_email.Size = new System.Drawing.Size(440, 33);
            this.em_email.TabIndex = 10;
            this.em_email.TextChanged += new System.EventHandler(this.em_email_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Middle Name";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(598, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date of Birth";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(598, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phone no";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1142, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Last Name";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1162, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Age";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1162, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 23);
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
            this.eupdate.Location = new System.Drawing.Point(693, 282);
            this.eupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eupdate.Name = "eupdate";
            this.eupdate.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.eupdate.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.eupdate.OnHoverTextColor = System.Drawing.Color.Black;
            this.eupdate.Size = new System.Drawing.Size(148, 55);
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
            this.edelete.Location = new System.Drawing.Point(879, 282);
            this.edelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edelete.Name = "edelete";
            this.edelete.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.edelete.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.edelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.edelete.Size = new System.Drawing.Size(148, 55);
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
            this.eadd.Location = new System.Drawing.Point(486, 282);
            this.eadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eadd.Name = "eadd";
            this.eadd.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.eadd.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.eadd.OnHoverTextColor = System.Drawing.Color.Black;
            this.eadd.Size = new System.Drawing.Size(148, 55);
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
            this.label1.Location = new System.Drawing.Point(177, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 29);
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
            this.label11.Location = new System.Drawing.Point(1250, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 29);
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
            this.label12.Location = new System.Drawing.Point(156, 126);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 29);
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
            this.label13.Location = new System.Drawing.Point(156, 217);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 29);
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
            this.label15.Location = new System.Drawing.Point(710, 126);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 29);
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
            this.label16.Location = new System.Drawing.Point(720, 185);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 29);
            this.label16.TabIndex = 14;
            this.label16.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(1222, 137);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 29);
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
            this.eclear.Location = new System.Drawing.Point(1078, 282);
            this.eclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eclear.Name = "eclear";
            this.eclear.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.eclear.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.eclear.OnHoverTextColor = System.Drawing.Color.Black;
            this.eclear.Size = new System.Drawing.Size(148, 55);
            this.eclear.TabIndex = 13;
            this.eclear.Text = "Clear";
            this.eclear.TextColor = System.Drawing.Color.White;
            this.eclear.UseVisualStyleBackColor = false;
            this.eclear.Click += new System.EventHandler(this.eclear_Click);
            // 
            // pnerror
            // 
            this.pnerror.AutoSize = true;
            this.pnerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnerror.ForeColor = System.Drawing.Color.Red;
            this.pnerror.Location = new System.Drawing.Point(750, 177);
            this.pnerror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnerror.Name = "pnerror";
            this.pnerror.Size = new System.Drawing.Size(244, 22);
            this.pnerror.TabIndex = 15;
            this.pnerror.Text = "Phone number Already exists";
            this.pnerror.Visible = false;
            // 
            // emailerror
            // 
            this.emailerror.AutoSize = true;
            this.emailerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailerror.ForeColor = System.Drawing.Color.Red;
            this.emailerror.Location = new System.Drawing.Point(1275, 252);
            this.emailerror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailerror.Name = "emailerror";
            this.emailerror.Size = new System.Drawing.Size(242, 22);
            this.emailerror.TabIndex = 15;
            this.emailerror.Text = "Email Address Already exists";
            this.emailerror.Visible = false;
            this.emailerror.Click += new System.EventHandler(this.label18_Click);
            // 
            // Required5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.emailerror);
            this.Controls.Add(this.pnerror);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Required5";
            this.Size = new System.Drawing.Size(1791, 923);
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
        private System.Windows.Forms.Label pnerror;
        private System.Windows.Forms.Label emailerror;
    }
}
