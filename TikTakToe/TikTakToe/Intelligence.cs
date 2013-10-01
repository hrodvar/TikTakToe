using System;
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
            //match = false;
            Array.Sort(array);
            int counter = 0;
            Rounds = 0;
            int i = array[0];
            switch (i)
            {
                case 1: { match = Rule1(array) || Rule3(array) || Rule4(array) ? true : false; break; }
                case 2: { match = Rule3(array) ? true : false; break; }
                case 3: { match = Rule2(array) || Rule3(array) ? true : false; break; }
                case 4: { match = Rule1(array) ? true : false; break; }
                case 7: { match = Rule1(array) ? true : false; break; }
            }   // end of switch
            if (match)
                counter++;
            else
                counter = 0;
        }
        return match;
    }   // end of IntelligenceCalculator()

    public bool Rule1(int[] array)
        // Role that check if number + 1 is the same 
        // as next number in the array.
        //      ___ ___ ___
        // formel: [index + 1] = [index] + 1;
    {
        List<int> list = new List<int>();
        int i = 0;
        try
        {
            do
            {
                if (array.Length > 3)
                {
                    int listCounter = 0;
                    List<int> list = new List<int>();
                    foreach (int num in array)
                    {
                        list.Add(num);
                    }
                    do
                    {
                        i = (array[i + list(listCounter)] == array[i] + 1) ? i += 1 : 0;
                        

                    } while ();
                }
                    i = (array[i + 1] == array[i] + 1) ? i += 1 : 0;
                Winner = i != 0 ? true : false;
                Counter = Counter >= WinnerPoints ? 0 : Counter++;
                Rounds++;
            } while (array.Length != Rounds);
            Counter = 0;
        }   // end of try
        catch { Rounds = 0; }
        Rounds = 0;
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
        int i = 0;
        try
        {
            do
            {    // 3, 5, 7index (0 + (3-1)) = 2 (vale = 7);  index(0) = 3; + (3-1)  = 3 + 2 = 5                
                i = (array[i + 1] == array[i] + (NumberOfBoxes - 1)) ? i += (NumberOfBoxes - 1) : 0;
                Winner = i != 0 ? true : false;
                Counter = Counter >= WinnerPoints ? 0 : Counter++;
                Rounds++;
            } while (array.Length != Rounds);
            Counter = 0;
        }   // end of try
        catch { Rounds = 0; }
        Rounds = 0;
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
        int i = 0;
        try
        {
            do
            {   // index(0 + 3) 
                i = (array[i + 1] == array[i] + NumberOfBoxes) ? i += NumberOfBoxes : 0;
                Winner = i != 0 ? true : false;
                Counter = Counter >= WinnerPoints ? 0 : Counter++;
                Rounds++;
            } while (array.Length != Rounds);
            Counter = 0;
        }   // end of try
        catch { Rounds = 0; }
        Rounds = 0;
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
        int i = 0;
        try
        {
            do
            {   // 1, 5, 9; index(0 + 2
                i = (array[i + 1] == array[i] + (NumberOfBoxes + 1)) ? i += (NumberOfBoxes + 1) : 0;
                Winner = i != 0 ? true : false;
                Counter = Counter >= WinnerPoints ? 0 : Counter++;
                Rounds++;
            } while (array.Length != Rounds);
            Counter = 0;
        }   // end of try
        catch { Rounds = 0; }
        Rounds = 0;
        return Winner; 
    }   // end of Rule4()

    // end of methods

}   // end of class Intelligence
