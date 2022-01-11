using EF.Lib;
using EF.Model;
using System;
using System.Linq;

namespace EF.App
{
    class Program
    {
        static void Main()
        {
            using (var db = DateBase.Init())
            {
                // создаем два объекта Game

                Game cs = new Game
                {
                    Name = "Counter-Strike",
                    Creator = "Valve Corporation",
                    Style = "Шутер от первого лица",
                    DateOfRelease = "08.11.2000"
                };
                Game warCraft = new Game
                {
                    Name = "Warcraft: Orcs & Humans",
                    Creator = "Blizzard Entertainment",
                    Style = "Стратегия в реальном времени",
                    DateOfRelease = "23.11.1994"
                };

                // добавляем их в базу данных

                db.TabGames.Add(cs);
                db.TabGames.Add(warCraft);
                db.SaveChanges();
            }
            using (var db = DateBase.Init())
            {
                // Получаем объекты из базы данных и выводим на консоль

                var games = db.TabGames.ToList();
                Console.WriteLine("Список игр:");
                foreach (var game in games)
                {
                    Console.WriteLine($"{game.Id}.{game.Name} - {game.Creator}-{game.Style}-{game.DateOfRelease}");
                }
            }
        }
    }
}
