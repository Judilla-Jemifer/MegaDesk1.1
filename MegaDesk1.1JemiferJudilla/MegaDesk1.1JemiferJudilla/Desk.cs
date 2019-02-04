using System;
using System.Collections.Generic;
using System.Text;


namespace MegaDesk_3_JemiferJudilla
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public string DeskMaterial { get; set; }

        // Constraints

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 28;
        public const int MAXDEPTH = 48;
        public const int MINNUMOFDRAWERS = 0;
        public const int MAXNUMOFDRAWERS = 7;


    }
    

}
