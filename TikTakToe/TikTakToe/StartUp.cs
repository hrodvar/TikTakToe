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

public class StartUp
{
    // properties
    public int BoardSize = 3;
    public string BoardColor = "Yellow";
    public string TextColor = "Yellow";
    public List<string> Alternativ = new List<string>() {"Player", "Mikael", 
    "Fatos", "Philip", "Xin", "Hrodvar" };
    public Player Human { get; set; }
    public Player Computer { get; set; }
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
            
        Console.SetWindowSize(boardsize * 13, boardsize * 7);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
   
        (strLeftTopCorner + strHorisontell + strRightTopCorner).CW(xSheet, ySheet, BoardColor);
        ("Välkommen!").CW(15, 4, TextColor);
                     
        for (int l = 0; l < 14; l++)
        {
            (strVertikal).CW(xSheet, ySheet + 1 +l, BoardColor);
            (strVertikal).CW(xSheet + 31, ySheet + 1+ l, BoardColor);
        }   // end of for

        (strLeftBottomCorner + strHorisontell + strRightBottomCorner).CW(xSheet, ySheet + 15, BoardColor);     
    }   // end of CreateFront()

    public void GetNames(bool onePlayer)
    {
        CreateFront(BoardSize);
        ("Spelare1 namn: ").CW(6, 8, TextColor);
        Console.SetCursorPosition(21,8);

        Human = new Player(Console.ReadLine(), 'X');
        if (!onePlayer)
        {
            ("Spelare2 namn:").CW(6, 12, TextColor);
            Console.SetCursorPosition(21, 12);
            Computer = new Player(Console.ReadLine(), 'O');
        }   // end of if
        Console.Clear();
    }   // end of GetNames()
        
    public void MenylList()
    {
        CreateFront(BoardSize);
        ("Till våran TicTacToe!").CW(10, 6, TextColor);

        for (int i = 0; i < Alternativ.Count; i++)
        {   
                (i+1 + ". " +  Alternativ[0] + " Vs " + Alternativ[i]  ).CW(6, i+8, TextColor);
                if(i !=0)("-AI").CW(31, i+8,TextColor);
        }   // end of for
        AltVal();
        Console.Clear();
    }   // end of MenylList()

    public void AltVal()
    {
        char key = Console.ReadKey(true).KeyChar;
           
        switch (key)
        {
            case '1': { GetNames(false);break; }
            case '2': { GetNames(true); break; }
            case '3': { GetNames(true); break; }
            case '4': { GetNames(true); break; }
            case '5': { GetNames(true); break; }
            case '6': { GetNames(true); break; }
        }   // end of switch
    }   // end of AltVal()

    // end of methods

}   // end of class StartUp