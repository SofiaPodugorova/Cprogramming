using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
            Console.WriteLine(GetFullName("София", "Подугорова", "Максимовна"));
            Console.WriteLine(GetFullName("Елена", "Григориева", "Константиновна"));
            Console.WriteLine(GetFullName("Иван", "Иванов", "Артемович"));

            Console.ReadKey();
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{patronymic} {firstName} {lastName}";
        }

    
    }
}
