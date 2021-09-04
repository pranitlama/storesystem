
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
   
    public partial class MyMessageBoxyesno : Form
    {
        static MyMessageBoxyesno newMessageBox;
        static string Button_ID;
        public MyMessageBoxyesno()
        {
            InitializeComponent();
           

        }
        private bool mouseDown;
        private Point offset;
        public static string ShowBox(string txtMessage)
        {
            newMessageBox = new MyMessageBoxyesno();
            newMessageBox.lblmessage.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_ID;
        }
        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new MyMessageBoxyesno();
            newMessageBox.lbltitle.Text = txtTitle;
            newMessageBox.lblmessage.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_ID;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Button_ID = "1";
            newMessageBox.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Button_ID = "2";
            newMessageBox.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown==true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

    

       

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }
    }
}
