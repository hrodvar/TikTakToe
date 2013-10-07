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
*            Programare: Mikael Wilkon 
*            Not even Alpha version :)                                 
*/
    public int aiSvar { get; set; }
    char[] CP = new char[9];
    public int RoysVariabel { get; set; }

    // constructor
    public MikaelsAI2(int[] player1, int[] player2, Player Player)
    {
        char symbol = ' ';
        if (Player.Symbol == 'X')
            symbol = 'O';
        else
           symbol = 'X';
        foreach (int item1 in player2)
        {

            CP[item1] = Player.Symbol;
        }

        foreach (int item2 in player1)
        {

            CP[item2] = symbol;
        }

        RoysVariabel = IsWinPossible(Player);

    } // end of constructor

    // a method that checks if the chosen index is already used
    public bool CheckIfUsed(char[] cp, int indexToCheck)
    {
        bool IsEmpty = false;

        if (cp[indexToCheck] == 0)
            IsEmpty = true;

        return IsEmpty;
    }
    //end of checkifused method

    // see if any of those combinations occure
    public int IsWinPossible(Player Player)
    {
        bool legit = false;



        do
        {

           

            if (CheckIfUsed(CP, 4))
            {
                aiSvar = 5;
                legit = true;
                break;
            }
            
            
            if  (CP[0] == 'X' && CP[2] == 'X')
            {
                aiSvar = 2;
                legit = true;
            }

            else if ((CP[0] == Player.Symbol && CP[8] == Player.Symbol) || (CP[6] == Player.Symbol && CP[2] == Player.Symbol) ||
                (CP[1] == Player.Symbol && CP[7] == Player.Symbol) || (CP[3] == Player.Symbol && CP[5] == Player.Symbol))
            {
                if (CheckIfUsed(CP, 4))
                {
                    aiSvar = 5;
                    legit = true;
                }

            }

            else if ((CP[6] == Player.Symbol && CP[3] == Player.Symbol) || (CP[4] == Player.Symbol && CP[8] == Player.Symbol) ||
                (CP[2] == Player.Symbol && CP[1] == Player.Symbol))
            {
                if (CheckIfUsed(CP, 0))
                {
                    aiSvar = 1;
                    legit = true;
                }

            }

            else if ((CP[0] == Player.Symbol && CP[3] == Player.Symbol) || (CP[1] == Player.Symbol && CP[4] == Player.Symbol) ||
                (CP[8] == Player.Symbol && CP[7] == Player.Symbol))
            {
                if (CheckIfUsed(CP, 6))
                {
                    aiSvar = 7;
                    legit = true;
                }

            }

            else if ((CP[0] == Player.Symbol && CP[4] == Player.Symbol) || (CP[6] == Player.Symbol && CP[7] == Player.Symbol) ||
               (CP[2] == Player.Symbol && CP[5] == Player.Symbol))
            {
                if (CheckIfUsed(CP, 8))
                {
                    aiSvar = 9;
                    legit = true;
                }

            }

            else if ((CP[8] == Player.Symbol && CP[5] == Player.Symbol) || (CP[6] == Player.Symbol && CP[4] == Player.Symbol) ||
               (CP[0] == Player.Symbol && CP[1] == Player.Symbol))
            {
                if (CheckIfUsed(CP, 2))
                {
                    aiSvar = 3;
                    legit = true;
                }

            }

            else if ((CP[0] == Player.Symbol && CP[6] == Player.Symbol) || (CP[5] == Player.Symbol && CP[4] == Player.Symbol))
            {
                if (CheckIfUsed(CP, 3))
                {
                    aiSvar = 4;
                    legit = true;
                }

            }

            else if ((CP[7] == Player.Symbol && CP[4] == Player.Symbol) || (CP[0] == Player.Symbol && CP[2] == Player.Symbol))
            {
                if (CheckIfUsed(CP, 1))
                {
                    aiSvar = 2;
                    legit = true;
                }

            }
            else if ((CP[3] == Player.Symbol && CP[4] == Player.Symbol) || (CP[2] == Player.Symbol && CP[8] == Player.Symbol))
            {
                if (CheckIfUsed(CP, 5))
                {
                    aiSvar = 6;
                    legit = true;
                }

            }

            else if ((CP[6] == Player.Symbol && CP[8] == Player.Symbol) || (CP[1] == Player.Symbol && CP[4] == Player.Symbol))
            {
                if (CheckIfUsed(CP, 7))
                {
                    aiSvar = 8;
                    legit = true;
                }
                else
                {
                    if (CheckIfUsed(CP, 0))
                    {
                        aiSvar = 0;
                        legit = true;
                    }
                    else if (CheckIfUsed(CP, 2))
                    {
                        aiSvar = 2;
                        legit = true;
                    }
                    else if (CheckIfUsed(CP, 6))
                    {
                        aiSvar = 6;
                        legit = true;
                    }
                    else if (CheckIfUsed(CP, 8))
                    {
                        aiSvar = 8;
                        legit = true;
                    }


                }
            }
        } while (legit == false);
        
        return aiSvar;
    }
}
     // end of combination method
 

