using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0, y1 = 0;
            double x2 = 30, y2 =0 ;
            double x3 = 30, y3 = 40;

            double lado1 = CalcularLado(x1, y1, x2, y2);
            double lado2 = CalcularLado(x2, y2, x3, y3);
            double lado3 = CalcularLado(x3, y3, x1, y1);

            double perimetro = lado1 + lado2 + lado3;

            Console.WriteLine( "El perimetro es de " + perimetro );


            double semi = (lado1 + lado2 + lado3)/2;

            double area = Math.Sqrt(semi * (semi - lado1) * (semi - lado2) * (semi - lado3));
            Console.WriteLine("El área es " + area);
            Console.Read();
        }

        static double CalcularLado(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
