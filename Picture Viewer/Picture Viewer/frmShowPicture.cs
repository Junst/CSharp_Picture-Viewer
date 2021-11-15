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
    public partial class frmShowPicture : Form
    {
        public frmShowPicture()
        {
            InitializeComponent();
        }

        private void frmShowPicture_Load(object sender, EventArgs e)
        {

        }

        private void frmShowPicture_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
