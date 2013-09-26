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
            Winner(board.Play(Console.ReadKey(true).KeyChar, thomas.Symbol), thomas);
            Turn(johan);
            board.Play(Console.ReadKey(true).KeyChar, johan.Symbol);
        } while(true);
    }   // end of Game()
    // end of constructor

    // methods

    public string[] Winner(char pos, Player player)
    {
        int Pos = Convert.ToInt16(pos.ToString());
        char[] Arr = new char[9];
        string[] winner = new string[4];

        Arr[Pos] = player.Symbol;

        if (Arr[0] == Arr[1] && Arr[1] == Arr[2])
        {
            ("hej").CW();
            winner = new string[] {player.PlayerName, "1", "2", "3"};            
            return winner;
        }
        else if (Arr[3] == Arr[4] && Arr[4] == Arr[5])
        {
            winner = new string[] { player.PlayerName, "4", "5", "6" };
            return winner;
        }
        else if (Arr[6] == Arr[7] && Arr[7] == Arr[8])
        {
            winner = new string[] { player.PlayerName, "7", "8", "9" };
            return winner;
        }
        else if (Arr[0] == Arr[3] && Arr[3] == Arr[6])
        {
            winner = new string[] { player.PlayerName, "1", "4", "7" };
            return winner;
        }
        else if (Arr[1] == Arr[4] && Arr[4] == Arr[7])
        {
            winner = new string[] { player.PlayerName, "2", "5", "8" };
            return winner;
        }
        else if (Arr[2] == Arr[5] && Arr[5] == Arr[8])
        {
            winner = new string[] { player.PlayerName, "3", "6", "9" };
            return winner;
        }
        else if (Arr[0] == Arr[4] && Arr[4] == Arr[8])
        {
            winner = new string[] { player.PlayerName, "1", "5", "9" };
            return winner;
        }
        else if (Arr[6] == Arr[4] && Arr[4] == Arr[2])
        {
            winner = new string[] { player.PlayerName, "7", "5", "3" };
            return winner;
        }
        else return null;
    }
    public void GameSituation(string[] Winner)
    {
        string WinnerColor = "Yellow";
        if (Winner != null)
        {
            ("Vinnaren är" + Winner[0] + ". Grattis!").CW(9, 18, WinnerColor);
            ("Du placerade vinnande täcken på").CW(6, 19, WinnerColor);
            (Winner[1] + Winner[2] + Winner[3]).CW(18, 20, WinnerColor);

        }
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

