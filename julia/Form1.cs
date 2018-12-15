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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRender_Click(object sender, EventArgs e)
        {
            double txcr, tycr, t1cr, txci, tyci, t1ci, txzr, tyzr, t1zr, txzi, tyzi, t1zi;

            Double.TryParse(textBoxXCR.Text, out txcr);
            Double.TryParse(textBoxYCR.Text, out tycr);
            Double.TryParse(textBox1CR.Text, out t1cr);
            Double.TryParse(textBoxXCI.Text, out txci);
            Double.TryParse(textBoxYCI.Text, out tyci);
            Double.TryParse(textBox1CI.Text, out t1ci);
            Double.TryParse(textBoxXZR.Text, out txzr);
            Double.TryParse(textBoxYZR.Text, out tyzr);
            Double.TryParse(textBox1ZR.Text, out t1zr);
            Double.TryParse(textBoxXZI.Text, out txzi);
            Double.TryParse(textBoxYZI.Text, out tyzi);
            Double.TryParse(textBox1ZI.Text, out t1zi);

            Bitmap bm = GenerateBitmap(txcr, tycr, t1cr, txci, tyci, t1ci, txzr, tyzr, t1zr, txzi, tyzi, t1zi);

            Form2 form2 = new Form2();
            form2.SetForm1(this);
            form2.SetPic(bm);
            form2.Visible = true;
        }

        protected Bitmap GenerateBitmap(double txcr, double tycr, double t1cr, double txci, double tyci, double t1ci, double txzr, double tyzr, double t1zr, double txzi, double tyzi, double t1zi)
        {
            Color[] colorScheme = new Color[]
            {
                Color.Blue,
                Color.Magenta,
                Color.Red,
                Color.Yellow,
                Color.Green,
                Color.Cyan
            };

            int pixelWidth = 200;
            int pixelHeight = 200;
            int maxValue = 100;

            Bitmap b = new Bitmap(pixelWidth, pixelHeight);
            for (int xx = 0; xx < pixelWidth; xx++)
            {
                // How to map from xx: [0, pixelWidth] to x: [-2, 2]
                double x = xx * 4.0 / pixelWidth + -2; 
                for (int yy = 0; yy < pixelHeight; yy++)
                {
                    double y = yy * 4.0 / pixelWidth + -2;

                    // Calculate the value for this pixel.
                    /////////////////////////////////////
                    int value = 0;

                    double cr = txcr * x + tycr * y + t1cr;
                    double ci = txci * x + tyci * y + t1ci;
                    double zr = txzr * x + tyzr * y + t1zr;
                    double zi = txzi * x + tyzi * y + t1zi;

                    while (zr*zr + zi*zi < 4)
                    {
                        value++;
                        if (value > maxValue)
                        {
                            value = 0;
                            break;
                        }
                        double tempzr = zr * zr - zi * zi + cr;
                        double tempzi = 2 * zi * zr + ci;
                        zr = tempzr;
                        zi = tempzi;
                    }
                    /////////////////////////////////////

                    // A value of 0 gets left as the background color.  Any other value is set to a colorScheme Color.
                    Color? clr = value == 0 ? (Color?)null : colorScheme[(value + 100) % colorScheme.Length];
                    if (clr.HasValue)
                    {
                        b.SetPixel(xx, yy, clr.Value);
                    } 

                }
            }
            return b;
        }

        protected void ZeroOutTextBoxes()
        {
            textBoxXCR.Text = "0.000";
            textBoxYCR.Text = "0.000";
            textBox1CR.Text = "0.000";
            textBoxXCI.Text = "0.000";
            textBoxYCI.Text = "0.000";
            textBox1CI.Text = "0.000";
            textBoxXZR.Text = "0.000";
            textBoxYZR.Text = "0.000";
            textBox1ZR.Text = "0.000";
            textBoxXZI.Text = "0.000";
            textBoxYZI.Text = "0.000";
            textBox1ZI.Text = "0.000";
        }
        private void buttonMandelbrot_Click(object sender, EventArgs e)
        {
            ZeroOutTextBoxes();
            textBoxXCR.Text = "1.000";
            textBoxYCI.Text = "1.000";
        }

        private void buttonJulia_Click(object sender, EventArgs e)
        {
            ZeroOutTextBoxes();
            textBoxXZR.Text = "1.000";
            textBoxYZI.Text = "1.000";
            textBox1CI.Text = "1.000";
        }

        public void ZoomInOn(int x, int y)
        {

        }
    }
}
