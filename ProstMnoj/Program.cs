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
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            List<int> div = GetFactors(n);

            Console.Write("n=");
            for (int i = 0; i < div.Count - 1; i++)
                Console.Write("{0}*", div[i]);
            Console.WriteLine(div[div.Count - 1]);

            Console.ReadLine();
        }
        private void Factorize(int k)
        {
            int mult = 1;
            List<int> div = new List<int>();
            for (int i = 2; i <= Math.Floor(Math.Sqrt(k)); i++)
            {
                if (k % i == 0) 
                {
                    bool IsPrime = true;
                    foreach (int j in div)
                        if (i % j == 0) { IsPrime = false; break; }
                    if (IsPrime)
                    {
                        div.Add(i);
                        mult *= i;
                    }
                }
            }
            if (mult == 1) ;  
            else
            {
                int next = k / mult;
                if (next == 1) return;
                Factorize(next);
            }
        }
    }
}
