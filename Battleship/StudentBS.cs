using System;

namespace Battleship
{
    public static partial class BS
    {
        /// <summary>
        /// This method checks if the shot hits or misses a boat.
        /// </summary>
        /// <param name="x">The x-coordinate of the shot</param>
        /// <param name="y">The y-coordinate of the shot</param>
        /// <returns>Returns true if it's a hit, false if it's a miss.</returns>
        public static bool CheckHit(int x, int y)
        {
            // Check if the coordinates are within the bounds of the board
            if (x < 1 || x > MAX_BOARD_SIZE || y < 1 || y > MAX_BOARD_SIZE)
            {
                throw new ArgumentOutOfRangeException("Shot is outside of the board.");
            }

            // Check the boatPositions array to see if there is a boat at the location
            if (boatPositions[x, y] != Boats.NoBoat)
            {
                // It's a hit!
                board[x, y] = BoardStatus.Hit;
                return true;
            }
            else
            {
                // It's a miss
                board[x, y] = BoardStatus.Miss;
                return false;
            }
        }
    }
}
