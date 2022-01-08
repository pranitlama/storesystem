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
using System.IO;

namespace Store_management_system
{

    public partial class Employee : UserControl
    {
        SqlConnection connect = new SqlConnection(connectionstri.Value);

        public Employee()
        {

            InitializeComponent();
            this.employeelist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.employeelist.ColumnHeadersHeight = 40;
            //    this.employeelist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            employeelist.Columns[10].DefaultCellStyle.Format = "yyyy/MM/dd";
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)employeelist.Columns["Action"];
            c.FlatStyle = FlatStyle.Popup;
            c.DefaultCellStyle.ForeColor = Color.White;
            c.DefaultCellStyle.BackColor = Color.Navy;
          

            searchselect.SelectedIndex = 0;

            // employeelist.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;

            //DataGridViewButtonColumn c1 = (DataGridViewButtonColumn)employeelist.Columns["Action"];
            //c.FlatStyle = FlatStyle.Popup;
            //c.DefaultCellStyle.ForeColor = Color.Navy;
            //c.DefaultCellStyle.BackColor = Color.Yellow;





        }
        string employeegender;
       
        private void DisplayData()
        {


            try
            {
                connect.Open();
                string query = "Select * from  employee_details";
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                employeelist.Rows.Clear();
                int sn = 1;
                foreach (DataRow dataRow in dt.Rows)
                {
                     var fullname = $"{dataRow["e_fname"].ToString()} {dataRow["e_mname"].ToString()} {dataRow["e_lname"].ToString()}";
                    employeelist.Rows.Add(sn, dataRow["e_id"], dataRow["e_fname"], dataRow["e_mname"], dataRow["e_lname"], fullname, dataRow["e_address"], dataRow["e_pn"], dataRow["e_age"], dataRow["e_gender"], dataRow["e_dob"], dataRow["e_email"], "Edit",dataRow["filepath"]);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eadd_Click(object sender, EventArgs e)
        {
            if (validerror.Visible == true)
            {
                return;
            }
            else
            {
            }

            #region Phone Number Duplicate Check
            SqlDataAdapter da = new SqlDataAdapter("Select e_pn from employee_details where e_pn='" + em_pn.Text + "'", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            var valid = true;
            if (dt.Rows.Count >= 1)
            {
                pnerror.Visible = true;
                valid = false;
            }
            else
            {
                DisplayData();
                pnerror.Visible = false;

            }
            #endregion

            #region Email Duplicate Check
            da = new SqlDataAdapter("Select e_email from employee_details where e_email='" + em_email.Text + "'", connect);
            DataTable dts = new DataTable();
            da.Fill(dts);
            if (dts.Rows.Count >= 1)
            {
                emailerror.Visible = true;
                valid = false;
            }
            else
            {
                DisplayData();
                emailerror.Visible = false;
            }

            #endregion

            if (!valid)
            {
                return;
            }

            if (em_fname.Text == "" || em_lname.Text == "" || em_address.Text == "" || em_pn.Text == "" || employeegender == null || em_dob.Text == "" || em_age.Text == "" |em_email.Text == "" || filepathtext.Text=="")
            {
                string result = Messageboxok.ShowBox("", "Please enter complete data");
            }
            else
            {
                try
                {
                    connect.Open();
                    string st_fname = em_fname.Text;
                    string st_mname = em_mname.Text;
                    string st_lname = em_lname.Text;
                    string st_address = em_address.Text;
                    string st_pn = em_pn.Text;
                    string st_age = em_age.Text;
                    string st_dob = em_dob.Text;
                    string st_email = em_email.Text;


                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    string correctfilename = Path.GetFileName(open.FileName);
                    File.Copy(open.FileName, paths + "\\Images\\" + correctfilename);
                
                    
                    string query = "Insert into employee_details (e_fname,e_mname,e_lname,e_address,e_pn,e_age,e_gender,e_dob,e_email,filepath) values (@parameter_fname,@parameter_mname,@parameter_lname,@parameter_address,@parameter_pn,@parameter_age,@parameter_gender,@parameter_dob,@parameter_email,'\\Images\\"+correctfilename+"')";
                   

                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@parameter_fname", st_fname);
                    cmd.Parameters.AddWithValue("@parameter_mname", st_mname);
                    cmd.Parameters.AddWithValue("@parameter_lname", st_lname);
                    cmd.Parameters.AddWithValue("@parameter_address", st_address);
                    cmd.Parameters.AddWithValue("@parameter_pn", st_pn);
                    cmd.Parameters.AddWithValue("@parameter_age", st_age);
                    cmd.Parameters.AddWithValue("@parameter_gender", employeegender);
                    cmd.Parameters.AddWithValue("@parameter_dob", st_dob);
                    cmd.Parameters.AddWithValue("@parameter_email", st_email);
                    

                    cmd.ExecuteNonQuery();
                    string result = Messageboxok.ShowBox("", "Data Added Successfully");
                    em_fname.Text = "";
                    em_mname.Text = "";
                    em_lname.Text = "";
                    em_address.Text = "";
                    em_pn.Text = "";
                    em_age.Text = "";
                    em_dob.Text = "";
                    em_email.Text = "";
                    em_male.Checked = false;
                    em_female.Checked = false;
                    photo.Image = photo.InitialImage;
                    filepathtext.Text = "";
                }
                catch (Exception )
                {
                    string result = Messageboxok.ShowBox("","File Name Already Exists");
                 
                }
                finally
                {
                    connect.Close();
                }
                DisplayData();

            }

        }

        private void em_male_CheckedChanged(object sender, EventArgs e)
        {
            employeegender = "Male";
        }

        private void em_female_CheckedChanged(object sender, EventArgs e)
        {
            employeegender = "Female";
        }

        private void employeerecord_Load(object sender, EventArgs e)
        {
            employeelist.RowTemplate.Height = 35;
            // employeelist.AllowUserToResizeRows = false;


            DisplayData();
            // em_dob.CustomFormat = "yyyy/MM/dd";

            employeelist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 50, 94);



            this.employeelist.EnableHeadersVisualStyles = false;
            // this.employeelist.ColumnHeadersHeight = 80;


        }

        private void edelete_Click(object sender, EventArgs e)
        {
            //for remove single row if any cell is clicked
            //studentlist.Rows.RemoveAt(studentlist.CurrentRow.Index);
            try
            {
                connect.Open();
                if (employeelist.SelectedRows.Count > 0)
                {

                    //remove only single row
                    // employeelist.Rows.RemoveAt(employeelist.SelectedRows[0].Index);

                    //remove multiple rows
                    foreach (DataGridViewRow row in employeelist.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["eid"].Value);

                        string query = "delete from employee_details where e_id=@parameter_id;delete from login where e_id= @parameter_id";
                      
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@parameter_id", id);
                        int employee_i = Convert.ToInt32(employeelist.CurrentRow.Cells["eid"].Value.ToString());
                        string filepaths =  employeelist.CurrentRow.Cells["filepath"].Value.ToString();
                       

                        //      MessageBox.Show("Removed successfully");
                        string result = MyMessageBoxyesno.ShowBox("DELETE", "Do you want to delete?" + "\nID No: " +employee_i);
                        if (result.Equals("1"))
                        {
                            cmd.ExecuteNonQuery();
                            string paths = Application.StartupPath.Substring(0,(Application.StartupPath.Length - 10));
                            FileInfo file = new FileInfo(paths +filepaths);
                            if (File.Exists(paths + filepaths))
                            {
                                File.Delete(paths + filepaths);                          
                            }
                            else
                            {
                                 result = MyMessageBoxyesno.ShowBox("", "Image not Found");
                            }
                            employeelist.Rows.RemoveAt(row.Index);
                            
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

        private void label17_Click(object sender, EventArgs e)
        {

        }
        int employee_id;
  
        private void employeelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //int index = e.RowIndex;
            if (e.ColumnIndex == employeelist.Columns["Action"].Index)
            {

                eupdate.Enabled = true;
                string employee_fname = employeelist.CurrentRow.Cells["efname"].Value.ToString();
                string employee_mname = employeelist.CurrentRow.Cells["emname"].Value.ToString();
                string employee_lname = employeelist.CurrentRow.Cells["elname"].Value.ToString();
                string employee_name = employeelist.CurrentRow.Cells["ename"].Value.ToString();
                employee_id = Convert.ToInt32(employeelist.CurrentRow.Cells["eid"].Value.ToString());
                string employee_address = employeelist.CurrentRow.Cells["eaddress"].Value.ToString();
                string employee_pn = employeelist.CurrentRow.Cells["epn"].Value.ToString();
                string employee_gender = employeelist.CurrentRow.Cells["egender"].Value.ToString();
                string employee_age = employeelist.CurrentRow.Cells["eage"].Value.ToString();
                string employee_dob = employeelist.CurrentRow.Cells["edob"].Value.ToString();
                string employee_email = employeelist.CurrentRow.Cells["eemail"].Value.ToString();
                string photo_path = employeelist.CurrentRow.Cells["filepath"].Value.ToString();



                //for saving and getting only file name
                //  string path = Application.StartupPath + "\\uploadedimage\\" + photo_path;
                // for saving and getting file path
               // photo.Image = Image.FromFile(photo_path);
                //   MessageBox.Show("Id: " + employee_id + "\nName: " + employee_name);
                string result = Messageboxok.ShowBox("", "Id: " + employee_id + "\nName: " + employee_name);
                em_fname.Text = employee_fname;
                em_mname.Text = employee_mname;
                em_lname.Text = employee_lname;
                em_address.Text = employee_address;
                em_pn.Text = employee_pn;
                employeegender = employee_gender;
                em_age.Text = employee_age;
                em_dob.Text = employee_dob;
                em_email.Text = employee_email;
                filepathtext.Text = photo_path;

                SqlDataAdapter sda = new SqlDataAdapter("select * from employee_details where e_id='" + employee_id + "'", connect);
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                DataTable dt = new DataTable();
                sda.Fill(dt);

                photo.Image = Image.FromFile(paths + dt.Rows[0]["filepath"].ToString());


            }
            else
            {


                //employeelist.Rows[index].Selected = true;
                //employeelist.CurrentRow.Selected = true;
                //employeelist.CurrentRow.Selected
                //eupdate.Enabled = false;



            }
            


            }

        private void eclear_Click(object sender, EventArgs e)
        {
            eupdate.Enabled = false;

            em_fname.Text = "";
            em_mname.Text = "";
            em_lname.Text = "";
            em_address.Text = "";
            em_pn.Text = "";
            employeegender = "";
            em_age.Text = "";
            em_dob.Text = "";
            em_email.Text = "";
            em_male.Checked = false;
            em_female.Checked = false;
            pnerror.Visible = false;
            emailerror.Visible = false;
            photo.Image.Dispose();
            photo.Image = photo.InitialImage;
            filepathtext.Text = "";
         

        }

        private void eupdate_Click(object sender, EventArgs e)
        {
            if (validerror.Visible == true)
            {
                return;
            }
            else
            {
            }
            var phoneDuplicateCheckQuery = $"Select e_pn from employee_details where e_pn='{em_pn.Text}' and e_id != {employee_id}";
            SqlDataAdapter da = new SqlDataAdapter(phoneDuplicateCheckQuery, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                pnerror.Visible = true;
            }
            else
            {

                DisplayData();
                pnerror.Visible = false;
            }
            var emailDuplicateCheckQuery = $"Select e_email from employee_details where e_email='{em_email.Text}' and e_id != {employee_id}";

            SqlDataAdapter daa = new SqlDataAdapter(emailDuplicateCheckQuery, connect);
            DataTable dts = new DataTable();
            daa.Fill(dts);


            if (dts.Rows.Count >= 1)
            {
                emailerror.Visible = true;
            }
            else
            {
                DisplayData();
                emailerror.Visible = false;
            }

            if (em_fname.Text == "" || em_lname.Text == "" || em_address.Text == "" || em_pn.Text == "" || employeegender == null || em_dob.Text == "" || em_age.Text == "" || em_email.Text == "")
            {
                string result = Messageboxok.ShowBox("", "Please enter complete data");
                return;

            }
            else
            {

                try
                {

                    if (employee_id != 0)
                    {

                        //open sql connection
                        connect.Open();

                        string st_fname = em_fname.Text;
                        string st_mname = em_mname.Text;
                        string st_lname = em_lname.Text;
                        string st_address = em_address.Text;
                        string st_pn = em_pn.Text;
                        string st_age = em_age.Text;
                        string st_dob = em_dob.Text;
                        string st_email = em_email.Text;

                        //save data to database

                        //passing paramter method
                        string query = "Update employee_details set e_fname=@parameter_fname,e_mname=@parameter_mname,e_lname=@parameter_lname, e_address=@parameter_address,e_pn=@parameter_pn,e_age=@parameter_age,e_gender=@parameter_gender,e_dob=@parameter_dob,e_email=@parameter_email where e_id=@parameter_id";


                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@parameter_fname", st_fname);
                        cmd.Parameters.AddWithValue("@parameter_mname", st_mname);
                        cmd.Parameters.AddWithValue("@parameter_lname", st_lname);
                        cmd.Parameters.AddWithValue("@parameter_address", st_address);
                        cmd.Parameters.AddWithValue("@parameter_pn", st_pn);
                        cmd.Parameters.AddWithValue("@parameter_age", st_age);
                        cmd.Parameters.AddWithValue("@parameter_gender", employeegender);
                        cmd.Parameters.AddWithValue("@parameter_dob", st_dob);
                        cmd.Parameters.AddWithValue("@parameter_email", st_email);
                        cmd.Parameters.AddWithValue("@parameter_id", employee_id);
                        cmd.ExecuteNonQuery();
                        string result = Messageboxok.ShowBox("", "Updated Successfully");
                        employee_id = 0;
                        em_fname.Text = "";
                        em_mname.Text = "";
                        em_lname.Text = "";
                        em_address.Text = "";
                        em_pn.Text = "";
                        em_age.Text = "";
                        em_dob.Text = "";
                        em_email.Text = "";
                        em_male.Checked = false;
                        em_female.Checked = false;
                        eupdate.Enabled = false;
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


        }



        private void em_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void em_pn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void em_pn_TextChanged(object sender, EventArgs e)
        {
            validerror.Visible = false;
            pnerror.Visible = false;

        }

        private void em_email_TextChanged(object sender, EventArgs e)
        {
            emailerror.Visible = false;
        }

       

        private void em_pn_Validating(object sender, CancelEventArgs e)
        {
            if (em_pn.Text.Length == 10 || em_pn.Text == "")
            {
                validerror.Visible = false;
            }
            else
            {

                validerror.Visible = true;
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
                else if (searchselect.Text == "ID")
                {
                    connect.Open();
                    string query = "select * from employee_details where e_id like '" + searchbox.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    employeelist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        var fullName = $"{dataRow["e_fname"].ToString()} {dataRow["e_mname"].ToString()} {dataRow["e_lname"].ToString()}";
                        employeelist.Rows.Add(sn, dataRow["e_id"], dataRow["e_fname"], dataRow["e_mname"], dataRow["e_lname"], fullName, dataRow["e_address"], dataRow["e_pn"], dataRow["e_age"], dataRow["e_gender"], dataRow["e_dob"], dataRow["e_email"], "Edit");
                        sn++;

                    }
                    countrows();


                }
                else if (searchselect.Text == "Name")
                {
                    connect.Open();
                    // string query = "select * from employee_details where e_fname,e_lname like '" + searchbox.Text + "%'";
                    string query = "Select * from employee_details where e_fname like'" + searchbox.Text + "%' or e_lname like '" + searchbox.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    employeelist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        var fullName = $"{dataRow["e_fname"].ToString()} {dataRow["e_mname"].ToString()} {dataRow["e_lname"].ToString()}";
                        employeelist.Rows.Add(sn, dataRow["e_id"], dataRow["e_fname"], dataRow["e_mname"], dataRow["e_lname"], fullName, dataRow["e_address"], dataRow["e_pn"], dataRow["e_age"], dataRow["e_gender"], dataRow["e_dob"], dataRow["e_email"], "Edit");
                        sn++;

                    }
                    countrows();


                }
                else if (searchselect.Text == "Phone no")
                {
                    connect.Open();
                    string query = "select * from employee_details where e_pn like '" + searchbox.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    employeelist.Rows.Clear();
                    int sn = 1;
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        var fullName = $"{dataRow["e_fname"].ToString()} {dataRow["e_mname"].ToString()} {dataRow["e_lname"].ToString()}";
                        employeelist.Rows.Add(sn, dataRow["e_id"], dataRow["e_fname"], dataRow["e_mname"], dataRow["e_lname"], fullName, dataRow["e_address"], dataRow["e_pn"], dataRow["e_age"], dataRow["e_gender"], dataRow["e_dob"], dataRow["e_email"], "Edit");
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
        private void countrows()
        {
            int numrows = employeelist.Rows.Count;
            countrow.Text = numrows.ToString();
            countrow.Text = "  " + countrow.Text;

        }

        private void em_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void em_mname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void em_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void searchbox_Leave(object sender, EventArgs e)
        {


        }


        private void employeelist_SelectionChanged_1(object sender, EventArgs e)
        {
            //foreach (DataGridViewCell c in employeelist.CurrentRow.Cells)
            //    c.Selected = c.ColumnIndex != 12;
            //employeelist.Columns[5].Selected = false;
            //employeelist.Columns[0].doSelect = false;
        }

        private void employeelist_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employeelist_Leave(object sender, EventArgs e)
        {
            searchbox.Text = "";
        }

        private void check1_Click(object sender, EventArgs e)
        {
            if (employeelist.SelectedCells.Count>0)
            {
                employee_id = Convert.ToInt32(employeelist.CurrentRow.Cells["eid"].Value.ToString());
                string employee_name = employeelist.CurrentRow.Cells["efname"].Value.ToString();
                string employee_address = employeelist.CurrentRow.Cells["eaddress"].Value.ToString();
                string employee_dob = employeelist.CurrentRow.Cells["edob"].Value.ToString();
                //string result = Messageboxok.ShowBox("", "Id: " + employee_id);

                checkid cid = new checkid(employee_id,employee_name,employee_address,employee_dob);
                cid.ShowDialog();
                
            }
            else
            {
                string result = Messageboxok.ShowBox("", "Please select at least one data");
            }

        }

        OpenFileDialog open = new OpenFileDialog();
        private void chooseimage_Click(object sender, EventArgs e)
        {
       

            // open.Filter = "Image Files (*.png) |*.png | All Files(*.*) | *.*";
            open.Filter = "JPG Files(*jpeg)|*jpeg|PNG Files(*.png)|*png";

            open.FilterIndex = 1;
            if(open.ShowDialog()==DialogResult.OK)
            { 
                if(open.CheckFileExists)
                {
                    string path = Path.GetFileName(open.FileName);
                    filepathtext.Text = path;
                    photo.Image = new Bitmap(open.FileName);
                }
            }
          
            
              
            
        }

        private void em_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void searchselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void em_dob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


/*   //Filter images only
                // image matra lina dincha (*jpeg,*jpg,png);
                openFileDialog.Filter = "JPG Files(*jpeg)|*jpeg|PNG Files(*.png)|*png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                //imglocation = openFileDialog.FileName;
                ////imglocation = openFileDialog.FileName.ToString();
                ////photo.ImageLocation = imglocation;
                //photo.Image = new Bitmap(openFileDialog.FileName);


                string path= Path.GetFullPath(openFileDialog.FileName);
              
                photo.Image = new Bitmap(openFileDialog.FileName);
            }
                else
                {
                    MessageBox.Show("Closed File Dialog");
                }*/