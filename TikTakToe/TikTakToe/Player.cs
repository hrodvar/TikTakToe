using System;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class Player is part of the project TikTakToe.
 *                 Datum: 2013-09-25
 *            Programare: Hrodvar Johannsson
 */

public class Player
{
    // properties
    public string PlayerName { get; set; }
    public Char Symbol { get; set; }
    public int[] PlayerMoves = new int[0];
    // end of properties

    // constructor
    public Player(string name, char symbol)
    {
        PlayerName = name;
        Symbol = symbol;
    }
    // end of constructor

    // methods
    // end of methods
}   // end of class Player
