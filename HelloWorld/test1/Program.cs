using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class A
    {
        public void test1()
        {
            Console.WriteLine("A");
        }
    }
    class B
    {
        public void test2()
        {
            Console.WriteLine("B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.test1();
            B b = new B();
            b.test2();
        }
    }
}
