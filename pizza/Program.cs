using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var n = Convert.ToInt32(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("2");
            }

            else
            { 
            var array = new int[n + 1];
            array[1] = 2;
            array[2] = 4;
            if (n == 1 || n == 2)
            {
                Console.WriteLine( array[n].ToString());
            }
            else
            {
                for (int i = 3; i < n + 1; i++)
                {
                    array[i] = array[i - 1] + i;
                }
                
            }
            Console.WriteLine( array[n].ToString());
            }
            Console.ReadKey();
        }
    }
}
