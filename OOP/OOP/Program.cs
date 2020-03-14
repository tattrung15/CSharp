using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return "Person{name=" + "\"" + this.Name + "\"" + ", age=" + this.Age + "}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Trung", Age = 20};
            Console.WriteLine(person.ToString());
            person.Name = "Tat Trung";
            Console.WriteLine(person.Name + ":" + person.Age);
        }
    }
}
