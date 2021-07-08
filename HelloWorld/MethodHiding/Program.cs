using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class Item
    {
        public void Using()
        {
            Console.WriteLine("Item.Uinsg()");
        }

    }

    class Posion : Item
    {
        public void Using()
        {
            Console.WriteLine("Posion.Using()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Posion();
            item.Using();
        }
    }
}
