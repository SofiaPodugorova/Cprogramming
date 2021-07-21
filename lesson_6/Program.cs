using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для того чтобы вывести процессы нажмите 1");
            Console.WriteLine("Для завершения процесса по ID нажмите 2");
            Console.WriteLine("Для завершения по имени нажмите 3 ");
            Console.WriteLine("Для завершения работы нажмите 4");
            Console.WriteLine("Введите цифру от 1 до 4");
            var userNumber = Convert.ToInt32(Console.ReadLine());
            while (userNumber != 4)
            {
                switch(userNumber)
                {
                    case 1:
                        Process[] processList = Process.GetProcesses();
                        foreach (Process item in processList)
                        {
                            Console.WriteLine($"{item.Id} {item.ProcessName}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Введите имя процеса");
                        var name = Convert.ToInt32(Console.ReadLine());
                        
                        try
                        {
                            Process ToKillById = Process.GetProcessById(name);
                            ToKillById.Kill();
                            Console.WriteLine($"Процесс {ToKillById.ProcessName} (id: {ToKillById.Id} завершен");
                        }
                        catch(ArgumentException)
                        {
                            Console.WriteLine($"Процесса с идентификатиором {name} не обнаружено");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Введите имя процеса чтобы потом исользовать его для завершения процесса ");
                        var killname = Console.ReadLine();
                        Process[] killByName = Process.GetProcessesByName(killname);
                        if (killByName.Length > 0)
                        {
                            foreach (Process item in killByName)
                            {
                                item.Kill();
                                Console.WriteLine($"Процесс {item.ProcessName} (id{item.Id}) завершен");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Error. Процессов с названием {killname} нет");
                        }
                        break;
                    case 4:
                        Console.WriteLine("программа завершена");
                        break;
                    case 5:
                        Console.WriteLine("Числа должны быть от 1 до 4");
                        break;

                }
            }
            Console.ReadKey();

        }
    }
}
