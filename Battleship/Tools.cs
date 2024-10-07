/* 
 * Nick Coffin - 100555045
 * OOP - Assignment 1 Tic Tac Toe
 * Sept 29, 2024
 * Contains various tools
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public static class Tools
    {

        private static Random random = new Random();
        
        /// <summary>
        /// Method to generate a random number.
        /// </summary>
        /// <param name="min">Min number</param>
        /// <param name="max">Max number</param>
        /// <returns></returns>
        public static int RandomInt(int min, int max)
        {
            return random.Next(min, max);
        }

    }
}
