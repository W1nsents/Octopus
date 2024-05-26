﻿using System;
using System.Drawing;
//---------------------------
using static Octopus.Keyboard;
//---------------------------

namespace Octopus
{
    class Configs
    {
        public static Point currentPosition;

        public static IntPtr hWnd { get; set; }

        public static int xAxis { get; set; }

        public static Random random { get; set; }

        public static bool appHide { get; set; } = false;

        public static VKeys toggleLeft { get; set; } = VKeys.None;

        public static VKeys toggleRight { get; set; } = VKeys.None;

    }
}
