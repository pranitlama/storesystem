﻿
namespace Store_management_system
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.nptxt = new System.Windows.Forms.TextBox();
            this.conptxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cptxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cphide = new System.Windows.Forms.Button();
            this.cpsee = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.matched = new System.Windows.Forms.PictureBox();
            this.unmatched = new System.Windows.Forms.PictureBox();
            this.clear = new ePOSOne.btnProduct.Button_WOC();
            this.confirm = new ePOSOne.btnProduct.Button_WOC();
            this.see = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmatched)).BeginInit();
            this.SuspendLayout();
            // 
            // nptxt
            // 
            this.nptxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nptxt.Location = new System.Drawing.Point(43, 200);
            this.nptxt.Margin = new System.Windows.Forms.Padding(2);
            this.nptxt.Name = "nptxt";
            this.nptxt.Size = new System.Drawing.Size(269, 24);
            this.nptxt.TabIndex = 0;
            this.nptxt.UseSystemPasswordChar = true;
            this.nptxt.TextChanged += new System.EventHandler(this.nptxt_TextChanged);
            this.nptxt.Enter += new System.EventHandler(this.nptxt_Enter);
            this.nptxt.Leave += new System.EventHandler(this.nptxt_Leave);
            // 
            // conptxt
            // 
            this.conptxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conptxt.Location = new System.Drawing.Point(43, 283);
            this.conptxt.Margin = new System.Windows.Forms.Padding(2);
            this.conptxt.Name = "conptxt";
            this.conptxt.Size = new System.Drawing.Size(269, 24);
            this.conptxt.TabIndex = 0;
            this.conptxt.UseSystemPasswordChar = true;
            this.conptxt.TextChanged += new System.EventHandler(this.conptxt_TextChanged);
            this.conptxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.conptxt_KeyDown);
            this.conptxt.Leave += new System.EventHandler(this.conptxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password";
            // 
            // cptxt
            // 
            this.cptxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cptxt.Location = new System.Drawing.Point(43, 123);
            this.cptxt.Margin = new System.Windows.Forms.Padding(2);
            this.cptxt.Name = "cptxt";
            this.cptxt.Size = new System.Drawing.Size(269, 24);
            this.cptxt.TabIndex = 0;
            this.cptxt.UseSystemPasswordChar = true;
            this.cptxt.TextChanged += new System.EventHandler(this.cptxt_TextChanged);
            this.cptxt.Enter += new System.EventHandler(this.cptxt_Enter);
            this.cptxt.Leave += new System.EventHandler(this.cptxt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username";
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(41, 42);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(2);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.ReadOnly = true;
            this.usernametxt.Size = new System.Drawing.Size(269, 24);
            this.usernametxt.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.cphide);
            this.panel1.Controls.Add(this.cpsee);
            this.panel1.Controls.Add(this.hide);
            this.panel1.Controls.Add(this.matched);
            this.panel1.Controls.Add(this.unmatched);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.confirm);
            this.panel1.Controls.Add(this.cptxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.usernametxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.conptxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.see);
            this.panel1.Controls.Add(this.nptxt);
            this.panel1.Location = new System.Drawing.Point(221, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 395);
            this.panel1.TabIndex = 14;
            // 
            // cphide
            // 
            this.cphide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cphide.BackgroundImage")));
            this.cphide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cphide.FlatAppearance.BorderSize = 0;
            this.cphide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cphide.ForeColor = System.Drawing.Color.White;
            this.cphide.Location = new System.Drawing.Point(287, 126);
            this.cphide.Margin = new System.Windows.Forms.Padding(2);
            this.cphide.Name = "cphide";
            this.cphide.Size = new System.Drawing.Size(23, 16);
            this.cphide.TabIndex = 23;
            this.cphide.UseVisualStyleBackColor = true;
            this.cphide.Visible = false;
            this.cphide.Click += new System.EventHandler(this.cphide_Click);
            // 
            // cpsee
            // 
            this.cpsee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpsee.BackgroundImage")));
            this.cpsee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cpsee.FlatAppearance.BorderSize = 0;
            this.cpsee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpsee.ForeColor = System.Drawing.Color.White;
            this.cpsee.Location = new System.Drawing.Point(287, 126);
            this.cpsee.Margin = new System.Windows.Forms.Padding(2);
            this.cpsee.Name = "cpsee";
            this.cpsee.Size = new System.Drawing.Size(23, 16);
            this.cpsee.TabIndex = 24;
            this.cpsee.UseVisualStyleBackColor = true;
            this.cpsee.Visible = false;
            this.cpsee.Click += new System.EventHandler(this.cpsee_Click);
            // 
            // hide
            // 
            this.hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide.BackgroundImage")));
            this.hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.ForeColor = System.Drawing.Color.White;
            this.hide.Location = new System.Drawing.Point(287, 203);
            this.hide.Margin = new System.Windows.Forms.Padding(2);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(23, 16);
            this.hide.TabIndex = 23;
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Visible = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // matched
            // 
            this.matched.Image = ((System.Drawing.Image)(resources.GetObject("matched.Image")));
            this.matched.Location = new System.Drawing.Point(317, 283);
            this.matched.Name = "matched";
            this.matched.Size = new System.Drawing.Size(23, 23);
            this.matched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.matched.TabIndex = 17;
            this.matched.TabStop = false;
            this.matched.Visible = false;
            // 
            // unmatched
            // 
            this.unmatched.Image = ((System.Drawing.Image)(resources.GetObject("unmatched.Image")));
            this.unmatched.Location = new System.Drawing.Point(317, 283);
            this.unmatched.Name = "unmatched";
            this.unmatched.Size = new System.Drawing.Size(23, 23);
            this.unmatched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unmatched.TabIndex = 16;
            this.unmatched.TabStop = false;
            this.unmatched.Visible = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.clear.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.clear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(183, 320);
            this.clear.Name = "clear";
            this.clear.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.clear.OnHoverButtonColor = System.Drawing.Color.White;
            this.clear.OnHoverTextColor = System.Drawing.Color.Black;
            this.clear.Size = new System.Drawing.Size(99, 36);
            this.clear.TabIndex = 13;
            this.clear.Text = "CLEAR";
            this.clear.TextColor = System.Drawing.Color.White;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.confirm.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.confirm.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.confirm.FlatAppearance.BorderSize = 0;
            this.confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.Location = new System.Drawing.Point(63, 320);
            this.confirm.Name = "confirm";
            this.confirm.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.confirm.OnHoverButtonColor = System.Drawing.Color.White;
            this.confirm.OnHoverTextColor = System.Drawing.Color.Black;
            this.confirm.Size = new System.Drawing.Size(99, 36);
            this.confirm.TabIndex = 13;
            this.confirm.Text = "CONFIRM";
            this.confirm.TextColor = System.Drawing.Color.White;
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click_1);
            // 
            // see
            // 
            this.see.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("see.BackgroundImage")));
            this.see.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.see.FlatAppearance.BorderSize = 0;
            this.see.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.see.ForeColor = System.Drawing.Color.White;
            this.see.Location = new System.Drawing.Point(287, 203);
            this.see.Margin = new System.Windows.Forms.Padding(2);
            this.see.Name = "see";
            this.see.Size = new System.Drawing.Size(23, 16);
            this.see.TabIndex = 24;
            this.see.UseVisualStyleBackColor = true;
            this.see.Visible = false;
            this.see.Click += new System.EventHandler(this.see_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangePassword";
            this.Size = new System.Drawing.Size(766, 493);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmatched)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nptxt;
        private System.Windows.Forms.TextBox conptxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cptxt;
        private ePOSOne.btnProduct.Button_WOC confirm;
        private ePOSOne.btnProduct.Button_WOC clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox unmatched;
        private System.Windows.Forms.PictureBox matched;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button see;
        private System.Windows.Forms.Button cphide;
        private System.Windows.Forms.Button cpsee;
    }
}
