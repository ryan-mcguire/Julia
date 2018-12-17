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
        int MouseDownX = 0;
        int MouseDownY = 0;

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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownX = e.X;
            MouseDownY = e.Y;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (ParentForm1 != null)
            {
                ParentForm1.ZoomInOn(MouseDownX, MouseDownY, e.X, e.Y);
            }
        }

        public void SetImageSize(int width, int height)
        {
            int extraWidth = this.Width - pictureBox1.Width;
            int extraHeight = this.Height - pictureBox1.Height;

            pictureBox1.Width = width;
            pictureBox1.Height = height;
            this.Width = width + extraWidth;
            this.Height = height + extraHeight;
        }
    }
}
