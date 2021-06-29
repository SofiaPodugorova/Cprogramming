using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру");
            var min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру");
            var max = Convert.ToInt32(Console.ReadLine());
            int avarange = (min + max) / 2;
            Console.WriteLine($"вот {avarange}");
        }
    }
}
