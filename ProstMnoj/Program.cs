using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstMnoj
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty;
            int b, c, n;

            Console.WriteLine("Введите номер ");
            if (!int.TryParse(Console.ReadLine(), out n)) return;

            while ((n % 2) == 0)
            {
                n = n / 2;
                s += "2*";
            }
            b = 3; c = (int)Math.Sqrt(n) + 1;
            while (b < c)
            {
                if ((n % b) == 0)
                {
                    if (n / b * b - n == 0)
                    {
                        s += b.ToString() + "*";
                        n = n / b;
                        c = (int)Math.Sqrt(n) + 1;
                    }
                    else
                        b += 2;
                }
                else
                    b += 2;
            }
            s += n.ToString();
            Console.WriteLine(s);
            Console.ReadKey(true);
        }
    }
}
