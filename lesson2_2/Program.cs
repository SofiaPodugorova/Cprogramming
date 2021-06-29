using System;

namespace lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц");
            if (Int32.TryParse(Console.ReadLine(), out int month))
            {
                switch (month)
                {
                    case 1:
                        Console.WriteLine("Январь");
                        break;

                    case 2:
                        Console.WriteLine("Февраль");
                        break;

                    case 3:
                        Console.WriteLine("Март");
                        break;

                    case 4:
                        Console.WriteLine("Апрель");
                        break;

                    case 5:
                        Console.WriteLine("Май");
                        break;

                    case 6:
                        Console.WriteLine("Июнь ");
                        break;

                    case 7:
                        Console.WriteLine("Июль");
                        break;

                    case 8:
                        Console.WriteLine("Август");
                        break;

                    case 9:
                        Console.WriteLine("Сентябрь");
                        break;

                    case 10:
                        Console.WriteLine("Октябрь");
                        break;

                    case 11:
                        Console.WriteLine("Ноябрь");
                        break;

                    case 12:
                        Console.WriteLine("Декабрь");
                        break;

                }

            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
            }

            Console.ReadKey();
        }



    }
}
