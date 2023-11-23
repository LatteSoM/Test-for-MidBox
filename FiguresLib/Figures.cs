using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Figures
    {
        public static double CircleArea(double _radius)
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }

        public static double TriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
        }
    }
}
