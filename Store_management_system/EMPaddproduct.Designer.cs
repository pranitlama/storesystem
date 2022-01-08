
namespace Store_management_system
{
    partial class EMPaddproduct
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
            this.itemcategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itembn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mfddate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.itemname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemquantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.itemprice = new System.Windows.Forms.TextBox();
            this.itemlist = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRANDNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFDDATEgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXPDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTION = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.itemexpdate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.searchitem = new System.Windows.Forms.ComboBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.idtaken = new System.Windows.Forms.Label();
            this.itemclear = new ePOSOne.btnProduct.Button_WOC();
            this.itemdelete = new ePOSOne.btnProduct.Button_WOC();
            this.itemupdate = new ePOSOne.btnProduct.Button_WOC();
            this.itemadd = new ePOSOne.btnProduct.Button_WOC();
            this.countrow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemlist)).BeginInit();
            this.SuspendLayout();
            // 
            // itemcategory
            // 
            this.itemcategory.BackColor = System.Drawing.SystemColors.HighlightText;
            this.itemcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemcategory.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemcategory.FormattingEnabled = true;
            this.itemcategory.Items.AddRange(new object[] {
            "BAKERY",
            "BEVERAGES",
            "CANNED FOOD",
            "DAIRY",
            "FRUITS",
            "MEAT",
            "PERSONAL CARE",
            "SNACKS",
            "OTHER ITEM"});
            this.itemcategory.Location = new System.Drawing.Point(176, 38);
            this.itemcategory.Name = "itemcategory";
            this.itemcategory.Size = new System.Drawing.Size(182, 29);
            this.itemcategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "BRAND NAME";
            // 
            // itemid
            // 
            this.itemid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemid.Location = new System.Drawing.Point(176, 109);
            this.itemid.Name = "itemid";
            this.itemid.Size = new System.Drawing.Size(182, 31);
            this.itemid.TabIndex = 1;
            this.itemid.TextChanged += new System.EventHandler(this.itemid_TextChanged);
            this.itemid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemid_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(124, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // itembn
            // 
            this.itembn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itembn.Location = new System.Drawing.Point(176, 175);
            this.itembn.Name = "itembn";
            this.itembn.Size = new System.Drawing.Size(182, 31);
            this.itembn.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(446, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "EXPIRE DATE";
            // 
            // mfddate
            // 
            this.mfddate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mfddate.Location = new System.Drawing.Point(602, 109);
            this.mfddate.Name = "mfddate";
            this.mfddate.Size = new System.Drawing.Size(180, 27);
            this.mfddate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(490, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = " NAME";
            // 
            // itemname
            // 
            this.itemname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemname.Location = new System.Drawing.Point(602, 49);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(180, 31);
            this.itemname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(900, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "QUANTITY";
            // 
            // itemquantity
            // 
            this.itemquantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemquantity.Location = new System.Drawing.Point(1035, 48);
            this.itemquantity.Name = "itemquantity";
            this.itemquantity.Size = new System.Drawing.Size(180, 31);
            this.itemquantity.TabIndex = 6;
            this.itemquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemquantity_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(936, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "PRICE";
            // 
            // itemprice
            // 
            this.itemprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemprice.Location = new System.Drawing.Point(1035, 112);
            this.itemprice.Name = "itemprice";
            this.itemprice.Size = new System.Drawing.Size(180, 31);
            this.itemprice.TabIndex = 7;
            this.itemprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemprice_KeyPress);
            // 
            // itemlist
            // 
            this.itemlist.AllowUserToAddRows = false;
            this.itemlist.AllowUserToDeleteRows = false;
            this.itemlist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.ID,
            this.Categorygv,
            this.BRANDNAME,
            this.NAME,
            this.MFDDATEgv,
            this.EXPDATE,
            this.quantity,
            this.PRICE,
            this.ACTION});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemlist.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemlist.GridColor = System.Drawing.SystemColors.Info;
            this.itemlist.Location = new System.Drawing.Point(24, 309);
            this.itemlist.Name = "itemlist";
            this.itemlist.ReadOnly = true;
            this.itemlist.RowHeadersWidth = 31;
            this.itemlist.RowTemplate.Height = 28;
            this.itemlist.Size = new System.Drawing.Size(1368, 500);
            this.itemlist.TabIndex = 12;
            this.itemlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemlist_CellClick);
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.MinimumWidth = 8;
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 80;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Categorygv
            // 
            this.Categorygv.HeaderText = "CATEGORY";
            this.Categorygv.MinimumWidth = 8;
            this.Categorygv.Name = "Categorygv";
            this.Categorygv.ReadOnly = true;
            this.Categorygv.Width = 150;
            // 
            // BRANDNAME
            // 
            this.BRANDNAME.HeaderText = "BRANDNAME";
            this.BRANDNAME.MinimumWidth = 8;
            this.BRANDNAME.Name = "BRANDNAME";
            this.BRANDNAME.ReadOnly = true;
            this.BRANDNAME.Visible = false;
            this.BRANDNAME.Width = 150;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 8;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 150;
            // 
            // MFDDATEgv
            // 
            this.MFDDATEgv.HeaderText = "MFDDATE";
            this.MFDDATEgv.MinimumWidth = 8;
            this.MFDDATEgv.Name = "MFDDATEgv";
            this.MFDDATEgv.ReadOnly = true;
            this.MFDDATEgv.Width = 80;
            // 
            // EXPDATE
            // 
            this.EXPDATE.HeaderText = "EXP DATE";
            this.EXPDATE.MinimumWidth = 8;
            this.EXPDATE.Name = "EXPDATE";
            this.EXPDATE.ReadOnly = true;
            this.EXPDATE.Width = 80;
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
            // ACTION
            // 
            this.ACTION.HeaderText = "ACTION";
            this.ACTION.MinimumWidth = 8;
            this.ACTION.Name = "ACTION";
            this.ACTION.ReadOnly = true;
            this.ACTION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACTION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ACTION.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(464, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "MFD DATE";
            // 
            // itemexpdate
            // 
            this.itemexpdate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemexpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.itemexpdate.Location = new System.Drawing.Point(602, 178);
            this.itemexpdate.Name = "itemexpdate";
            this.itemexpdate.Size = new System.Drawing.Size(180, 27);
            this.itemexpdate.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(874, 183);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "SEARCH BY:";
            // 
            // searchitem
            // 
            this.searchitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchitem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchitem.FormattingEnabled = true;
            this.searchitem.Items.AddRange(new object[] {
            "ID",
            "NAME",
            "CATEGORY"});
            this.searchitem.Location = new System.Drawing.Point(1035, 178);
            this.searchitem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchitem.Name = "searchitem";
            this.searchitem.Size = new System.Drawing.Size(140, 29);
            this.searchitem.TabIndex = 21;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchbox.Location = new System.Drawing.Point(1184, 178);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(206, 35);
            this.searchbox.TabIndex = 22;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // idtaken
            // 
            this.idtaken.AutoSize = true;
            this.idtaken.ForeColor = System.Drawing.Color.Red;
            this.idtaken.Location = new System.Drawing.Point(174, 148);
            this.idtaken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idtaken.Name = "idtaken";
            this.idtaken.Size = new System.Drawing.Size(125, 20);
            this.idtaken.TabIndex = 25;
            this.idtaken.Text = "ID already taken";
            this.idtaken.Visible = false;
            // 
            // itemclear
            // 
            this.itemclear.BackColor = System.Drawing.Color.White;
            this.itemclear.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.itemclear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemclear.FlatAppearance.BorderSize = 0;
            this.itemclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.itemclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.itemclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemclear.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.itemclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemclear.Location = new System.Drawing.Point(714, 246);
            this.itemclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemclear.Name = "itemclear";
            this.itemclear.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.itemclear.OnHoverButtonColor = System.Drawing.Color.White;
            this.itemclear.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemclear.Size = new System.Drawing.Size(141, 55);
            this.itemclear.TabIndex = 11;
            this.itemclear.Text = "CLEAR";
            this.itemclear.TextColor = System.Drawing.Color.White;
            this.itemclear.UseVisualStyleBackColor = false;
            this.itemclear.Click += new System.EventHandler(this.itemclear_Click);
            // 
            // itemdelete
            // 
            this.itemdelete.BackColor = System.Drawing.Color.White;
            this.itemdelete.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.itemdelete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemdelete.FlatAppearance.BorderSize = 0;
            this.itemdelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.itemdelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.itemdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemdelete.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.itemdelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemdelete.Location = new System.Drawing.Point(536, 246);
            this.itemdelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemdelete.Name = "itemdelete";
            this.itemdelete.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.itemdelete.OnHoverButtonColor = System.Drawing.Color.White;
            this.itemdelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemdelete.Size = new System.Drawing.Size(141, 55);
            this.itemdelete.TabIndex = 10;
            this.itemdelete.Text = "DELETE";
            this.itemdelete.TextColor = System.Drawing.Color.White;
            this.itemdelete.UseVisualStyleBackColor = false;
            this.itemdelete.Click += new System.EventHandler(this.itemdelete_Click);
            // 
            // itemupdate
            // 
            this.itemupdate.BackColor = System.Drawing.Color.White;
            this.itemupdate.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.itemupdate.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemupdate.FlatAppearance.BorderSize = 0;
            this.itemupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.itemupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.itemupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemupdate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.itemupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemupdate.Location = new System.Drawing.Point(357, 246);
            this.itemupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemupdate.Name = "itemupdate";
            this.itemupdate.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.itemupdate.OnHoverButtonColor = System.Drawing.Color.White;
            this.itemupdate.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemupdate.Size = new System.Drawing.Size(141, 55);
            this.itemupdate.TabIndex = 9;
            this.itemupdate.Text = "UPDATE";
            this.itemupdate.TextColor = System.Drawing.Color.White;
            this.itemupdate.UseVisualStyleBackColor = false;
            this.itemupdate.Click += new System.EventHandler(this.itemupdate_Click);
            // 
            // itemadd
            // 
            this.itemadd.BackColor = System.Drawing.Color.White;
            this.itemadd.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.itemadd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemadd.FlatAppearance.BorderSize = 0;
            this.itemadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.itemadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.itemadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemadd.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.itemadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemadd.Location = new System.Drawing.Point(178, 246);
            this.itemadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemadd.Name = "itemadd";
            this.itemadd.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.itemadd.OnHoverButtonColor = System.Drawing.Color.White;
            this.itemadd.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemadd.Size = new System.Drawing.Size(141, 55);
            this.itemadd.TabIndex = 8;
            this.itemadd.Text = "ADD";
            this.itemadd.TextColor = System.Drawing.Color.White;
            this.itemadd.UseVisualStyleBackColor = false;
            this.itemadd.Click += new System.EventHandler(this.itemadd_Click);
            // 
            // countrow
            // 
            this.countrow.BackColor = System.Drawing.Color.White;
            this.countrow.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.countrow.Location = new System.Drawing.Point(357, 817);
            this.countrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countrow.Multiline = true;
            this.countrow.Name = "countrow";
            this.countrow.ReadOnly = true;
            this.countrow.Size = new System.Drawing.Size(168, 32);
            this.countrow.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(206, 822);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Count:";
            // 
            // EMPaddproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.countrow);
            this.Controls.Add(this.idtaken);
            this.Controls.Add(this.itemclear);
            this.Controls.Add(this.itemdelete);
            this.Controls.Add(this.itemupdate);
            this.Controls.Add(this.itemadd);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.searchitem);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.itemlist);
            this.Controls.Add(this.itemexpdate);
            this.Controls.Add(this.mfddate);
            this.Controls.Add(this.itembn);
            this.Controls.Add(this.itemprice);
            this.Controls.Add(this.itemquantity);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.itemid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemcategory);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "EMPaddproduct";
            this.Size = new System.Drawing.Size(1450, 860);
            this.Load += new System.EventHandler(this.EMPaddproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox itemcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itembn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker mfddate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemquantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itemprice;
        private System.Windows.Forms.DataGridView itemlist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker itemexpdate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox searchitem;
        private System.Windows.Forms.TextBox searchbox;
        private ePOSOne.btnProduct.Button_WOC itemadd;
        private ePOSOne.btnProduct.Button_WOC itemupdate;
        private ePOSOne.btnProduct.Button_WOC itemdelete;
        private ePOSOne.btnProduct.Button_WOC itemclear;
        private System.Windows.Forms.Label idtaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRANDNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFDDATEgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewButtonColumn ACTION;
        private System.Windows.Forms.TextBox countrow;
        private System.Windows.Forms.Label label9;
    }
}
