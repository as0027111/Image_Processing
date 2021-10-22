using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HW1
{
    class utilize
    {
        public static Bitmap registration(Bitmap b1, Bitmap b2, double theta, double scaling)
        {
            Bitmap result = new Bitmap(b1.Width, b1.Height);
            for (int y = 0; y < result.Height; y++)
                for (int x = 0; x < result.Width; x++)
                {
                    double new_x = ((x - b1.Width / 2) * Math.Cos(theta) - (y - b1.Height / 2) * Math.Sin(theta)) * scaling + (b2.Width / 2);
                    double new_y = ((x - b1.Width / 2) * Math.Sin(theta) + (y - b1.Height / 2) * Math.Cos(theta)) * scaling + (b2.Height / 2);
                    if (new_x < 0 || new_x + 1 > b2.Width || new_y < 0 || new_y + 1 > b2.Height)
                        result.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                    {
                        int magnitude = (int)(b2.GetPixel((int)new_x, (int)new_y).R);
                        result.SetPixel(x, y, Color.FromArgb(magnitude, magnitude, magnitude));
                    }
                }
            return result;
        }
        
        public static double Difference(Bitmap b1, Bitmap b2)
        {
            double difference_I = 0;
            for (int y = 0; y < b1.Height; y++)
                for (int x = 0; x < b2.Width; x++)
                {
                    difference_I += (b1.GetPixel(x, y).R - b2.GetPixel(x, y).R);
                }
            difference_I = difference_I / (b1.Height * b1.Width);
            return difference_I;
        }
    }
}
