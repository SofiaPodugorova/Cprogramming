using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,]array = { { 1, 2 }, { 3,4} };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(j = 0;  j < array.GetLength(1);j++)
                {
                    if (i==j)
                    {
                        Console.WriteLine($"{array[i,j]}");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
