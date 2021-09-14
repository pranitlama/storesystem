
namespace Store_management_system
{
    partial class BillingSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemviewer = new System.Windows.Forms.DataGridView();
            this.prodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textname = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.textquantity = new System.Windows.Forms.TextBox();
            this.basket = new System.Windows.Forms.DataGridView();
            this.tID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bsubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bidtext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.searchitem = new System.Windows.Forms.ComboBox();
            this.bdiscount = new System.Windows.Forms.TextBox();
            this.btotal = new System.Windows.Forms.TextBox();
            this.bcash = new System.Windows.Forms.TextBox();
            this.bbalance = new System.Windows.Forms.TextBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.prodprint = new ePOSOne.btnProduct.Button_WOC();
            this.prodclear = new ePOSOne.btnProduct.Button_WOC();
            this.prodadd = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.itemviewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).BeginInit();
            this.SuspendLayout();
            // 
            // itemviewer
            // 
            this.itemviewer.AllowUserToAddRows = false;
            this.itemviewer.AllowUserToDeleteRows = false;
            this.itemviewer.AllowUserToResizeColumns = false;
            this.itemviewer.AllowUserToResizeRows = false;
            this.itemviewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemviewer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemviewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemviewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.itemviewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemviewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodid,
            this.prodcategory,
            this.prodname,
            this.prodquantity,
            this.prodprice});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemviewer.DefaultCellStyle = dataGridViewCellStyle6;
            this.itemviewer.GridColor = System.Drawing.SystemColors.Info;
            this.itemviewer.Location = new System.Drawing.Point(26, 129);
            this.itemviewer.Name = "itemviewer";
            this.itemviewer.ReadOnly = true;
            this.itemviewer.RowHeadersVisible = false;
            this.itemviewer.RowHeadersWidth = 15;
            this.itemviewer.RowTemplate.Height = 28;
            this.itemviewer.Size = new System.Drawing.Size(544, 658);
            this.itemviewer.TabIndex = 0;
            this.itemviewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemviewer_CellClick);
            // 
            // prodid
            // 
            this.prodid.FillWeight = 50F;
            this.prodid.HeaderText = "ID";
            this.prodid.MinimumWidth = 8;
            this.prodid.Name = "prodid";
            this.prodid.ReadOnly = true;
            // 
            // prodcategory
            // 
            this.prodcategory.FillWeight = 102.2727F;
            this.prodcategory.HeaderText = "CATEGORY";
            this.prodcategory.MinimumWidth = 8;
            this.prodcategory.Name = "prodcategory";
            this.prodcategory.ReadOnly = true;
            // 
            // prodname
            // 
            this.prodname.FillWeight = 102.2727F;
            this.prodname.HeaderText = "NAME";
            this.prodname.MinimumWidth = 8;
            this.prodname.Name = "prodname";
            this.prodname.ReadOnly = true;
            // 
            // prodquantity
            // 
            this.prodquantity.FillWeight = 70F;
            this.prodquantity.HeaderText = "QTY";
            this.prodquantity.MinimumWidth = 8;
            this.prodquantity.Name = "prodquantity";
            this.prodquantity.ReadOnly = true;
            // 
            // prodprice
            // 
            this.prodprice.FillWeight = 102.2727F;
            this.prodprice.HeaderText = "PRICE";
            this.prodprice.MinimumWidth = 8;
            this.prodprice.Name = "prodprice";
            this.prodprice.ReadOnly = true;
            // 
            // textname
            // 
            this.textname.BackColor = System.Drawing.Color.White;
            this.textname.Location = new System.Drawing.Point(880, 38);
            this.textname.Name = "textname";
            this.textname.ReadOnly = true;
            this.textname.Size = new System.Drawing.Size(150, 26);
            this.textname.TabIndex = 1;
            // 
            // textprice
            // 
            this.textprice.BackColor = System.Drawing.Color.White;
            this.textprice.Location = new System.Drawing.Point(1158, 35);
            this.textprice.Name = "textprice";
            this.textprice.ReadOnly = true;
            this.textprice.Size = new System.Drawing.Size(118, 26);
            this.textprice.TabIndex = 1;
            this.textprice.TextChanged += new System.EventHandler(this.textprice_TextChanged);
            // 
            // textquantity
            // 
            this.textquantity.Location = new System.Drawing.Point(1419, 32);
            this.textquantity.Name = "textquantity";
            this.textquantity.Size = new System.Drawing.Size(100, 26);
            this.textquantity.TabIndex = 3;
            this.textquantity.TextChanged += new System.EventHandler(this.textquantity_TextChanged);
            this.textquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textquantity_KeyPress);
            // 
            // basket
            // 
            this.basket.AllowUserToAddRows = false;
            this.basket.AllowUserToDeleteRows = false;
            this.basket.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.basket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tID,
            this.tname,
            this.tquantity,
            this.tprice,
            this.tamt,
            this.tdelete});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.basket.DefaultCellStyle = dataGridViewCellStyle8;
            this.basket.GridColor = System.Drawing.SystemColors.Info;
            this.basket.Location = new System.Drawing.Point(595, 143);
            this.basket.Name = "basket";
            this.basket.ReadOnly = true;
            this.basket.RowHeadersVisible = false;
            this.basket.RowHeadersWidth = 62;
            this.basket.RowTemplate.Height = 28;
            this.basket.Size = new System.Drawing.Size(924, 480);
            this.basket.TabIndex = 0;
            // 
            // tID
            // 
            this.tID.HeaderText = "ID";
            this.tID.MinimumWidth = 8;
            this.tID.Name = "tID";
            this.tID.ReadOnly = true;
            this.tID.Width = 50;
            // 
            // tname
            // 
            this.tname.HeaderText = "NAME";
            this.tname.MinimumWidth = 8;
            this.tname.Name = "tname";
            this.tname.ReadOnly = true;
            this.tname.Width = 150;
            // 
            // tquantity
            // 
            this.tquantity.HeaderText = "QUANTITY";
            this.tquantity.MinimumWidth = 8;
            this.tquantity.Name = "tquantity";
            this.tquantity.ReadOnly = true;
            this.tquantity.Width = 150;
            // 
            // tprice
            // 
            this.tprice.HeaderText = "PRICE";
            this.tprice.MinimumWidth = 8;
            this.tprice.Name = "tprice";
            this.tprice.ReadOnly = true;
            this.tprice.Width = 150;
            // 
            // tamt
            // 
            this.tamt.HeaderText = "AMOUNT";
            this.tamt.MinimumWidth = 8;
            this.tamt.Name = "tamt";
            this.tamt.ReadOnly = true;
            this.tamt.Width = 150;
            // 
            // tdelete
            // 
            this.tdelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tdelete.HeaderText = "DELETE";
            this.tdelete.MinimumWidth = 8;
            this.tdelete.Name = "tdelete";
            this.tdelete.ReadOnly = true;
            this.tdelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tdelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tdelete.Width = 105;
            // 
            // bsubtotal
            // 
            this.bsubtotal.BackColor = System.Drawing.Color.White;
            this.bsubtotal.Location = new System.Drawing.Point(1024, 642);
            this.bsubtotal.Name = "bsubtotal";
            this.bsubtotal.ReadOnly = true;
            this.bsubtotal.Size = new System.Drawing.Size(184, 26);
            this.bsubtotal.TabIndex = 4;
            this.bsubtotal.Text = "0";
            this.bsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1072, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRICE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1300, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUANTITY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(902, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "SUB TOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(876, 686);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "DISCOUNT(%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1246, 683);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "CASH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1212, 723);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "BALANCE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1244, 646);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "TOTAL";
            // 
            // bidtext
            // 
            this.bidtext.BackColor = System.Drawing.Color.White;
            this.bidtext.Location = new System.Drawing.Point(670, 43);
            this.bidtext.Name = "bidtext";
            this.bidtext.ReadOnly = true;
            this.bidtext.Size = new System.Drawing.Size(90, 26);
            this.bidtext.TabIndex = 1;
            this.bidtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bidtext_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(626, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(60, 46);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 23);
            this.label18.TabIndex = 26;
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
            this.searchitem.Location = new System.Drawing.Point(208, 42);
            this.searchitem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchitem.Name = "searchitem";
            this.searchitem.Size = new System.Drawing.Size(140, 29);
            this.searchitem.TabIndex = 24;
            // 
            // bdiscount
            // 
            this.bdiscount.Location = new System.Drawing.Point(1024, 686);
            this.bdiscount.Name = "bdiscount";
            this.bdiscount.Size = new System.Drawing.Size(184, 26);
            this.bdiscount.TabIndex = 4;
            this.bdiscount.Text = "0";
            this.bdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bdiscount.TextChanged += new System.EventHandler(this.bdiscount_TextChanged);
            this.bdiscount.Enter += new System.EventHandler(this.bdiscount_Enter);
            this.bdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bdiscount_KeyPress);
            this.bdiscount.Leave += new System.EventHandler(this.bdiscount_Leave);
            // 
            // btotal
            // 
            this.btotal.BackColor = System.Drawing.Color.White;
            this.btotal.Location = new System.Drawing.Point(1335, 645);
            this.btotal.Name = "btotal";
            this.btotal.ReadOnly = true;
            this.btotal.Size = new System.Drawing.Size(184, 26);
            this.btotal.TabIndex = 4;
            this.btotal.Text = "0";
            this.btotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bcash
            // 
            this.bcash.Location = new System.Drawing.Point(1335, 686);
            this.bcash.Name = "bcash";
            this.bcash.Size = new System.Drawing.Size(184, 26);
            this.bcash.TabIndex = 4;
            this.bcash.Text = "0";
            this.bcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bcash.TextChanged += new System.EventHandler(this.bcash_TextChanged);
            this.bcash.Enter += new System.EventHandler(this.bcash_Enter);
            this.bcash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bcash_KeyPress);
            this.bcash.Leave += new System.EventHandler(this.bcash_Leave);
            // 
            // bbalance
            // 
            this.bbalance.BackColor = System.Drawing.Color.White;
            this.bbalance.Location = new System.Drawing.Point(1335, 722);
            this.bbalance.Name = "bbalance";
            this.bbalance.ReadOnly = true;
            this.bbalance.Size = new System.Drawing.Size(184, 26);
            this.bbalance.TabIndex = 4;
            this.bbalance.Text = "0";
            this.bbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(388, 46);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(150, 26);
            this.searchbox.TabIndex = 1;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // prodprint
            // 
            this.prodprint.BackColor = System.Drawing.Color.White;
            this.prodprint.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.prodprint.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.prodprint.FlatAppearance.BorderSize = 0;
            this.prodprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.prodprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.prodprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodprint.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.prodprint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prodprint.Location = new System.Drawing.Point(1238, 80);
            this.prodprint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prodprint.Name = "prodprint";
            this.prodprint.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.prodprint.OnHoverButtonColor = System.Drawing.Color.White;
            this.prodprint.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.prodprint.Size = new System.Drawing.Size(124, 55);
            this.prodprint.TabIndex = 27;
            this.prodprint.Text = "PRINT";
            this.prodprint.TextColor = System.Drawing.Color.White;
            this.prodprint.UseVisualStyleBackColor = false;
            // 
            // prodclear
            // 
            this.prodclear.BackColor = System.Drawing.Color.White;
            this.prodclear.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.prodclear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.prodclear.FlatAppearance.BorderSize = 0;
            this.prodclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.prodclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.prodclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodclear.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.prodclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prodclear.Location = new System.Drawing.Point(1077, 80);
            this.prodclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prodclear.Name = "prodclear";
            this.prodclear.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.prodclear.OnHoverButtonColor = System.Drawing.Color.White;
            this.prodclear.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.prodclear.Size = new System.Drawing.Size(124, 55);
            this.prodclear.TabIndex = 27;
            this.prodclear.Text = "CLEAR";
            this.prodclear.TextColor = System.Drawing.Color.White;
            this.prodclear.UseVisualStyleBackColor = false;
            this.prodclear.Click += new System.EventHandler(this.prodclear_Click);
            // 
            // prodadd
            // 
            this.prodadd.BackColor = System.Drawing.Color.White;
            this.prodadd.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.prodadd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.prodadd.FlatAppearance.BorderSize = 0;
            this.prodadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.prodadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.prodadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodadd.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.prodadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prodadd.Location = new System.Drawing.Point(932, 80);
            this.prodadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prodadd.Name = "prodadd";
            this.prodadd.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.prodadd.OnHoverButtonColor = System.Drawing.Color.White;
            this.prodadd.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.prodadd.Size = new System.Drawing.Size(124, 55);
            this.prodadd.TabIndex = 27;
            this.prodadd.Text = "ADD";
            this.prodadd.TextColor = System.Drawing.Color.White;
            this.prodadd.UseVisualStyleBackColor = false;
            this.prodadd.Click += new System.EventHandler(this.prodadd_Click);
            // 
            // BillingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.prodprint);
            this.Controls.Add(this.prodclear);
            this.Controls.Add(this.prodadd);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.searchitem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bbalance);
            this.Controls.Add(this.bcash);
            this.Controls.Add(this.btotal);
            this.Controls.Add(this.bdiscount);
            this.Controls.Add(this.bsubtotal);
            this.Controls.Add(this.textquantity);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.bidtext);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.itemviewer);
            this.Name = "BillingSystem";
            this.Size = new System.Drawing.Size(1546, 897);
            this.Load += new System.EventHandler(this.BillingSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemviewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemviewer;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox textquantity;
        private System.Windows.Forms.DataGridView basket;
        private System.Windows.Forms.TextBox bsubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bidtext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox searchitem;
        private System.Windows.Forms.TextBox bdiscount;
        private System.Windows.Forms.TextBox btotal;
        private System.Windows.Forms.TextBox bcash;
        private System.Windows.Forms.TextBox bbalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodprice;
        private System.Windows.Forms.TextBox searchbox;
        private ePOSOne.btnProduct.Button_WOC prodadd;
        private ePOSOne.btnProduct.Button_WOC prodclear;
        private ePOSOne.btnProduct.Button_WOC prodprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn tID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamt;
        private System.Windows.Forms.DataGridViewButtonColumn tdelete;
    }
}
