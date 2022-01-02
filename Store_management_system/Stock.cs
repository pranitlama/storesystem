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
    public partial class Stock : UserControl

    {
        SqlConnection connect = new SqlConnection(connectionstri.Value);
        public Stock()
        {
            InitializeComponent();
            stocklist.DefaultCellStyle.ForeColor = Color.Black;
            searchitem.SelectedIndex = 3;
            
            
            
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            DisplayData();
            countrows();
        }
        private void DisplayData()
        {


            try
            {
                connect.Open();
                string query = "Select * from  item_details";
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                stocklist.Rows.Clear();
              
                foreach (DataRow dataRow in dt.Rows)
                {

                    stocklist.Rows.Add( dataRow["i_id"], dataRow["i_category"], dataRow["i_brandname"], dataRow["i_name"], dataRow["i_quantity"], dataRow["i_price"] );
                  

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

        private void countrows()
        {
            int num = stocklist.Rows.GetRowCount(DataGridViewElementStates.Visible);
            countrow.Text = num.ToString();
            countrow.Text = "  " + countrow.Text;
        }

        private void stocklist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==4 & e.Value!= null  )
            {
                int sum1 = Convert.ToInt32(e.Value);
                if(sum1<=30 && sum1>0)
                {
                   // stockalert.Visible = true;
                    e.CellStyle.BackColor = Color.Yellow;
                    
                }

                else if(sum1<=0)

                {
                    stockalert.Visible = true;
                    pictureBox1.Visible = true;

                    e.CellStyle.BackColor = Color.Red;
                }
                else
                {
                    //stockalert.Visible = false;
                       
                    e.CellStyle.BackColor = Color.Green;
                }
            }
        }

        private void searchitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchitem.Text == "OUT OF STOCK")
            {
                foreach (DataGridViewRow row in stocklist.Rows)
                {
                    int X = Convert.ToInt32(row.Cells["quantity"].Value);
                    if (X <= 0)
                    {
                        row.Visible = true;
                        
                    }
                   
                    else
                    {
                        row.Visible = false;
                    }
                   
                }
                countrows();
            }

            if (searchitem.Text == "LOW STOCK")
            {
                foreach (DataGridViewRow row in stocklist.Rows)
                {
                    int X = Convert.ToInt32(row.Cells["quantity"].Value);
                    if (X > 0 && X<=30)
                    {
                        row.Visible = true;
                       
                            countrows();
                        
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                countrows();

            }

            if (searchitem.Text == "STOCK")
            {
                foreach (DataGridViewRow row in stocklist.Rows)
                {
                    int X = Convert.ToInt32(row.Cells["quantity"].Value);
                    if (X >30)
                    {
                        row.Visible = true;
                        countrows();

                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                countrows();


            }

            if (searchitem.Text == "ALL")
            {
                foreach (DataGridViewRow row in stocklist.Rows)
                {
                  
                    row.Visible = true;
                  
                        countrows();
                    

                }
                countrows();

            }
        }

        private void stockalert_Click(object sender, EventArgs e)
        {
            searchitem.SelectedIndex = 1;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            searchitem.SelectedIndex = 3;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            searchitem.SelectedIndex = 1;
        }
    }
}
