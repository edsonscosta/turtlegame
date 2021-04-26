using System;
using System.IO;
using System.Text.Json;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = File.ReadAllText(@"ConfigurationFiles\GameSettings.json");
            var gameSettings = JsonSerializer.Deserialize<GameSettings>(settings);

            var moveList = File.ReadAllText(@"ConfigurationFiles\Moves.json");
            var moves = JsonSerializer.Deserialize<Moves>(moveList);

            var turtleGame = new TurtleGame();

            turtleGame.InitializeGame(gameSettings);

            turtleGame.MoveTurtle(moves);

            Console.ReadLine();
        }
    }
}
