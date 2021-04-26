using System.Collections.Generic;
using TurtleGame.Enum;

namespace TurtleGame
{
    public class BoardSize
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class StartPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ExitPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class MinePoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class GameSettings
    {
        public string Direction { get; set; }
        public BoardSize BoardSize { get; set; }
        public StartPoint StartPoint { get; set; }
        public ExitPoint ExitPoint { get; set; }
        public Direction StartDirection { get; set; }
        public List<MinePoint> MinePoints { get; set; }
    }
    public class Moves
    {
        public List<List<string>> MoveList { get; set; }
    }
}

