using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtension;

namespace MyExtension
{
    public static class IntegerExtension 
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
            {
                result *= myInt;
            }
            return result;
        }
        public static string Append(this string myString, string exponent)
        {
            return myString + exponent;
        }
    }
}

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");
            Console.WriteLine(hello.Append(",World!"));
        }
    }
}
