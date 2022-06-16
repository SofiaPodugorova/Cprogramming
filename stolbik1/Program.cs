using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stolbik1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberOne = Console.ReadLine() ;
            string numberTwo = Console.ReadLine();

            Console.WriteLine(Sub(numberOne, numberTwo));
            Console.ReadKey();
        }
        private static string Sub(string numberOne, string numberTwo)
        {
            StringBuilder s = new StringBuilder();

            numberTwo = new string(numberTwo.Reverse().ToArray());
            numberOne = new string(numberOne.Reverse().ToArray());


            int i = 0;
            int nextPosition = 0;
            while (i < numberOne.Length || i < numberTwo.Length)
            {
                int digit = 0;
                if (i < numberOne.Length)
                {
                    digit += numberOne[i] - '0';
                }

                if (i < numberTwo.Length)
                {
                    digit += numberTwo[i] - '0';
                }

                digit += nextPosition;

                s.Append(digit % 10);

                nextPosition = digit / 10;

                i++;
            }
            if (nextPosition != 0)
            {
                s.Append(nextPosition);
            }

            return new string(s.ToString().Reverse().ToArray());
        }
    }
}
