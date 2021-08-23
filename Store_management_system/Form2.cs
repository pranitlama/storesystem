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
    public partial class MainMenu : Form
    {
        int panelWidth;
        bool isCollapsed; 
        public MainMenu()
        {
            InitializeComponent();
            panelWidth = panelleft.Width; 
            isCollapsed= false;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
           int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0,0);
            this.Size = new Size(w,h);
           
         }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(button1); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            moveSidePanel(button6);
        }

        private void aemployee_Click(object sender, EventArgs e)
        {
            moveSidePanel(aemployee);

        }

        private void button7_Click(object sender, EventArgs e)//exit code
        {
            moveSidePanel(button7);
            DialogResult dialog = MessageBox.Show("Do you really want to exit the program?", "EXIT", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
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
                if(panelleft.Width<=74)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        private void moveSidePanel(Control btn)
        {
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
            
        }

        private void astock_Click(object sender, EventArgs e)
        {
            moveSidePanel(astock);
        }

        private void areport_Click(object sender, EventArgs e)
        {
            moveSidePanel(areport);
        }
    }
}
