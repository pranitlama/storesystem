
namespace Store_management_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.see = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.mini = new System.Windows.Forms.Button();
            this.clos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.incorrecterror = new System.Windows.Forms.Label();
            this.entererror = new System.Windows.Forms.Label();
            this.logins = new ePOSOne.btnProduct.Button_WOC();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(914, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(830, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(882, 349);
            this.textBox1.MaxLength = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Username";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(830, 429);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(882, 426);
            this.textBox2.MaxLength = 15;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Password";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // see
            // 
            this.see.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("see.BackgroundImage")));
            this.see.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.see.FlatAppearance.BorderSize = 0;
            this.see.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.see.Location = new System.Drawing.Point(1116, 429);
            this.see.Name = "see";
            this.see.Size = new System.Drawing.Size(33, 20);
            this.see.TabIndex = 0;
            this.see.UseVisualStyleBackColor = true;
            this.see.Click += new System.EventHandler(this.see_Click);
            // 
            // hide
            // 
            this.hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide.BackgroundImage")));
            this.hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Location = new System.Drawing.Point(1115, 429);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(33, 20);
            this.hide.TabIndex = 0;
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // mini
            // 
            this.mini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mini.BackgroundImage")));
            this.mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mini.FlatAppearance.BorderSize = 0;
            this.mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mini.Location = new System.Drawing.Point(1116, 12);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(36, 37);
            this.mini.TabIndex = 4;
            this.mini.UseVisualStyleBackColor = true;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // clos
            // 
            this.clos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clos.BackgroundImage")));
            this.clos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clos.FlatAppearance.BorderSize = 0;
            this.clos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clos.Location = new System.Drawing.Point(1158, 12);
            this.clos.Name = "clos";
            this.clos.Size = new System.Drawing.Size(36, 37);
            this.clos.TabIndex = 5;
            this.clos.UseVisualStyleBackColor = true;
            this.clos.Click += new System.EventHandler(this.clos_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(780, 829);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(874, 380);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 3);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(874, 460);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 3);
            this.panel2.TabIndex = 9;
            // 
            // incorrecterror
            // 
            this.incorrecterror.AutoSize = true;
            this.incorrecterror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrecterror.ForeColor = System.Drawing.Color.DarkRed;
            this.incorrecterror.Location = new System.Drawing.Point(852, 488);
            this.incorrecterror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incorrecterror.Name = "incorrecterror";
            this.incorrecterror.Size = new System.Drawing.Size(304, 20);
            this.incorrecterror.TabIndex = 10;
            this.incorrecterror.Text = "Incorrect Username or Password!!!";
            // 
            // entererror
            // 
            this.entererror.AutoSize = true;
            this.entererror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entererror.ForeColor = System.Drawing.Color.DarkRed;
            this.entererror.Location = new System.Drawing.Point(852, 488);
            this.entererror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entererror.Name = "entererror";
            this.entererror.Size = new System.Drawing.Size(323, 20);
            this.entererror.TabIndex = 10;
            this.entererror.Text = "Enter your Username and Password!!";
            // 
            // logins
            // 
            this.logins.BackColor = System.Drawing.Color.White;
            this.logins.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.logins.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.logins.FlatAppearance.BorderSize = 0;
            this.logins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.logins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.logins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logins.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logins.Location = new System.Drawing.Point(936, 529);
            this.logins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logins.Name = "logins";
            this.logins.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.logins.OnHoverButtonColor = System.Drawing.Color.White;
            this.logins.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.logins.Size = new System.Drawing.Size(141, 55);
            this.logins.TabIndex = 3;
            this.logins.Text = "Login";
            this.logins.TextColor = System.Drawing.Color.White;
            this.logins.UseVisualStyleBackColor = false;
            this.logins.Click += new System.EventHandler(this.logins_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 13;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(926, 94);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 135);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(856, 646);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 15;
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.logins;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 783);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.logins);
            this.Controls.Add(this.entererror);
            this.Controls.Add(this.incorrecterror);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.clos);
            this.Controls.Add(this.mini);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.see);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button see;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button mini;
        private System.Windows.Forms.Button clos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label incorrecterror;
        private System.Windows.Forms.Label entererror;
        private ePOSOne.btnProduct.Button_WOC logins;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
    }
}

