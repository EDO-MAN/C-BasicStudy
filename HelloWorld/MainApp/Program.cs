using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MainApp
{
    class Cat
    {
        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        ~Cat()
        {
            WriteLine($"{Name} : 잘가");
        }
        public void Meow()
        {
            WriteLine($"{Name} : 야옹");
        }
        public string Name;
        public string Color;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat Kitty = new Cat("키티", "회색");
            Kitty.Meow();
            WriteLine($"{Kitty.Name} : {Kitty.Color}");

            Cat Nero = new Cat("네로", "검은색");
            Nero.Meow();
            WriteLine($"{Nero.Name} : {Nero.Color}");
        }
    }
    
}
