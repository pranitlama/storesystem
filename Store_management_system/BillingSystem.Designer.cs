﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingSystem));
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.cancelcart = new System.Windows.Forms.Button();
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
            this.itemviewer.Location = new System.Drawing.Point(17, 84);
            this.itemviewer.Margin = new System.Windows.Forms.Padding(2);
            this.itemviewer.Name = "itemviewer";
            this.itemviewer.ReadOnly = true;
            this.itemviewer.RowHeadersVisible = false;
            this.itemviewer.RowHeadersWidth = 15;
            this.itemviewer.RowTemplate.Height = 28;
            this.itemviewer.Size = new System.Drawing.Size(363, 455);
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
            this.textname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textname.Location = new System.Drawing.Point(587, 25);
            this.textname.Margin = new System.Windows.Forms.Padding(2);
            this.textname.Name = "textname";
            this.textname.ReadOnly = true;
            this.textname.Size = new System.Drawing.Size(101, 23);
            this.textname.TabIndex = 1;
            // 
            // textprice
            // 
            this.textprice.BackColor = System.Drawing.Color.White;
            this.textprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textprice.Location = new System.Drawing.Point(772, 23);
            this.textprice.Margin = new System.Windows.Forms.Padding(2);
            this.textprice.Name = "textprice";
            this.textprice.ReadOnly = true;
            this.textprice.Size = new System.Drawing.Size(80, 23);
            this.textprice.TabIndex = 1;
            this.textprice.TextChanged += new System.EventHandler(this.textprice_TextChanged);
            // 
            // textquantity
            // 
            this.textquantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textquantity.Location = new System.Drawing.Point(946, 21);
            this.textquantity.Margin = new System.Windows.Forms.Padding(2);
            this.textquantity.Name = "textquantity";
            this.textquantity.Size = new System.Drawing.Size(68, 23);
            this.textquantity.TabIndex = 3;
            this.textquantity.TextChanged += new System.EventHandler(this.textquantity_TextChanged);
            this.textquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textquantity_KeyPress);
            // 
            // basket
            // 
            this.basket.AllowUserToAddRows = false;
            this.basket.AllowUserToDeleteRows = false;
            this.basket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.basket.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.basket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.basket.DefaultCellStyle = dataGridViewCellStyle8;
            this.basket.GridColor = System.Drawing.SystemColors.Info;
            this.basket.Location = new System.Drawing.Point(398, 93);
            this.basket.Margin = new System.Windows.Forms.Padding(2);
            this.basket.Name = "basket";
            this.basket.ReadOnly = true;
            this.basket.RowHeadersVisible = false;
            this.basket.RowHeadersWidth = 62;
            this.basket.RowTemplate.Height = 28;
            this.basket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.basket.Size = new System.Drawing.Size(616, 372);
            this.basket.TabIndex = 0;
            this.basket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.basket_CellClick);
            this.basket.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.basket_CellPainting);
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
            // tdelete
            // 
            this.tdelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tdelete.FillWeight = 20F;
            this.tdelete.HeaderText = "DELETE";
            this.tdelete.MinimumWidth = 8;
            this.tdelete.Name = "tdelete";
            this.tdelete.ReadOnly = true;
            this.tdelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tdelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tdelete.Width = 71;
            // 
            // bsubtotal
            // 
            this.bsubtotal.BackColor = System.Drawing.Color.White;
            this.bsubtotal.Location = new System.Drawing.Point(662, 480);
            this.bsubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.bsubtotal.Name = "bsubtotal";
            this.bsubtotal.ReadOnly = true;
            this.bsubtotal.Size = new System.Drawing.Size(124, 20);
            this.bsubtotal.TabIndex = 4;
            this.bsubtotal.Text = "0";
            this.bsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(715, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRICE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(867, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUANTITY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(571, 482);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "SUB TOTAL(Rs)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 508);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "DISCOUNT(%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(825, 508);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "CASH(Rs)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(802, 536);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "BALANCE(Rs)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(823, 484);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "TOTAL(Rs)";
            // 
            // bidtext
            // 
            this.bidtext.BackColor = System.Drawing.Color.White;
            this.bidtext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bidtext.Location = new System.Drawing.Point(447, 28);
            this.bidtext.Margin = new System.Windows.Forms.Padding(2);
            this.bidtext.Name = "bidtext";
            this.bidtext.ReadOnly = true;
            this.bidtext.Size = new System.Drawing.Size(61, 23);
            this.bidtext.TabIndex = 1;
            this.bidtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bidtext_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(40, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 19);
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
            this.searchitem.Location = new System.Drawing.Point(139, 27);
            this.searchitem.Name = "searchitem";
            this.searchitem.Size = new System.Drawing.Size(95, 25);
            this.searchitem.TabIndex = 24;
            // 
            // bdiscount
            // 
            this.bdiscount.Location = new System.Drawing.Point(662, 508);
            this.bdiscount.Margin = new System.Windows.Forms.Padding(2);
            this.bdiscount.Name = "bdiscount";
            this.bdiscount.Size = new System.Drawing.Size(124, 20);
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
            this.btotal.Location = new System.Drawing.Point(890, 482);
            this.btotal.Margin = new System.Windows.Forms.Padding(2);
            this.btotal.Name = "btotal";
            this.btotal.ReadOnly = true;
            this.btotal.Size = new System.Drawing.Size(124, 20);
            this.btotal.TabIndex = 4;
            this.btotal.Text = "0";
            this.btotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bcash
            // 
            this.bcash.Location = new System.Drawing.Point(890, 508);
            this.bcash.Margin = new System.Windows.Forms.Padding(2);
            this.bcash.Name = "bcash";
            this.bcash.Size = new System.Drawing.Size(124, 20);
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
            this.bbalance.Location = new System.Drawing.Point(890, 532);
            this.bbalance.Margin = new System.Windows.Forms.Padding(2);
            this.bbalance.Name = "bbalance";
            this.bbalance.ReadOnly = true;
            this.bbalance.Size = new System.Drawing.Size(124, 20);
            this.bbalance.TabIndex = 4;
            this.bbalance.Text = "0";
            this.bbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchbox.Location = new System.Drawing.Point(259, 30);
            this.searchbox.Margin = new System.Windows.Forms.Padding(2);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(101, 23);
            this.searchbox.TabIndex = 1;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // cancelcart
            // 
            this.cancelcart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.cancelcart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelcart.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.cancelcart.ForeColor = System.Drawing.Color.White;
            this.cancelcart.Image = ((System.Drawing.Image)(resources.GetObject("cancelcart.Image")));
            this.cancelcart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelcart.Location = new System.Drawing.Point(398, 482);
            this.cancelcart.Name = "cancelcart";
            this.cancelcart.Size = new System.Drawing.Size(144, 41);
            this.cancelcart.TabIndex = 28;
            this.cancelcart.Text = "       CANCEL CART";
            this.cancelcart.UseVisualStyleBackColor = false;
            this.cancelcart.Click += new System.EventHandler(this.cancelcart_Click);
            this.cancelcart.MouseEnter += new System.EventHandler(this.cancelcart_MouseEnter);
            this.cancelcart.MouseLeave += new System.EventHandler(this.cancelcart_MouseLeave);
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
            this.prodprint.Location = new System.Drawing.Point(894, 52);
            this.prodprint.Name = "prodprint";
            this.prodprint.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.prodprint.OnHoverButtonColor = System.Drawing.Color.White;
            this.prodprint.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.prodprint.Size = new System.Drawing.Size(119, 36);
            this.prodprint.TabIndex = 27;
            this.prodprint.Text = "PURCHASE & PRINT";
            this.prodprint.TextColor = System.Drawing.Color.White;
            this.prodprint.UseVisualStyleBackColor = false;
            this.prodprint.Click += new System.EventHandler(this.prodprint_Click);
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
            this.prodclear.Location = new System.Drawing.Point(796, 52);
            this.prodclear.Name = "prodclear";
            this.prodclear.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.prodclear.OnHoverButtonColor = System.Drawing.Color.White;
            this.prodclear.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.prodclear.Size = new System.Drawing.Size(83, 36);
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
            this.prodadd.Location = new System.Drawing.Point(683, 52);
            this.prodadd.Name = "prodadd";
            this.prodadd.OnHoverBorderColor = System.Drawing.Color.SlateGray;
            this.prodadd.OnHoverButtonColor = System.Drawing.Color.White;
            this.prodadd.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.prodadd.Size = new System.Drawing.Size(98, 36);
            this.prodadd.TabIndex = 27;
            this.prodadd.Text = "ADD TO CART";
            this.prodadd.TextColor = System.Drawing.Color.White;
            this.prodadd.UseVisualStyleBackColor = false;
            this.prodadd.Click += new System.EventHandler(this.prodadd_Click);
            // 
            // BillingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cancelcart);
            this.Controls.Add(this.basket);
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
            this.Controls.Add(this.itemviewer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BillingSystem";
            this.Size = new System.Drawing.Size(1029, 581);
            this.Load += new System.EventHandler(this.BillingSystem_Load);
            this.Enter += new System.EventHandler(this.BillingSystem_Enter);
            this.Leave += new System.EventHandler(this.BillingSystem_Leave);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn tID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamt;
        private System.Windows.Forms.DataGridViewButtonColumn tdelete;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        internal ePOSOne.btnProduct.Button_WOC prodprint;
        private System.Windows.Forms.Button cancelcart;
    }
}
