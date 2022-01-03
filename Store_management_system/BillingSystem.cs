using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Store_management_system.Properties;
namespace Store_management_system
{
    public partial class BillingSystem : UserControl

    {

        SqlConnection connect = new SqlConnection(connectionstri.Value);
        public BillingSystem()
        {
            InitializeComponent();
            datagridcustomize();
            searchitem.SelectedIndex = 0;
           
        }

        private void displaydata()
        {
            try
            {
                connect.Open();
                string query = "Select * from  item_details";
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                itemviewer.Rows.Clear();

                foreach (DataRow dataRow in dt.Rows)
                {

                    itemviewer.Rows.Add(dataRow["i_id"], dataRow["i_category"], dataRow["i_name"], dataRow["i_quantity"], dataRow["i_price"]);


                }






            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();

                }
            }
        }


        private void BillingSystem_Load(object sender, EventArgs e)
        {
            displaydata();
            prodprint.Enabled = false;



        }

        private void datagridcustomize()
        {
            itemviewer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);
            itemviewer.RowTemplate.Height = 35;
            itemviewer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);
            this.itemviewer.EnableHeadersVisualStyles = false;

            basket.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);
            basket.RowTemplate.Height = 35;
            basket.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);
            this.basket.EnableHeadersVisualStyles = false;

            itemviewer.DefaultCellStyle.ForeColor = Color.Black;

            this.itemviewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.itemviewer.ColumnHeadersHeight = 40;

            this.basket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.basket.ColumnHeadersHeight = 40;


            //DataGridViewButtonColumn c = (DataGridViewButtonColumn)basket.Columns["tdelete"];
            //c.Text = "delete";

//            tdelete.UseColumnTextForButtonValue = true;

         //   tdelete.Width = 5;

          //  tdelete.DefaultCellStyle.Padding = new Padding(16,0,16,0);

//            DataGridViewButtonColumn c = (DataGridViewButtonColumn)basket.Columns["tdelete"];
            //c.FlatStyle = FlatStyle.Popup;
            //c.DefaultCellStyle.ForeColor = Color.White;
            //c.DefaultCellStyle.BackColor = Color.Navy;



        }


        private void display()
        {
            try
            {

                if (searchbox.Text == "")
                {
                    displaydata();
                }
                else if (searchitem.Text == "ID")
                {
                    connect.Open();
                    string query = "select * from item_details where i_id like '" + searchbox.Text + "%'";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    itemviewer.Rows.Clear();

                    foreach (DataRow dataRow in dt.Rows)
                    {

                        itemviewer.Rows.Add(dataRow["i_id"], dataRow["i_category"], dataRow["i_name"], dataRow["i_quantity"], dataRow["i_price"]);


                    }
                    // countrows();


                }
                else if (searchitem.Text == "CATEGORY")
                {
                    connect.Open();
                    // string query = "select * from employee_details where e_fname,e_lname like '" + searchbox.Text + "%'";
                    string query = "Select * from item_details where i_category like'" + searchbox.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    itemviewer.Rows.Clear();

                    foreach (DataRow dataRow in dt.Rows)
                    {

                        itemviewer.Rows.Add(dataRow["i_id"], dataRow["i_category"], dataRow["i_name"], dataRow["i_quantity"], dataRow["i_price"]);

                    }



                }
                else if (searchitem.Text == "NAME")
                {
                    connect.Open();
                    string query = "select * from item_details where i_name like '" + searchbox.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    itemviewer.Rows.Clear();

                    foreach (DataRow dataRow in dt.Rows)
                    {

                        itemviewer.Rows.Add(dataRow["i_id"], dataRow["i_category"], dataRow["i_name"], dataRow["i_quantity"], dataRow["i_price"]);


                    }




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }



        private void textprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void textquantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }











        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            display();
        }

        private void bidtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void textquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void bdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
              {
               e.Handled = true;
            }
        }

        private void bcash_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void prodclear_Click(object sender, EventArgs e)
        {
            bidtext.Text = "";
            textname.Text = "";
            textquantity.Text = "";
            textprice.Text = "";
            prodprint.Enabled = false ;
        }
        int item_id;

        private void itemviewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            // string item_category = itemviewer.CurrentRow.Cells["prodcategory"].Value.ToString();
            string item_name = itemviewer.CurrentRow.Cells["prodname"].Value.ToString();

            item_id = Convert.ToInt32(itemviewer.CurrentRow.Cells["prodid"].Value.ToString());
            //string item_quantity = itemviewer.CurrentRow.Cells["prodquantity"].Value.ToString();
            string item_price = itemviewer.CurrentRow.Cells["prodprice"].Value.ToString();


            //   MessageBox.Show("Id: " + employee_id + "\nName: " + employee_name);
            // string result = Messageboxok.ShowBox("", "Id: " + item_id + "\nName: " + item_name);
            bidtext.Text = item_id.ToString();
            //itemcategory.Text = item_category;
            textname.Text = item_name;

            //quantity.Text = item_quantity;
            textprice.Text = item_price;
            itemviewer.Rows[index].Selected = true;
            itemviewer.CurrentRow.Selected = true;


        }


        int i;
        int st;
        int remaining;
        private void prodadd_Click(object sender, EventArgs e)
        {
            
            int qtycompare = 0;
            // var valid = false;
          
            int text;
            //int text1 = 0;

            if (bidtext.Text == "" || textname.Text == "" || textprice.Text == "")
            {
                
                string result = Messageboxok.ShowBox("", "Please select a item");
                prodprint.Enabled = false;
            }

            else if(textquantity.Text==string.Empty)
            {
                string result = Messageboxok.ShowBox("", "Please Enter Quantity");
                prodprint.Enabled = false;
            }
            else
            {
                try
                {
                    connect.Open();
                    string query = "Select i_quantity from  item_details where i_ID=" + bidtext.Text;
                    SqlCommand cmd = new SqlCommand(query, connect);
                    //  SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    // DataTable dt = new DataTable();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        qtycompare = Convert.ToInt32(dr["i_quantity"]);
                    }
                    text = Convert.ToInt32(this.textquantity.Text);

                    if (text > qtycompare)
                    {
                        string result = Messageboxok.ShowBox("", "Quantity Exceeded");
                        prodprint.Enabled = false;
                        return;

                    }


                    else
                    {

                        int a = 0;
                        int sum = 0;

                        dr.Close();
                        remaining = qtycompare - text;
                        string st_id = bidtext.Text;
                        string st_name = textname.Text;
                        string st_qty = textquantity.Text;
                        string st_price = textprice.Text;

                        string[] rows = { st_id, st_name, st_qty, st_price };
                        basket.Rows.Add(rows);
                        string total = bsubtotal.Text;
                        foreach (DataGridViewRow row in basket.Rows)
                        {
                            //amount calulator
                            a = Convert.ToInt32(row.Cells[2].Value) * Convert.ToInt32(row.Cells[3].Value);

                            row.Cells[4].Value = a;
                            //  row.Cells[5].Value = amount;



                        }
                        prodprint.Enabled = true;
                        for (i = 0; i < basket.Rows.Count; ++i)
                        {

                            sum += Convert.ToInt32(basket.Rows[i].Cells[4].Value);


                        }






                        bsubtotal.Text = sum.ToString();
                        btotal.Text = bsubtotal.Text;
                        st = int.Parse(bsubtotal.Text);
                        string ab =  bsubtotal.Text;
                        bsubtotal.Text = ab;
                        //if (bdiscount.Text == "" || bdiscount.Text == "0")
                        //{
                        //    btotal.Text = bsubtotal.Text;
                        //    double.Parse(btotal.Text);
                        //}




                        int text1;
                        text1 = Convert.ToInt32(this.bidtext.Text);

                        string s = remaining.ToString();
                        query = "Update item_details set i_quantity=@parameter_quantity where i_id=" + bidtext.Text;

                        SqlCommand cmds = new SqlCommand(query, connect);

                        cmds.Parameters.AddWithValue("@parameter_quantity", remaining);

                        cmds.ExecuteNonQuery();
                        bidtext.Text = "";
                        textname.Text = "";
                        textquantity.Text = "";
                        textprice.Text = "";




                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connect.Close();
                }
                itemviewer.Rows.Clear();
                displaydata();







            }
        }

        double dis;
        double disgi;
        double gtotal;
     
        private void bdiscount_TextChanged(object sender, EventArgs e)
        {

            if (bdiscount.Text != "")
            {
                
                dis = double.Parse(bdiscount.Text);
                disgi = st * (dis / 100);
                gtotal = st - disgi;
                btotal.Text = gtotal.ToString();
                double c = double.Parse(btotal.Text);
                double d = double.Parse(bcash.Text);
                bbalance.Text = (d - c).ToString();

            }
            else if(bdiscount.Text=="")
            {
                btotal.Text = bsubtotal.Text;
        


            }
            else if(bdiscount.Text=="0")
            {
                btotal.Text = bsubtotal.Text;
            }

        }

        private void bdiscount_Enter(object sender, EventArgs e)
        {
            if (bdiscount.Text == "" || bdiscount.Text == "0")
            {
                bdiscount.Text = string.Empty;
            }
            
        }

        private void bdiscount_Leave(object sender, EventArgs e)
        {
            if(bdiscount.Text =="")
            {
                bdiscount.Text = "0";
            }
        }
        double money;
        double totals;
        double balance;
        private void bcash_TextChanged(object sender, EventArgs e)
        {
            if (bcash.Text != "")
            {
                money = double.Parse(bcash.Text);
                totals = double.Parse(btotal.Text);
                balance = money - totals;
                bbalance.Text = balance.ToString();
               double.Parse(bbalance.Text);
            }
            else if(bcash.Text=="")
            {
                bbalance.Text = btotal.Text;
            }
            else if(bcash.Text=="0")
            {
                bbalance.Text = btotal.Text;
            }

            

        }

        private void bcash_Enter(object sender, EventArgs e)
        {
            if (bcash.Text == "" || bcash.Text=="0")
            {
                bcash.Text = string.Empty;

            }
        }

        private void bcash_Leave(object sender, EventArgs e)
        {
            if (bcash.Text == "")
            {
                bcash.Text = "0";
            }
        }
        public Rectangle rc;
        private void basket_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Image someImage = Properties.Resources.Img4;
            if (e.RowIndex < 0)
            {
                return;
            }

     
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Img4.Width;
                var h = Properties.Resources.Img4.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
              
                e.Graphics.DrawImage(someImage , new Rectangle(x, y, w, h));
      
                e.Handled = true;
            }
        }
        int b_id;
        
        int qtycompares;
        private void basket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sumqty;
            int totalqty;
            
        
            if (e.ColumnIndex == basket.Columns["tdelete"].Index)
            {

                 
                try
                {
                    connect.Open();
                    string b_amount = basket.CurrentRow.Cells["tamt"].Value.ToString();
                    string b_name = basket.CurrentRow.Cells["tname"].Value.ToString();
                    string b_quantity = basket.CurrentRow.Cells["tquantity"].Value.ToString();
                    string b_price = basket.CurrentRow.Cells["tprice"].Value.ToString();
                    b_id = Convert.ToInt32(basket.CurrentRow.Cells["tID"].Value.ToString());


                    string query = "Select i_quantity from  item_details where i_ID=" + b_id;
                    SqlCommand cmds = new SqlCommand(query, connect);
                    SqlDataReader dr = cmds.ExecuteReader();
                    if (dr.Read())
                    {
                        qtycompares = Convert.ToInt32(dr["i_quantity"]);
                    }
                    dr.Close();
                    sumqty = Convert.ToInt32(b_quantity);
                    totalqty = sumqty + qtycompares;
                    string querys = "Update item_details set i_quantity=@parameter_quantity where i_id=" + b_id;
                    SqlCommand cmdss = new SqlCommand(querys, connect);
                    cmdss.Parameters.AddWithValue("@parameter_quantity", totalqty.ToString());
                    cmdss.ExecuteNonQuery();
                    int amounts = int.Parse(b_amount);
                    int sbt = int.Parse(bsubtotal.Text);
                    int totalamt = sbt - amounts ;
                    string tamts = totalamt.ToString();
                    bsubtotal.Text = tamts;
                   btotal.Text = bsubtotal.Text ;
               


                    foreach (DataGridViewCell onecell in basket.SelectedCells)
                   {
                      if (onecell.Selected)
                        { 
                            basket.Rows.RemoveAt(onecell.RowIndex);

                          

                        

                            
                        }
                        bcash.Text = "0";
                        bbalance.Text = "0";
                   }
                    checkdatagrid();


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connect.Close();
                }
                displaydata();

              
            }
            else
            {


             


            }
        }

        private void prodprint_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dr in basket.Rows )
            {
                try
                {
                    connect.Open();
                    string query = "insert into transaction_details (t_name,t_quantity,t_amt,t_price,t_date,t_empname) values(@parameter_name,@parameter_qty,@parameter_amt,@parameter_price,@parameter_date,@parameter_uname)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@parameter_name", dr.Cells["tname"].Value);
                    cmd.Parameters.AddWithValue("@parameter_qty", dr.Cells["tquantity"].Value);
                    cmd.Parameters.AddWithValue("@parameter_amt", dr.Cells["tamt"].Value);
                    cmd.Parameters.AddWithValue("@parameter_price", dr.Cells["tprice"].Value);
                    cmd.Parameters.AddWithValue("@parameter_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@parameter_uname", Form1.username);
                    cmd.ExecuteNonQuery();
                 

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                 
                    connect.Close();

                  
                }
               
            }
          //  printDocument1.Print();
            string result = Messageboxok.ShowBox("", "PURCHASE COMPLETE");
         
            print pr = new print();
            pr.Show();

            basket.Rows.Clear();
        }
        private void checkdatagrid()
        {
            if(basket.Rows.Count ==0)
            {
                prodprint.Enabled = false;

            }
            else
            {
                prodprint.Enabled = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          //   var Center = Convert.ToSingle(e.PageBounds.Width / 2 - e.Graphics.MeasureString("SAMP STORE",SystemFonts.DefaultFont).Width / 2);
          //  SolidBrush brush = new SolidBrush(Color.Black);
          //  e.Graphics.DrawString(Center,new Font("Century Gothic", 18, FontStyle.Bold), brush, new Point(1, 10)); 
            
        }
    }
}
