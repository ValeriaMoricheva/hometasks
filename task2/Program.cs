using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double h = 5;
            double res = a * a;
            double ress = res * Math.Sqrt(3.0);
            double square = ress / 4.0;

            Console.WriteLine("Если длина стороны правильного треугольника, лежащего в основании пирамиды равна " + a + ", а высота пирамиды равна " + h);
            Console.ReadLine();
            Console.WriteLine("то:");
            Console.ReadLine();

            Console.WriteLine("Площадь основания пирамиды равна:" + square);
            Console.ReadLine();

            double divide = square / 3;

            Console.WriteLine("Объем пирамиды равен:" + divide * h);
            Console.ReadLine();
        }
    }
}
