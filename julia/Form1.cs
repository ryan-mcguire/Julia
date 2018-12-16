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
            double xmin, xmax, ymin, ymax;
            int imageWidth, imageHeight;

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

            Double.TryParse(textBoxXMin.Text, out xmin);
            Double.TryParse(textBoxXMax.Text, out xmax);
            Double.TryParse(textBoxYMin.Text, out ymin);
            Double.TryParse(textBoxYMax.Text, out ymax);

            Int32.TryParse(textBoxImageWidth.Text, out imageWidth);
            Int32.TryParse(textBoxImageHeight.Text, out imageHeight);

            Parameters p = new Parameters()
            {
                Transform = new double[3][]
                {
                    new double[4] { txcr, txci, txzr, txzi},
                    new double[4] { tycr, tyci, tyzr, tyzi},
                    new double[4] { t1cr, t1ci, t1zr, t1zi},
                },
                ImageHeight = imageHeight,
                ImageWidth = imageWidth,
                XMin = xmin,
                XMax = xmax,
                YMin = ymin,
                YMax = ymax
            };

            Bitmap bm = GenerateBitmap(p);

            Form2 form2 = new Form2();
            form2.SetForm1(this);
            form2.SetImageSize(bm.Width, bm.Height);
            form2.SetPic(bm);
            form2.Visible = true;
        }

        public Bitmap GenerateBitmap(Parameters p)
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

            int pixelWidth = p.ImageWidth;
            int pixelHeight = p.ImageHeight;
            int maxValue = 250;

            Bitmap b = new Bitmap(pixelWidth, pixelHeight);
            for (int xx = 0; xx < pixelWidth; xx++)
            {
                // How to map from xx: [0, pixelWidth] to x: [-2, 2]
                double x = p.GetXForXX(xx);

                for (int yy = 0; yy < pixelHeight; yy++)
                {
                    double y = p.GetYForYY(yy);

                    CAndZ cAndZ = p.GetCAndZForXAndY(x, y);

                    // Calculate the value for this pixel.
                    /////////////////////////////////////
                    int value = 0;

                    double cr = cAndZ.CR;
                    double ci = cAndZ.CI;
                    double zr = cAndZ.ZR;
                    double zi = cAndZ.ZI;

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
