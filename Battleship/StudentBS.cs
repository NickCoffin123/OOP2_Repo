using System;

namespace Battleship
{
    public static partial class BS
    {
        /// <summary>
        /// A method checks if the shot hits or misses a boat.
        /// </summary>
        /// <param name="x">The x-coordinate of the shot</param>
        /// <param name="y">The y-coordinate of the shot</param>
        /// <returns>Returns true if it's a hit, false if it's a miss.</returns>
        public static bool CheckHit(int x, int y)
        {
            
            if (boatPositions[x, y] != Boats.NoBoat)
            {
                board[x, y] = BoardStatus.Hit;
                return true;
            }
            else
            {
                board[x, y] = BoardStatus.Miss;
                return false;
            }
        }

        /// <summary>
        /// A method to check if a ship is sunk.
        /// </summary>
        /// <param name="boat"></param>
        /// <returns>Returns true when ship sunk</returns>
        public static bool IsShipSunk(Boats boat)
        {
            for (int x = 1; x <= MAX_BOARD_SIZE; x++)
            {
                for (int y = 1; y <= MAX_BOARD_SIZE; y++)
                {
                    if (boatPositions[x, y] == boat && board[x, y] != BoardStatus.Hit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
