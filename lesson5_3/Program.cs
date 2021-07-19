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
        ///<summary>
        ///Получение масивов байтов из строки
        ///</summary>
        ///<param name="line">Вводная строка</param>
        ///<param name="correctLine">Выходной флаг коректности строки</param>
        ///<returns>Возврвщает массив байтов из строки и флаг успешного преобразования</returns>
        
        static byte[] GetByteArray(string line , out bool correctLine)
        {
            var numbers = line.Split(' ');
            byte[] array = new byte[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isValid = byte.TryParse(numbers[i], out byte currentNum);
                if (isValid)
                {
                    array[i] = currentNum;
                    continue;
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то , попробуйте снова");
                    correctLine = false;
                    return array;
                }
            }
            correctLine = true;
            return array;
        }
    }
}
