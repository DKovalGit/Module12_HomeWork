using System;
using System.Collections.Generic;
using System.Threading;

namespace Module12_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            SetConsoleRus();
            List<User> Users = GetUsersFromDB();
            foreach (User user in Users)
            {
                Console.WriteLine($"{user.Name}, добрый день!");
                if (!user.IsPremium)
                {
                    ShowAds();
                }
            }
            Console.ReadKey();
        }
        static void SetConsoleRus()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.Unicode;
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
        static List<User> GetUsersFromDB()
        {
            return new List<User>()
            {
                new User("Login1", "Иван", false),
                new User("Login2", "Фёдор", false),
                new User("Login3", "Дмитрий", true)
            };
        }

    }
}
