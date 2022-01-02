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
    public partial class EMPaddproduct : UserControl
    {
        SqlConnection connect = new SqlConnection(connectionstri.Value);
        public EMPaddproduct()
        {
            InitializeComponent();
            itemlist.DefaultCellStyle.ForeColor = Color.Black;
           
            this.itemlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.itemlist.ColumnHeadersHeight = 40;
            //    this.employeelist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            itemlist.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
            itemlist.Columns[6].DefaultCellStyle.Format = "yyyy/MM/dd";
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)itemlist.Columns["Action"];
            c.FlatStyle = FlatStyle.Popup;
            c.DefaultCellStyle.ForeColor = Color.White;
            c.DefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);
            itemlist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);
            itemlist.RowTemplate.Height = 35;
            // employeelist.AllowUserToResizeRows = false;


            countrows();

            // em_dob.CustomFormat = "yyyy/MM/dd";

            itemlist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);



            this.itemlist.EnableHeadersVisualStyles = false;


            searchitem.SelectedIndex = 0;
            itemupdate.Enabled = false;
        }

        private void countrows()
        {
            int numrows = itemlist.Rows.Count;
            countrow.Text = numrows.ToString();
            countrow.Text = "  " + countrow.Text;

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
                itemlist.Rows.Clear();
                int sn = 1;
                foreach (DataRow dataRow in dt.Rows)
                {

                    itemlist.Rows.Add(sn, dataRow["i_id"], dataRow["i_category"], dataRow["i_brandname"], dataRow["i_name"], dataRow["i_mfddate"], dataRow["i_expdate"], dataRow["i_quantity"], dataRow["i_price"], "Edit");
                    sn++;

                }


                countrows();



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
            //  throw new NotImplementedException();
        }
       

        private void itemid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void itemquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void itemprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

       

       

        private void EMPaddproduct_Load(object sender, EventArgs e)
        {
            DisplayData();
           
            // this.employeelist.ColumnHeadersHeight = 80;

        }

       
        int item_id;
    
        private void itemlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == itemlist.Columns["Action"].Index)
            {

                itemupdate.Enabled = true;
                itemid.Enabled = false;
                label3.Enabled = false;
                string item_category = itemlist.CurrentRow.Cells["categorygv"].Value.ToString();
                string item_name = itemlist.CurrentRow.Cells["name"].Value.ToString();
                string item_mfddate = itemlist.CurrentRow.Cells["mfddategv"].Value.ToString();
                string item_expdate = itemlist.CurrentRow.Cells["expdate"].Value.ToString();
                item_id = Convert.ToInt32(itemlist.CurrentRow.Cells["id"].Value.ToString());
                string item_quantity = itemlist.CurrentRow.Cells["quantity"].Value.ToString();
                string item_price = itemlist.CurrentRow.Cells["price"].Value.ToString();
                string item_brandname = itemlist.CurrentRow.Cells["brandname"].Value.ToString();

                //   MessageBox.Show("Id: " + employee_id + "\nName: " + employee_name);
                string result = Messageboxok.ShowBox("", "Id: " + item_id + "\nName: " + item_name);
                 itemid.Text = item_id.ToString() ;
                itemcategory.Text = item_category;
                itemname.Text = item_name;
                mfddate.Text = item_mfddate;
                itemexpdate.Text = item_expdate;
                itemquantity.Text = item_quantity;
                itemprice.Text = item_price;
                itembn.Text = item_brandname;
                  itemid.Enabled = false;
                label3.Enabled = false;
                
                    idtaken.Visible = false;
                


            }
            else
            {

              




            }


        }
        private void display()
        {
            try
            {

                if (searchbox.Text == "")
                {
                    DisplayData();
                }
                else if (searchitem.Text == "ID")
                {
                    connect.Open();
                    string query = "select * from item_details where i_id like '" + searchbox.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    itemlist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {

                        itemlist.Rows.Add(sn, dataRow["i_id"], dataRow["i_category"], dataRow["i_brandname"], dataRow["i_name"], dataRow["i_mfddate"], dataRow["i_expdate"], dataRow["i_quantity"], dataRow["i_price"], "Edit");
                        sn++;

                    }
                     countrows();


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
                    itemlist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {
                       
                        itemlist.Rows.Add(sn, dataRow["i_id"], dataRow["i_category"], dataRow["i_brandname"], dataRow["i_name"], dataRow["i_mfddate"], dataRow["i_expdate"], dataRow["i_quantity"], dataRow["i_price"], "Edit");
                        sn++;

                    }
                        countrows();


                }
                else if (searchitem.Text == "NAME")
                {
                    connect.Open();
                    string query = "select * from item_details where i_name like '" + searchbox.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    itemlist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {

                        itemlist.Rows.Add(sn, dataRow["i_id"], dataRow["i_category"], dataRow["i_brandname"], dataRow["i_name"], dataRow["i_mfddate"], dataRow["i_expdate"], dataRow["i_quantity"], dataRow["i_price"], "Edit");
                        sn++;

                    }
                       countrows();



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


            private void searchbox_TextChanged(object sender, EventArgs e)
            {

                display();
            }

        

        private void itemadd_Click(object sender, EventArgs e)
        {
            if (itemname.Text == "" || itemid.Text == "" || itembn.Text == "" || itemquantity.Text == "" || itemprice.Text == "" || mfddate.Text == "" | itemexpdate.Text == "" || itemcategory.Text=="")
            {
                string result = Messageboxok.ShowBox("", "Please enter complete data");
            }
            else
            {
                try
                {
                    connect.Open();
                    string st_id = itemid.Text;
                    string st_icategory = itemcategory.Text;
                    string st_ibrandname = itemname.Text;
                    string st_iname = itembn.Text;
                    string st_imfd = mfddate.Text;
                    string st_iexp = itemexpdate.Text;
                    string st_iquantity = itemquantity.Text;
                    string st_iprice = itemprice.Text;


                    //string query = "Insert into student_details(name,address,Contact) values (" + namee + "," + Addresss +")";
                    string query = "Insert into item_details (i_id,i_category,i_brandname,i_name,i_mfddate,i_expdate,i_quantity,i_price) values (@parameter_id,@parameter_category,@parameter_brandname,@parameter_name,@parameter_mfddate,@parameter_expdate,@parameter_quantity,@parameter_price)";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@parameter_id", st_id);
                    cmd.Parameters.AddWithValue("@parameter_category", st_icategory);
                    cmd.Parameters.AddWithValue("@parameter_name", st_ibrandname);
                    cmd.Parameters.AddWithValue("@parameter_brandname", st_iname);
                    cmd.Parameters.AddWithValue("@parameter_mfddate", st_imfd);
                    cmd.Parameters.AddWithValue("@parameter_expdate", st_iexp);
                    cmd.Parameters.AddWithValue("@parameter_quantity", st_iquantity);
                    cmd.Parameters.AddWithValue("@parameter_price", st_iprice);



                    cmd.ExecuteNonQuery();
                    string result = Messageboxok.ShowBox("", "Data Added Successfully");
                    itemid.Text = "";
                    itembn.Text = "";
                    itemname.Text = "";
                    itemquantity.Text = "";
                    itemprice.Text = "";
                    searchbox.Text = "";
                    mfddate.Text = "";
                    itemexpdate.Text = "";
                    itemcategory.SelectedIndex = -1;
                    searchitem.SelectedIndex = -1;

                }
                catch (Exception )
                {
                   // MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connect.Close();
                }
                DisplayData();

            }
        }

        private void itemupdate_Click(object sender, EventArgs e)
        {
            itemupdate.Enabled = false;

            if (itemname.Text == "" || itembn.Text == "" || itemquantity.Text == "" || itemprice.Text == "" || mfddate.Text == "" | itemexpdate.Text == "")
            {
                string result = Messageboxok.ShowBox("", "Please enter complete data");
                return;

            }
            else
            {

                try
                {

                   


                        //open sql connection
                        connect.Open();

                        string st_id = itemid.Text;
                        string st_icategory = itemcategory.Text;
                        string st_ibrandname = itemname.Text;
                        string st_iname = itembn.Text;
                        string st_imfd = mfddate.Text;
                        string st_iexp = itemexpdate.Text;
                        string st_iquantity = itemquantity.Text;
                        string st_iprice = itemprice.Text;

                        //save data to database

                        //passing paramter method
                        string query = "Update item_details set i_id=@parameter_id,i_category=@parameter_category,i_name=@parameter_name, i_brandname=@parameter_brandname,i_mfddate=@parameter_mfddate,i_expdate=@parameter_expdate,i_quantity=@parameter_quantity,i_price=@parameter_price where i_id=@parameter_id";


                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@parameter_id", st_id);
                        cmd.Parameters.AddWithValue("@parameter_category", st_icategory);
                        cmd.Parameters.AddWithValue("@parameter_name", st_ibrandname);
                        cmd.Parameters.AddWithValue("@parameter_brandname", st_iname);
                        cmd.Parameters.AddWithValue("@parameter_mfddate", st_imfd);
                        cmd.Parameters.AddWithValue("@parameter_expdate", st_iexp);
                        cmd.Parameters.AddWithValue("@parameter_quantity", st_iquantity);
                        cmd.Parameters.AddWithValue("@parameter_price", st_iprice);
                        cmd.ExecuteNonQuery();
                        string result = Messageboxok.ShowBox("", "Updated Successfully");
                        itemid.Text = "";
                        itembn.Text = "";
                        itemname.Text = "";
                        itemquantity.Text = "";
                        itemprice.Text = "";
                        searchbox.Text = "";
                        mfddate.Text = "";
                        itemexpdate.Text = "";
                        itemcategory.SelectedIndex = -1;
                        searchitem.SelectedIndex = -1;


                    

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connect.Close();

                }

                DisplayData();
                itemid.Enabled = true;
                label3.Enabled = true;
            }
        }

        private void itemdelete_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                if (itemlist.SelectedRows.Count > 0)
                {

                    //remove only single row
                    // employeelist.Rows.RemoveAt(employeelist.SelectedRows[0].Index);

                    //remove multiple rows
                    foreach (DataGridViewRow row in itemlist.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["ID"].Value);

                        string query = "delete from item_details where i_id=@parameter_id";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@parameter_id", id);
                        int item_i = Convert.ToInt32(itemlist.CurrentRow.Cells["id"].Value.ToString());
                        //      MessageBox.Show("Removed successfully");
                        string result = MyMessageBoxyesno.ShowBox("DELETE", "Do you want to delete?"+"\nID No: " + item_i );
                        if (result.Equals("1"))
                        {
                            cmd.ExecuteNonQuery();

                            itemlist.Rows.RemoveAt(row.Index);
                        }
                        if (result.Equals("2"))
                        {

                        }

                    }


                    // serial no count from 1

                }
                else
                {
                    string result = Messageboxok.ShowBox("", "Please select a row to remove");
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

            DisplayData();
        }

        private void itemclear_Click(object sender, EventArgs e)
        {
            itemid.Text = "";
            itembn.Text = "";
            itemname.Text = "";
            itemquantity.Text = "";
            itemprice.Text = "";
            searchbox.Text = "";
            mfddate.Text = "";
            itemexpdate.Text = "";
            itemcategory.SelectedIndex = -1;          
            itemupdate.Enabled = false;
            itemid.Enabled = true;
            label3.Enabled = true;

        }

        private void itemid_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select i_id from item_details where i_id='" + itemid.Text + "'", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                idtaken.Visible = true;
                return;
            }
            else
            {
                //displaydata();
                idtaken.Visible = false;
            }
        }
    }
}
