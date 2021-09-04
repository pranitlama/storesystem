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
    public partial class Messageboxok : Form
    {
        static Messageboxok newsMessageBox;
        static string Buttin_ID;
        public Messageboxok()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point offset;
        public static string ShowBox(string txtMessage)
        {
            newsMessageBox = new Messageboxok();
            newsMessageBox.labelmessage.Text = txtMessage;
            newsMessageBox.ShowDialog();
            return Buttin_ID;
        }
        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newsMessageBox = new Messageboxok();
            newsMessageBox.labeltitle.Text = txtTitle;
            newsMessageBox.labelmessage.Text = txtMessage;
            newsMessageBox.ShowDialog();
            return Buttin_ID;
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            Buttin_ID = "1";
            newsMessageBox.Dispose();
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void toppanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
