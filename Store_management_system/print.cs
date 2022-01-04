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
    public partial class print : Form
    {
        SqlConnection connect = new SqlConnection(connectionstri.Value);
        public print(double subtotal,double discount, double grandtotal)
        {
            InitializeComponent();
            display();
            printsubtotal.Text = subtotal.ToString() ;
            printdiscount.Text = discount.ToString();
            printgrandtotal.Text = grandtotal.ToString();
        }
        private void display()
        {
            try
            {
                connect.Open();
                string query = "Select * from  addcart";
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                printdis.Rows.Clear();

                foreach (DataRow dataRow in dt.Rows)
                {

                    printdis.Rows.Add(dataRow["a_id"], dataRow["a_name"], dataRow["a_quantity"], dataRow["a_prince"], dataRow["a_amt"]);


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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
            Graphics grp = printdisplay.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(printdisplay.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

          
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
    }
}
