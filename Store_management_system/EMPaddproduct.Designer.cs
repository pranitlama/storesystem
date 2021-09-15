
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
            this.itemcategory.Location = new System.Drawing.Point(117, 25);
            this.itemcategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemcategory.Name = "itemcategory";
            this.itemcategory.Size = new System.Drawing.Size(123, 24);
            this.itemcategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "BRAND NAME";
            // 
            // itemid
            // 
            this.itemid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemid.Location = new System.Drawing.Point(117, 71);
            this.itemid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemid.Name = "itemid";
            this.itemid.Size = new System.Drawing.Size(123, 23);
            this.itemid.TabIndex = 3;
            this.itemid.TextChanged += new System.EventHandler(this.itemid_TextChanged);
            this.itemid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemid_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(83, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // itembn
            // 
            this.itembn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itembn.Location = new System.Drawing.Point(117, 114);
            this.itembn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itembn.Name = "itembn";
            this.itembn.Size = new System.Drawing.Size(123, 23);
            this.itembn.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(297, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "EXPIRE DATE";
            // 
            // mfddate
            // 
            this.mfddate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mfddate.Location = new System.Drawing.Point(401, 71);
            this.mfddate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mfddate.Name = "mfddate";
            this.mfddate.Size = new System.Drawing.Size(121, 21);
            this.mfddate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(327, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = " NAME";
            // 
            // itemname
            // 
            this.itemname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemname.Location = new System.Drawing.Point(401, 32);
            this.itemname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(121, 23);
            this.itemname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(600, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "QUANTITY";
            // 
            // itemquantity
            // 
            this.itemquantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemquantity.Location = new System.Drawing.Point(690, 31);
            this.itemquantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemquantity.Name = "itemquantity";
            this.itemquantity.Size = new System.Drawing.Size(121, 23);
            this.itemquantity.TabIndex = 3;
            this.itemquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemquantity_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(624, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "PRICE";
            // 
            // itemprice
            // 
            this.itemprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemprice.Location = new System.Drawing.Point(690, 73);
            this.itemprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemprice.Name = "itemprice";
            this.itemprice.Size = new System.Drawing.Size(121, 23);
            this.itemprice.TabIndex = 3;
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
            this.itemlist.Location = new System.Drawing.Point(16, 201);
            this.itemlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemlist.Name = "itemlist";
            this.itemlist.ReadOnly = true;
            this.itemlist.RowHeadersWidth = 31;
            this.itemlist.RowTemplate.Height = 28;
            this.itemlist.Size = new System.Drawing.Size(912, 348);
            this.itemlist.TabIndex = 6;
            this.itemlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemlist_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(309, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "MFD DATE";
            // 
            // itemexpdate
            // 
            this.itemexpdate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemexpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.itemexpdate.Location = new System.Drawing.Point(401, 116);
            this.itemexpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemexpdate.Name = "itemexpdate";
            this.itemexpdate.Size = new System.Drawing.Size(121, 21);
            this.itemexpdate.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(591, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 19);
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
            this.searchitem.Location = new System.Drawing.Point(690, 116);
            this.searchitem.Name = "searchitem";
            this.searchitem.Size = new System.Drawing.Size(95, 25);
            this.searchitem.TabIndex = 21;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchbox.Location = new System.Drawing.Point(789, 116);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(139, 24);
            this.searchbox.TabIndex = 22;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // idtaken
            // 
            this.idtaken.AutoSize = true;
            this.idtaken.ForeColor = System.Drawing.Color.Red;
            this.idtaken.Location = new System.Drawing.Point(116, 96);
            this.idtaken.Name = "idtaken";
            this.idtaken.Size = new System.Drawing.Size(85, 13);
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
            this.itemclear.Location = new System.Drawing.Point(476, 160);
            this.itemclear.Name = "itemclear";
            this.itemclear.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.itemclear.OnHoverButtonColor = System.Drawing.Color.White;
            this.itemclear.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemclear.Size = new System.Drawing.Size(94, 36);
            this.itemclear.TabIndex = 24;
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
            this.itemdelete.Location = new System.Drawing.Point(357, 160);
            this.itemdelete.Name = "itemdelete";
            this.itemdelete.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.itemdelete.OnHoverButtonColor = System.Drawing.Color.White;
            this.itemdelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemdelete.Size = new System.Drawing.Size(94, 36);
            this.itemdelete.TabIndex = 24;
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
            this.itemupdate.Location = new System.Drawing.Point(238, 160);
            this.itemupdate.Name = "itemupdate";
            this.itemupdate.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.itemupdate.OnHoverButtonColor = System.Drawing.Color.White;
            this.itemupdate.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemupdate.Size = new System.Drawing.Size(94, 36);
            this.itemupdate.TabIndex = 24;
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
            this.itemadd.Location = new System.Drawing.Point(119, 160);
            this.itemadd.Name = "itemadd";
            this.itemadd.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.itemadd.OnHoverButtonColor = System.Drawing.Color.White;
            this.itemadd.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.itemadd.Size = new System.Drawing.Size(94, 36);
            this.itemadd.TabIndex = 24;
            this.itemadd.Text = "ADD";
            this.itemadd.TextColor = System.Drawing.Color.White;
            this.itemadd.UseVisualStyleBackColor = false;
            this.itemadd.Click += new System.EventHandler(this.itemadd_Click);
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
            // 
            // EMPaddproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemcategory);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EMPaddproduct";
            this.Size = new System.Drawing.Size(967, 559);
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
    }
}
