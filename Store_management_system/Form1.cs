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
   
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-NS3RPG2\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
       
        public Form1()
        {
            InitializeComponent();
            hide.Hide();
            see.Hide();
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text  != "")
            {
                

                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    string user_name = textBox1.Text;
                    string Pass_word = textBox2.Text;
                    

                    string query = "Select * from login where username='" + user_name + "' and password = '" + Pass_word + "'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("login successfully!!!");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        MainMenu f2 = new MainMenu();
                        f2.Show();//open main menu
                        Visible = false;//hide login form
                        
                    }
                    else
                    {
                        MessageBox.Show("Your Username or Password is incorrect, Please Try Again!!!", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "";
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
            else
            {
                MessageBox.Show("Please Enter Your Username and Password First!!!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
       
        private void hide_Click(object sender, EventArgs e)
        {
           
            if(textBox2.PasswordChar =='\0')
            {
                hide.Hide();
             //   see.BringToFront();
             //hide password
                textBox2.PasswordChar = '•';
                see.Show();
                textBox2.Focus();
              
                
            }
        }

        private void see_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '•')
            {
                // hide.BringToFront();
               //show password
                see.Hide();
                textBox2.PasswordChar = '\0';
                hide.Show();
                textBox2.Focus(); 
            }
                
        }

        private void mini_Click(object sender, EventArgs e)
        {
            //minimize login window
            this.WindowState = FormWindowState.Minimized;
            textBox1.Focus();
        }

        private void clos_Click(object sender, EventArgs e)
        {
            //closes login window
            DialogResult dialog = MessageBox.Show("Do you really want to exit the program?", "EXIT", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
           // else if (dialog == DialogResult.No)
          //  {
           //     e.Cancel = true;
           // }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar== '•')
            {
                see.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "username";
            textBox2.Text = "password";
        }
        //placeholder username
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="username" )
            {//comment
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "username";
                textBox1.ForeColor = Color.Silver;
            }
        }
        //placeholder password
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
            //placeholder       
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text  ="password" ;
                textBox2.ForeColor = Color.Silver;
            }
        }
    }
}
