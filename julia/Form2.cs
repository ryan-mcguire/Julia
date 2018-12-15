using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace julia
{
    public partial class Form2 : Form
    {
        Form1 ParentForm1 = null;
        public Form2()
        {
            InitializeComponent();
        }

        public void SetPic(Bitmap bm)
        {
            pictureBox1.Image = bm;
            this.Refresh();
        }

        public void SetForm1(Form1 form1)
        {
            this.ParentForm1 = form1;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ParentForm1 != null)
            {
                ParentForm1.ZoomInOn(e.X, e.Y);
            }
        }
    }
}
