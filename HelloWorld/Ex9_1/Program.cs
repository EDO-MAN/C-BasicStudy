using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_1
{
    class NameCard
    {
        private int age;
        private string name;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameCard namecard = new NameCard();
            namecard.Age = 24;
            namecard.Name = "이도현";

            Console.WriteLine($"{namecard.Age}");
            Console.WriteLine($"{namecard.Name}");
        }
    }
}
