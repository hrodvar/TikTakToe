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
 *                        Xin Hansen
 */

class Program
{
    // properties
    public static int    BoardSize      = 3;
    public static string HumanName      = "Hroi";
    public static char   SymbolHuman    = 'X';
    public static Player Human          = new Player(HumanName, SymbolHuman);
    public static string ComputerName   = "Thomas";
    public static char   SymbolComputer = 'O';
    public static Player Computer       = new Player(ComputerName, SymbolComputer);
    // end of properties

    // Constructor
    static void Main(string[] args)
    {
        utseende();
        do
        {
            Game game = new Game(BoardSize, Human, Computer); 
        } while (Run());
    }
    // end of constructor

    // methods
    static void utseende()
    {
        Console.SetWindowSize(BoardSize * 13, BoardSize * 7);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
    }   // end of utseende()

    static bool Run()
    {
        bool result = false;
        do
        {  
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Enter)
            {
                Array.Clear(Human.PlayerMoves, 0, Human.PlayerMoves.Length);
                Array.Clear(Computer.PlayerMoves, 0, Computer.PlayerMoves.Length);
                Console.Clear();
                result = true;
            }   //  end of if
            else if (key == ConsoleKey.Escape)
                Environment.Exit(0);    //  stänger programmet
            else
                result = false;
        } while (!result);
        return result;
    }   //  end of Run()

    // end of methods
}
