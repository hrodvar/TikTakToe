using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class StartUp is part of the project TikTakToe.
 *                 Datum: 2013-10-01
 *            Programare: Hrodvar Johannsson
 *                        Mikael Wilkon
 *                        Fatos Jasharaj
 *                        Xin Hansen
 */

public class StartUp
{
    // properties
    public int BoardSize = 3;
    public string TableColor = "DarkBlue";
    public string FramesColor = "Yellow";
    public string TextColor = "Yellow";
    public string InputTextColor = "Red";
    public string DisableTextColor = "Gray";
    public List<string> Alternativ = new List<string>() {"Player", "Mikael", "Fatos", "Philip", "Xin", "Hroi" };
    public Player Human { get; set; }
    public Player Computer { get; set; }
    public AI AIAuthor { get; set; }
    // end of properties

    // constructor
    public StartUp()
    {     
        CreateFront(BoardSize);
        MenylList();      
    }   // end of  StartUp()
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

        (strLeftTopCorner + strHorisontell + strRightTopCorner).CW(xSheet, ySheet, FramesColor, TableColor);
                     
        for (int l = 0; l < 14; l++)
        {
            (strVertikal).CW(xSheet, ySheet + 1 + l, FramesColor, TableColor);
            (strVertikal).CW(xSheet + 31, ySheet + 1 + l, FramesColor, TableColor);
        }   // end of for

        (strLeftBottomCorner + strHorisontell + strRightBottomCorner).CW(xSheet, ySheet + 15, FramesColor, TableColor);     
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

    public void GetNames(string name, bool ai, int i)
    {
        CreateFront(BoardSize);   
        ("Player 1: ").CW(15, 8, TextColor, TableColor);
        Console.CursorVisible = true;
        Human = new Player((" ").CR(15, 9, InputTextColor, TableColor), 'X');
        if (!ai)
        {
            ("Player 2:").CW(15, 11, TextColor, TableColor);
            Computer = new Player((" ").CR(15, 12, InputTextColor, TableColor), 'O');
        }   // end of if
        else
        {
            Computer = new Player(name, 'O');
            //AIPlayer(name, ai, i);
        }   // end of else
        AIPlayer(name, ai, i);
        Console.Clear();
        Console.CursorVisible = false;
    }   // end of GetNames()
    
    public void AIPlayer(string name, bool runAI, int i)
    {    
        AIAuthor = new AI(name, runAI);
    }  // end of AIPlayer()  

    public void MenylList()
    {
        CreateFront(BoardSize);
        ("Velcome to TicTacToe!").CW(10, 5, TextColor, TableColor);

        ("1. Player vs Player ").CW(8, 8, TextColor, TableColor);
        ("2. Player vs Mikaels  AI ").CW(8, 9, TextColor, TableColor);
        ("3. Player vs Fatos    AI ").CW(8, 10, DisableTextColor, TableColor);
        ("4. Player vs Philips  AI ").CW(8, 11, DisableTextColor, TableColor);
        ("5. Player vs Xins     AI ").CW(8, 12, DisableTextColor, TableColor);
        ("6. Player vs Hrois    AI ").CW(8, 13, TextColor, TableColor);
       
        AltVal();
        Console.Clear();
    }   // end of MenylList()

    public void AltVal()
    {
        char key = Console.ReadKey(true).KeyChar;
           
        switch (key)
        {
            case '1': { GetNames(" ", false, 1);break; }
            case '2': { GetNames("Mikaels AI", true,  2); break; }
            case '3': { GetNames("Fatos AI", true,  3); break; }
            case '4': { GetNames("Philips AI", true,  4); break; }
            case '5': { GetNames("Xins AI", true,  5); break; }
            case '6': { GetNames("Hrois AI", true,  6); break; }
            default: { GetNames(" ", false, 1); break; }
        }   // end of switch
    }   // end of AltVal()

    // end of methods

}   // end of class StartUp