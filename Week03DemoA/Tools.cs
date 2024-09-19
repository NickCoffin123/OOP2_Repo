/* 
 * Nick Coffin - 100555045
 * OOP - 2 Week 03 Demo A
 * Sept 17, 2024
 * Contains various tools
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03DemoA
{
    public static class Tools
    {

        private static Random random = new Random();

        public static int RandomInt(int min, int max)
        {
            return random.Next(min, max);
        }

        public static Color RandomColor()
        {
            return Color.FromArgb(255, RandomInt(0, 255), RandomInt(0, 255), RandomInt(0, 255));
        }

    }
}
