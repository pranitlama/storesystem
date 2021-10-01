
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stocklist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchitem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.stocklist)).BeginInit();
            this.SuspendLayout();
            // 
            // stocklist
            // 
            this.stocklist.AllowUserToAddRows = false;
            this.stocklist.AllowUserToDeleteRows = false;
            this.stocklist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.stocklist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stocklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stocklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.icategory,
            this.bname,
            this.NAME,
            this.quantity,
            this.PRICE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stocklist.DefaultCellStyle = dataGridViewCellStyle2;
            this.stocklist.GridColor = System.Drawing.SystemColors.Info;
            this.stocklist.Location = new System.Drawing.Point(105, 94);
            this.stocklist.Name = "stocklist";
            this.stocklist.ReadOnly = true;
            this.stocklist.RowHeadersWidth = 31;
            this.stocklist.RowTemplate.Height = 28;
            this.stocklist.Size = new System.Drawing.Size(1077, 734);
            this.stocklist.TabIndex = 8;
            this.stocklist.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.stocklist_CellFormatting);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // icategory
            // 
            this.icategory.HeaderText = "CATEGORY";
            this.icategory.MinimumWidth = 8;
            this.icategory.Name = "icategory";
            this.icategory.ReadOnly = true;
            this.icategory.Width = 150;
            // 
            // bname
            // 
            this.bname.HeaderText = "BRAND NAME";
            this.bname.MinimumWidth = 8;
            this.bname.Name = "bname";
            this.bname.ReadOnly = true;
            this.bname.Width = 150;
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
            this.searchitem.Location = new System.Drawing.Point(762, 36);
            this.searchitem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchitem.Name = "searchitem";
            this.searchitem.Size = new System.Drawing.Size(140, 29);
            this.searchitem.TabIndex = 25;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchitem);
            this.Controls.Add(this.stocklist);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(1410, 746);
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stocklist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stocklist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn icategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.ComboBox searchitem;
    }
}
