using System;
using System.IO;

namespace lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "bytes.bin";
            while (true)
            {
                Console.WriteLine("Введите числа от 0 до 225");
                var line = Console.ReadLine();
                byte[] array = GetByteArray(line, out bool correctLine);
                if (correctLine)
                {
                    File.WriteAllBytes(fileName, array);
                    break;
                }
           
            }
            Console.WriteLine($"Запись в файл {fileName}");
            Console.ReadKey();
        }

        private static byte[] GetByteArray(string line, out bool correctLine)
        {
            throw new NotImplementedException();
        }
    }
}
