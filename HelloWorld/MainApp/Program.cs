using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, mean);

            WriteLine($"{mean}");

        }
        public static void Mean(double a, double b, double c, double d, double e, double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
