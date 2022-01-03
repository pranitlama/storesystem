
namespace Store_management_system
{
    partial class print
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printdis = new System.Windows.Forms.DataGridView();
            this.printdisplay = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printdis)).BeginInit();
            this.printdisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // printdis
            // 
            this.printdis.AllowUserToAddRows = false;
            this.printdis.AllowUserToDeleteRows = false;
            this.printdis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.printdis.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.printdis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.printdis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.printdis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printdis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tID,
            this.tname,
            this.tquantity,
            this.tprice,
            this.tamt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.printdis.DefaultCellStyle = dataGridViewCellStyle2;
            this.printdis.GridColor = System.Drawing.SystemColors.Info;
            this.printdis.Location = new System.Drawing.Point(28, 100);
            this.printdis.Name = "printdis";
            this.printdis.ReadOnly = true;
            this.printdis.RowHeadersVisible = false;
            this.printdis.RowHeadersWidth = 62;
            this.printdis.RowTemplate.Height = 28;
            this.printdis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.printdis.Size = new System.Drawing.Size(796, 573);
            this.printdis.TabIndex = 1;
            // 
            // printdisplay
            // 
            this.printdisplay.Controls.Add(this.label9);
            this.printdisplay.Controls.Add(this.label8);
            this.printdisplay.Controls.Add(this.label7);
            this.printdisplay.Controls.Add(this.label6);
            this.printdisplay.Controls.Add(this.label5);
            this.printdisplay.Controls.Add(this.label4);
            this.printdisplay.Controls.Add(this.label3);
            this.printdisplay.Controls.Add(this.printdis);
            this.printdisplay.Controls.Add(this.label1);
            this.printdisplay.Controls.Add(this.label2);
            this.printdisplay.Location = new System.Drawing.Point(40, 12);
            this.printdisplay.Name = "printdisplay";
            this.printdisplay.Size = new System.Drawing.Size(925, 817);
            this.printdisplay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAMP STORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "KAMALPOKHARI,KATHMANDU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "01-444444";
            // 
            // tID
            // 
            this.tID.FillWeight = 50F;
            this.tID.HeaderText = "ID";
            this.tID.MinimumWidth = 8;
            this.tID.Name = "tID";
            this.tID.ReadOnly = true;
            // 
            // tname
            // 
            this.tname.FillWeight = 120F;
            this.tname.HeaderText = "NAME";
            this.tname.MinimumWidth = 8;
            this.tname.Name = "tname";
            this.tname.ReadOnly = true;
            // 
            // tquantity
            // 
            this.tquantity.FillWeight = 60F;
            this.tquantity.HeaderText = "QUANTITY";
            this.tquantity.MinimumWidth = 8;
            this.tquantity.Name = "tquantity";
            this.tquantity.ReadOnly = true;
            // 
            // tprice
            // 
            this.tprice.HeaderText = "PRICE";
            this.tprice.MinimumWidth = 8;
            this.tprice.Name = "tprice";
            this.tprice.ReadOnly = true;
            // 
            // tamt
            // 
            this.tamt.HeaderText = "AMOUNT";
            this.tamt.MinimumWidth = 8;
            this.tamt.Name = "tamt";
            this.tamt.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 704);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "AMOUNT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(647, 735);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "DISCOUNT :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 768);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "GRAND TOTAL :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(756, 704);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(756, 735);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(756, 767);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "0";
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 841);
            this.Controls.Add(this.printdisplay);
            this.Name = "print";
            this.Text = "print";
            ((System.ComponentModel.ISupportInitialize)(this.printdis)).EndInit();
            this.printdisplay.ResumeLayout(false);
            this.printdisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView printdis;
        private System.Windows.Forms.Panel printdisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}