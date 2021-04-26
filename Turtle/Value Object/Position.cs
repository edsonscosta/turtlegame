using System;

namespace TurtleGame
{
    public class Position : IEquatable<Position>
    {
        private Position(int x, int y)
        {
            X = x;
            Y = y;
            IsMine = false;
            Start = false;
            Exit = false;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public bool IsMine { get; private set; }
        public bool Start { get; private set; }
        public bool Exit { get; private set; }

        public bool Equals(Position other)
        {
            if (other == null)
                return false;

            if (this.X == other.X && this.Y == other.Y)
                return true;
            else
                return false;
        }

        public static Position CreatePosition(int x, int y)
        {
            return new Position(x, y);
        }

        public void SetMine()
        {
            IsMine = true;
        }
        public void SetStart(bool isStart)
        {
            Start = isStart;
        }
        public void SetExit(bool isExit)
        {
            Exit = isExit;
        }
    }
}