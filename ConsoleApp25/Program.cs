using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        public static double CalculateY()
        {
            double part1 = (15 + Math.Sqrt(8)) / (8 + Math.Sqrt(15));

            double part2 = (6 + Math.Sqrt(12)) / (12 + Math.Sqrt(6));

            double part3 = (7 + Math.Sqrt(21)) / (21 + Math.Sqrt(7));

            double y = part1 + part2 + part3;

            return y;
        }

        static void Main(string[] args)
        {
            double result = CalculateY();
            Console.WriteLine($"Значение y: {result}");
            Console.ReadKey();
        }
    }
}
