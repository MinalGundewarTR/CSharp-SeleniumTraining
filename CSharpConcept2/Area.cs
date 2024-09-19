using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.Formule
{
    public class Area
    {
        public double AreaOfCircle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }
        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public static double AreaOfTriangle(double b, double h)
        {
            double areaTriangle = 0.5 * b * h;
            return areaTriangle;
        }

        public static string GetAutherName()
        {
            return "Minal Gundewar";
        }
    }
}
