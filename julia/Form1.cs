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
        Form2 MyForm2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void buttonRender_Click(object sender, EventArgs e)
        {
            RenderFromForm();
        }

        protected void RenderFromForm()
        {
            Parameters p = GetParametersFromForm();

            Bitmap bm = GenerateBitmap(p);

            if (MyForm2 == null)
            {
                MyForm2 = new Form2();
            }
            MyForm2.SetForm1(this);
            MyForm2.SetImageSize(bm.Width, bm.Height);
            MyForm2.SetPic(bm);
            MyForm2.Visible = true;
        }

        protected Parameters GetParametersFromForm()
        {
            double txcr, tycr, t1cr, txci, tyci, t1ci, txzr, tyzr, t1zr, txzi, tyzi, t1zi;
            double xmin, xmax, ymin, ymax;
            int imageWidth, imageHeight;
            int maxIterations;

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
            Int32.TryParse(textBoxMaxIterations.Text, out maxIterations);

            return new Parameters()
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
                YMax = ymax,
                MaxValue = maxIterations
            };
        }

        public void PutParametersInForm(Parameters p)
        {
            textBoxXCR.Text = p.Transform[0][0].ToString();
            textBoxYCR.Text = p.Transform[1][0].ToString();
            textBox1CR.Text = p.Transform[2][0].ToString();
            textBoxXCI.Text = p.Transform[0][1].ToString();
            textBoxYCI.Text = p.Transform[1][1].ToString();
            textBox1CI.Text = p.Transform[2][1].ToString();
            textBoxXZR.Text = p.Transform[0][2].ToString();
            textBoxYZR.Text = p.Transform[1][2].ToString();
            textBox1ZR.Text = p.Transform[2][2].ToString();
            textBoxXZI.Text = p.Transform[0][3].ToString();
            textBoxYZI.Text = p.Transform[1][3].ToString();
            textBox1ZI.Text = p.Transform[2][3].ToString();

            textBoxXMin.Text = p.XMin.ToString();
            textBoxXMax.Text = p.XMax.ToString();
            textBoxYMin.Text = p.YMin.ToString();
            textBoxYMax.Text = p.YMax.ToString();

            textBoxImageWidth.Text = p.ImageWidth.ToString();
            textBoxImageHeight.Text = p.ImageHeight.ToString();
            textBoxMaxIterations.Text = p.MaxValue.ToString();


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

            Bitmap b = new Bitmap(pixelWidth, pixelHeight);
            for (int xx = 0; xx < pixelWidth; xx++)
            {
                progressBar1.Value = xx * 100 / pixelWidth;
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
                        if (value > p.MaxValue)
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
            textBox1CI.Text = "0.636";
        }

        public void ZoomInOn(int xx1, int yy1, int xx2, int yy2)
        {
            Parameters p = GetParametersFromForm();

            // In case of just a click on a single point, zoom in on a small area around that point.
            if (xx1 == xx2 && yy1 == yy2)
            {
                int xZoomSize = p.ImageWidth / 10;
                int yZoomSize = p.ImageHeight / 10;
                xx1 -= xZoomSize;
                xx2 += xZoomSize;
                yy1 -= yZoomSize;
                yy2 += yZoomSize;
            }

            if (xx1 == xx2)
            {
                xx2 = xx1 + 1;
            }
            else if (xx2 < xx1)
            {
                int temp = xx1;
                xx1 = xx2;
                xx2 = temp;
            }

            if (yy1 == yy2)
            {
                yy2 = yy1 + 1;
            }
            else if (yy2 < yy1)
            {
                int temp = yy1;
                yy1 = yy2;
                yy2 = temp;
            }

            p.XMin = p.GetXForXX(xx1);
            p.YMin = p.GetYForYY(yy1);
            p.XMax = p.GetXForXX(xx2);
            p.YMax = p.GetYForYY(yy2);

            PutParametersInForm(p);
            RenderFromForm();
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            Parameters p = GetParametersFromForm();

            p.XMin = p.GetXForXX(-p.ImageWidth);
            p.XMax = p.GetXForXX(p.ImageWidth * 2);
            p.YMin = p.GetYForYY(-p.ImageHeight);
            p.YMax = p.GetYForYY(p.ImageHeight * 2);

            PutParametersInForm(p);
            RenderFromForm();

        }
    }
}
