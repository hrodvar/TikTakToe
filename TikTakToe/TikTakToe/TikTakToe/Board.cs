using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Board
{
    // properties
    public int[] XPosition = new int[] { 10, 20, 30 };
    public int[] YPosition = new int[] { 7, 11, 15 };
    public int XPlayerPosition { get; set; }
    public int YPlayerPosition { get; set; }
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
        int yColumn = 5;
        int xColumn = 5;
        string strValue1 = new String('-', 31);
        string strValue2 = "|";
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(xSheet, ySheet);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(strValue1);
            Console.SetCursorPosition(xColumn, ySheet + 1);
            for (int x = 0; x < 4; x++)
            {
                Console.SetCursorPosition(xColumn, ySheet + 1);
                Console.WriteLine(strValue2);
                Console.SetCursorPosition(xColumn, ySheet + 2);
                Console.WriteLine(strValue2);
                Console.SetCursorPosition(xColumn, ySheet + 3);
                Console.WriteLine(strValue2);
                
                if (x == 3)
                    xColumn = 5;
                else
                    xColumn += 10;
            }

            ySheet += 4;

        }
        Console.SetCursorPosition(xSheet, ySheet);
        Console.WriteLine(strValue1);
    }

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
        }
        WritePossition(symbol);
    }

    public void WritePossition(char symbol)
    {
        Console.SetCursorPosition(XPlayerPosition, YPlayerPosition);
        Console.WriteLine(symbol);
    }

    public void PlayerInformation(string player1, char player1Symbol, string player2, char player2Symbol)
    {
        Console.SetCursorPosition(5, 2);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(player1);
        Console.SetCursorPosition(12, 2);
        Console.Write(" har ");
        Console.SetCursorPosition(18, 2);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(player1Symbol);
        Console.SetCursorPosition(5, 3);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(player2 );
        Console.SetCursorPosition(12, 3);
        Console.Write(" har ");
        Console.SetCursorPosition(18, 3);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(player2Symbol);
    }
}