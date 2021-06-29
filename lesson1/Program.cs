using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int age = 14;
            DateTime dateTime = DateTime.Now;
            string date = DateTime.Now.ToString();
            Console.WriteLine($"Hello, my name is {name}, age = {age} , time is {dateTime}");
            Console.ReadKey();
        }
    }
}
