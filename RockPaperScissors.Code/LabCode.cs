using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Code
{
    public class labRPSGame
    {
        public static string play(string p1Throw, string p2Throw)
        {
            string gameResult = "";
            if (p1Throw.ToLower() == p2Throw.ToLower())
            {
                gameResult = "TIE";
            }
            else if (p1Throw.ToLower() == "rock")
            {
                if (p2Throw.ToLower() == "scissors")
                {
                    gameResult = "Player1";
                }
                else gameResult = "Player2";
            }
            else if (p1Throw.ToLower() == "paper")
            {
                if (p2Throw.ToLower() == "scissors")
                {
                    gameResult = "Player2";
                }
                else gameResult = "Player1";
            }
            else if (p1Throw.ToLower() == "scissors")
            {
                if (p2Throw.ToLower() == "rock")
                {
                    gameResult = "Player2";
                }
                else gameResult = "Player1";
            }
            return gameResult;
        }
    }
}
