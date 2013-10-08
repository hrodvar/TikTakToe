using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class Intelligence is part of the project TikTakToe.
 *                 Datum: 2013-09-26
 *            Programare: Hrodvar Johannsson
 */

public class Intelligence
{
    // properties
    public static int[] HumansMoves   = new int[0];
    public static int[] ComputerMoves = new int[0];
    public int[] WinningsLine  = new int[3];
    public static int NumberOfBoxes = 3;
    public static int WinnerPoints { get; set; }
    public static int Counter = 0;
    public static bool Winner = false;
    public static int Rounds = 1;
    // end of properties

    // constructor
    public Intelligence(int winnerPoints)
    {
        WinnerPoints = winnerPoints;
    }   // end of Intelligence()
    // end of constructor

    // methods
    //public void HumansTurn(int HumansMove)
    //{
    //    int HumansMovesArrayLength = HumansMoves.Length;
    //    Array.Resize<int>(ref HumansMoves, HumansMovesArrayLength + 1);
    //    HumansMovesArrayLength = HumansMoves.Length;
    //    HumansMoves[HumansMovesArrayLength] = HumansMove;
    //}   // end of HumansTurn()

    //public void ComputersTurn(int[] array)
    //{

    //}   // end of ComputersTurn()

    public bool IntelligenceCalculator(int[] array)
        // This method returns true if someone won.
    {
        bool match = false;
        if (array.Length > 2)
        {
            match = false;
            match = AlgorithmFunction(array);
        }   // end of if
        return match;
    }   // end of IntelligenceCalculator()

    public bool AlgorithmFunction(int[] playerArray)
    {
        Array.Sort(playerArray);
        int[] testingArray = new int[9];
        if (playerArray.Length > 0)
            foreach (int item in playerArray)
                testingArray[item - 1] = item; 	 

        int i = 0;
        bool result = false;
        do
        {
            if (testingArray[i] != 0 && !result)
            {
                switch (i)
                {
                    case 0:
                        {
                            result = Rule1(testingArray, i) ||
                            Rule3(testingArray, i) ||
                            Rule4(testingArray, i) ?
                            true : false; break;
                        }   // end of case 0
                    case 1:
                        {
                            result = Rule3(testingArray, i) ?
                            true : false; break;
                        }   // end of case 1
                    case 2:
                        {
                            result = Rule2(testingArray, i) ||
                            Rule3(testingArray, i) ?
                            true : false; break;
                        }   // end of case 2
                    case 3: 
                        { 
                            result = Rule1(testingArray, i); 
                            break;
                        }   // end of case 3 
                    case 6: 
                        { 
                            result = Rule1(testingArray, i); 
                            break;
                        }   // end of case 6
                }   // end of switch
            }   // end of if
            i++;
        } while(i < testingArray.Length);
        return result;
    }   // end of AlgorithmFunction()

    public bool Rule1(int[] array, int i)
        // Role that check if number + 1 is the same 
        // as next number in the array.
        //      ___ ___ ___
        // formel: [index + 1] = =[index] + 1;
    {
        int startValue = i;
        try
        {
            int winnerCounter = 0;
            do{
                if (array[i + 1] == array[i] + 1)
                {
                    winnerCounter++;
                    WinningsLine[winnerCounter] = array[i];
                    if (winnerCounter == 2)
                    {
                        Winner = true;
                        break;
                    }   // end of if
                    else
                        Winner = false;
                }   // end of if
                i++;
            } while (winnerCounter != 2 || i != array.Length - 1 || startValue + 3 != i);
        }   // end of try
        catch { Winner = false; }
        return Winner; 
    }   // end of Rule1()

    public bool Rule2(int[] array, int i)
        // Role that check if number + 2 is the same
        // as next number in the array.
        //      /
        //     /
        //    /
        // formel: [index + (NumberOfBoxes - 1)] = [index] + (NumberOfBoxes - 1)
    {
        int indexValue = i;
        try
        {
            int winnerCounter = 0;
            do
            {
                if (array[i] == array[indexValue + 1] - (NumberOfBoxes - 1))
                {
                    WinningsLine[winnerCounter] = array[i];
                    winnerCounter++;
                    if (indexValue != i)
                    {
                        i = indexValue + 1;
                        indexValue += 1;
                    }   // end of if
                    else
                    {
                        i += 1;
                        indexValue += 1;
                    }   // end of else

                    if (winnerCounter == 2)
                    {
                        WinningsLine[winnerCounter] = array[indexValue];
                        Winner = true;
                        break;
                    }   // end of if
                    else
                        Winner = false;
                }   // end of if
                else
                    indexValue += 1;
            } while (winnerCounter != 2 || indexValue != array.Length - 1);
        }   // end of try
        catch { Winner = false;  }
        return Winner; 
    }   // end of Rule2()
    
    public bool Rule3(int[] array, int i)
        // Role that check if number + 3 is the same
        // as next number in the array.
        //      |
        //      |
        //      |
        // formel: [index + NumberOfBoxes] = [index] + NumberOfBoxes;
    {
        int indexValue = i;
        try
        {
            int winnerCounter = 0;
            do
            {
                if (array[i] == array[indexValue + 1] - (NumberOfBoxes))
                {
                    
                    WinningsLine[winnerCounter] = array[i];
                    winnerCounter++;
                    if (winnerCounter == 2)
                    {
                        WinningsLine[winnerCounter] = array[indexValue + 1];
                        Winner = true;
                        break;
                    }   // end of if
                    else
                        Winner = false;

                    if (indexValue != i)
                    {
                        i = indexValue + 1;
                        indexValue = i;
                    }   // end of if
                    else
                    {
                        i += 1;
                        indexValue += 1;
                    }   // end of else
                }   // end of if
                else
                    indexValue += 1;
            } while (winnerCounter != 2 || indexValue != array.Length - 1);
        }   // end of try
        catch { Winner = false; }
        return Winner; 
    }   // end of Rule3()

    public bool Rule4(int[] array, int i)
        // Role that check if number + 3 is the same
        // as next number in the array.
        //      \
        //       \
        //        \
        // formel: [index + (NumberOfBoxes + 1)] = [index] + (NumberOfBoxes +)
    {
        try
        {
            int winnerCounter = 0;
            do
            {
                if (array[i + 1] == array[i] + (NumberOfBoxes + 1))
                {
                    winnerCounter++;
                    WinningsLine[winnerCounter] = array[i];
                    if (winnerCounter == 2)
                    {
                        Winner = true;
                        break;
                    }   // end of if
                    else
                        Winner = false;
                }   // end of if
                i++;
            } while (winnerCounter != 2 || i != array.Length - 1);
        }   // end of try
        catch { Winner = false;  }
        return Winner; 
    }   // end of Rule4()

    // end of methods

}   // end of class Intelligence
