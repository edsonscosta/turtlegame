using TurtleGame.Enum;

namespace TurtleGame.Entity
{
    public class Turtle
    {
        public Position CurrentPosition { get; private set; }
        public Direction CurrentDirection { get; private set; }

        public void Move()
        {
            switch (CurrentDirection)
            {
                case Direction.North:
                    CurrentPosition = Position.CreatePosition(CurrentPosition.X, CurrentPosition.Y - 1);
                    break;
                case Direction.East:
                    CurrentPosition = Position.CreatePosition(CurrentPosition.X + 1, CurrentPosition.Y);
                    break;
                case Direction.South:
                    CurrentPosition = Position.CreatePosition(CurrentPosition.X, CurrentPosition.Y + 1);
                    break;
                case Direction.West:
                    CurrentPosition = Position.CreatePosition(CurrentPosition.X - 1, CurrentPosition.Y);
                    break;
                default:
                    break;
            }
        }

        public void Rotate()
        {
            switch (CurrentDirection)
            {
                case Direction.North:
                    CurrentDirection = Direction.East;
                    break;
                case Direction.East:
                    CurrentDirection = Direction.South;
                    break;
                case Direction.South:
                    CurrentDirection = Direction.West;
                    break;
                case Direction.West:
                    CurrentDirection = Direction.North;
                    break;
                default:
                    break;
            }
        }

        public void SetInitialPosition(Position initial, Direction direction)
        {
            CurrentPosition = initial;
            CurrentDirection = direction;
        }
    }
}
