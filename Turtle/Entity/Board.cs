using System.Collections.Generic;
using TurtleGame.Entity;

namespace TurtleGame
{
    public class Board
    {
        public Board()
        {

        }

        public Turtle Turtle { get; set; }
        public List<Position> BoardPosition { get; set; }
        public void SetStartPosition(Position startPosition)
        {
            BoardPosition.ForEach(x =>
            {
                x.SetStart(false);
                if (x.Equals(startPosition))
                {
                    x.SetStart(true);
                }
            });
        }
        public void SetExitPosition(Position exitPosition)
        {
            BoardPosition.ForEach(x =>
            {
                x.SetExit(false);
                if (x.Equals(exitPosition))
                {
                    x.SetExit(true);
                }
            });
        }
    }
}
