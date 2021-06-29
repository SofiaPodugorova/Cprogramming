using System;

namespace lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите набор чисел, раздельнных пробелом: ");
            Console.WriteLine(GetSum(Console.ReadLine()));

            Console.ReadKey();
        }

        static int GetSum(string Input)
        {
            int sum = 0;

            string number = "";
            for (int i = 0; i <= Input.Length; i++)
            {
                if (i == Input.Length || Input[i] == ' ')
                {
                    if (number != "")
                    {
                        sum += Convert.ToInt32(number);
                        number = "";
                    }
                }
                else
                {
                    number += Input[i];
                }
            }
            return sum;
        }
    }
}
