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
    public partial class checkid : Form
    {
        SqlConnection connect = new SqlConnection(connectionstri.Value);
      
        
       
        public checkid(int eid, string name,string add,string dob)
        {

            InitializeComponent();
            SqlDataAdapter sda = new SqlDataAdapter("select * from employee_details where e_id='" + eid + "'", connect);
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ephoto.Image=Image.FromFile(paths + dt.Rows[0]["filepath"].ToString());
            idlabel.Text = eid.ToString();
            namelabel.Text = name;
            addresslabel.Text = add;
            joineddatelabel.Text = dob;
        }
      
        private void buttonok_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
