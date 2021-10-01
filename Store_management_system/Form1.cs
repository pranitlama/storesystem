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
        SqlConnection connect = new SqlConnection(connectionstri.Value);

        private Point mouseoffset;

        public Form1()
        {
            InitializeComponent();
            hide.Hide();
            see.Hide();
          

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            incorrecterror.Hide();
            entererror.Hide();
        }



        private void hide_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            // if (textBox2.UseSystemPasswordChar==false)
            // if (textBox2.PasswordChar == '\0')

            hide.Hide();
            //   see.BringToFront();
            //hide password
            //textBox2.UseSystemPasswordChar = true;
            // textBox2.PasswordChar = '•';
            see.Show();
            textBox2.Focus();



        }

        private void see_Click(object sender, EventArgs e)
        {
            //textBox2.UseSystemPasswordChar = false;
            //if(textBox2.UseSystemPasswordChar==true)
            //  if (textBox2.PasswordChar == '•')
            textBox2.UseSystemPasswordChar = false;
            // hide.BringToFront();
            //show password
            see.Hide();
            //textBox2.PasswordChar = '\0';

            hide.Show();
            textBox2.Focus();


        }

        private void mini_Click(object sender, EventArgs e)
        {
            //minimize login window
            this.WindowState = FormWindowState.Minimized;
            textBox1.Focus();
        }

        private void clos_Click(object sender, EventArgs e)
        {
            string result = MyMessageBoxyesno.ShowBox("CLOSE", "Do you want to exit the program");
            if (result.Equals("1"))
            {
                Application.Exit();
            }
            if (result.Equals("2"))
            {

            }
            //closes login window
            //DialogResult dialog = MessageBox.Show("Do you really want to exit the program?", "EXIT", MessageBoxButtons.YesNo);
            //if (dialog == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            // else if (dialog == DialogResult.No)
            //  {
            //     e.Cancel = true;
            // }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                incorrecterror.Hide();
                entererror.Hide();
            }

            textBox2.UseSystemPasswordChar = true;
            see.Show();
            //  textBox2.PasswordChar = '•';
            // if (textBox2.PasswordChar == '•')
            // {
            //   see.Show();

            //  }

        }

        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            entererror.Hide();
            incorrecterror.Hide();
            textBox1.Text = " Username";
            textBox2.Text = "Password";
        }
        //placeholder username
        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (textBox1.Text == " Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = " Username";
                textBox1.ForeColor = Color.Silver;
            }
        }
        //placeholder password
        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == "Password")
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

                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
                textBox2.UseSystemPasswordChar = false;
                see.Hide();
                hide.Hide();

            }
        }






        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseoffset = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseoffset.X, mouseoffset.Y);
                this.Location = mousePos;// to move the form to desired location

            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {


        }
        private bool mouseDown;
        private Point offset;
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void eadd_Click(object sender, EventArgs e)
        {

        }
        public static string username;
        public static string label;

        private void logins_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "Username" && textBox2.Text != "Password")
            {
                try
                {
  
                        connect.Open();
                    
                    string query = "Select * from login where username='" + textBox1.Text + "' and password = '" + textBox2.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, connect);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    int count = 0;
                    string userrole = string.Empty;
                   
                    if (textBox1.Text=="admin" && textBox2.Text=="admin")
                    {
                        string result = Messageboxok.ShowBox("", "Admin Login Successful");
                        username = textBox1.Text.ToUpper();

                        label = "ADMIN";
                        MainMenu mm = new MainMenu();
                        this.Hide();
                        mm.Show();
                       
                        

                    }
                        while (reader.Read())
                    {
                        count = count + 1;
                        userrole = reader["userrole"].ToString();
                    }
                    
                    if (count == 1)
                    {
                       // string result = Messageboxok.ShowBox("", "ADMIN Login Successful");
                     //  MessageBox.Show("Username and Password . . . is Correct", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //this.Hide();
                        if (userrole == "Admin")
                        {
                            //show admin window
                            //     MessageBox.Show("admin login");
                            string result = Messageboxok.ShowBox("", "Admin Login Successful");
                            username = textBox1.Text.ToUpper(); 
                                
                            label = "ADMIN";
                            MainMenu mm = new MainMenu();
                            this.Hide();
                            mm.Show();
                          
                            
                           

                        }
                      
                        else
                        {//show user window
                         string result = Messageboxok.ShowBox("", "Employee Login Successful");
                            username = textBox1.Text.ToUpper();
                                
                            label = "USER";
                            //   MessageBox.Show("employee login"); 
                            Employeewindow ew = new Employeewindow();
                            this.Hide();
                            ew.Show();
                        }
                    }
                    else
                    {
                        incorrecterror.Show();
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
                entererror.Show();
                incorrecterror.Hide();
            }
        }
    }
}

/*
 
*/