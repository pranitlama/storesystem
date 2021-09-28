
namespace Store_management_system
{
    partial class Reports
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
            this.transactionlist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdategv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrow = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.searchselect = new System.Windows.Forms.ComboBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.transactionlist)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionlist
            // 
            this.transactionlist.AllowUserToAddRows = false;
            this.transactionlist.AllowUserToDeleteRows = false;
            this.transactionlist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.transactionlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transactionlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.empname,
            this.NAME,
            this.quantity,
            this.PRICE,
            this.AMOUNT,
            this.tdategv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transactionlist.DefaultCellStyle = dataGridViewCellStyle2;
            this.transactionlist.GridColor = System.Drawing.SystemColors.Info;
            this.transactionlist.Location = new System.Drawing.Point(174, 122);
            this.transactionlist.Name = "transactionlist";
            this.transactionlist.ReadOnly = true;
            this.transactionlist.RowHeadersWidth = 31;
            this.transactionlist.RowTemplate.Height = 28;
            this.transactionlist.Size = new System.Drawing.Size(1200, 734);
            this.transactionlist.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // empname
            // 
            this.empname.HeaderText = "EMPLOYEE NAME";
            this.empname.MinimumWidth = 8;
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            this.empname.Width = 150;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 8;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 150;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "QUANTITY";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 80;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 8;
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 80;
            // 
            // AMOUNT
            // 
            this.AMOUNT.HeaderText = "AMOUNT";
            this.AMOUNT.MinimumWidth = 8;
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.ReadOnly = true;
            this.AMOUNT.Width = 150;
            // 
            // tdategv
            // 
            this.tdategv.HeaderText = "TDATE";
            this.tdategv.MinimumWidth = 8;
            this.tdategv.Name = "tdategv";
            this.tdategv.ReadOnly = true;
            this.tdategv.Width = 80;
            // 
            // countrow
            // 
            this.countrow.BackColor = System.Drawing.Color.White;
            this.countrow.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.countrow.Location = new System.Drawing.Point(451, 864);
            this.countrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countrow.Multiline = true;
            this.countrow.Name = "countrow";
            this.countrow.ReadOnly = true;
            this.countrow.Size = new System.Drawing.Size(168, 32);
            this.countrow.TabIndex = 24;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(285, 869);
            this.Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(128, 23);
            this.Total.TabIndex = 23;
            this.Total.Text = "Total Count:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(710, 67);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 28);
            this.label18.TabIndex = 27;
            this.label18.Text = "Search By:";
            // 
            // searchselect
            // 
            this.searchselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchselect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchselect.FormattingEnabled = true;
            this.searchselect.Items.AddRange(new object[] {
            "ID",
            "NAME",
            "EMPLOYEE NAME"});
            this.searchselect.Location = new System.Drawing.Point(866, 66);
            this.searchselect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchselect.Name = "searchselect";
            this.searchselect.Size = new System.Drawing.Size(186, 29);
            this.searchselect.TabIndex = 25;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(1060, 66);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(298, 36);
            this.searchbox.TabIndex = 26;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.searchselect);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.countrow);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.transactionlist);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1453, 928);
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdategv;
        private System.Windows.Forms.TextBox countrow;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox searchselect;
        private System.Windows.Forms.TextBox searchbox;
    }
}
