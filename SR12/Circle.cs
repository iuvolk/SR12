using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR12
{
    static class Circle
    {
        static public double GetSquare(double r)
        {
            return Math.PI * r * r;
        }
        static public double GetLenght(double r)
        {
            return 2 * Math.PI * r;
        }
        static public void CheckCoordinates(double x0, double y0, double x, double y, double r, out bool a)
        {

            if (Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2)) > r)
            {
                a = false;
            }
            else
            {
                a = true;
            }



        }
    }
}
