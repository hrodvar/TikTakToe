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
    *                 Datum: 2013-10-07
    *           
    *                                           
    */


    class XinAI
    {
        public int aiAnswer { get; set; } 
        char[] P = new char[9]; 
        public int RoysVariabel { get; set; }

    public XinAI(int[] player1, int[] player2, Player Player)
    {
        char symbol = ' ';   
        
       //to change players' turn, Player = 'X', Computer = 'O'
        if (Player.Symbol == 'X')
            symbol = 'O';
        else
            symbol = 'X';
        foreach (int item1 in player2)
        {

            P[item1] = Player.Symbol; //'X'
        }

        foreach (int item2 in player1)
        {

            P[item2] = symbol; // 'O'
        }
         
     }
     public bool CheckIfUsed(char[] p, int indexToCheck)
     {
         bool IsEmpty = false;

         if (p[indexToCheck] == 0)
             IsEmpty = true;

         return IsEmpty;
     }
    public int CheckWin(Player Player)
     {
         bool legit = false; 
       
        do{

             if (P[4] == Player.Symbol) //if [4] is taken by 'X', place 'O' in [0]
             {
                 aiAnswer = 1;
                 legit = true;
        
             }
                //when [4] is empty
             else if ((P[0] == Player.Symbol && P[8] == Player.Symbol) || (P[2] == Player.Symbol && P[6] == Player.Symbol) ||
                 (P[1] == Player.Symbol && P[7] == Player.Symbol) || (P[3] == Player.Symbol && P[5] == Player.Symbol))
             {
                 if (CheckIfUsed(P, 4))
                 {
                     aiAnswer = 5;
                     legit = true;
                 }
             }
                 //to block player, start with [0] O|X|X
             else if ((P[3] == Player.Symbol && P[6] == Player.Symbol) || (P[1] == Player.Symbol && P[2] == Player.Symbol) ||
                 (P[4] == Player.Symbol && P[8] == Player.Symbol))
             {
                 if (CheckIfUsed(P, 0))
                 {
                     aiAnswer = 1;
                     legit = true;
                 }
                 
             }
                 // [1] 
             else if ((P[4] == Player.Symbol && P[7] == Player.Symbol) || (P[0] == Player.Symbol && P[2] == Player.Symbol))
                
             {
                 if (CheckIfUsed(P, 1))
                 {
                     aiAnswer = 2;
                     legit = true;
                 }
                
             }
                 // [2]
             else if ((P[0] == Player.Symbol && P[1] == Player.Symbol) ||( P[4] == Player.Symbol && P[6] == Player.Symbol) ||
                (P[5] == Player.Symbol && P[8] == Player.Symbol))
             {
                 if (CheckIfUsed(P, 2))
                 {
                     aiAnswer = 3;
                     legit = true;
                 }
             }
                 //[3]
             else if ((P[0] == Player.Symbol && P[6] == Player.Symbol) ||( P[4] == Player.Symbol && P[5] == Player.Symbol ))
             {
                 if (CheckIfUsed(P, 3))
                 {
                     aiAnswer = 4;
                        legit = true;
                 }
                 
             }
                 //[5]
             else if ((P[3] == Player.Symbol && P[4] == Player.Symbol)|| (P[2] == Player.Symbol && P[8] == Player.Symbol))
             {
                 if (CheckIfUsed(P, 5))
                 {
                     aiAnswer = 6;
                        legit = true;
                 }
                 
             }
                 //[6]
             else if ((P[0] == Player.Symbol && P[3] == Player.Symbol) ||( P[2] == Player.Symbol && P[4] == Player.Symbol) || 
                 (P[7] == Player.Symbol && P[8] == Player.Symbol ))
             {
                 if (CheckIfUsed(P, 6))
                 {
                     aiAnswer = 7;
                     legit = true;
                 }
                 
             }
                 //[7]
             else if ((P[1] == Player.Symbol && P[4] == Player.Symbol) || (P[6] == Player.Symbol && P[8] == Player.Symbol))
             {
                 if (CheckIfUsed(P, 7))
                 {
                     aiAnswer = 8;
                     legit = true;
                 }
             }
                 //[8]
             else if ((P[0] == Player.Symbol && P[4] == Player.Symbol) ||( P[6] == Player.Symbol && P[7] == Player.Symbol )||
                  (P[2] == Player.Symbol && P[5] == Player.Symbol) )
             {
                 if (CheckIfUsed(P, 8))
                 {
                     aiAnswer = 8;
                     legit = true;
                 }
             }

         }while(legit ==true);
         return aiAnswer; 
    }
        
    
     }



    }

