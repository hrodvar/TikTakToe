using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class Player is part of the project TikTakToe.
 *                 Datum: 2013-09-25
 *            Programare: Hrodvar Johannsson
 *                        Mikael Wilkon
 *                        Philip Andreasson
 *                        Fatos Jasharaj
 */

class Board
{
    // properties
    public int[] XPosition = new int[] { 10, 20, 30 };
    public int[] YPosition = new int[] { 7, 11, 15 };
    public int XPlayerPosition { get; set; }
    public int YPlayerPosition { get; set; }
    public string boardColor = "Yellow";
    public string playerColor = "Red";
    public string symbolColor = "Green";
    // end of properties

    // constructor
    public Board()
    {
        CreateBoard();
    }
    // end ofconstructor

    public void CreateBoard()
    {
        int ySheet = 5;
        int xSheet = 5;
        int xColumn = 5;
        string strValue1 = new String('-', 31);
        string strValue2 = "|";
        for (int i = 0; i < 3; i++)
        {
            (strValue1).CW(xSheet, ySheet, boardColor);
            Console.SetCursorPosition(xColumn, ySheet + 1);
            for (int x = 0; x < 4; x++)
            {
                (strValue2).CW(xColumn, ySheet + 1, boardColor);
                (strValue2).CW(xColumn, ySheet + 2, boardColor);
                (strValue2).CW(xColumn, ySheet + 3, boardColor);
                if (x == 3)
                    xColumn = 5;
                else
                    xColumn += 10;
            }   // end of for
            ySheet += 4;
        }   // end of for
        (strValue1).CW(xSheet, ySheet, boardColor);
    }   // end of CreateBoard()

    public void Play(char i, char symbol)
    {

        switch (i)
        {
            case '1': { XPlayerPosition = XPosition[0]; YPlayerPosition = YPosition[0]; break; }
            case '2': { XPlayerPosition = XPosition[1]; YPlayerPosition = YPosition[0]; break; }
            case '3': { XPlayerPosition = XPosition[2]; YPlayerPosition = YPosition[0]; break; }
            case '4': { XPlayerPosition = XPosition[0]; YPlayerPosition = YPosition[1]; break; }
            case '5': { XPlayerPosition = XPosition[1]; YPlayerPosition = YPosition[1]; break; }
            case '6': { XPlayerPosition = XPosition[2]; YPlayerPosition = YPosition[1]; break; }
            case '7': { XPlayerPosition = XPosition[0]; YPlayerPosition = YPosition[2]; break; }
            case '8': { XPlayerPosition = XPosition[1]; YPlayerPosition = YPosition[2]; break; }
            case '9': { XPlayerPosition = XPosition[2]; YPlayerPosition = YPosition[2]; break; }
        }   // end of switch
        WritePossition(symbol);
    }   // end of Play()

    public void WritePossition(char symbol)
    {
        (symbol.ToString()).CW(XPlayerPosition, YPlayerPosition, symbolColor);
    }   // end of WritePossition()

    public void PlayerInformation(string player1, char player1Symbol, string player2, char player2Symbol)
    {
        (player1).CW(5, 2, playerColor);
        ("har").CW(12, 2, playerColor);
        (player1Symbol.ToString()).CW(17, 2, symbolColor);
        (player2).CW(5, 3, playerColor);
        ("har").CW(12, 3, playerColor);
        (player2Symbol.ToString()).CW(17, 3, symbolColor);

        
    }   // end of PlayerInformation()
}   // end of class Board