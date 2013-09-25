﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class Player is part of the project TikTakToe.
 *                 Datum: 2013-09-25
 *            Programare: Hrodvar Johannsson
 *                        Mikael
 *                        Pilip
 *                        Fatos
 */

namespace TikTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            utseende();
            Game game = new Game(); 
        }
         
        static void utseende()
        {
            Console.SetWindowSize(40, 20);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
        }
    }
}
