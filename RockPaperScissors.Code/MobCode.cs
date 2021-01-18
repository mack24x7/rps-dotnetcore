using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Code
{
    public class mobRPSGame
    {
        public static string play(string p1Throw, string p2Throw)
        {
            string gameResult = "";
            if (p1Throw == "ROCK" && p2Throw == "ROCK")
            {
                gameResult = "TIE";
            }
            return gameResult;
        }
    }
}
