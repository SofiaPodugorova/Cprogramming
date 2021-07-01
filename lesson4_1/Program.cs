using System;

namespace lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = {
                { "Елена", "+38058417895" }, 
                { "Даша", "+380564211445" },
                { "Виталина", "+380585462445" }, 
                { "Дмитрий", "+380556891445" }, 
                { "Иван", "+380575861445" }};
            Console.WriteLine("Телефонный спрвочник : ");
            for (int i = 0;i< array.GetLength(0);i++)
            {
                Console.WriteLine($"{array[i, 0]},{array[i, 1]}");
            }
        }
    }
}
