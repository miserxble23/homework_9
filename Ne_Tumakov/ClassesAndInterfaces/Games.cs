using System;
using System.Collections.Generic;
namespace Games
{
    public interface IGame
    {
        void Play();
    }
    public class BeachGame : IGame
    {
        public void Play()
        {
            Console.WriteLine("Игра: Пляж");
        }
    }
    public class MouseGame : IGame
    {
        public void Play()
        {
            Console.WriteLine("Игра: Мышеловка");
        }
    }
    public class SeaGame : IGame
    {
        public void Play()
        {
            Console.WriteLine("Игра: Море");
        }
    }
    public class FishingGame : IGame
    {
        public void Play()
        {
            Console.WriteLine("Игра: Рыбалка");
        }
    }
    public class PostmenGame : IGame
    {
        public void Play()
        {
            Console.WriteLine("Игра: Почтальон");
        }
    }
    public class SlideGame : IGame
    {
        public void Play()
        {
            Console.WriteLine("Игра: Горка");
        }
    }
    public class NewCustomGame : IGame
    {
        public void Play()
        {
            Console.WriteLine("Моя новая игра: Rust");
        }
    }
    public class Team
    {
        public string Name { get; set; }
        public Team(string name)
        {
            Name = name;
        }
        public void PlayGame(IGame game)
        {
            Console.WriteLine($"Команда {Name} играет в ");
            game.Play();
        }
    }
    public class BigRace
    {
        private List<Team> teams = new List<Team>();
        private List<IGame> games = new List<IGame>();
        public void AddTeam(Team team)
        {
            teams.Add(team);
        }
        public void AddGame(IGame game)
        {
            games.Add(game);
        }
        public void StartChampionship()
        {
            if (games.Count == 0 || teams.Count == 0)
            {
                Console.WriteLine("Недостаточно игр или команд!");
                return;
            }
            foreach (var game in games)
            {
                Console.WriteLine("\n--- Новая игра ---");
                foreach (var team in teams)
                {
                    team.PlayGame(game);
                }
            }
        }
    }
}
