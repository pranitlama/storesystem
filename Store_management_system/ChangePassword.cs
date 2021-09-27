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
    public partial class ChangePassword : UserControl
    {
        SqlConnection connect = new SqlConnection(connectionstri.Value);
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            cptxt.Clear();
            conptxt.Clear();
            nptxt.Clear();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            usernametxt.Text = Form1.username ;
        }



        private void confirm_Click_1(object sender, EventArgs e)
        {
            if (cptxt.Text != "" || nptxt.Text != "" || conptxt.Text != "" )
            {

                try
                {
                    connect.Open();
                    string query = "select username from login where username = '" + usernametxt.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count.ToString()=="1")
                    {
                        string querys = "update  login set password='" + nptxt.Text + "' where username= '" + usernametxt.Text + "'";
                        SqlCommand cmds = new SqlCommand(querys, connect);
                        cmds.ExecuteNonQuery();
                        MessageBox.Show("password changed");
                        cptxt.Text = "";
                        nptxt.Text = "";
                        conptxt.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("incorrect");


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
            }
            else
            {
                MessageBox.Show("please enter all data");
            }
        
        }
    }
}
