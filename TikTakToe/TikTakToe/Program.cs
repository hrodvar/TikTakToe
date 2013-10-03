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
   
    // end of properties

    // Constructor
    static void Main(string[] args)
    {
        StartUp startUp = new StartUp();
        do
        {
            Game game = new Game(startUp.BoardSize, startUp.Human, startUp.Computer, startUp.AI); 
        } while (Run(startUp.Human, startUp.Computer));
    }
    // end of constructor

    // methods

    static bool Run(Player human, Player computer)
    {
        bool result = false;
        do
        {  
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Enter)
            {
                Array.Clear(human.PlayerMoves, 0, human.PlayerMoves.Length);
                Array.Clear(computer.PlayerMoves, 0, computer.PlayerMoves.Length);
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

}   // end of class Program
