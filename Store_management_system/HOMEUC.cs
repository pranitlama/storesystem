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
    public partial class HomeUC : UserControl
    {
        SqlConnection connect = new SqlConnection(connectionstri.Value);
        public HomeUC()
        {
            InitializeComponent();
            displayinadminlabel();
            displayinuserlabel();
            displayintotalproductlabel();
            displayintotalorderlabel();
            displayintotalsaleslabel();
            displayinemplabel();

        }
        private void displayinadminlabel()
        {
            connect.Open();
            string query = "Select * from login where userrole='admin'";
            SqlCommand cmd = new SqlCommand(query, connect);  
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            connect.Close();
            if (ds.Tables[0].Rows.Count != 0)
            {
                admincount.Text = ds.Tables[0].Rows.Count.ToString();

            }
            else
            {
                admincount.Text = "0";
            }
           
        }

        private void displayintotalsaleslabel()
        {
            connect.Open();
            string query = "Select Sum(t_amt) from transaction_details";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            totalsaleslabel.Text = dt.Rows[0][0].ToString();
         
            connect.Close();
            
        }
        private void displayinuserlabel()
        {
            connect.Open();
            string query = "Select * from login where userrole='Employee'";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            connect.Close();
            if (ds.Tables[0].Rows.Count != 0)
            {
                usercount.Text = ds.Tables[0].Rows.Count.ToString();
            }
            else
            {
                usercount.Text = "0";
            }
        }
        private void displayintotalproductlabel()
        {
            connect.Open();
            string query = "Select * from item_details ";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            connect.Close();
            if (ds.Tables[0].Rows.Count != 0)
            {
                product_amt.Text = ds.Tables[0].Rows.Count.ToString();

            }
            else
            {
                product_amt.Text = "0";
            }


        }
        private void displayintotalorderlabel()
        {
            connect.Open();
            string query = "Select * from transaction_details ";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            connect.Close();
            if (ds.Tables[0].Rows.Count != 0)
            {
                order_amt.Text = ds.Tables[0].Rows.Count.ToString();

            }
            else
            {
                order_amt.Text = "0";
            }

        }
        private void HomeUC_Load(object sender, EventArgs e)
        {
           
        }
        private void displayinemplabel()
        {
            connect.Open();
            string query = "Select * from employee_details ";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            connect.Close();
            if (ds.Tables[0].Rows.Count != 0)
            {
               emp_no.Text = ds.Tables[0].Rows.Count.ToString();
            }
            else
            {
                emp_no.Text = "0";
            }
        }



    }
}
