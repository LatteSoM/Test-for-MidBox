using FiguresLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"choise operation: \r\n " +
                $"1) Circle area \r\n" +
                $"2) Triangle are \r\n");

            int operation = Convert.ToInt32(Console.ReadLine());
            if (operation == 1)
            {
                Console.WriteLine("input radius");
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Area of Circle = {Figures.CircleArea(radius)}"); 
            }
            else
            {
                double a, b, c;
                Console.WriteLine("input side a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("input side b");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("input side c");
                c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Area of Triangle = {Figures.TriangleArea(a, b, c)}");
            }
        }
    }
}
