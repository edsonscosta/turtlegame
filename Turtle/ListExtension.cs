using System.Collections.Generic;
using System.Linq;

namespace TurtleGame
{
    public static class ListExtension
    {
        public static List<Position> AddIfNotExists(this List<Position> board, Position position)
        {
            if (!board.Any(x => x.X == position.X && x.Y == position.Y))
                board.Add(position);

            return board;
        }
    }
}
