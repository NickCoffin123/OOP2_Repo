﻿using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02DemoC
{
    public static class Settings
    {

        #region Global Variables and Constants

        public const int DEF_SQUARESIZE = 80;
        public const int DEF_SPACING = 10;
        public const int DEF_LAYOUTMARGIN = 20;
        public const int DEF_TOPMARGIN = 50;
        // Number of squares.
        public const int MIN_NUMSQUARES = 1;
        public const int MAX_NUMSQUARES = 6;
        public const int DEF_NUMSQUARES = 3;

        public static bool runEvents = false;
        public static Label[,] labels = new Label[MAX_NUMSQUARES, MAX_NUMSQUARES];

        #endregion

    }
}
