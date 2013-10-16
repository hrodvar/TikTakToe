using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MikaelsAI2
{
    /* 
* Programmeringsverktyg: Visual Studio 2012 pro.
*               Program: class MikaelsAI2 is part of the project TikTakToe.
*                 Datum: 2013-10-05
*           2
*            Not even Alpha version :)                                 
*/
    public int aiSvar { get; set; }
    public int RoysVariabel { get; set; }
    private int RandomNumber { get; set; }
    private bool empty { get; set; }

    // constructor
    public MikaelsAI2(int[] player1, int[] player2, Player Player)
    {
        RoysVariabel = CheckForWin(player1, player2, Player);
        /*
        RoysVariabel = TryToWin(player1, player2, Player);
        if (RoysVariabel == 1337)
        {
            RoysVariabel = CheckForWin(player1, player2, Player);
        }
        */
    } // end of constructor

    // a method that checks if the chosen index is already used


    public bool IsEmpty(int[] arrayToCheck, int num)
    {
        bool empty = false;

        if (arrayToCheck.All(number => arrayToCheck.Contains(num)))
            empty = true;

        return empty;
    }

    // end of IsEmpty
    //Checks if Player Can Win
    public int CheckForWin(int[] player1, int[] player2, Player Player)
    {
        bool legit = false;

        while (legit == false)
        {
            Random random = new Random();
            RandomNumber = random.Next(1, 9);

            #region if-BlockOrRandomize

            if (player1.Length < 2 && !IsEmpty(player2, 5))
            {
                aiSvar = 5;
                legit = true;
                break;
            }
            if (player1.Length < 2 && !IsEmpty(player2, 1))
            {
                aiSvar = 1;
                legit = true;
                break;
            }
            if (player1.Length < 2 && !IsEmpty(player2, 3))
            {
                aiSvar = 3;
                legit = true;
                break;
            }
            if (player1.Length < 2 && !IsEmpty(player2, 7))
            {
                aiSvar = 7;
                legit = true;
                break;
            }
            if (player1.Length < 2 && !IsEmpty(player2, 9))
            {
                aiSvar = 9;
                legit = true;
                break;
            }
            /////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////



            else if (((!IsEmpty(player2, 3) && !IsEmpty(player1, 3)) && ((IsEmpty(player1, 1)) && (IsEmpty(player1, 2)))) ||
                     ((!IsEmpty(player2, 3) && !IsEmpty(player1, 3)) && ((IsEmpty(player1, 9)) && (IsEmpty(player1, 6)))) ||
                     ((!IsEmpty(player2, 3) && !IsEmpty(player1, 3)) && ((IsEmpty(player1, 5)) && (IsEmpty(player1, 7)))))
            {
                if (!IsEmpty(player2, 3) && !IsEmpty(player1, 3))
                {
                    aiSvar = 3;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }

            else if (((!IsEmpty(player2, 1) && !IsEmpty(player1, 1)) && ((IsEmpty(player1, 7)) && (IsEmpty(player1, 4)))) ||
                     ((!IsEmpty(player2, 1) && !IsEmpty(player1, 1)) && ((IsEmpty(player1, 3)) && (IsEmpty(player1, 2)))) ||
                     ((!IsEmpty(player2, 1) && !IsEmpty(player1, 1)) && ((IsEmpty(player1, 5)) && (IsEmpty(player1, 9)))))
            {
                if (!IsEmpty(player2, 1) && !IsEmpty(player1, 1))
                {
                    aiSvar = 1;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }

            else if (((!IsEmpty(player2, 7) && !IsEmpty(player1, 7)) && ((IsEmpty(player1, 1)) && (IsEmpty(player1, 4)))) ||
                     ((!IsEmpty(player2, 7) && !IsEmpty(player1, 7)) && ((IsEmpty(player1, 9)) && (IsEmpty(player1, 8)))) ||
                     ((!IsEmpty(player2, 7) && !IsEmpty(player1, 7)) && ((IsEmpty(player1, 3)) && (IsEmpty(player1, 5)))))
            {


                if (!IsEmpty(player2, 7) && !IsEmpty(player1, 7))
                {
                    aiSvar = 7;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }

            else if (((!IsEmpty(player2, 9) && !IsEmpty(player1, 9)) && ((IsEmpty(player1, 8)) && (IsEmpty(player1, 7)))) ||
                     ((!IsEmpty(player2, 9) && !IsEmpty(player1, 9)) && ((IsEmpty(player1, 3)) && (IsEmpty(player1, 6)))) ||
                     ((!IsEmpty(player2, 9) && !IsEmpty(player1, 9)) && ((IsEmpty(player1, 5)) && (IsEmpty(player1, 1)))))
            {
                if (!IsEmpty(player2, 9) && !IsEmpty(player1, 9))
                {
                    aiSvar = 9;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            else if (((!IsEmpty(player2, 8) && !IsEmpty(player1, 8)) && ((IsEmpty(player1, 7)) && (IsEmpty(player1, 9)))) ||
                     ((!IsEmpty(player2, 8) && !IsEmpty(player1, 8)) && ((IsEmpty(player1, 2)) && (IsEmpty(player1, 5)))))
            {
                if (!IsEmpty(player2, 8) && !IsEmpty(player1, 8))
                {
                    aiSvar = 8;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            else if (((!IsEmpty(player2, 4) && !IsEmpty(player1, 4)) && ((IsEmpty(player1, 1)) && (IsEmpty(player1, 7)))) ||
                     ((!IsEmpty(player2, 4) && !IsEmpty(player1, 4)) && ((IsEmpty(player1, 5)) && (IsEmpty(player1, 6)))))
            {
                if (!IsEmpty(player2, 4) && !IsEmpty(player1, 4))
                {
                    aiSvar = 4;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            else if (((!IsEmpty(player2, 6) && !IsEmpty(player1, 6)) && ((IsEmpty(player1, 9)) && (IsEmpty(player1, 3)))) ||
                     ((!IsEmpty(player2, 6) && !IsEmpty(player1, 6)) && ((IsEmpty(player1, 4)) && (IsEmpty(player1, 5)))))
            {
                if (!IsEmpty(player2, 6) && !IsEmpty(player1, 6))
                {
                    aiSvar = 6;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            else if (((!IsEmpty(player2, 2) && !IsEmpty(player1, 2)) && ((IsEmpty(player1, 1)) && (IsEmpty(player1, 3)))) ||
                     ((!IsEmpty(player2, 2) && !IsEmpty(player1, 2)) && ((IsEmpty(player1, 8)) && (IsEmpty(player1, 5)))))
            {
                if (!IsEmpty(player2, 2) && !IsEmpty(player1, 2))
                {
                    aiSvar = 2;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            else if (((!IsEmpty(player2, 5) && !IsEmpty(player1, 5)) && ((IsEmpty(player1, 2)) && (IsEmpty(player1, 8)))) ||
                     ((!IsEmpty(player2, 5) && !IsEmpty(player1, 5)) && ((IsEmpty(player1, 4)) && (IsEmpty(player1, 6)))) ||
                     ((!IsEmpty(player2, 5) && !IsEmpty(player1, 5)) && ((IsEmpty(player1, 1)) && (IsEmpty(player1, 9)))) ||
                     ((!IsEmpty(player2, 5) && !IsEmpty(player1, 5)) && ((IsEmpty(player1, 7)) && (IsEmpty(player1, 3)))))
            {
                if (!IsEmpty(player2, 5) && !IsEmpty(player1, 5))
                {
                    aiSvar = 5;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            ///////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////

            else if (((!IsEmpty(player1, 3) && !IsEmpty(player2, 3)) && ((IsEmpty(player2, 1)) && (IsEmpty(player2, 2)))) ||
                     ((!IsEmpty(player1, 3) && !IsEmpty(player2, 3)) && ((IsEmpty(player2, 9)) && (IsEmpty(player2, 6)))) || 
                     ((!IsEmpty(player1, 3) && !IsEmpty(player2, 3)) && ((IsEmpty(player2, 5)) && (IsEmpty(player2, 7)))))
            {
                if (!IsEmpty(player2, 3) && !IsEmpty(player1, 3))
                {
                    aiSvar = 3;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }

            else if (((!IsEmpty(player1, 1) && !IsEmpty(player2, 1)) && ((IsEmpty(player2, 7)) && (IsEmpty(player2, 4)))) || 
                     ((!IsEmpty(player1, 1) && !IsEmpty(player2, 1)) && ((IsEmpty(player2, 3)) && (IsEmpty(player2, 2)))) || 
                     ((!IsEmpty(player1, 1) && !IsEmpty(player2, 1)) && ((IsEmpty(player2, 5)) && (IsEmpty(player2, 9)))))
            {
                if (!IsEmpty(player2, 1) && !IsEmpty(player1, 1))
                {
                    aiSvar = 1;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }

            else if (((!IsEmpty(player1, 7) && !IsEmpty(player2, 7)) && ((IsEmpty(player2, 1)) && (IsEmpty(player2, 4)))) ||
                     ((!IsEmpty(player1, 7) && !IsEmpty(player2, 7)) && ((IsEmpty(player2, 9)) && (IsEmpty(player2, 8)))) ||
                     ((!IsEmpty(player1, 7) && !IsEmpty(player2, 7)) && ((IsEmpty(player2, 3)) && (IsEmpty(player2, 5)))))
            {


                if (!IsEmpty(player2, 7) && !IsEmpty(player1, 7))
                {
                    aiSvar = 7;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }

            else if (((!IsEmpty(player1, 9) && !IsEmpty(player2, 9)) && ((IsEmpty(player2, 8)) && (IsEmpty(player2, 7)))) ||
                     ((!IsEmpty(player1, 9) && !IsEmpty(player2, 9)) && ((IsEmpty(player2, 3)) && (IsEmpty(player2, 6)))) ||
                     ((!IsEmpty(player1, 9) && !IsEmpty(player2, 9)) && ((IsEmpty(player2, 5)) && (IsEmpty(player2, 1)))))
            {
                if (!IsEmpty(player2, 9) && !IsEmpty(player1, 9))
                {
                    aiSvar = 9;
                    legit = true;
                    break;
                }
                else
                {
                    if (player1.Length >= 3 && !IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            else if (((!IsEmpty(player1, 8) && !IsEmpty(player2, 8)) && ((IsEmpty(player2, 7)) && (IsEmpty(player2, 9)))) ||
                     ((!IsEmpty(player1, 8) && !IsEmpty(player2, 8)) && ((IsEmpty(player2, 2)) && (IsEmpty(player2, 5)))))
            {
                if (!IsEmpty(player2, 8) && !IsEmpty(player1, 8))
                {
                    aiSvar = 8;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player1, RandomNumber) && !IsEmpty(player2, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            else if (((!IsEmpty(player1, 4) && !IsEmpty(player2, 4)) && ((IsEmpty(player2, 1)) && (IsEmpty(player2, 7)))) ||
                     ((!IsEmpty(player1, 4) && !IsEmpty(player2, 4)) && ((IsEmpty(player2, 5)) && (IsEmpty(player2, 6)))))
            {
                if (!IsEmpty(player2, 4) && !IsEmpty(player1, 4))
                {
                    aiSvar = 4;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            else if (((!IsEmpty(player1, 6) && !IsEmpty(player2, 6)) && ((IsEmpty(player2, 9)) && (IsEmpty(player2, 3)))) ||
                     ((!IsEmpty(player1, 6) && !IsEmpty(player2, 6)) && ((IsEmpty(player2, 4)) && (IsEmpty(player2, 5)))))
            {
                if (!IsEmpty(player2, 6) && !IsEmpty(player1, 6))
                {
                    aiSvar = 6;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            else if (((!IsEmpty(player1, 2) && !IsEmpty(player2, 2)) && ((IsEmpty(player2, 1)) && (IsEmpty(player2, 3)))) ||
                     ((!IsEmpty(player1, 2) && !IsEmpty(player2, 2)) && ((IsEmpty(player2, 8)) && (IsEmpty(player2, 5)))))
            {
                if (!IsEmpty(player2, 2) && !IsEmpty(player1, 2))
                {
                    aiSvar = 2;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }
            else if (((!IsEmpty(player1, 5) && !IsEmpty(player2, 5)) && ((IsEmpty(player2, 2)) && (IsEmpty(player2, 8)))) ||
                     ((!IsEmpty(player1, 5) && !IsEmpty(player2, 5)) && ((IsEmpty(player2, 4)) && (IsEmpty(player2, 6)))) ||
                     ((!IsEmpty(player1, 5) && !IsEmpty(player2, 5)) && ((IsEmpty(player2, 1)) && (IsEmpty(player2, 9)))) ||
                     ((!IsEmpty(player1, 5) && !IsEmpty(player2, 5)) && ((IsEmpty(player2, 7)) && (IsEmpty(player2, 3)))))
            {
                if (!IsEmpty(player2, 5) && !IsEmpty(player1, 5))
                {
                    aiSvar = 5;
                    legit = true;
                    break;
                }
                else
                {
                    if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                    {
                        aiSvar = RandomNumber;
                        legit = true;
                        break;
                    }
                    else
                    {
                        legit = false;
                    }
                }
            }

            else
            {
                if (!IsEmpty(player2, RandomNumber) && !IsEmpty(player1, RandomNumber))
                {
                    aiSvar = RandomNumber;
                    legit = true;
                    break;
                }
                else
                {
                    legit = true;
                }
            }
            #endregion
        }
        return aiSvar;

    }
    
}
// end of combination method


