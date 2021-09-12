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

        private void HomeUC_Load(object sender, EventArgs e)
        {
           
        }

     
    }
}
