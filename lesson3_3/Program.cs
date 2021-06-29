using System;

namespace lesson3_3
{
    class Program
    {
        enum Seasons
        {
            None = 0,
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }

        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца: ");
            int number;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 1 || number > 12)
                {
                    Console.Write("Ошибка. Введите число от 1 до 12: ");
                }
            } while (number < 1 || number > 12);
            Seasons seasons = GetSeason(number);
            Console.WriteLine("Время года: " + GetSeasonStr(seasons));

            Console.ReadKey();
        }
        static Seasons GetSeason(int number)
        {
            Seasons seasons = Seasons.None;
            switch (number)
            {
                case 12:
                case 1:
                case 2:
                    seasons = Seasons.Winter;
                    break;

                case 3:
                case 4:
                case 5:
                    seasons = Seasons.Spring;
                    break;

                case 6:
                case 7:
                case 8:
                    seasons = Seasons.Summer;
                    break;

                case 9:
                case 10:
                case 11:
                    seasons = Seasons.Autumn;
                    break;
            }
            return seasons;
        }

        static string GetSeasonStr(Seasons season)
        {
            string seasonStr = "";
            switch (season)
            {
                case Seasons.Winter:
                    seasonStr = "Зима";
                    break;

                case Seasons.Spring:
                    seasonStr = "Весна";
                    break;

                case Seasons.Summer:
                    seasonStr = "Лето";
                    break;

                case Seasons.Autumn:
                    seasonStr = "Весна";
                    break;
            }
            return seasonStr;
        }

    }
}
