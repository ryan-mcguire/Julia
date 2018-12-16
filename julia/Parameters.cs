using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace julia
{
    public class Parameters
    {
        public double[][] Transform { get; set; } = new double[3][]
        {
            new double[] { 1.000, 0.000, 0.000, 0.000 },
            new double[] { 0.000, 1.000, 0.000, 0.000 },
            new double[] { 0.000, 0.000, 0.000, 0.000 }
        };
        public double XMin { get; set; } = -2.000;
        public double XMax { get; set; } = 2.000;
        public double YMin { get; set; } = -2.000;
        public double YMax { get; set; } = 2.000;
        public int ImageWidth { get; set; } = 200;
        public int ImageHeight { get; set; } = 200;

        public CAndZ GetCAndZForXAndY(double x, double y)
        {
            return new CAndZ()
            {
                CR = Transform[0][0] * x + Transform[1][0] * y + Transform[2][0],
                CI = Transform[0][1] * x + Transform[1][1] * y + Transform[2][1],
                ZR = Transform[0][2] * x + Transform[1][2] * y + Transform[2][2],
                ZI = Transform[0][3] * x + Transform[1][3] * y + Transform[2][3]
            };
        }

        // Get the double x for a pixel coordinate x
        public double GetXForXX(int xx)
        {
            return (double)(xx * (XMax - XMin) / ImageWidth) + XMin;
        }

        // Get the double y for a pixel coordinate y
        public double GetYForYY(int yy)
        {
            return (double)(yy * (YMax - YMin) / ImageHeight) + YMin;
        }

        // In this case, x and y are pixel coordinates on the image.  No exception is thrown if they are outside the [0, ImageWidth or ImageHeight]
        public CAndZ GetCAndZForXAndY(int xx, int yy)
        {
            // First, convert xx and yy to x and y.
            double x = GetXForXX(xx);
            double y = GetYForYY(yy);

            return new CAndZ()
            {
                CR = Transform[0][0] * x + Transform[1][0] * y + Transform[2][0],
                CI = Transform[0][1] * x + Transform[1][1] * y + Transform[2][1],
                ZR = Transform[0][2] * x + Transform[1][2] * y + Transform[2][2],
                ZI = Transform[0][3] * x + Transform[1][3] * y + Transform[2][3]
            };
        }
    }
}
