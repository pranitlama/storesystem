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

namespace Store_management_system
{
    public partial class BillingSystem : UserControl

    {

        SqlConnection connect = new SqlConnection(connectionstri.Value);
        public BillingSystem()
        {
            InitializeComponent();
            itemviewer.DefaultCellStyle.ForeColor = Color.Black;

            this.itemviewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.itemviewer.ColumnHeadersHeight = 40;

            //DataGridViewButtonColumn c = (DataGridViewButtonColumn)basket.Columns["tdelete"];
            //c.Text = "delete";
       
            tdelete.UseColumnTextForButtonValue = true;
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

                    itemviewer.Rows.Add( dataRow["i_id"], dataRow["i_category"], dataRow["i_name"], dataRow["i_quantity"], dataRow["i_price"]);
                    

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
            itemviewer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);
            itemviewer.RowTemplate.Height = 35;
         



           
           

            itemviewer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);



            this.itemviewer.EnableHeadersVisualStyles = false;
            

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

        private void prodadd_Click(object sender, EventArgs e)
        {
            if (bidtext.Text == "" || textname.Text == "" || textquantity.Text == "" || textprice.Text == "")
            {
                string result = Messageboxok.ShowBox("", "Please enter complete data");
            }
            else
            {

                
                

                string st_id = bidtext .Text;
                    string st_name = textname .Text;
                    string st_qty = textquantity.Text;
                    string st_price = textprice .Text;
              
                    string[] rows = { st_id , st_name,st_qty,st_price};
                    basket.Rows.Add(rows);
               
                foreach (DataGridViewRow row in basket.Rows)
                {
                    int a = Convert.ToInt32(row.Cells[2].Value) * Convert.ToInt32(row.Cells[3].Value);  
                    row.Cells[4].Value = a;
                }



            }
        }

        private void basket_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
               }

        private void basket_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex > -1)
            {
                Image img = Image.FromFile(@"D:\delete.png");
                e.Graphics.DrawImage(img, e.CellBounds.Location);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }
    }
}
