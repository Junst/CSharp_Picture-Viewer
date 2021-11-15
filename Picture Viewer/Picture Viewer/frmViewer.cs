using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class frmViewer : Form
    {
        public frmViewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ofdSelectPicture_FileOk(object sender, CancelEventArgs e)
        {
          
        }

        private void picShowPicture_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {

            if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
            {
                
                ChildPicture objShowPicture = new ChildPicture();
                objShowPicture.BackgroundImage = Image.FromFile(ofdSelectPicture.FileName);
                objShowPicture.MdiParent = this;
                objShowPicture.Show();

            }
        }

        private void Quitbutton(object sender, EventArgs e)
        {
            this.Close();
        }
   
        private void btnDrawBorder_Click(object sender, EventArgs e)
        {
          
        }

   

        private void picShowPicture_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void picShowPicture_MouseLeave(object sender, EventArgs e)
        {
       
        }

     

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
            {
                frmShowPicture objShowPicture = new frmShowPicture();
                objShowPicture.BackgroundImage = Image.FromFile(ofdSelectPicture.FileName);
                objShowPicture.Show();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
