using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    class Global
    {
        public static int Count = 0;
    }
    class A
    {
        public A()
        {
            Global.Count++;
        }
    }
    class B
    {
        public B()
        {
            Global.Count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global.Count : {Global.Count}");

            new A();
            new A();
            new B();
            new B();


            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}
