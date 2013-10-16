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
                switch (testingArray[i])
                {
                    case 1:
                        {
                            result = Rule1(testingArray, testingArray[i],1) ||
                            Rule3(testingArray, testingArray[i], i) ||
                            Rule4(testingArray, testingArray[i], i) ?
                            true : false; break;
                        }   // end of case 0
                    case 2:
                        {
                            result = Rule3(testingArray, testingArray[i], 2) ?
                            true : false; break;
                        }   // end of case 1
                    case 3:
                        {
                            result = Rule2(testingArray, testingArray[i], 3) ||
                            Rule3(testingArray, testingArray[i], i) ?
                            true : false; break;
                        }   // end of case 2
                    case 4: 
                        {
                            result = Rule1(testingArray, testingArray[i], 4); 
                            break;
                        }   // end of case 3 
                    case 7: 
                        {
                            result = Rule1(testingArray, testingArray[i], 7); 
                            break;
                        }   // end of case 6
                }   // end of switch
            }   // end of if
            i++;
        } while(i < testingArray.Length);
        return result;
    }   // end of AlgorithmFunction()

    
    public bool Rule1(int[] array, int i, int index)
        // Role that check if number + 1 is the same 
        // as next number in the array.
        //      ___ ___ ___
        // formel: [index + 1] = =[index] + 1;
    {
        int startValue = index;
        try
        {
            int winnerCounter = 0;
            do{
                if (i == array[index + 1] - 1)
                //if (i + 1 == array[index + 1])
                {
                    WinningsLine[winnerCounter] = array[index];
                    winnerCounter++;
                    if (winnerCounter == 2)
                    {
                        WinningsLine[winnerCounter] = array[index + 1];
                        Winner = true;
                        break;
                    }   // end of if
                    else
                        Winner = false;
                    if (index != i)
                    {
                        i = array[index + 1];
                        //index += 1;
                    }   // end of if
                    else
                    {
                        i += 1;
                        //index += 1;
                    } 
                }   // end of if
                index++;
                //startValue++;

            } while (index != startValue + 3); 
        }   // end of try
        catch { Winner = false; }
        return Winner; 
    }   // end of Rule1()

    public bool Rule2(int[] array, int i, int index)
        // Role that check if number + 2 is the same
        // as next number in the array.
        //      /
        //     /
        //    /
        // formel: [index + (NumberOfBoxes - 1)] = [index] + (NumberOfBoxes - 1)
    {
        try
        {
            int winnerCounter = 0;
            do
            {
                if (i == array[index + 1] - (NumberOfBoxes - 1))
                //if (i + (NumberOfBoxes - 1) == array[index + 1])
                {
                    WinningsLine[winnerCounter] = array[index - 1];
                    winnerCounter++;
                    if (winnerCounter == 2)
                    {
                        WinningsLine[winnerCounter] = array[index + 1];
                        Winner = true;
                        break;
                    }   // end of if
                    else
                        Winner = false;

                    if (index != i)
                    {
                        i = array[index + 1];
                        index += 1;
                    }   // end of if
                    else
                    {
                        i += 2;
                        index += 1;
                    }   // end of else
                    
                }   // end of if
                else
                    index += 1;
                
            } while (winnerCounter != 2 || index != array.Length - 1);
        }   // end of try
        catch { Winner = false;  }
        return Winner; 
    }   // end of Rule2()

    public bool Rule3(int[] array, int i, int index)
        // Role that check if number + 3 is the same
        // as next number in the array.
        //      |
        //      |
        //      |
        // formel: [index + NumberOfBoxes] = [index] + NumberOfBoxes;
    {
        //int startValue = i;
        //int indexValue = i;
        try
        {
            int winnerCounter = 0;
            do
            {
                //winnerCounter = 0;
                if (i == array[index + 1] - NumberOfBoxes)
                //if (i + NumberOfBoxes == array[index + 1])
                {
                    
                    WinningsLine[winnerCounter] = array[index - 1];
                    winnerCounter++;
                    if (winnerCounter == 2)
                    {
                        WinningsLine[winnerCounter] = array[index + 1];
                        Winner = true;
                        break;
                    }   // end of if
                    else
                        Winner = false;

                    //if (index != i)
                    //{
                        i = array[index + 1];
                        index += 1;
                    //}   // end of if
                    //else
                    //{
                    //    i += 1;
                    //    indexValue += 1;
                    //}   // end of else
                }   // end of if
                else
                    index += 1;
                
            } while (winnerCounter != 2 || index != array.Length - 1);
        }   // end of try
        catch { Winner = false; }
        return Winner; 
    }   // end of Rule3()

    public bool Rule4(int[] array, int i, int index)
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
                //winnerCounter = 0;
                //if (array[i + 1] == array[i] + (NumberOfBoxes + 1))
                if (i == array[index + 1] - (NumberOfBoxes + 1))
                //if (i + (NumberOfBoxes + 1) == array[index + 1])
                {
                    winnerCounter++;
                    WinningsLine[winnerCounter] = array[index];
                    if (winnerCounter == 2)
                    {
                        Winner = true;
                        break;
                    }   // end of if
                    else
                        Winner = false;
                }   // end of if
                index++;
            } while (winnerCounter != 2 || index != array.Length - 1);
        }   // end of try
        catch { Winner = false;  }
        return Winner; 
    }   // end of Rule4()

    // end of methods

}   // end of class Intelligence
