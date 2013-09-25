﻿using System;
using System.Collections.Generic;
using System.Linq;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class Player is part of the project TikTakToe.
 *                 Datum: 2013-09-25
 *            Programare: Hrodvar Johannsson
 *                        Mikael
 *                        Pilip
 *                        Fatos
 */

class Game
{
    public Game()
    {
        Player thomas = new Player("Thomas", 'O');
        Player johan = new Player("Johan", 'X');
        Board board = new Board();
        board.PlayerInformation(thomas.PlayerName, thomas.Symbol, johan.PlayerName, johan.Symbol);
        do
        {
            board.Play(Console.ReadKey(true).KeyChar, thomas.Symbol);
            board.Play(Console.ReadKey(true).KeyChar, johan.Symbol);
        } while(true);
    }
}

