using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class Player is part of the project TikTakToe.
 *                 Datum: 2013-10-01
 *            Programare: Hrodvar Johannsson
 *                        Mikael Wilkon
 *                        Philip Andreasson
 *                        Fatos Jasharaj
 *                        Xin Hansen
 */

public class WinnerScreen
{
    // properties
    public string WinnerColor = "Green";
    public int Boardsize = 3;
    public string BoardColor = "Yellow";
    public string TextColor = "Yellow";
    public List<string> Alternativ = new List<string>() { "Meny", "Avsluta" };
    //  public Player Human { get; set; }
    //  public Player Computer { get; set; }

    // end of properties

    // constructor
    public WinnerScreen()
    {
        CreateFront(Boardsize);
        MenyIIList();
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

        (strLeftTopCorner + strHorisontell + strRightTopCorner).CW(xSheet, ySheet, BoardColor);
        ("Winner!").CW(17, 4, WinnerColor);

        for (int l = 0; l < 14; l++)
        {
            (strVertikal).CW(xSheet, ySheet + 1 + l, BoardColor);
            (strVertikal).CW(xSheet + 31, ySheet + 1 + l, BoardColor);
        }   // end of for

        (strLeftBottomCorner + strHorisontell + strRightBottomCorner).CW(xSheet, ySheet + 15, BoardColor);
    }   // end of CreateFront()

    public void Utseende(int boardsize)
    {
        Console.SetWindowSize(boardsize * 13, boardsize * 7);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
    }   // end of Utseende()

    public void GetOptions(bool onePlayer)
    {
        //  CreateFront(Boardsize);
        Console.SetCursorPosition(21, 8);


        //Console.ReadLine();

        if (!onePlayer)
        {
            Console.SetCursorPosition(21, 12);
            //Console.ReadLine();

        }   // end of if

        StartUp startUp = new StartUp();
        startUp.MenylList();

        // startUp.CreateFront(Boardsize);
        Game game = new Game(startUp.BoardSize, startUp.Human, startUp.Computer, startUp.AI);

        Console.Clear();
    }   // end of GetOptions()

    public void MenyIIList()
    {

        CreateFront(Boardsize);

        for (int i = 0; i < Alternativ.Count; i++)
        {
            (i + 1 + ". " + Alternativ[i]).CW(6, i + 8, TextColor);

        }   // end of for



        AltVal2();


        Console.Clear();
    }   // end of MenyIIList()

    public void AltVal2()
    {
        char key = Console.ReadKey(true).KeyChar;

        switch (key)
        {
            case '1': { GetOptions(true); break; }
            //  case '2': { GetOption(true); break; }  


        }   // end of switch

    }   // end of AltVal2()

    public void AltVal3()
    {
        char key = Console.ReadKey(true).KeyChar;

        switch (key)
        {
            //case '1': { GetOption(true); break; }   
            case '2': { GetOptions(true); break; }


        }   // end of switch

    }   // end of AltVal3()
    // end of methods

}


