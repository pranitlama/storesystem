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
            this.usernametxt.BackColor = Color.White;
            
            
       
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
                    string query = "Select * from login where username='" + usernametxt.Text + "' and password = '" + cptxt.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                   
                        if (dt.Rows.Count.ToString() == "1")
                        {
                            string querys = "update  login set password='" + nptxt.Text + "' where username= '" + usernametxt.Text + "'";
                        SqlCommand cmdsa = new SqlCommand(querys, connect);
                            cmdsa.ExecuteNonQuery();
                        string result = Messageboxok.ShowBox("", "Change Password");
                        cptxt.Text = "";
                            nptxt.Text = "";
                            conptxt.Text = "";

                        }
                        else
                        {
                        string result = Messageboxok.ShowBox("", "Incorrect Password");
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

        private void conptxt_TextChanged(object sender, EventArgs e)
        {
            conptxt.UseSystemPasswordChar = true;


            if (nptxt.Text != conptxt.Text && conptxt.Text != string.Empty)
            {
                unmatched.Visible = true;
                matched.Visible = false;

            }
            else if (nptxt.Text == conptxt.Text && conptxt.Text != string.Empty)
            {

                unmatched.Visible = false;
                matched.Visible = true;
            }

        }

        private void nptxt_TextChanged(object sender, EventArgs e)
        {
            nptxt.UseSystemPasswordChar = true;


            if (nptxt.Text != conptxt.Text)
            {
                unmatched.Visible = true;
                matched.Visible = false;

            }
            else if (nptxt.Text == conptxt.Text && conptxt.Text != string.Empty)
            {

                unmatched.Visible = false;
                matched.Visible = true;
            }
            else if (nptxt.Text==string.Empty)
            {
                unmatched.Visible = false;
                matched.Visible = false;
            }
        }

        private void conptxt_Leave(object sender, EventArgs e)
        {

        }

        private void nptxt_Enter(object sender, EventArgs e)
        {
            nptxt.Focus();
            hide.Show();
            see.Show();
        }

        private void nptxt_Leave(object sender, EventArgs e)
        {
            if (nptxt.Text == "")
            {


                nptxt.UseSystemPasswordChar = false;
                see.Hide();
                hide.Hide();

            }

        }

        private void conptxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (conptxt.Text == string.Empty)
            {
                matched.Visible = false;
                unmatched.Visible = false;

            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            nptxt.UseSystemPasswordChar = false;
            nptxt.Focus();
            hide.Hide();
            see.Show();
           
        }

        private void see_Click(object sender, EventArgs e)
        {
            nptxt.UseSystemPasswordChar = true;
            nptxt.Focus();
            hide.Show();
            see.Hide();
        }

        private void cphide_Click(object sender, EventArgs e)
        {
            cptxt.UseSystemPasswordChar = false;
            cptxt.Focus();
            cphide.Hide();
            cpsee.Show();
        }

        private void cpsee_Click(object sender, EventArgs e)
        {
            cptxt.UseSystemPasswordChar = true;
            cptxt.Focus();
            cphide.Show();
            cpsee.Hide();
        }

        private void cptxt_Enter(object sender, EventArgs e)
        {
            cptxt.Focus();
            cphide.Show();
            cpsee.Show();
        }

        private void cptxt_Leave(object sender, EventArgs e)
        {
            if (cptxt.Text == "")
            {


                cptxt.UseSystemPasswordChar = true;
                cpsee.Hide();
                cphide.Hide();

            }
        }

        private void cptxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
