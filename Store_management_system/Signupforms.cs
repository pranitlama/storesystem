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
    public partial class Signupforms : UserControl
    {
        SqlConnection connect = new SqlConnection(ConnectionString.Value);

        public Signupforms()
        {
            InitializeComponent();
            this.userlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userlist.ColumnHeadersHeight = 40;
           
         
         
            rolechoose.SelectedIndex = 1;
          
            
        }

        private void displaydata()
        {
            try
            {
                connect.Open();
                string query = "Select * from  login";
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                userlist.Rows.Clear();
                int sn = 1;
                foreach (DataRow dataRow in dt.Rows)
                {
                   
                    userlist.Rows.Add(sn, dataRow["userrole"], dataRow["e_id"], dataRow["username"], dataRow["password"],"Edit","Check");
                    sn++;

                }

                //countrows();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Signupforms_Load(object sender, EventArgs e)
        {
            userlist.RowTemplate.Height = 35;
            // employeelist.AllowUserToResizeRows = false;


 
            // em_dob.CustomFormat = "yyyy/MM/dd";

            userlist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);



            this.userlist.EnableHeadersVisualStyles = false;
            displaydata();
        }

        private void rolechoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolechoose.Text == "Admin")
            {
                idtaken.Visible = false;
                iderror.Visible = false;
                idno.Text = "";
                idno.Enabled = false;
                label2.Enabled = false;
            }
            else
            {
                idno.Enabled = true;
                label2.Enabled = true;
            }
        }
    

        private void signupbtn_Click(object sender, EventArgs e)
        {
          
            if (rolechoose.Text == "Employee")
            {
                if(idtaken.Visible==true)
                {
                    return;
                }
                if(unmatched.Visible==true)
                {
                    return;
                }
                SqlDataAdapter da = new SqlDataAdapter("Select username from login where username='" + username.Text + "'", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                var valid = true;
                if (dt.Rows.Count >= 1)
                {
                    usernameerror.Visible = true;
                    valid = false;
                }
                else
                {
                 //   displaydata();
                    usernameerror.Visible = false;
                }
                da = new SqlDataAdapter("Select e_id from employee_details where e_id='" + idno.Text + "'", connect);
                DataTable dts = new DataTable();
                da.Fill(dts);
                if (!(dts.Rows.Count >= 1))
                {
                    if (idno.Text != "")
                    {
                        iderror.Visible = true;
                        valid = false;
                    }

                }
                else
                {
                   // displaydata();
                    iderror.Visible = false;
                }
                

                if (!valid)
                {
                    return;
                }

                if (idno.Text == "" || username.Text == "" || passw.Text == "" || cpassw.Text == "")
                {
                    string result = Messageboxok.ShowBox("", "Please enter complete data");
                }
                else
                {
                    try
                    {
                        connect.Open();
                        string st_userrole = rolechoose.Text;
                        string st_username = username.Text;
                        string st_password = passw.Text;
                    
                        string query = "Insert into login (e_id,userrole,username,password) values (@parameter_id,@parameter_userrole,@parameter_username,@parameter_password)";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@parameter_id", idno.Text);
                        cmd.Parameters.AddWithValue("@parameter_userrole", st_userrole);
                        cmd.Parameters.AddWithValue("@parameter_username", st_username);
                        cmd.Parameters.AddWithValue("@parameter_password", st_password);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sign up successfully");
                        idno.Text = "";
                        username.Text = "";
                        passw.Text = "";
                        cpassw.Text = "";
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        connect.Close();
                    }
                    displaydata();
                    matched.Visible = false;
                    unmatched.Visible = false;
                }
            }


            ////for admin
            else
            {
               
                if (unmatched.Visible == true)
                {
                    return;
                }
                SqlDataAdapter da = new SqlDataAdapter("Select username from login where username='" + username.Text + "'", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                var valid = true;
                if (dt.Rows.Count >= 1)
                {
                    usernameerror.Visible = true;
                    valid = false;
                }
                else
                {
                    //displaydata();
                    usernameerror.Visible = false;
                }
                
                if (!valid)
                {
                    return;
                }

                if (username.Text == "" || passw.Text == "" || cpassw.Text == "")
                {
                    string result = Messageboxok.ShowBox("", "Please enter complete data");
                }
                else
                {
                    try
                    {
                        connect.Open();
                        string st_userrole = rolechoose.Text;
                        string st_username = username.Text;
                        string st_password = passw.Text;
                     
                        string query = "Insert into login (userrole,username,password) values (@parameter_userrole,@parameter_username,@parameter_password)";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        //cmd.Parameters.AddWithValue("@parameter_id", idno.Text);
                        cmd.Parameters.AddWithValue("@parameter_userrole", st_userrole);
                        cmd.Parameters.AddWithValue("@parameter_username", st_username);
                        cmd.Parameters.AddWithValue("@parameter_password", st_password);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sign up successfully");
                        //idno.Text = "";
                        username.Text = "";
                        passw.Text = "";
                        cpassw.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        connect.Close();
                    }
                    displaydata();
                    matched.Visible = false;
                    unmatched.Visible = false;
                }
            }
            
            
        }     
        private void username_TextChanged(object sender, EventArgs e)
        {
            usernameerror.Visible = false;
        }

        private void cpassw_TextChanged(object sender, EventArgs e)
        {
            cpassw.UseSystemPasswordChar = true;
            if (cpassw.Text == "")
            {
                unmatched.Visible = false;
                matched.Visible = false;
            }
            else
            {

            }
            if (passw.Text != cpassw.Text)
            {
                unmatched.Visible = true;
                matched.Visible = false;

            }
            else
            {
               
                unmatched.Visible = false;
                matched.Visible = true;
            }
        }

        private void cpassw_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cpassw_Leave(object sender, EventArgs e)
        {
          if(cpassw.Text=="")
            {
                unmatched.Visible = false;
                matched.Visible = false;
            }
        }

        private void passw_TextChanged(object sender, EventArgs e)
        {
            passw.UseSystemPasswordChar = true;
        }

        private void idno_TextChanged(object sender, EventArgs e)
        {
         
            iderror.Visible = false;
            idtaken.Visible = false;
            SqlDataAdapter da = new SqlDataAdapter("Select e_id from login where e_id='" + idno.Text + "'", connect);
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
                iderror.Visible = false;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            iderror.Visible = false;
            usernameerror.Visible = false;
            idtaken.Visible = false;
            username.Clear();
            passw.Clear();
            cpassw.Clear();
            idno.Clear();

            matched.Visible = false;
            unmatched.Visible = false;
            
        }

        private void idno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
    }



/*
  if (rolechoose.Text == "Employee")
           {
              
               {
                   MessageBox.Show("Please enter complete data");
               }
               SqlDataAdapter dar = new SqlDataAdapter("Select e_id from employee_details where e_id='" + idno.Text + "'", connect);
               DataTable dat = new DataTable();
               dar.Fill(dat);
               if (!(dat.Rows.Count >= 1))
               {
                   iderror.Visible = true;
               }
               else
               {
                   displaydata();
               }
               SqlDataAdapter daq = new SqlDataAdapter("Select username from login where username='" + username.Text + "'", connect);
               DataTable dt = new DataTable();
               daq.Fill(dt);
               if (dt.Rows.Count >= 1)
               {
                   usernameerror.Visible = true;
               }
               else
               {
                   displaydata();
               }
               if(passw.Text==cpassw.Text)
               {
                   passworderror.Visible = true;
               }
               else
               {
                   displaydata();
               }

               else
               {

                   try
                   {
                     
                   }

                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.ToString());
                   }
                   finally
                   {
                       connect.Close();
                   }
                   displaydata();
               }



           }

*/