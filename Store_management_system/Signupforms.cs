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
        SqlConnection connect = new SqlConnection(connectionstri.Value);

        public Signupforms()
        {
            InitializeComponent();
            this.userlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userlist.ColumnHeadersHeight = 40;
            
        //    rolechoose.BackColor = Color.Yellow;

            rolechoose.SelectedIndex = 1;
            adminoremployee.SelectedIndex = 2;
            see.Hide();
            hide.Hide();
            searchselect.SelectedIndex = 1;

            
          
            
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
                   
                    userlist.Rows.Add(sn, dataRow["userrole"], dataRow["e_id"], dataRow["username"], dataRow["password"]);
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void countrows()
        {
            int numrows = userlist.Rows.Count;
            countrow.Text = numrows.ToString();
            countrow.Text = "  " + countrow.Text;

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
                if (idtaken.Visible == true)
                {
                    valid = false;
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

                if(username.Text=="admin" || username.Text=="Admin")
                {
                    authorizederror.Visible = true;
                    valid = false;
                }
                else
                {
                    authorizederror.Visible = false;
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
                        string result = Messageboxok.ShowBox("", "Sign Up Successfully");
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
                if (username.Text == "admin" || username.Text == "Admin")
                {
                    authorizederror.Visible = true;
                    valid = false;
                }
                else
                {
                    authorizederror.Visible = false;
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
                        string result = Messageboxok.ShowBox("", "Sign Up Successfully");
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
            authorizederror.Visible = false;
        }

        private void cpassw_TextChanged(object sender, EventArgs e)
        {
            cpassw.UseSystemPasswordChar = true;
           
               
                if (passw.Text != cpassw.Text && cpassw.Text!=string.Empty )
                {
                    unmatched.Visible = true;
                    matched.Visible = false;

                }
                else if(passw.Text==cpassw.Text && cpassw.Text!=string.Empty)
                {

                    unmatched.Visible = false;
                    matched.Visible = true;
                }
            
        }

        private void passw_TextChanged(object sender, EventArgs e)
        {
            passw.UseSystemPasswordChar = true;
            
           
            if (passw.Text != cpassw.Text)
            {
                unmatched.Visible = true;
                matched.Visible = false;

            }
            else if (passw.Text == cpassw.Text && cpassw.Text != string.Empty)
            {

                unmatched.Visible = false;
                matched.Visible = true;
            }
            else if (passw.Text == string.Empty)
            {
                unmatched.Visible = false;
                matched.Visible = false;
            }
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
            authorizederror.Visible = false;
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

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                if (userlist.SelectedRows.Count > 0)
                {

                    //remove only single row
                    // employeelist.Rows.RemoveAt(employeelist.SelectedRows[0].Index);

                    //remove multiple rows
                    foreach (DataGridViewRow row in userlist.SelectedRows)
                    {
                        // int serial = Convert.ToInt32(row.Cells["sn"].Value);

                        string usern = Convert.ToString(row.Cells["usrname"].Value);

                        string query = "delete from login where username=@parameter_username";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@parameter_username",usern);

                        //      MessageBox.Show("Removed successfully");
                        string result = MyMessageBoxyesno.ShowBox("DELETE", "Do you want to delete?");
                        if (result.Equals("1"))
                        {
                            cmd.ExecuteNonQuery();

                            userlist.Rows.RemoveAt(row.Index);
                        }
                        if (result.Equals("2"))
                        {

                        }
                        //DialogResult dialog = MessageBox.Show("Do you really want to delete?", "Delete", MessageBoxButtons.YesNo);
                        //if (dialog == DialogResult.Yes)
                        //{
                        //    cmd.ExecuteNonQuery();
                        //    employeelist.Rows.RemoveAt(row.Index);
                        //}
                        //else
                        //{

                        //}
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

            displaydata();
        }

        private void userlist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (showpassw.Checked == false)
            {
                if (e.ColumnIndex == 4)
                {
                    if (e.Value != null)
                    {
                        e.Value = new String('●', e.Value.ToString().Length);

                    }
                }
            }

        }

        private void showpassw_CheckedChanged(object sender, EventArgs e)
        {
            adminoremployee_SelectedIndexChanged(sender, e);
            searchbox_TextChanged(sender, e);
        }

       
        private void combo1()
        {
            string query = "select * from login where userrole='" + adminoremployee.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            userlist.Rows.Clear();
            int sn = 1;
            foreach (DataRow dataRow in dt.Rows)
            {

                userlist.Rows.Add(sn, dataRow["userrole"], dataRow["e_id"], dataRow["username"], dataRow["password"]);
                sn++;

            }
            //countrows();


        }
        private void adminoremployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
               
            {
                
                if (adminoremployee.Text == "Admin")
                {
                    connect.Open();

                    combo1();
                    countrows();
                 
                }
                 else if(adminoremployee.Text=="Employee")
                {
                    connect.Open();
                    combo1();
                    countrows();
                    
                }
                else
                {
                    displaydata();
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

        private void cpassw_KeyDown(object sender, KeyEventArgs e)
        {
            if (cpassw.Text == string.Empty)
            {
                matched.Visible = false;
                unmatched.Visible = false;

            }


        }

        private void hide_Click(object sender, EventArgs e)
        {
            passw.UseSystemPasswordChar = false;
          
            hide.Hide();
            see.Show();
        }

        private void see_Click(object sender, EventArgs e)
        {
            passw.UseSystemPasswordChar = true;
            hide.Show();
            see.Hide();
        }

        private void passw_Enter(object sender, EventArgs e)
        {
           
            passw.Focus();
            hide.Show();
            see.Show();
     
        }

        private void passw_Leave(object sender, EventArgs e)
        {

            if (passw.Text == "")
            {

               
                passw.UseSystemPasswordChar = false;
                see.Hide();
                hide.Hide();

            }



        }

        private void unmatched_Click(object sender, EventArgs e)
        {

        }

        private void idtaken_Click(  object sender, EventArgs e)
        {

        }

       
        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (searchbox.Text == "")
                {
                    displaydata();
                }
                else if (searchselect.Text == "EID")
                {
                                        connect.Open();             
                    string query = "select * from login where e_id like '" + searchbox.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    userlist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {

                        userlist.Rows.Add(sn, dataRow["userrole"], dataRow["e_id"], dataRow["username"], dataRow["password"]);
                        sn++;

                    }
                    
                    connect.Close();


                 
                    countrows();


                }
                else if (searchselect.Text == "Username")
                {
                    
                    connect.Open();
                  
                    // string query = "select * from employee_details where e_fname,e_lname like '" + searchbox.Text + "%'";
                    string query = "Select * from login where username like'" + searchbox.Text + "%' ";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    userlist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        userlist.Rows.Add(sn, dataRow["userrole"], dataRow["e_id"], dataRow["username"], dataRow["password"]);
                        sn++;

                    }
                    connect.Close();
           
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
    }
    }



/*
 
*/