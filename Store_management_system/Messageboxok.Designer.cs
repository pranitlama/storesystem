
namespace Store_management_system
{
    partial class Messageboxok
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
            this.toppanel = new System.Windows.Forms.Panel();
            this.labelmessage = new System.Windows.Forms.Label();
            this.buttonok = new System.Windows.Forms.Button();
            this.labeltitle = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toppanel.Controls.Add(this.labelmessage);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(527, 49);
            this.toppanel.TabIndex = 0;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            this.toppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseUp);
            // 
            // labelmessage
            // 
            this.labelmessage.AutoSize = true;
            this.labelmessage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmessage.ForeColor = System.Drawing.Color.White;
            this.labelmessage.Location = new System.Drawing.Point(18, 14);
            this.labelmessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmessage.Name = "labelmessage";
            this.labelmessage.Size = new System.Drawing.Size(15, 21);
            this.labelmessage.TabIndex = 0;
            this.labelmessage.Text = ".";
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(206, 195);
            this.buttonok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(112, 48);
            this.buttonok.TabIndex = 1;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(150, 100);
            this.labeltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(15, 23);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = ".";
            // 
            // Messageboxok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 288);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Messageboxok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messageboxok";
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label labelmessage;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Label labeltitle;
    }
}