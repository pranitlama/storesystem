
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
            this.button1 = new System.Windows.Forms.Button();
            this.see = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.mini = new System.Windows.Forms.Button();
            this.clos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(120, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(74, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Username";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(74, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "password";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(95, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // see
            // 
            this.see.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("see.BackgroundImage")));
            this.see.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.see.FlatAppearance.BorderSize = 0;
            this.see.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.see.Location = new System.Drawing.Point(241, 258);
            this.see.Name = "see";
            this.see.Size = new System.Drawing.Size(33, 20);
            this.see.TabIndex = 4;
            this.see.UseVisualStyleBackColor = true;
            this.see.Click += new System.EventHandler(this.see_Click);
            // 
            // hide
            // 
            this.hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide.BackgroundImage")));
            this.hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Location = new System.Drawing.Point(241, 258);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(33, 20);
            this.hide.TabIndex = 5;
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // mini
            // 
            this.mini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mini.BackgroundImage")));
            this.mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mini.FlatAppearance.BorderSize = 0;
            this.mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mini.Location = new System.Drawing.Point(262, 12);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(34, 26);
            this.mini.TabIndex = 6;
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
            this.clos.Location = new System.Drawing.Point(302, 12);
            this.clos.Name = "clos";
            this.clos.Size = new System.Drawing.Size(34, 26);
            this.clos.TabIndex = 7;
            this.clos.UseVisualStyleBackColor = true;
            this.clos.Click += new System.EventHandler(this.clos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 494);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button see;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button mini;
        private System.Windows.Forms.Button clos;
    }
}

