using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Simulator
{
    static class Board
    {
        // Board Size information
        // This information should not be manually changed unless the size of panel1 changes in the form designer
        public static int mBoardSize = 0;
        public const int mBoardWidth = 1000;
        public const int mBoardHeight = 1000;

        // List to store square objects on the board. Needed to find positioning when drawing
        public static List<Square> squares = new List<Square>();

        // Start position for the player
        public static Vector2 start = new Vector2(0, 0);
        // The tiles surrounding the start position. Used to ensure all spaces around the start are clear/traversable
        public static List<Vector2> adjacentStartSquares = new List<Vector2>();

        // Target for the players to reach. Once reaches, the simulation stops
        public static Vector2 target = new Vector2(0, 0);
        // The tiles surrounding the target. Used to ensure all spaces around the target are clear/traversable
        public static List<Vector2> adjacentTargetSquares = new List<Vector2>();

        // Untraversable spaces. The players cannot move through these spaces
        public static List<Vector2> blockedSpaces = new List<Vector2>();

        /// <summary>
        /// Use to define if a move is valid or not. 
        /// Returns true if the space specified is traversable. Returns false if the space specified is out of bounds or blocked
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public static bool isSquareValid(Vector2 coordinates)
        {
            try
            {
                foreach (Vector2 square in blockedSpaces)
                {
                    if (square.X == coordinates.X && square.Y == coordinates.Y)
                    {
                        return false;
                    }
                }

                if (coordinates.X >= mBoardSize || coordinates.X < 0)
                {
                    return false;
                }
                else if (coordinates.Y >= mBoardSize || coordinates.Y < 0)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Returns the weighting of a specified square. Weighting can be any number from 0 to 255
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public static int GetWeight(Vector2 coordinates)
        {
            foreach (Square square in squares)
            {
                if (square.Coordinates.X == coordinates.X && square.Coordinates.Y == target.Y)
                {
                    return square.Weight;
                }
            }

            return 0;
        }

        /// <summary>
        /// Returns a string showing the coordinates of the start position.
        /// 14,54; or 1,122; or 9,8
        /// </summary>
        /// <returns></returns>
        public static string GetStartPositionString()
        {
            return start.X.ToString() + "," + start.Y.ToString();
        }

        /// <summary>
        /// Returns a string showing the coordinates of the target position.
        /// 14,54; or 1,122; or 9,8
        /// </summary>
        /// <returns></returns>
        public static string GetTargetPositionString()
        {
            return target.X.ToString() + "," + target.Y.ToString();
        }

        /// <summary>
        /// Returns a string showing the squares surrounding a string.
        /// Shows squares as either a number (thier weight), an X if its blocked, a T for a target or / for out of bounds.
        /// Squares are returned in order from the space directly above the specified location, working around clockwise
        /// eg. 12,32,253,X,122,X,/,/,/
        /// </summary>
        /// <param name="squareLocation"></param>
        /// <returns></returns>
        public static string GetSquareSurroundingsString(Vector2 squareLocation)
        {
            Square[] adjacentSquares = new Square[8];

            foreach (Square possibleAdjacent in Board.squares)
            {
                if ((possibleAdjacent.Coordinates.Y == squareLocation.Y - 1) && (possibleAdjacent.Coordinates.X == squareLocation.X))
                {
                    // North
                    adjacentSquares[0] = possibleAdjacent;
                }
                else if ((possibleAdjacent.Coordinates.Y == squareLocation.Y - 1) && (possibleAdjacent.Coordinates.X == squareLocation.X + 1))
                {
                    // North East
                    adjacentSquares[1] = possibleAdjacent;
                }
                else if ((possibleAdjacent.Coordinates.Y == squareLocation.Y) && (possibleAdjacent.Coordinates.X == squareLocation.X + 1))
                {
                    // East
                    adjacentSquares[2] = possibleAdjacent;
                }
                else if ((possibleAdjacent.Coordinates.Y == squareLocation.Y + 1) && (possibleAdjacent.Coordinates.X == squareLocation.X + 1))
                {
                    // South East
                    adjacentSquares[3] = possibleAdjacent;
                }
                else if ((possibleAdjacent.Coordinates.Y == squareLocation.Y + 1) && (possibleAdjacent.Coordinates.X == squareLocation.X))
                {
                    // South
                    adjacentSquares[4] = possibleAdjacent;
                }
                else if ((possibleAdjacent.Coordinates.Y == squareLocation.Y + 1) && (possibleAdjacent.Coordinates.X == squareLocation.X - 1))
                {
                    //South West
                    adjacentSquares[5] = possibleAdjacent;
                }
                else if ((possibleAdjacent.Coordinates.Y == squareLocation.Y) && (possibleAdjacent.Coordinates.X == squareLocation.X - 1))
                {
                    // West
                    adjacentSquares[6] = possibleAdjacent;
                }
                else if ((possibleAdjacent.Coordinates.Y == squareLocation.Y - 1) && (possibleAdjacent.Coordinates.X == squareLocation.X - 1))
                {
                    // North West
                    adjacentSquares[7] = possibleAdjacent;
                }
            }

            string returnString = "";

            for (int i = 0; i < 8; i++)
            {
                if (adjacentSquares[i] == null)
                {
                    returnString += "/,";
                }
                else if (!Board.isSquareValid(adjacentSquares[i].Coordinates))
                {
                    returnString += "X,";
                }
                else if (adjacentSquares[i].Coordinates.X == Board.target.X && adjacentSquares[i].Coordinates.Y == Board.target.Y)
                {
                    returnString += "T,";
                }
                else
                {
                    returnString += adjacentSquares[i].Weight.ToString() + ",";
                }


            }

            return returnString;
        }

        /// <summary>
        /// Places the target on the board for players to reach.        
        /// Used for board generation.
        /// </summary>
        public static void PlaceTarget()
        {
            // Find a random space for the target
            Random random = new Random();
            int x = random.Next(1, mBoardSize - 1);
            int y = random.Next(1, mBoardSize - 1);
            Board.target = new Vector2(x, y);

            // Remove any blocked spots around the target
            Board.adjacentTargetSquares = new List<Vector2>
            {
                new Vector2(Board.target.X, Board.target.Y),
                new Vector2(Board.target.X + 1, Board.target.Y),
                new Vector2(Board.target.X - 1, Board.target.Y),
                new Vector2(Board.target.X, Board.target.Y + 1),
                new Vector2(Board.target.X, Board.target.Y - 1),
                new Vector2(Board.target.X + 1, Board.target.Y + 1),
                new Vector2(Board.target.X + 1, Board.target.Y - 1),
                new Vector2(Board.target.X - 1, Board.target.Y + 1),
                new Vector2(Board.target.X - 1, Board.target.Y - 1),
            };

            for (int i = Board.blockedSpaces.Count - 1; i >= 0; i--)
            {
                for (int j = Board.adjacentTargetSquares.Count - 1; j >= 0; j--)
                {
                    if (Board.blockedSpaces[i].X == Board.adjacentTargetSquares[j].X && Board.blockedSpaces[i].Y == Board.adjacentTargetSquares[j].Y)
                    {
                        Board.blockedSpaces.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        
        /// <summary>
        /// Places the start position for players on the board.
        /// Used for board generation.
        /// Must be called after PlaceTarget()
        /// </summary>
        public static void PlaceStart()
        {
            bool validStart = false;

            do
            {
                // Find a random space for the start that is not on the target
                Random random = new Random();
                int x = random.Next(1, mBoardSize - 1);
                int y = random.Next(1, mBoardSize - 1);
                Board.start = new Vector2(x, y);

                if (Board.start.X == Board.target.X && Board.start.Y == Board.target.Y)
                {
                    // Invalid start position
                    // Retry
                }
                else
                {
                    validStart = true;
                }
            }
            while (!validStart);

            // Remove any blocked spots around the start
            Board.adjacentStartSquares = new List<Vector2>
            {
                new Vector2(Board.start.X, Board.start.Y),
                new Vector2(Board.start.X + 1, Board.start.Y),
                new Vector2(Board.start.X - 1, Board.start.Y),
                new Vector2(Board.start.X, Board.start.Y + 1),
                new Vector2(Board.start.X, Board.start.Y - 1),
                new Vector2(Board.start.X + 1, Board.start.Y + 1),
                new Vector2(Board.start.X + 1, Board.start.Y - 1),
                new Vector2(Board.start.X - 1, Board.start.Y + 1),
                new Vector2(Board.start.X - 1, Board.start.Y - 1),
            };

            for (int i = Board.blockedSpaces.Count - 1; i >= 0; i--)
            {
                for (int j = Board.adjacentStartSquares.Count - 1; j >= 0; j--)
                {
                    if (Board.blockedSpaces[i].X == Board.adjacentStartSquares[j].X && Board.blockedSpaces[i].Y == Board.adjacentStartSquares[j].Y)
                    {
                        Board.blockedSpaces.RemoveAt(i);
                        break;
                    }
                }
            }
        }

    }
}
