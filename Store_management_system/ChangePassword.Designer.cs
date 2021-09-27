
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
            this.nptxt = new System.Windows.Forms.TextBox();
            this.conptxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cptxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.clear = new ePOSOne.btnProduct.Button_WOC();
            this.confirm = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // nptxt
            // 
            this.nptxt.Location = new System.Drawing.Point(514, 388);
            this.nptxt.Name = "nptxt";
            this.nptxt.Size = new System.Drawing.Size(303, 26);
            this.nptxt.TabIndex = 0;
            // 
            // conptxt
            // 
            this.conptxt.Location = new System.Drawing.Point(514, 477);
            this.conptxt.Name = "conptxt";
            this.conptxt.Size = new System.Drawing.Size(303, 26);
            this.conptxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password";
            // 
            // cptxt
            // 
            this.cptxt.Location = new System.Drawing.Point(514, 308);
            this.cptxt.Name = "cptxt";
            this.cptxt.Size = new System.Drawing.Size(303, 26);
            this.cptxt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(514, 214);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.ReadOnly = true;
            this.usernametxt.Size = new System.Drawing.Size(303, 26);
            this.usernametxt.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Info;
            this.clear.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.clear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(669, 533);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clear.Name = "clear";
            this.clear.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.clear.OnHoverButtonColor = System.Drawing.Color.White;
            this.clear.OnHoverTextColor = System.Drawing.Color.Black;
            this.clear.Size = new System.Drawing.Size(148, 55);
            this.clear.TabIndex = 13;
            this.clear.Text = "CLEAR";
            this.clear.TextColor = System.Drawing.Color.White;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.SystemColors.Info;
            this.confirm.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.confirm.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.confirm.FlatAppearance.BorderSize = 0;
            this.confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.Location = new System.Drawing.Point(514, 533);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirm.Name = "confirm";
            this.confirm.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.confirm.OnHoverButtonColor = System.Drawing.Color.White;
            this.confirm.OnHoverTextColor = System.Drawing.Color.Black;
            this.confirm.Size = new System.Drawing.Size(148, 55);
            this.confirm.TabIndex = 13;
            this.confirm.Text = "CONFIRM";
            this.confirm.TextColor = System.Drawing.Color.White;
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click_1);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clear);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conptxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.cptxt);
            this.Controls.Add(this.nptxt);
            this.Name = "ChangePassword";
            this.Size = new System.Drawing.Size(1149, 707);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
