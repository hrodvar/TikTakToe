using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Board
{
    // properties
    public int[] XPossition = new int[] {7, 12, 17};
    public int[] YPossition = new int[] { 7, 10, 13 };
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
        string strValue1 = new String('-', 16);
        string strValue2 = "|";
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(xSheet, ySheet);
            Console.WriteLine(strValue1);
            Console.SetCursorPosition(xColumn, ySheet + 1);
            for (int x = 0; x < 4; x++)
            {
                Console.SetCursorPosition(xColumn, ySheet + 1);
                Console.WriteLine(strValue2);
                Console.SetCursorPosition(xColumn, ySheet + 2);
                Console.WriteLine(strValue2);
                if (x == 3)
                    xColumn = 5;
                else
                xColumn += 5;
            }
                
            ySheet += 3;
                
        }
        Console.SetCursorPosition(xSheet, ySheet);
        Console.WriteLine(strValue1);
    }

    public void Play(char i, char symbol)
    {
        
        switch (i)
        {
            case '1': { XPlayerPosition = XPossition[0]; YPlayerPosition = YPossition[0]; break; }
            case '2': { XPlayerPosition = XPossition[1]; YPlayerPosition = YPossition[0]; break; }
            case '3': { XPlayerPosition = XPossition[2]; YPlayerPosition = YPossition[0]; break; }
            case '4': { XPlayerPosition = XPossition[0]; YPlayerPosition = YPossition[1]; break; }
            case '5': { XPlayerPosition = XPossition[1]; YPlayerPosition = YPossition[1]; break; }
            case '6': { XPlayerPosition = XPossition[2]; YPlayerPosition = YPossition[1]; break; }
            case '7': { XPlayerPosition = XPossition[0]; YPlayerPosition = YPossition[2]; break; }
            case '8': { XPlayerPosition = XPossition[1]; YPlayerPosition = YPossition[2]; break; }
            case '9': { XPlayerPosition = XPossition[2]; YPlayerPosition = YPossition[2]; break; }
        }
        WritePossition(symbol);
    }

    public void WritePossition(char symbol)
    {
        Console.SetCursorPosition(XPlayerPosition, YPlayerPosition);
        Console.WriteLine(symbol);
    }

    public void PlayerInformation(string player1, string player2)
    {
        Console.SetCursorPosition(22, 6);
        Console.WriteLine("Player 1:");
        Console.SetCursorPosition(22, 7);
        Console.WriteLine(player1);
        Console.SetCursorPosition(22, 10);
        Console.WriteLine("Player 2:");
        Console.SetCursorPosition(22, 11);
        Console.WriteLine(player2);
    }
}

