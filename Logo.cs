﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace StopThinkAct
{
    internal class Logo
    {
        public static void DisplayLogo()
        {
            string logo = @"
 _______       ________       ___
/  ____/      /_     _/      /   \
\____ \         /  /        / /_\ \
 ____\ \       /  /        /  ___  \
/______/TOP   /__/HINK    /__/   \__\CT
";
            Console.WriteLine(logo , Color.Magenta);
        }
    }
}
