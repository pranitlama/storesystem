
namespace Store_management_system
{
    partial class Stock
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.stocklist = new System.Windows.Forms.DataGridView();
            this.searchitem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stockalert = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.countrow = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stocklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stocklist
            // 
            this.stocklist.AllowUserToAddRows = false;
            this.stocklist.AllowUserToDeleteRows = false;
            this.stocklist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stocklist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.stocklist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stocklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.stocklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.icategory,
            this.bname,
            this.NAME,
            this.quantity,
            this.PRICE});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stocklist.DefaultCellStyle = dataGridViewCellStyle6;
            this.stocklist.GridColor = System.Drawing.SystemColors.Info;
            this.stocklist.Location = new System.Drawing.Point(70, 61);
            this.stocklist.Margin = new System.Windows.Forms.Padding(2);
            this.stocklist.Name = "stocklist";
            this.stocklist.ReadOnly = true;
            this.stocklist.RowHeadersWidth = 31;
            this.stocklist.RowTemplate.Height = 28;
            this.stocklist.Size = new System.Drawing.Size(898, 479);
            this.stocklist.TabIndex = 8;
            this.stocklist.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.stocklist_CellFormatting);
            // 
            // searchitem
            // 
            this.searchitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchitem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchitem.FormattingEnabled = true;
            this.searchitem.Items.AddRange(new object[] {
            "LOW STOCK",
            "OUT OF STOCK",
            "STOCK",
            "ALL"});
            this.searchitem.Location = new System.Drawing.Point(220, 23);
            this.searchitem.Name = "searchitem";
            this.searchitem.Size = new System.Drawing.Size(116, 25);
            this.searchitem.TabIndex = 25;
            this.searchitem.SelectedIndexChanged += new System.EventHandler(this.searchitem_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 23);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Stock Filter:";
            // 
            // stockalert
            // 
            this.stockalert.AutoSize = true;
            this.stockalert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockalert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stockalert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockalert.ForeColor = System.Drawing.Color.Red;
            this.stockalert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockalert.Location = new System.Drawing.Point(781, 23);
            this.stockalert.Name = "stockalert";
            this.stockalert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stockalert.Size = new System.Drawing.Size(154, 19);
            this.stockalert.TabIndex = 26;
            this.stockalert.Text = "Out of Stock Alert !!!";
            this.stockalert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip2.SetToolTip(this.stockalert, "Show out of stock items");
            this.stockalert.Visible = false;
            this.stockalert.Click += new System.EventHandler(this.stockalert_Click);
            // 
            // refresh
            // 
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(342, 23);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(24, 24);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.refresh.TabIndex = 31;
            this.refresh.TabStop = false;
            this.toolTip1.SetToolTip(this.refresh, "Refresh");
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // countrow
            // 
            this.countrow.BackColor = System.Drawing.Color.White;
            this.countrow.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.countrow.Location = new System.Drawing.Point(192, 560);
            this.countrow.Multiline = true;
            this.countrow.Name = "countrow";
            this.countrow.ReadOnly = true;
            this.countrow.Size = new System.Drawing.Size(113, 22);
            this.countrow.TabIndex = 33;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(81, 563);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(88, 17);
            this.Total.TabIndex = 32;
            this.Total.Text = "Total Count:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(758, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ID
            // 
            this.ID.FillWeight = 60F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // icategory
            // 
            this.icategory.HeaderText = "CATEGORY";
            this.icategory.MinimumWidth = 8;
            this.icategory.Name = "icategory";
            this.icategory.ReadOnly = true;
            // 
            // bname
            // 
            this.bname.HeaderText = "BRAND NAME";
            this.bname.MinimumWidth = 8;
            this.bname.Name = "bname";
            this.bname.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 8;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 80F;
            this.quantity.HeaderText = "QUANTITY";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 8;
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.countrow);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.stockalert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchitem);
            this.Controls.Add(this.stocklist);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(989, 607);
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stocklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stocklist;
        private System.Windows.Forms.ComboBox searchitem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label stockalert;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox countrow;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn icategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
    }
}
