
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.rolechoose = new System.Windows.Forms.ComboBox();
            this.iderror = new System.Windows.Forms.Label();
            this.usernameerror = new System.Windows.Forms.Label();
            this.unmatched = new System.Windows.Forms.PictureBox();
            this.idtaken = new System.Windows.Forms.Label();
            this.Reset = new ePOSOne.btnProduct.Button_WOC();
            this.signupbtn = new ePOSOne.btnProduct.Button_WOC();
            this.matched = new System.Windows.Forms.PictureBox();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmatched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matched)).BeginInit();
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
            this.passw.Location = new System.Drawing.Point(211, 308);
            this.passw.Name = "passw";
            this.passw.PasswordChar = '*';
            this.passw.Size = new System.Drawing.Size(179, 22);
            this.passw.TabIndex = 4;
            this.passw.UseSystemPasswordChar = true;
            this.passw.TextChanged += new System.EventHandler(this.passw_TextChanged);
            // 
            // cpassw
            // 
            this.cpassw.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cpassw.Location = new System.Drawing.Point(211, 375);
            this.cpassw.Name = "cpassw";
            this.cpassw.Size = new System.Drawing.Size(178, 22);
            this.cpassw.TabIndex = 5;
            this.cpassw.TextChanged += new System.EventHandler(this.cpassw_TextChanged);
            this.cpassw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpassw_KeyPress);
            this.cpassw.Leave += new System.EventHandler(this.cpassw_Leave);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
            this.userrole,
            this.empid,
            this.usrname,
            this.Password});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userlist.DefaultCellStyle = dataGridViewCellStyle4;
            this.userlist.Location = new System.Drawing.Point(433, 90);
            this.userlist.Name = "userlist";
            this.userlist.ReadOnly = true;
            this.userlist.Size = new System.Drawing.Size(713, 382);
            this.userlist.TabIndex = 7;
            // 
            // rolechoose
            // 
            this.rolechoose.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.iderror.Location = new System.Drawing.Point(215, 204);
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
            this.usernameerror.Location = new System.Drawing.Point(215, 267);
            this.usernameerror.Name = "usernameerror";
            this.usernameerror.Size = new System.Drawing.Size(120, 13);
            this.usernameerror.TabIndex = 14;
            this.usernameerror.Text = "username already taken";
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
            // 
            // idtaken
            // 
            this.idtaken.AutoSize = true;
            this.idtaken.ForeColor = System.Drawing.Color.Red;
            this.idtaken.Location = new System.Drawing.Point(215, 204);
            this.idtaken.Name = "idtaken";
            this.idtaken.Size = new System.Drawing.Size(90, 13);
            this.idtaken.TabIndex = 14;
            this.idtaken.Text = "ID Already Taken";
            this.idtaken.Visible = false;
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
            this.Reset.Location = new System.Drawing.Point(256, 445);
            this.Reset.Name = "Reset";
            this.Reset.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.Reset.OnHoverButtonColor = System.Drawing.Color.Gold;
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
            this.signupbtn.Location = new System.Drawing.Point(141, 445);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.signupbtn.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.signupbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.signupbtn.Size = new System.Drawing.Size(99, 36);
            this.signupbtn.TabIndex = 12;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.TextColor = System.Drawing.Color.White;
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
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
            // sn
            // 
            this.sn.HeaderText = "SN";
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            // 
            // userrole
            // 
            this.userrole.HeaderText = "UserRole";
            this.userrole.Name = "userrole";
            this.userrole.ReadOnly = true;
            this.userrole.Width = 150;
            // 
            // empid
            // 
            this.empid.HeaderText = "Employee ID";
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            this.empid.Width = 120;
            // 
            // usrname
            // 
            this.usrname.HeaderText = "Username";
            this.usrname.Name = "usrname";
            this.usrname.ReadOnly = true;
            this.usrname.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 150;
            // 
            // Signupforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.unmatched);
            this.Controls.Add(this.usernameerror);
            this.Controls.Add(this.idtaken);
            this.Controls.Add(this.iderror);
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
            this.Name = "Signupforms";
            this.Size = new System.Drawing.Size(1194, 561);
            this.Load += new System.EventHandler(this.Signupforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmatched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matched)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}
