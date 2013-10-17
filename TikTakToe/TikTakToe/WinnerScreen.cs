using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class WinnerScreen is part of the project TikTakToe.
 *                 Datum: 2013-10-17
 *            Programare: Hrodvar Johannsson
 */

public class WinnerScreen
{
    // properties
    public string TableColor = "DarkBlue";
    public string WinnerColor = "Green";
    public string InputTextColor = "Red";
    public string DisableTextColor = "Gray";
    public string BoardColor = "Yellow";
    public string TextColor = "Yellow";
    public int Boardsize = 3;
    // end of properties

    // constructor
    public WinnerScreen()
    {
        Console.Clear();
        CreateFront(Boardsize);
        AboutTicTacToe();
    }  
    // end of constructor

    // methods
    public void CreateFront(int boardsize)
    {
        int ySheet = 2;
        int xSheet = 4;
        string strLeftTopCorner = new String('╔', 1);
        string strRightTopCorner = new String('╗', 1);
        string strLeftBottomCorner = new String('╚', 1);
        string strRightBottomCorner = new String('╝', 1);
        string strHorisontell = new String('═', 30);
        string strVertikal = new String('║', 1);

        Utseende(boardsize);

        (strLeftTopCorner + strHorisontell + strRightTopCorner).CW(xSheet, ySheet, BoardColor, TableColor);
    
        for (int l = 0; l < 14; l++)
        {
            (strVertikal).CW(xSheet, ySheet + 1 + l, BoardColor, TableColor);
            (strVertikal).CW(xSheet + 31, ySheet + 1 + l, BoardColor, TableColor);
        }   // end of for

        (strLeftBottomCorner + strHorisontell + strRightBottomCorner).CW(xSheet, ySheet + 15, BoardColor, TableColor);
    }   // end of CreateFront()

    public void Utseende(int boardsize)
    {
        Console.Title = "TikTakToe";
        Console.SetWindowSize(40, 24);
        Console.SetBufferSize(40, 24);
        Console.CursorVisible = false;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
    }   // end of Utseende()

    public void AboutTicTacToe()
    {
        string output = "About TicTacToe";
        int x = (Console.WindowWidth / 2) - (output.Length / 2);
        int y = 5;
        (output).CW(x, y, TextColor, TableColor);

        ("TicTacToe 1.0.").CW(8, y+=2, TextColor, TableColor);
        ("Tekninkhögskolan 2013.").CW(8, y++, TextColor, TableColor);
        y = y + 1;
        ("Authors:").CW(8, y++, TextColor, TableColor);
        ("   Hrodvar Johannsson,").CW(8, y++, TextColor, TableColor);
        ("   Mikael Wilkon,").CW(8, y++, TextColor, TableColor);
        ("   Philip Andreasson").CW(8, y++, TextColor, TableColor);
        y = y + 1;
        ("Teacher:").CW(8, y++, TextColor, TableColor);
        ("   Thomas Frank").CW(8, y++, TextColor, TableColor);
        string meny = "Press F1  - Menu";
        string esc  = "Press Esc - Exit";
        int xNew = (Console.WindowWidth / 2) - (meny.Length / 2);
        y = y + 3;
        (meny).CW(xNew, y++, DisableTextColor, TableColor);
        (esc).CW(xNew, y++, DisableTextColor, TableColor);
        

        bool result = false;
        do
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.F1)
                result = true;
            else if (key == ConsoleKey.Escape)
                Environment.Exit(2);    //  stänger programmet
            else
                result = false;
        } while (!result);
        Console.Clear();
    }   // end of AboutTicTacToe()

    // end of methods

}


