using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    class Program
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        //열거형식 enum
        enum DialogResult
        {
            YES,
            NO,
            CANCEL,
            CONFIRM,
            OK
        }
        public static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            //2장 연습문제
            WriteLine("여러분 안녕하세요?");
            WriteLine("반갑습니다!");
            //5장 연습문제
            //for(int i = 0; i < 5; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Write("*");
            //    }
            //    WriteLine();
            //}
            //역계단
            //for (int i = 5; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Write("*");
            //    }
            //    WriteLine();
            //}
            int result = Fibonacci(5);
            WriteLine($"{result}");
            int a = 20;
            int b = 3;

            Divide(a, b, out int c, out int d);

            WriteLine($"a:{a}, b : {b}, a/b : {c}, a % b : {d}");

            int sum = Sum(3,4,5,6,7,8,9,10);

            WriteLine($"{sum}");
        }
        static int Sum(params int[] args)
        {
            Write("Summing...");

            int sum = 0;

            for(int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    Write(",");

                Write(args[i]);

                sum += args[i];
            }
            WriteLine();

            return sum;
        }
    }
}
