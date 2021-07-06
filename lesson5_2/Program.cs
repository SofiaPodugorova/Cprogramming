using System;

namespace lesson5_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            AppendTime();
        }

        private static void AppendTime()
        {
            using var sw = System.IO.File.AppendText("sturtup.txt");
            var time = DateTime.Now.ToString("HH:mm:ss");
            sw.WriteLine(time);
            Console.Write($"Добавлено новое время время : {time} в sturtup.txt");
        }
    }
}
