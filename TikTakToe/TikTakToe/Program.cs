using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class Program is part of the project TikTakToe.
 *                 Datum: 2013-09-25
 *            Programare: Hrodvar Johannsson
 */

class Program
{
    // properties
    public static Game game { get; set; }
    // end of properties

    // Constructor
    static void Main(string[] args)
    {
        bool run = false;
        do
        {
            run = PlayTheGame();
        } while (!run);
    }
    // end of constructor

    // methods
    static bool PlayTheGame()
    {
        StartUp startUp = new StartUp();
        do
        {
            game = new Game(startUp.BoardSize, startUp.Human, startUp.Computer, startUp.AIAuthor);
        } while (Run(startUp.Human, startUp.Computer, startUp));
        return false;
    }   // end of PlayTheGame()

    static bool Run(Player human, Player computer, StartUp startUp)
    {
        bool result = false;
        do
        {  
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Enter)
            {
                Array.Clear(human.PlayerMoves, 0, human.PlayerMoves.Length);
                Array.Resize<int>(ref human.PlayerMoves, 0);
                Array.Clear(computer.PlayerMoves, 0, computer.PlayerMoves.Length);
                Array.Resize<int>(ref computer.PlayerMoves, 0);
                Console.Clear();
                result = true;
            }   //  end of if
            else if (key == ConsoleKey.F1)
            {
                result = false;
                break;
            }   // end of else if
            else if (key == ConsoleKey.Escape)
                Environment.Exit(2);    //  stänger programmet
            //else
            //    result = false;
        } while (!result);
        return result;
    }   //  end of Run()

    // end of methods

}   // end of class Program
