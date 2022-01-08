using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_management_system
{
    public partial class Employeewindow : Form
    {
        int panelWidth;
        bool isCollapsed;
        bool on = true;
        public Employeewindow()
        {
            InitializeComponent();
            panelWidth = panelleft.Width;
            isCollapsed = false;
        }
        private void AddControlsToPanel(Control C)
        {
            C.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(C);
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
                    

                }
            }
            else
            {
                panelleft.Width = panelleft.Width - 10;
                if (panelleft.Width <= 78)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu.Visible = true;

            button2.Visible = true;

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

        private void menu_Click(object sender, EventArgs e)
        {
            menu.Visible = true;

            button2.Visible = true;

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

                on = true;
                button2.Visible = false;
               
            }

        }

        private void emp_logout_Click(object sender, EventArgs e)
        {
           // employeerecords.Visible = false;
            moveSidePanel(emp_logout);
            //  moveSidePanel(button7);
            string result = MyMessageBoxyesno.ShowBox("CLOSE", "Do you want to sign out?");
            if (result.Equals("1"))
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            if(result.Equals("2"))
            {

            }
            
        }
        private void moveSidePanel(Control btn)
        {
            panelsides.Top = btn.Top;
            panelsides.Height = btn.Height;

        }

        private void emp_addproduct_Click(object sender, EventArgs e)
        {
            moveSidePanel(emp_addproduct);
            EMPaddproduct ap = new EMPaddproduct();
            AddControlsToPanel(ap);
        }
       
        private void emp_bill_Click(object sender, EventArgs e)
        {
         
            moveSidePanel(emp_bill);
            BillingSystem  bs  = new BillingSystem ();
            

            

           
            AddControlsToPanel(bs);
            
            
            


        }

        private void emp_cpass_Click(object sender, EventArgs e)
        {
            moveSidePanel(emp_cpass);
            ChangePassword  cp = new ChangePassword ();
            AddControlsToPanel(cp);
        }

        private void Employeewindow_Load(object sender, EventArgs e)
        {
         
            userusernamelabel.Text ="WELCOME:  "+ Form1.username;   
            userlabel.Text = "ROLE:  " + Form1.label;

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            EMPaddproduct ap = new EMPaddproduct();
            AddControlsToPanel(ap);
        }

        private void close_Click(object sender, EventArgs e)
        {
            //closes login window
            string result = MyMessageBoxyesno.ShowBox("CLOSE", "Do you want to exit the program?");
            if (result.Equals("1"))
            {
                Application.Exit();
            }
            if (result.Equals("2"))
            {
                //
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            //minimize login window
            this.WindowState = FormWindowState.Minimized;
            //textBox1.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stock_Click(object sender, EventArgs e)
        {
            moveSidePanel(stock);
            Stock st  = new Stock();
            AddControlsToPanel(st);

        }

       
    }
}
