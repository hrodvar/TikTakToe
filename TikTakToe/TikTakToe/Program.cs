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
 */

class Program
{
    // properties
    // end of properties

    // Constructor
    static void Main(string[] args)
    {
        utseende();
        Game game = new Game(); 
    }
    // end of constructor

    // methods
    static void utseende()
    {
        Console.SetWindowSize(42, 22);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
    }   // end of utseende()

    // end of methods
}
