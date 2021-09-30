
namespace Store_management_system
{
    partial class Signupforms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signupforms));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idno = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passw = new System.Windows.Forms.TextBox();
            this.cpassw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userlist = new System.Windows.Forms.DataGridView();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolechoose = new System.Windows.Forms.ComboBox();
            this.iderror = new System.Windows.Forms.Label();
            this.usernameerror = new System.Windows.Forms.Label();
            this.unmatched = new System.Windows.Forms.PictureBox();
            this.idtaken = new System.Windows.Forms.Label();
            this.matched = new System.Windows.Forms.PictureBox();
            this.authorizederror = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adminoremployee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.Button();
            this.see = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.countrow = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.searchselect = new System.Windows.Forms.ComboBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showpassw = new CustomControls.RJControls.RJToggleButton();
            this.delete = new ePOSOne.btnProduct.Button_WOC();
            this.Reset = new ePOSOne.btnProduct.Button_WOC();
            this.signupbtn = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.userlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmatched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matched)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(68, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID No.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // idno
            // 
            this.idno.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.idno.Location = new System.Drawing.Point(212, 174);
            this.idno.Multiline = true;
            this.idno.Name = "idno";
            this.idno.Size = new System.Drawing.Size(178, 23);
            this.idno.TabIndex = 2;
            this.idno.TextChanged += new System.EventHandler(this.idno_TextChanged);
            this.idno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idno_KeyPress);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.username.Location = new System.Drawing.Point(211, 241);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(179, 23);
            this.username.TabIndex = 3;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.Location = new System.Drawing.Point(63, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(63, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.Location = new System.Drawing.Point(63, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Confirm Password";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // passw
            // 
            this.passw.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.passw.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passw.Location = new System.Drawing.Point(210, 306);
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(179, 22);
            this.passw.TabIndex = 4;
            this.passw.UseSystemPasswordChar = true;
            this.passw.TextChanged += new System.EventHandler(this.passw_TextChanged);
            this.passw.Enter += new System.EventHandler(this.passw_Enter);
            this.passw.Leave += new System.EventHandler(this.passw_Leave);
            // 
            // cpassw
            // 
            this.cpassw.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cpassw.Location = new System.Drawing.Point(211, 375);
            this.cpassw.Name = "cpassw";
            this.cpassw.Size = new System.Drawing.Size(178, 22);
            this.cpassw.TabIndex = 5;
            this.cpassw.TextChanged += new System.EventHandler(this.cpassw_TextChanged);
            this.cpassw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cpassw_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sign Up Form";
            // 
            // userlist
            // 
            this.userlist.AllowUserToAddRows = false;
            this.userlist.AllowUserToDeleteRows = false;
            this.userlist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.userlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.userlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
            this.userrole,
            this.empid,
            this.usrname,
            this.Password});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userlist.DefaultCellStyle = dataGridViewCellStyle2;
            this.userlist.GridColor = System.Drawing.Color.White;
            this.userlist.Location = new System.Drawing.Point(435, 90);
            this.userlist.Name = "userlist";
            this.userlist.ReadOnly = true;
            this.userlist.RowHeadersWidth = 62;
            this.userlist.Size = new System.Drawing.Size(703, 382);
            this.userlist.TabIndex = 7;
            this.userlist.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.userlist_CellFormatting);
            // 
            // sn
            // 
            this.sn.HeaderText = "SN";
            this.sn.MinimumWidth = 8;
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            this.sn.Width = 80;
            // 
            // userrole
            // 
            this.userrole.HeaderText = "User Role";
            this.userrole.MinimumWidth = 8;
            this.userrole.Name = "userrole";
            this.userrole.ReadOnly = true;
            this.userrole.Width = 150;
            // 
            // empid
            // 
            this.empid.HeaderText = "Employee ID";
            this.empid.MinimumWidth = 8;
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            this.empid.Width = 130;
            // 
            // usrname
            // 
            this.usrname.HeaderText = "Username";
            this.usrname.MinimumWidth = 8;
            this.usrname.Name = "usrname";
            this.usrname.ReadOnly = true;
            this.usrname.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 152;
            // 
            // rolechoose
            // 
            this.rolechoose.BackColor = System.Drawing.Color.White;
            this.rolechoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolechoose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rolechoose.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolechoose.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rolechoose.FormattingEnabled = true;
            this.rolechoose.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.rolechoose.Location = new System.Drawing.Point(211, 114);
            this.rolechoose.Name = "rolechoose";
            this.rolechoose.Size = new System.Drawing.Size(144, 25);
            this.rolechoose.TabIndex = 1;
            this.rolechoose.SelectedIndexChanged += new System.EventHandler(this.rolechoose_SelectedIndexChanged);
            // 
            // iderror
            // 
            this.iderror.AutoSize = true;
            this.iderror.ForeColor = System.Drawing.Color.Red;
            this.iderror.Location = new System.Drawing.Point(209, 204);
            this.iderror.Name = "iderror";
            this.iderror.Size = new System.Drawing.Size(90, 13);
            this.iderror.TabIndex = 14;
            this.iderror.Text = "Invalid ID number";
            this.iderror.Visible = false;
            // 
            // usernameerror
            // 
            this.usernameerror.AutoSize = true;
            this.usernameerror.ForeColor = System.Drawing.Color.Red;
            this.usernameerror.Location = new System.Drawing.Point(209, 267);
            this.usernameerror.Name = "usernameerror";
            this.usernameerror.Size = new System.Drawing.Size(127, 13);
            this.usernameerror.TabIndex = 14;
            this.usernameerror.Text = "Username Already Taken";
            this.usernameerror.Visible = false;
            // 
            // unmatched
            // 
            this.unmatched.Image = ((System.Drawing.Image)(resources.GetObject("unmatched.Image")));
            this.unmatched.Location = new System.Drawing.Point(395, 375);
            this.unmatched.Name = "unmatched";
            this.unmatched.Size = new System.Drawing.Size(23, 23);
            this.unmatched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unmatched.TabIndex = 15;
            this.unmatched.TabStop = false;
            this.unmatched.Visible = false;
            this.unmatched.Click += new System.EventHandler(this.unmatched_Click);
            // 
            // idtaken
            // 
            this.idtaken.AutoSize = true;
            this.idtaken.ForeColor = System.Drawing.Color.Red;
            this.idtaken.Location = new System.Drawing.Point(209, 205);
            this.idtaken.Name = "idtaken";
            this.idtaken.Size = new System.Drawing.Size(90, 13);
            this.idtaken.TabIndex = 14;
            this.idtaken.Text = "ID Already Taken";
            this.idtaken.Visible = false;
            this.idtaken.Click += new System.EventHandler(this.idtaken_Click);
            // 
            // matched
            // 
            this.matched.Image = ((System.Drawing.Image)(resources.GetObject("matched.Image")));
            this.matched.Location = new System.Drawing.Point(395, 375);
            this.matched.Name = "matched";
            this.matched.Size = new System.Drawing.Size(23, 23);
            this.matched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.matched.TabIndex = 15;
            this.matched.TabStop = false;
            this.matched.Visible = false;
            // 
            // authorizederror
            // 
            this.authorizederror.AutoSize = true;
            this.authorizederror.ForeColor = System.Drawing.Color.Red;
            this.authorizederror.Location = new System.Drawing.Point(209, 267);
            this.authorizederror.Name = "authorizederror";
            this.authorizederror.Size = new System.Drawing.Size(190, 13);
            this.authorizederror.TabIndex = 14;
            this.authorizederror.Text = "Username Already Authorized to Admin";
            this.authorizederror.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(696, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Show Password";
            // 
            // adminoremployee
            // 
            this.adminoremployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adminoremployee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminoremployee.FormattingEnabled = true;
            this.adminoremployee.Items.AddRange(new object[] {
            "Admin",
            "Employee",
            "Both"});
            this.adminoremployee.Location = new System.Drawing.Point(493, 60);
            this.adminoremployee.Name = "adminoremployee";
            this.adminoremployee.Size = new System.Drawing.Size(127, 25);
            this.adminoremployee.TabIndex = 19;
            this.adminoremployee.SelectedIndexChanged += new System.EventHandler(this.adminoremployee_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Show:";
            // 
            // hide
            // 
            this.hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide.BackgroundImage")));
            this.hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.ForeColor = System.Drawing.Color.White;
            this.hide.Location = new System.Drawing.Point(365, 311);
            this.hide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(22, 13);
            this.hide.TabIndex = 22;
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Visible = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // see
            // 
            this.see.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("see.BackgroundImage")));
            this.see.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.see.FlatAppearance.BorderSize = 0;
            this.see.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.see.ForeColor = System.Drawing.Color.White;
            this.see.Location = new System.Drawing.Point(365, 309);
            this.see.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.see.Name = "see";
            this.see.Size = new System.Drawing.Size(22, 17);
            this.see.TabIndex = 21;
            this.see.UseVisualStyleBackColor = true;
            this.see.Visible = false;
            this.see.Click += new System.EventHandler(this.see_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(484, 493);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(88, 17);
            this.Total.TabIndex = 24;
            this.Total.Text = "Total Count:";
            // 
            // countrow
            // 
            this.countrow.BackColor = System.Drawing.Color.White;
            this.countrow.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.countrow.Location = new System.Drawing.Point(590, 490);
            this.countrow.Multiline = true;
            this.countrow.Name = "countrow";
            this.countrow.ReadOnly = true;
            this.countrow.Size = new System.Drawing.Size(113, 22);
            this.countrow.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(819, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 19);
            this.label18.TabIndex = 30;
            this.label18.Text = "Search By:";
            // 
            // searchselect
            // 
            this.searchselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchselect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchselect.FormattingEnabled = true;
            this.searchselect.Items.AddRange(new object[] {
            "EID",
            "USER NAME"});
            this.searchselect.Location = new System.Drawing.Point(913, 59);
            this.searchselect.Name = "searchselect";
            this.searchselect.Size = new System.Drawing.Size(99, 25);
            this.searchselect.TabIndex = 28;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(0, 1);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(115, 25);
            this.searchbox.TabIndex = 29;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Location = new System.Drawing.Point(1023, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 26);
            this.panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 20);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // showpassw
            // 
            this.showpassw.AutoSize = true;
            this.showpassw.Location = new System.Drawing.Point(635, 57);
            this.showpassw.MinimumSize = new System.Drawing.Size(45, 22);
            this.showpassw.Name = "showpassw";
            this.showpassw.OffBackColor = System.Drawing.Color.DarkGray;
            this.showpassw.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.showpassw.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.showpassw.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.showpassw.Size = new System.Drawing.Size(45, 22);
            this.showpassw.TabIndex = 17;
            this.showpassw.UseVisualStyleBackColor = true;
            this.showpassw.CheckedChanged += new System.EventHandler(this.showpassw_CheckedChanged);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.delete.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.delete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(992, 478);
            this.delete.Name = "delete";
            this.delete.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.delete.OnHoverButtonColor = System.Drawing.Color.White;
            this.delete.OnHoverTextColor = System.Drawing.Color.Black;
            this.delete.Size = new System.Drawing.Size(99, 36);
            this.delete.TabIndex = 12;
            this.delete.Text = "Delete";
            this.delete.TextColor = System.Drawing.Color.White;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Reset.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Reset.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(256, 445);
            this.Reset.Name = "Reset";
            this.Reset.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.Reset.OnHoverButtonColor = System.Drawing.Color.White;
            this.Reset.OnHoverTextColor = System.Drawing.Color.Black;
            this.Reset.Size = new System.Drawing.Size(99, 36);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "Reset";
            this.Reset.TextColor = System.Drawing.Color.White;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.signupbtn.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.signupbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.signupbtn.FlatAppearance.BorderSize = 0;
            this.signupbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.signupbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.ForeColor = System.Drawing.Color.White;
            this.signupbtn.Location = new System.Drawing.Point(141, 445);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.signupbtn.OnHoverButtonColor = System.Drawing.Color.White;
            this.signupbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.signupbtn.Size = new System.Drawing.Size(99, 36);
            this.signupbtn.TabIndex = 12;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.TextColor = System.Drawing.Color.White;
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // Signupforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.searchselect);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.countrow);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.see);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adminoremployee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showpassw);
            this.Controls.Add(this.authorizederror);
            this.Controls.Add(this.usernameerror);
            this.Controls.Add(this.idtaken);
            this.Controls.Add(this.iderror);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.rolechoose);
            this.Controls.Add(this.userlist);
            this.Controls.Add(this.cpassw);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.username);
            this.Controls.Add(this.idno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matched);
            this.Controls.Add(this.unmatched);
            this.Controls.Add(this.panel1);
            this.Name = "Signupforms";
            this.Size = new System.Drawing.Size(1194, 561);
            this.Load += new System.EventHandler(this.Signupforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmatched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matched)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idno;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.TextBox cpassw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView userlist;
        private System.Windows.Forms.ComboBox rolechoose;
        private ePOSOne.btnProduct.Button_WOC signupbtn;
        private System.Windows.Forms.Label iderror;
        private System.Windows.Forms.Label usernameerror;
        private System.Windows.Forms.PictureBox unmatched;
        private System.Windows.Forms.Label idtaken;
        private ePOSOne.btnProduct.Button_WOC Reset;
        private System.Windows.Forms.PictureBox matched;
        private ePOSOne.btnProduct.Button_WOC delete;
        private System.Windows.Forms.Label authorizederror;
        private CustomControls.RJControls.RJToggleButton showpassw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.ComboBox adminoremployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button see;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox countrow;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox searchselect;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
