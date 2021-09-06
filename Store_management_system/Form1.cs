﻿using System;
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
        //pranit
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-NS3RPG2\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        //samik
        //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-JB605NC\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        private Point mouseoffset;
        
        public Form1()
        {
            InitializeComponent();
            hide.Hide();
            see.Hide();
          //  System.Windows.Forms.Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            incorrecterror.Hide();
            entererror.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "Username" && textBox2.Text != "Password")
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
                        //MessageBox.Show("login successfull!!!");
                        string result = Messageboxok.ShowBox("","     Login Successful");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        MainMenu f2 = new MainMenu();
                        f2.Show();//open main menu
                        Visible = false;//hide login form

                    }
                    else
                    {
                        entererror.Hide();
                        incorrecterror.Show();
                        
                        //MessageBox.Show("Your Username or Password is incorrect, Please Try Again!!!", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "";
                        textBox2.Focus();
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
                //   MessageBox.Show("Please Enter Your Username and Password First!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            if (textBox2.Text != "")
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
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
            button1.BackColor = Color.White;
            button1.ForeColor = System.Drawing.Color.FromArgb(30, 50, 94);
           
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(30, 50, 94);
            button1.ForeColor = System.Drawing.Color.White;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                button1_Click(sender, e);
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

      
    }
}
