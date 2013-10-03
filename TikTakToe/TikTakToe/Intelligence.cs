using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class Player is part of the project TikTakToe.
 *                 Datum: 2013-09-26
 *            Programare: Hrodvar Johannsson
 *                        Mikael Wilkon
 *                        Philip Andreasson
 *                        Fatos Jasharaj
 *                        Xin Hansen
 */

public class Intelligence
{
    // properties
    public static int[] HumansMoves   = new int[0];
    public static int[] ComputerMoves = new int[0];
    public static int NumberOfBoxes = 3;
    public static int WinnerPoints = 2;
    public static int Counter = 0;
    public static bool Winner = false;
    public static int Rounds = 1;
    // end of properties

    // constructor
    public Intelligence()
    {

    }   // end of Intelligence()
    // end of constructor

    // methods
    public void HumansTurn(int HumansMove)
    {
        int HumansMovesArrayLength = HumansMoves.Length;
        Array.Resize<int>(ref HumansMoves, HumansMovesArrayLength + 1);
        HumansMovesArrayLength = HumansMoves.Length;
        HumansMoves[HumansMovesArrayLength] = HumansMove;
    }   // end of HumansTurn()

    public void ComputersTurn(int[] array)
    {

    }   // end of ComputersTurn()

    public bool IntelligenceCalculator(int[] array)
    {
        bool match = false;
        if (array.Length > 2)
        {
            match = false;
            match = PhilipRules(array);
            //match = Rule1(array) || Rule2(array) || Rule3(array) || Rule4(array) ? true : false;
        }   // end of if
        return match;
    }   // end of IntelligenceCalculator()

    public bool PhilipRules(int[] array)
    {
        Array.Sort(array);
        string numbers = string.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            numbers += array[i].ToString();
        }
        if (numbers.Contains("123") ||
            numbers.Contains("456") ||
            numbers.Contains("789") ||
            (numbers.Contains("1") && numbers.Contains("4") && numbers.Contains("7")) ||
            (numbers.Contains("2") && numbers.Contains("5") && numbers.Contains("8")) ||
            (numbers.Contains("3") && numbers.Contains("6") && numbers.Contains("9")) ||
            (numbers.Contains("1") && numbers.Contains("5") && numbers.Contains("9")) ||
            (numbers.Contains("3") && numbers.Contains("5") && numbers.Contains("7")))
        {
            return true;
        }
        return false;
    }

    public bool Rule1(int[] array)
        // Role that check if number + 1 is the same 
        // as next number in the array.
        //      ___ ___ ___
        // formel: [index + 1] = [index] + 1;
    {
        Array.Sort(array);
        int i = 0;
        bool test1 = false;
        try
        {
            int winnerCounter = 0;
            do{
                if (array[i] == 1 || array[i] == 4 || array[i] == 7)
                    test1 = true;
                if (array[i + 1] == array[i] + 1 && test1)
                {
                    winnerCounter++;
                    if (winnerCounter == 2)
                    {
                        Winner = true;
                        break;
                    }
                    else
                        Winner = false;
                }
                i++;
            } while (winnerCounter != 2 || i != array.Length - 1);
        }   // end of try
        catch { test1 = false; Winner = false; }
        return Winner; 
    }   // end of Rule1()

    public bool Rule2(int[] array)
        // Role that check if number + 2 is the same
        // as next number in the array.
        //      /
        //     /
        //    /
        // formel: [index + (NumberOfBoxes - 1)] = [index] + (NumberOfBoxes - 1)
    {
        Array.Sort(array);
        int i = 0;
        bool test2 = false;
        try
        {
            int winnerCounter = 0;
            do
            {
                if (array[i] == 3)
                    test2 = true;
                if (array[i + 1] == array[i] + (NumberOfBoxes - 1) && test2)
                {
                    winnerCounter++;
                    if (winnerCounter == 2)
                    {
                        Winner = true;
                        break;
                    }
                    else
                        Winner = false;
                }
                i++;
                
            } while (winnerCounter != 2 || i != array.Length - 1);

        }   // end of try
        catch { test2 = false; Winner = false;  }
        return Winner; 
    }   // end of Rule2()
    
    public bool Rule3(int[] array)
        // Role that check if number + 3 is the same
        // as next number in the array.
        //      |
        //      |
        //      |
        // formel: [index + NumberOfBoxes] = [index] + NumberOfBoxes;
    {
        Array.Sort(array);
        int i = 0;
        bool test3 = false;
        try
        {
            int winnerCounter = 0;
            do
            {
                if (array[i] == 1 || array[i] == 2 || array[i] == 3)
                    test3 = true;
                if (array[i + 1] == array[i] + (NumberOfBoxes) && test3)
                {
                    winnerCounter++;
                    if (winnerCounter == 2)
                    {
                        Winner = true;
                        break;
                    }
                    else
                        Winner = false;
                }
                i++;
            } while (winnerCounter != 2 || i != array.Length - 1);
        }   // end of try
        catch { test3 = false; Winner = false; }
        return Winner; 
    }   // end of Rule3()

    public bool Rule4(int[] array)
        // Role that check if number + 3 is the same
        // as next number in the array.
        //      \
        //       \
        //        \
        // formel: [index + (NumberOfBoxes + 1)] = [index] + (NumberOfBoxes +)
    {
        Array.Sort(array);
        int i = 0;
        bool test4 = false;
        try
        {
            int winnerCounter = 0;
            do
            {
                if (array[i] == 1)
                    test4 = true;
                if (array[i + 1] == array[i] + (NumberOfBoxes + 1) && test4)
                {
                    winnerCounter++;
                    if (winnerCounter == 2)
                    {
                        Winner = true;
                        break;
                    }
                    else
                        Winner = false;
                }
                i++;
            } while (winnerCounter != 2 || i != array.Length - 1);
        }   // end of try
        catch { test4 = false; Winner = false;  }
        return Winner; 
    }   // end of Rule4()

    // end of methods

}   // end of class Intelligence
