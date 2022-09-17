using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSever
{
    public partial class frmScrnSvr : Form
    {
        public frmScrnSvr()
        {
            InitializeComponent();
        }

        private void FrmScrnSvr_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }
}
