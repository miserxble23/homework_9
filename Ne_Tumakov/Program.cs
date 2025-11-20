using System;
using Games;
namespace Ne_Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigRace show = new BigRace();

            // Создаем команды
            show.AddTeam(new Team("Россия"));
            show.AddTeam(new Team("Франция"));
            show.AddTeam(new Team("Китай"));
            show.AddTeam(new Team("Казахстан"));

            // Добавляем игры
            show.AddGame(new BeachGame());
            show.AddGame(new MouseGame());
            show.AddGame(new SeaGame());
            show.AddGame(new FishingGame());
            show.AddGame(new PostmenGame());
            show.AddGame(new SlideGame());

            // Добавляем свою игру (расширяем функционал)
            show.AddGame(new NewCustomGame());
            show.StartChampionship();
        }
    }
}
