using System;

namespace lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Четное");

            }
            else
            {
                Console.WriteLine("Не четное");
            }
        }
    }
}
