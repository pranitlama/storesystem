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
    public partial class Required5 : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-JB605NC\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        public Required5()
        {
            InitializeComponent();
        }
        string employeegender;
        //int temp;
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
                    var fullName = $"{dataRow["e_fname"].ToString()} {dataRow["e_mname"].ToString()} {dataRow["e_lname"].ToString()}";
                    employeelist.Rows.Add(sn, dataRow["e_id"], dataRow["e_fname"], dataRow["e_mname"], dataRow["e_lname"] ,fullName, dataRow["e_address"], dataRow["e_pn"], dataRow["e_age"], dataRow["e_gender"], dataRow["e_dob"], dataRow["e_email"], "Edit");
                    sn++;

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
            //  throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eadd_Click(object sender, EventArgs e)
        {
           
            if (em_fname.Text != "" || em_lname.Text != "" ||em_address.Text!="" || em_pn.Text=="" || employeegender=="" ||em_dob.Text=="" || em_age.Text=="")
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


                    //string query = "Insert into student_details(name,address,Contact) values (" + namee + "," + Addresss +")";
                    string query = "Insert into employee_details (e_fname,e_mname,e_lname,e_address,e_pn,e_age,e_gender,e_dob,e_email) values (@parameter_fname,@parameter_mname,@parameter_lname,@parameter_address,@parameter_pn,@parameter_age,@parameter_gender,@parameter_dob,@parameter_email)";

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
                    MessageBox.Show("Data added successfully");
                    em_fname.Text = "";
                    em_mname.Text = "";
                    em_lname.Text = "";
                    em_address.Text = "";
                    em_pn.Text = "";
                    em_age.Text = "";
                    em_dob.Text = "";
                    em_email.Text = "";
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
            else
            {
                MessageBox.Show("Please enter complete data");
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
            DisplayData();
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

                        string query = "delete from employee_details where e_id=@parameter_id";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@parameter_id", id);


                        cmd.ExecuteNonQuery();
                        employeelist.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed successfully");
                    }


                    // serial no count from 1

                }
                else
                {
                    MessageBox.Show("Please select at least one row to Remove");
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
            eupdate.Enabled = true;
            int index = e.RowIndex;
            if (e.ColumnIndex == employeelist.Columns["Action"].Index)
            {
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
                MessageBox.Show("Id: " + employee_id + "\nName: " + employee_name);
                em_fname.Text = employee_fname;
                em_mname.Text = employee_mname;
                em_lname.Text = employee_lname;
                em_address.Text = employee_address;
                em_pn.Text = employee_pn;
                employeegender = employee_gender;
                em_age.Text = employee_age;
                em_dob.Text = employee_dob;
                em_email.Text = employee_email;

            }
            else
            {
                employeelist.Rows[index].Selected = true;
            }

        }

        private void eclear_Click(object sender, EventArgs e)
        {
            eupdate.Enabled = false;

            em_fname.Text = "";
            em_address.Text = "";
            em_pn.Text = "";
            employeegender = "";
        }

        private void eupdate_Click(object sender, EventArgs e)
        {

            eupdate.Enabled = false;
        }
        
        private void em_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar) || e.KeyChar==(char)Keys.Back || e.KeyChar==(char)Keys.Delete)) 
            {
                e.Handled = true;
            }
        }

        private void em_pn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar=='+' || e.KeyChar=='-'))
            {
                e.Handled = true;
            }
        }
    }
}
