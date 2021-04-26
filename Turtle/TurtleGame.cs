using System;
using System.Collections.Generic;
using System.Linq;
using TurtleGame.Entity;

namespace TurtleGame
{
    public class TurtleGame
    {
        public Board Board { get; private set; }
        public void InitializeGame(GameSettings gameSettings)
        {
            Turtle turtle = new Turtle();

            Position startPosition = Position.CreatePosition(gameSettings.StartPoint.X, gameSettings.StartPoint.Y);
            Position exitPosition = Position.CreatePosition(gameSettings.ExitPoint.X, gameSettings.ExitPoint.Y);

            var minePoints = gameSettings.MinePoints.Select(x => Position.CreatePosition(x.X, x.Y)).ToList();

            Board board = new Board();

            List<Position> boardPositionList = new List<Position>();

            for (int x = 0; x < gameSettings.BoardSize.X; x++)
            {
                for (int y = 0; y < gameSettings.BoardSize.Y; y++)
                {
                    var position = Position.CreatePosition(x, y);

                    if (minePoints.Any(x => x.Equals(position)))
                    {
                        position.SetMine();
                    }

                    boardPositionList.AddIfNotExists(position);
                }
            }

            board.BoardPosition = boardPositionList;

            board.SetStartPosition(startPosition);

            board.SetExitPosition(exitPosition);

            board.BoardPosition = boardPositionList;

            turtle.SetInitialPosition(startPosition, gameSettings.StartDirection);

            board.Turtle = turtle;

            Board = board;
        }
        public void MoveTurtle(Moves moves)
        {
            foreach (var sequence in moves.MoveList)
            {
                Console.WriteLine("Sequence: ");

                string result = string.Empty;

                foreach (var move in sequence)
                {
                    if (move == "r")
                        Board.Turtle.Rotate();

                    if (move == "m")
                        Board.Turtle.Move();

                    if (Board.Turtle.CurrentPosition.IsMine)
                    {
                        result = "Mine Hit!";
                        break;
                    }

                    var exitPoint = Board.BoardPosition.SingleOrDefault(x => x.Exit);

                    if (exitPoint.Equals(Board.Turtle.CurrentPosition))
                    {
                        result = "Success!";
                        break;
                    }
                }

                if (string.IsNullOrEmpty(result))
                {
                    result = "Still in Danger!";
                }

                Console.WriteLine(result);
            }
        }
    }
}
