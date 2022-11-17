using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты центра окружности x0, y0");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки x, y");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());


            double s = Circle.GetSquare(r);
            double l = Circle.GetLenght(r);

            bool a;
            Circle.CheckCoordinates(x0, y0, x, y, r, out a);

            Console.WriteLine($"Площадь круга {s} \nДлина окружности {l} \nПринадлежность точки окружности {a}");
            Console.ReadKey();
        }
    }
}
