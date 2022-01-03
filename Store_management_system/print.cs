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
    public partial class print : Form
    {
        SqlConnection connect = new SqlConnection(connectionstri.Value);
        public print()
        {
            InitializeComponent();
            display();
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
                printdis.Rows.Clear();

                foreach (DataRow dataRow in dt.Rows)
                {

                    printdis.Rows.Add(dataRow["t_id"], dataRow["t_name"], dataRow["t_quantity"], dataRow["t_price"], dataRow["t_amt"]);


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
    }
}
