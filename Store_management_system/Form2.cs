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
    public partial class MainMenu : Form
    {
        int panelWidth;
        bool isCollapsed;
        bool on = true;
        public MainMenu()
        {
            InitializeComponent();
            panelWidth = panelleft.Width; 
            isCollapsed= false;
            if(Form1.username=="ADMIN")
            {
                changepassword.Enabled = false;
            }
           
        }

        private void AddControlsToPanel(Control C)
        {
            C.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(C);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           
            adminusernamelabel.Text = "WELCOME:  " + Form1.username;
            adminlabel.Text = "ROLE:  " + Form1.label;


            button2.Visible=false;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            HomeUC ue = new HomeUC();
            AddControlsToPanel(ue);


        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            moveSidePanel(button1);
            HomeUC  ue = new HomeUC();
            AddControlsToPanel(ue);


        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            
            moveSidePanel(changepassword);
            ChangePassword  cp = new ChangePassword();
            AddControlsToPanel(cp);
          
        }

        private void aemployee_Click(object sender, EventArgs e)
        {
            
            moveSidePanel(aemployee);
            Employee ue = new Employee();
            AddControlsToPanel(ue);
        }
       
        private void button7_Click(object sender, EventArgs e)//exit code
        {
           // employeerecords.Visible = false;
            moveSidePanel(button7);
            string result = MyMessageBoxyesno.ShowBox("CLOSE", "Do you want to sign out?");
            if (result.Equals("1"))
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            if (result.Equals("2"))
            {
              //  employeerecords.Visible = true;
            }
            //if (dialog == DialogResult.Yes)
            //{
            //    Form1 fm = new Form1();
            //    fm.Show();
            //    this.Hide();
            //}//
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if (isCollapsed)
            {
                panelleft.Width = panelleft.Width + 10;
                if (panelleft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                    //command accepted
                    //i am accepting the command

                }
            }
            else
            {
                panelleft.Width = panelleft.Width - 10;
                if(panelleft.Width<=75)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                 
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menu.Visible =true;
   
            button2.Visible=true;
            
            timer1.Start();
            if (on)
            {
                label1.Hide();
                //pictureBox1.Hide();
                on = false;
                
               
              
            }
            else
            {
                label1.Show();
               // pictureBox1.Show();
               //this is a comment
                on = true;
                button2.Visible = false;
                //comasdklfja
            }
            
        }
      

        private void moveSidePanel(Control btn)
        {
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
            
        }

        private void report_Click(object sender, EventArgs e)
        {
           
            moveSidePanel(report);
            Reports re  = new Reports ();
            AddControlsToPanel(re);
        }

        private void areport_Click(object sender, EventArgs e)
        {
            moveSidePanel(areport);
            Signupforms us = new Signupforms();
            AddControlsToPanel(us);
          
        }

        private void mini_Click(object sender, EventArgs e)
        {
            //minimize login window
            this.WindowState = FormWindowState.Minimized;
            //textBox1.Focus();
        }

        private void clos_Click(object sender, EventArgs e)
        {
            //closes login window
            string result = MyMessageBoxyesno.ShowBox("CLOSE", "Do you want to exit the program?");
            if (result.Equals("1"))
            {
                Application.Exit();
            }
            if (result.Equals("2"))
            {

            }

       
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
