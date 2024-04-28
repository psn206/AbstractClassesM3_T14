using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка");
            Dog dog = new Dog("Шарик", "Тяф");

            cat.ShowInfo();
            Console.WriteLine();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
