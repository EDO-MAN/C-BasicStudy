using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInterface
{
    interface INameValue
    {
        string Name
        {
            get;
            set;
        }
        string Value
        {
            get;
            set;
        }
    }
    class NameValue : INameValue
    {
        public string Name
        {
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NameValue name = new NameValue()
            {
                Name = "이름",
                Value = "박상현"
            };

            NameValue heihgt = new NameValue()
            {
                Name = "키",
                Value = "177cm"
            };

            NameValue weight = new NameValue()
            {
                Name = "몸무게",
                Value = "90kg"
            };
            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{heihgt.Name} : {heihgt.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}
