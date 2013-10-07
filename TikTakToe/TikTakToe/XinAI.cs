using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    /* 
    * Programmeringsverktyg: Visual Studio 2012 pro.
    *               Program: class XinAI is part of the project TikTakToe.
    *                 Datum: 2013-10-05
    *           
    *            Borrowed the idea from Mikael :)                                 
    */


    class XinAI
    {
        int[] P = new int[9];

        public XinAI(int[] Position, Player Player)
        {
            Position = P;

            CheckWin(Player);

        }
        public bool CheckIfUsed(int[] p, int indexToCheck)
        {
            bool IsEmpty = false;

            if (p[indexToCheck] == 0)
                IsEmpty = true;

            return IsEmpty;
        }
        public int CheckWin(Player Player)
        {
            int aiAnswer = 0;

            for (int i = 0; i < P.Length; i++)
            {
                if (CheckIfUsed(P, 4))
                {
                    aiAnswer = 4;
                    break;
                }
                //when [4] is empty
                else if (P[0] == Player.Symbol && P[8] == Player.Symbol || P[2] == Player.Symbol && P[6] == Player.Symbol ||
                    (P[1] == Player.Symbol && P[7] == Player.Symbol) || (P[3] == Player.Symbol && P[5] == Player.Symbol))
                {
                    if (CheckIfUsed(P, 4))
                    {
                        aiAnswer = 4;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                //to block the player, start with [0]
                else if (P[3] == Player.Symbol && P[6] == Player.Symbol || P[1] == Player.Symbol && P[2] == Player.Symbol ||
                    P[4] == Player.Symbol && P[8] == Player.Symbol)
                {
                    if (CheckIfUsed(P, 0))
                    {
                        aiAnswer = 0;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                // [1]
                else if (P[4] == Player.Symbol && P[7] == Player.Symbol || P[0] == Player.Symbol && P[2] == Player.Symbol)
                {
                    if (CheckIfUsed(P, 1))
                    {
                        aiAnswer = 1;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                // [2]
                else if (P[0] == Player.Symbol && P[1] == Player.Symbol || P[4] == Player.Symbol && P[6] == Player.Symbol ||
                   P[5] == Player.Symbol && P[8] == Player.Symbol)
                {
                    if (CheckIfUsed(P, 2))
                    {
                        aiAnswer = 2;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                //[3]
                else if (P[0] == Player.Symbol && P[6] == Player.Symbol || P[4] == Player.Symbol && P[5] == Player.Symbol)
                {
                    if (CheckIfUsed(P, 3))
                    {
                        aiAnswer = 3;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                //[5]
                else if (P[3] == Player.Symbol && P[4] == Player.Symbol || P[2] == Player.Symbol && P[8] == Player.Symbol)
                {
                    if (CheckIfUsed(P, 5))
                    {
                        aiAnswer = 5;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                //[6]
                else if (P[0] == Player.Symbol && P[3] == Player.Symbol || P[2] == Player.Symbol && P[4] == Player.Symbol ||
                    P[7] == Player.Symbol && P[8] == Player.Symbol)
                {
                    if (CheckIfUsed(P, 6))
                    {
                        aiAnswer = 6;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                //[7]
                else if (P[1] == Player.Symbol && P[4] == Player.Symbol || P[6] == Player.Symbol && P[8] == Player.Symbol)
                {
                    if (CheckIfUsed(P, 7))
                    {
                        aiAnswer = 7;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                //[8]
                else if (P[0] == Player.Symbol && P[4] == Player.Symbol || P[6] == Player.Symbol && P[7] == Player.Symbol ||
                     P[2] == Player.Symbol && P[5] == Player.Symbol)
                {
                    if (CheckIfUsed(P, 8))
                    {
                        aiAnswer = 8;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

            }

            return aiAnswer;
        }




    }
}
