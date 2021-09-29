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
    public partial class Reports : UserControl
    {
        SqlConnection connect = new SqlConnection(connectionstri.Value);
        public Reports()
        {
            InitializeComponent();
            transactionlist.DefaultCellStyle.ForeColor = Color.Black;
            this.transactionlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.transactionlist.ColumnHeadersHeight = 40;
            //    this.employeelist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            transactionlist.Columns[6].DefaultCellStyle.Format = "yyyy/MM/dd";
            searchselect.SelectedIndex = 0;
            transactionlist.RowTemplate.Height = 35;
            // employeelist.AllowUserToResizeRows = false;



            // em_dob.CustomFormat = "yyyy/MM/dd";

            transactionlist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);



            this.transactionlist.EnableHeadersVisualStyles = false;

        }
        private void display()
        {
            try
            {
                connect.Open();
                string query = "Select * from  transaction_details";
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                transactionlist.Rows.Clear();
              
                foreach (DataRow dataRow in dt.Rows)
                {

                    transactionlist.Rows.Add(dataRow["t_id"], dataRow["t_empname"], dataRow["t_name"], dataRow["t_quantity"], dataRow["t_price"],dataRow["t_amt"],dataRow["t_date"]);
                    

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
        }
        private void countrows()
        {
            int numrows =transactionlist.Rows.Count;
            countrow.Text = numrows.ToString();
            countrow.Text = "  " + countrow.Text;

        }
        private void Reports_Load(object sender, EventArgs e)
        {
            display();
           
            // this.employeelist.ColumnHeadersHeight = 80;
        }
        private void displaydata()
        {
            try
            {

                if (searchbox.Text == "")
                {
                    display();
                }
                else if (searchselect.Text == "ID")
                {
                    connect.Open();
                    string query = "select * from transaction_details where t_id like '" + searchbox.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    transactionlist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {

                        transactionlist.Rows.Add(dataRow["t_id"], dataRow["t_empname"], dataRow["t_name"], dataRow["t_quantity"], dataRow["t_price"], dataRow["t_amt"], dataRow["t_date"]);
                        sn++;

                    }
                    countrows();


                }
                else if (searchselect.Text == "NAME")
                {
                    connect.Open();
                    // string query = "select * from employee_details where e_fname,e_lname like '" + searchbox.Text + "%'";
                    string query = "Select * from transaction_details where t_name like'" + searchbox.Text + "%' ";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    transactionlist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {

                        transactionlist.Rows.Add(dataRow["t_id"], dataRow["t_empname"], dataRow["t_name"], dataRow["t_quantity"], dataRow["t_price"], dataRow["t_amt"], dataRow["t_date"]);
                        sn++;

                    }
                    countrows();


                }
                else if (searchselect.Text == "EMPLOYEE NAME")
                {
                    connect.Open();
                    string query = "select * from transaction_details where t_empname like '" + searchbox.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    transactionlist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        transactionlist.Rows.Add(dataRow["t_id"], dataRow["t_empname"], dataRow["t_name"], dataRow["t_quantity"], dataRow["t_price"], dataRow["t_amt"], dataRow["t_date"]);
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
            displaydata();
        }

        private void searchselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void filter_Click(object sender, EventArgs e)
        {
            DateTime datefrom = Convert.ToDateTime(fromdate.Text);
            DateTime dateto = Convert.ToDateTime(todate.Text);
            if (datefrom <= dateto)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from transaction_details where t_date between '" + fromdate.Value.ToString() + "' and '" + todate.Value.ToString() + "'", connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                transactionlist.Rows.Clear();

                foreach (DataRow dataRow in dt.Rows)
                {

                    transactionlist.Rows.Add(dataRow["t_id"], dataRow["t_empname"], dataRow["t_name"], dataRow["t_quantity"], dataRow["t_price"], dataRow["t_amt"], dataRow["t_date"]);


                }
                countrows();
            }
            else
            {
                string result = Messageboxok.ShowBox("", "Invalid Date Difference");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            display();
            fromdate.Value = DateTime.Today;
        }

       
    }
}
