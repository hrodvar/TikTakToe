using System;
using System.Collections.Generic;
using System.Linq;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class Player is part of the project TikTakToe.
 *                 Datum: 2013-09-25
 *            Programare: Hrodvar Johannsson
 *                        Mikael Wilkon
 *                        Philip Andreasson
 *                        Fatos Jasharaj
 */

class Game
{
    // properties
    // end of properties

    // constructor
    public Game()
    {
        Player thomas = new Player("Thomas", 'O');
        Player johan = new Player("Johan", 'X');
        Board board = new Board();
        board.PlayerInformation(thomas.PlayerName, thomas.Symbol, johan.PlayerName, johan.Symbol);
        do
        {
            Turn(thomas);
            board.Play(Console.ReadKey(true).KeyChar, thomas.Symbol);
            Turn(johan);
            board.Play(Console.ReadKey(true).KeyChar, johan.Symbol);
        } while(true);
    }   // end of Game()
    // end of constructor

    // methods
    public void GameSituation(string[] Winner)
    {
        string WinnerColor = "Yellow";
        if (Winner !=null)
        ("Vinnaren är" + Winner[0] + ". Grattis!").CW(9, 18, WinnerColor);
        ("Du placerade vinnande täcken på").CW(6, 19, WinnerColor);
        (Winner[1] + Winner[2] + Winner[3]).CW(18, 20, WinnerColor);
        

    }   // end of GameSituation()

    public void Turn(Player Player)
    {
        
        string name = Player.PlayerName;
        int i = name.Length;
        char[] nameArrey = name.ToCharArray();

        if (nameArrey[i - 1] != 's')
            name = name + "s";
        ("Det är: " + name + " (" + Player.Symbol + ") " + "Tur att spela!").CW(5, 19, "Green");
       
    }
    // end of methods

}

