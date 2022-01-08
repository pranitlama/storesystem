
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
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
            this.to = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fromdate = new Store_management_system.RJDatePicker();
            this.todate = new Store_management_system.RJDatePicker();
            this.filter = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.transactionlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionlist
            // 
            this.transactionlist.AllowUserToAddRows = false;
            this.transactionlist.AllowUserToDeleteRows = false;
            this.transactionlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.transactionlist.Location = new System.Drawing.Point(124, 166);
            this.transactionlist.Name = "transactionlist";
            this.transactionlist.ReadOnly = true;
            this.transactionlist.RowHeadersWidth = 31;
            this.transactionlist.RowTemplate.Height = 28;
            this.transactionlist.Size = new System.Drawing.Size(1530, 649);
            this.transactionlist.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // empname
            // 
            this.empname.HeaderText = "EMPLOYEE NAME";
            this.empname.MinimumWidth = 8;
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
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
            this.quantity.FillWeight = 50F;
            this.quantity.HeaderText = "QUANTITY";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // PRICE
            // 
            this.PRICE.FillWeight = 60F;
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 8;
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            // 
            // AMOUNT
            // 
            this.AMOUNT.FillWeight = 60F;
            this.AMOUNT.HeaderText = "AMOUNT";
            this.AMOUNT.MinimumWidth = 8;
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.ReadOnly = true;
            // 
            // tdategv
            // 
            this.tdategv.HeaderText = "TDATE";
            this.tdategv.MinimumWidth = 8;
            this.tdategv.Name = "tdategv";
            this.tdategv.ReadOnly = true;
            // 
            // countrow
            // 
            this.countrow.BackColor = System.Drawing.Color.White;
            this.countrow.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.countrow.Location = new System.Drawing.Point(398, 868);
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
            this.Total.Location = new System.Drawing.Point(231, 872);
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
            this.label18.Location = new System.Drawing.Point(1017, 109);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 28);
            this.label18.TabIndex = 27;
            this.label18.Text = "Search By:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
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
            this.searchselect.Location = new System.Drawing.Point(1180, 103);
            this.searchselect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchselect.Name = "searchselect";
            this.searchselect.Size = new System.Drawing.Size(172, 29);
            this.searchselect.TabIndex = 25;
            this.searchselect.SelectedIndexChanged += new System.EventHandler(this.searchselect_SelectedIndexChanged);
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(1386, 103);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(246, 36);
            this.searchbox.TabIndex = 26;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.Location = new System.Drawing.Point(399, 62);
            this.to.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(52, 30);
            this.to.TabIndex = 27;
            this.to.Text = "TO:";
            this.to.Click += new System.EventHandler(this.label18_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(140, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = " FROM:";
            this.label1.Click += new System.EventHandler(this.label18_Click);
            // 
            // refresh
            // 
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(716, 108);
            this.refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(24, 24);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.refresh.TabIndex = 30;
            this.refresh.TabStop = false;
            this.toolTip1.SetToolTip(this.refresh, "Refresh");
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // fromdate
            // 
            this.fromdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fromdate.BorderSize = 0;
            this.fromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromdate.Location = new System.Drawing.Point(146, 98);
            this.fromdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromdate.MinimumSize = new System.Drawing.Size(4, 35);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(169, 35);
            this.fromdate.SkinColor = System.Drawing.Color.RoyalBlue;
            this.fromdate.TabIndex = 32;
            this.fromdate.TextColor = System.Drawing.Color.White;
            // 
            // todate
            // 
            this.todate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.todate.BorderSize = 0;
            this.todate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.todate.Location = new System.Drawing.Point(405, 98);
            this.todate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.todate.MinimumSize = new System.Drawing.Size(4, 35);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(169, 35);
            this.todate.SkinColor = System.Drawing.Color.RoyalBlue;
            this.todate.TabIndex = 31;
            this.todate.TextColor = System.Drawing.Color.White;
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.White;
            this.filter.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.filter.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.filter.FlatAppearance.BorderSize = 0;
            this.filter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filter.Location = new System.Drawing.Point(585, 97);
            this.filter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filter.Name = "filter";
            this.filter.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.filter.OnHoverButtonColor = System.Drawing.Color.White;
            this.filter.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.filter.Size = new System.Drawing.Size(122, 55);
            this.filter.TabIndex = 1;
            this.filter.Text = "Filter";
            this.filter.TextColor = System.Drawing.Color.White;
            this.filter.UseVisualStyleBackColor = false;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fromdate);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.searchselect);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.countrow);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.transactionlist);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1791, 863);
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionlist;
        private System.Windows.Forms.TextBox countrow;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox searchselect;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC filter;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdategv;
        private RJDatePicker todate;
        private RJDatePicker fromdate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
