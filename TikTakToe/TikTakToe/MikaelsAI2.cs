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
     
     int[] CP =  new int[9];

     public MikaelsAI2(int[] ChosenPosition, Player Player)
     {
         ChosenPosition = CP;
         
         IsWinPossible(Player);
         
     }

     public bool CheckIfUsed(int[] cp,int indexToCheck)
     {
         bool IsEmpty = false;

         if (cp[indexToCheck] == 0)
             IsEmpty = true;

         return IsEmpty;
     }


     public int IsWinPossible(Player Player)
     {
         int aiSvar = 0;

         
         
         for (int i = 0; i < CP.Length; i++)
         {
             if (CheckIfUsed(CP, 4))
             {
                 aiSvar = 4;
                 break;
             }

             else if (CP[0] == Player.Symbol && CP[8] == Player.Symbol || CP[6] == Player.Symbol && CP[2] == Player.Symbol ||
                 CP[1] == Player.Symbol && CP[7] == Player.Symbol && CP[3] == Player.Symbol && CP[5] == Player.Symbol)
             {
                 if (CheckIfUsed(CP, 4))
                 {
                     aiSvar = 4;
                     break;
                 }
                 else
                 {
                     continue;
                 }
             }

             else if (CP[6] == Player.Symbol && CP[3] == Player.Symbol || CP[4] == Player.Symbol && CP[8] == Player.Symbol ||
                 CP[2] == Player.Symbol && CP[1] == Player.Symbol)
             {
                 if (CheckIfUsed(CP, 0))
                 {
                     aiSvar = 0;
                     break;
                 }
                 else
                 {
                     continue;
                 }
             } 
             
             else if (CP[0] == Player.Symbol && CP[3] == Player.Symbol || CP[1] == Player.Symbol && CP[4] == Player.Symbol ||
                 CP[8] == Player.Symbol && CP[7] == Player.Symbol)
             {
                 if (CheckIfUsed(CP, 6))
                 {
                     aiSvar = 6;
                     break;
                 }
                 else
                 {
                     continue;
                 }
             }
             
             else if (CP[0] == Player.Symbol && CP[4] == Player.Symbol || CP[6] == Player.Symbol && CP[7] == Player.Symbol ||
                CP[2] == Player.Symbol && CP[5] == Player.Symbol)
             {
                 if (CheckIfUsed(CP, 8))
                 {
                     aiSvar = 8;
                     break;
                 }
                 else
                 {
                     continue;
                 }
             }
             
             else if (CP[8] == Player.Symbol && CP[5] == Player.Symbol || CP[6] == Player.Symbol && CP[4] == Player.Symbol ||
                CP[0] == Player.Symbol && CP[1] == Player.Symbol)
             {
                 if (CheckIfUsed(CP, 2))
                 {
                     aiSvar = 2;
                     break;
                 }
                 else
                 {
                     continue;
                 }
             }

             else if (CP[0] == Player.Symbol && CP[6] == Player.Symbol || CP[5] == Player.Symbol && CP[4] == Player.Symbol)
             {
                 if (CheckIfUsed(CP, 3))
                 {
                     aiSvar = 3;
                     break;
                 }
                 else
                 {
                     continue;
                 }
             }
             
             else if (CP[7] == Player.Symbol && CP[4] == Player.Symbol || CP[0] == Player.Symbol && CP[2] == Player.Symbol)
             {
                 if (CheckIfUsed(CP, 1))
                 {
                     aiSvar = 1;
                     break;
                 }
                 else
                 {
                     continue;
                 }
             }
             else if (CP[3] == Player.Symbol && CP[4] == Player.Symbol || CP[2] == Player.Symbol && CP[8] == Player.Symbol)
             {
                 if (CheckIfUsed(CP, 5))
                 {
                     aiSvar = 5;
                     break;
                 }
                 else
                 {
                     continue;
                 }
             }
             
             else if (CP[6] == Player.Symbol && CP[8] == Player.Symbol || CP[1] == Player.Symbol && CP[4] == Player.Symbol)
             {
                 if (CheckIfUsed(CP, 7))
                 {
                     aiSvar = 7;
                     break;
                 }
                 else
                 {
                     continue;
                 }
             } 

         }

        return aiSvar;
     }

    
 }

