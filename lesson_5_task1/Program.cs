using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла");
            var fileName = GenerateFileName();
            Console.WriteLine("Введите данные");
            var line = Console.ReadLine();

            if (System.IO.File.Exists(fileName))
            {
                if (NeedReCreateAFile())
                {
                    File.WriteAllText(fileName, line);
                    Console.WriteLine($"Файл {fileName} был перезаписан");
                }

                else
                {
                    File.AppendAllText(fileName, Environment.NewLine);
                    File.AppendAllText(fileName, line);
                    Console.WriteLine($"Данные добавлены в файл {fileName}");
                }
            }

            else
            {
                File.WriteAllText(fileName, line);
                Console.WriteLine($"Файл {fileName} с введеными данными был создан");
            }
            Console.ReadKey();
        }
        static bool NeedReCreateAFile()
        {
            while (true)
            {
                Console.WriteLine("Введите Д , чтобы добавить строку в файл , либо П,чтобы перезаписать файл полностью");
                    var choise = Console.ReadLine().ToUpper();
                switch (choise)
                {
                    case "Д":
                        return false;
                    case "П":
                        return true;
                    default:
                        Console.WriteLine("Некоректный ввод.");
                        break;
                }
            }
        }
        static string GenerateFileName()
        {
            var fileName = Console.ReadLine();
            var words = fileName.Split('.');
            return words[words.Length - 1] == "txt" ? fileName : fileName + ".txt";
        }
    }
}
