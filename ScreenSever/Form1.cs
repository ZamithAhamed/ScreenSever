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
        List<Image> BGImages = new List<Image>();
        List<BritPic> BritPics = new List<BritPic>();
        Random rand = new Random();

        class BritPic {
            public int PicNum;
            public float x;
            public float y;
            public float Speed;
        }


        public frmScrnSvr()
        {
            InitializeComponent();
        }

        private void FrmScrnSvr_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void FrmScrnSvr_Load(object sender, EventArgs e)
        {
            String[] images = System.IO.Directory.GetFiles("pics");

            foreach (String image in images) {
                BGImages.Add(new Bitmap(image));
            }

            for (int i = 0; i < 50; ++i) {
                BritPic mp = new BritPic();
                mp.PicNum = i % BGImages.Count;
                mp.x = rand.Next(0, Width);
                mp.y = rand.Next(0, Height);

                BritPics.Add(mp);

            }
        }
    }
}
