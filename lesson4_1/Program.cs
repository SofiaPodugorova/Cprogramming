using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            HashSet<string> myHash = new HashSet<string>();
            while (myHash.Count < 10_000)
            {
                string value = default;
                for (int j = 0; j < r.Next(5, 10); j++) value += ((char)r.Next('a', 'z')).ToString();
                myHash.Add(value);
            }
            //Замер HasSet
            Stopwatch stopWatch = Stopwatch.StartNew();
            foreach (var item in myHash)
            {
                if (item.Equals("abcderfdk"))
                {
                    break;
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string time = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds / 10}";
            Console.WriteLine("RunTime " + time);

        }
    }
}
