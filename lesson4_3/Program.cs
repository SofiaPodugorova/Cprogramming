using System;

namespace lesson4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //обратное слово
            string line = Console.ReadLine();
            for (int i = line.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(line[i]);
            }
        }
    }
}
