using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class AIHroi is part of the project TikTakToe.
 *                 Datum: 2013-10-07
 *            Programare: Hrodvar Johannsson
 */

public class AIHroi
{
    // properties
    public Intelligence intelligence { get; set; }
    public int[] BoardArray = new int[9];
    public int[,] pos = new int[8, 3];
    public int[,] values = new int[8,3] { {1,2,3}, {4,5,6}, {7, 8 ,9}, {1, 4, 7}, {2, 5, 8}, {3, 6, 9}, {1, 5, 9}, {3, 5, 7} };
    public int ReturnValue { get; set; }
    // end of properties

    // constructor
    public AIHroi(int[] computerArray, int[] humanArray)
    {
        BoardArray = CombineArrays(computerArray, humanArray);
        InsertValue(computerArray, -1);
        InsertValue(humanArray, 1);
        if (computerArray.Length == 1)
            ReturnValue = 5;
        else
        ReturnValue = CheckOutTheWinningsPositions();
    }
    // end of constructor

    // methods
    public int CheckOutTheWinningsPositions()
    {
        int value = 0;
        int sum = 0;
        int k = 0;
        try
        {
            value = 2;
            do
            {
                for (int i = 0; i < values.GetLength(0); i++)
                {
                    for (int j = 0; j < values.GetLength(1); j++)
                    {
                        if (pos[i, j] == 0)
                            k = values[i, j];
                        
                            sum += pos[i, j];
                    }   // end of for  

                    if (sum == value)
                        return k; 
                    else if (sum == -value)
                        return k; 

                    sum = 0;
                }   // end of for
                value -= 1;
            } while (value != 0);
        }
        catch { }
        return 0;
    }   // CheckOutTheWinningsPositions()
    public void InsertValue(int[] array, int playerValue)
    {
        foreach (int i in array)
        {
            if (i > 0)
            {
                switch (i)
                {
                    case 1:
                        {
                            pos[0, 0] = playerValue;
                            pos[3, 0] = playerValue;
                            pos[6, 0] = playerValue;
                            break;
                        }
                    case 2:
                        {
                            pos[0, 1] = playerValue;
                            pos[4, 0] = playerValue;
                            break;
                        }
                    case 3:
                        {
                            pos[0, 2] = playerValue;
                            pos[5, 0] = playerValue;
                            pos[7, 0] = playerValue;
                            break;
                        }
                    case 4:
                        {
                            pos[1, 0] = playerValue;
                            pos[3, 1] = playerValue;
                            break;
                        }
                    case 5:
                        {
                            pos[1, 1] = playerValue;
                            pos[4, 1] = playerValue;
                            pos[6, 1] = playerValue;
                            pos[7, 1] = playerValue;
                            break;
                        }
                    case 6:
                        {
                            pos[1, 2] = playerValue;
                            pos[5, 1] = playerValue;
                            break;
                        }
                    case 7:
                        {
                            pos[2, 0] = playerValue;
                            pos[3, 2] = playerValue;
                            pos[7, 2] = playerValue;
                            break;
                        }
                    case 8:
                        {
                            pos[2, 1] = playerValue;
                            pos[4, 2] = playerValue;
                            break;
                        }
                    case 9:
                        {
                            pos[2, 2] = playerValue;
                            pos[5, 2] = playerValue;
                            pos[6, 2] = playerValue;
                            break;
                        }
                }   // end of switch
            }
        }
    }   // end of WinningPositions()

    public int[] CombineArrays(int[] computerArray, int[] humanArray)
    {
        int[] resultArray = new int[9];
        if (computerArray.Length > 1)
            foreach (int item in computerArray)
                if (item > 0)
                    resultArray[item - 1] = item;
        if (humanArray.Length >= 0)
            foreach (int item in humanArray)
                resultArray[item - 1] = item;
        return resultArray;
    }   // end of CombineArrays()

    // end of methods

}   // end of class AIHroi

