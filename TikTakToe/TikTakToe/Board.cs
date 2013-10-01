﻿using System;
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
 *                        Xin Hansen
 */

public class Board
{
    // properties
    public int BoardSize { get; set; }
    public int[] XPosition = new int[] { 10, 20, 30 };
    public int[] YPosition = new int[] { 7, 11, 15 };
    public int XPlayerPosition { get; set; }
    public int YPlayerPosition { get; set; }
    public string BoardColor = "Yellow";
    public string PlayerColor = "Red";
    public string SymbolColor = "Green";
    public string InstructionColor = "Gray";
    // end of properties

    // constructor
    public Board(int boardSize)
    {
        CreateBoard(boardSize);
    }
    // end ofconstructor

    public void CreateBoard(int boardSize)
    {
        BoardSize   = boardSize;
        int ySheet  = 5;
        int xSheet  = 5;
        int xColumn = 5;
        string strLeftTopCorner              = new String('╔', 1); 
        string strRightTopCorner             = new String('╗', 1); 
        string strTopColumnSeperator         = new String('╦', 1);
        string strMiddelLeftColumnSeperator  = new String('╠', 1);
        string strMiddelRightColumnSeperator = new String('╣', 1);
        string strMiddelColumnSeperator      = new String('╬', 1); 
        string strLeftBottomCorner           = new String('╚', 1); 
        string strRightBottomCorner          = new String('╝', 1); 
        string strBottomColumnSeperator      = new String('╩', 1);  
        string strHorisontell                = new String('═', boardSize * boardSize);
        string strVertikal                   = new String('║', 1);
        for (int i = 0; i < BoardSize; i++)
        { 
            if (i == 0)
                (strLeftTopCorner + strHorisontell + strTopColumnSeperator + strHorisontell + 
                    strTopColumnSeperator + strHorisontell + strRightTopCorner).
                    CW(xSheet, ySheet, BoardColor
                );
            else
                (strMiddelLeftColumnSeperator + strHorisontell + strMiddelColumnSeperator + 
                    strHorisontell + strMiddelColumnSeperator + strHorisontell + 
                    strMiddelRightColumnSeperator).CW(xSheet, ySheet, BoardColor
                );
            Console.SetCursorPosition(xColumn, ySheet + 1);
            for (int x = 0; x < (BoardSize  + 1); x++)
            {
                (strVertikal).CW(xColumn, ySheet + 1, BoardColor);
                (strVertikal).CW(xColumn, ySheet + 2, BoardColor);
                (strVertikal).CW(xColumn, ySheet + 3, BoardColor);
                if (x == BoardSize)
                    xColumn = 5;
                else
                    xColumn += 10;
            }   // end of for
            ySheet += 4;
        }   // end of for
        (strLeftBottomCorner + strHorisontell + strBottomColumnSeperator + strHorisontell + 
            strBottomColumnSeperator + strHorisontell + strRightBottomCorner).
            CW(xSheet, ySheet, BoardColor
        );
        int writeInstructionValue = 0;
        for (int i = 1; i < 10; i++)
        {
            writeInstructionValue = Play(Convert.ToChar(i.ToString()), 
                Convert.ToChar(i.ToString()), InstructionColor);
        }
    }   // end of CreateBoard()

    public int Play(char c, char symbol, string color)
    {
        int i = 0;
        switch (c)
        {
            case '1': { XPlayerPosition = XPosition[0]; YPlayerPosition = YPosition[0]; i = 1; break; }
            case '2': { XPlayerPosition = XPosition[1]; YPlayerPosition = YPosition[0]; i = 2; break; }
            case '3': { XPlayerPosition = XPosition[2]; YPlayerPosition = YPosition[0]; i = 3; break; }
            case '4': { XPlayerPosition = XPosition[0]; YPlayerPosition = YPosition[1]; i = 4; break; }
            case '5': { XPlayerPosition = XPosition[1]; YPlayerPosition = YPosition[1]; i = 5; break; }
            case '6': { XPlayerPosition = XPosition[2]; YPlayerPosition = YPosition[1]; i = 6; break; }
            case '7': { XPlayerPosition = XPosition[0]; YPlayerPosition = YPosition[2]; i = 7; break; }
            case '8': { XPlayerPosition = XPosition[1]; YPlayerPosition = YPosition[2]; i = 8; break; }
            case '9': { XPlayerPosition = XPosition[2]; YPlayerPosition = YPosition[2]; i = 9; break; }
        }   // end of switch
        WritePosition(symbol, color);
        return i;
    }   // end of Play()

    public void WritePosition(char symbol, string color)
    {
        (symbol.ToString()).CW(XPlayerPosition, YPlayerPosition, color);
    }   // end of WritePossition()

    public void PlayerInformation(string player1, char player1Symbol, string player2, char player2Symbol)
    {
        (player1).CW(5, 2, PlayerColor);
        ("har").CW(12, 2, PlayerColor);
        (player1Symbol.ToString()).CW(17, 2, SymbolColor);
        (player2).CW(5, 3, PlayerColor);
        ("har").CW(12, 3, PlayerColor);
        (player2Symbol.ToString()).CW(17, 3, SymbolColor);
    }   // end of PlayerInformation()
}   // end of class Board