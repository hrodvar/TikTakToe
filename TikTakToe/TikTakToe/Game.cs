using System;
using System.Collections.Generic;
using System.Linq;


class Game
{
    public Game()
    {
        Player thomas = new Player("Thomas", 'O');
        Player johan = new Player("Johan", 'X');
        Board board = new Board();
        board.PlayerInformation(thomas.PlayerName, johan.PlayerName);
        ConsoleKeyInfo key;

        do
        {
            board.Play(Console.ReadKey(true).KeyChar, thomas.Symbol);
            board.Play(Console.ReadKey(true).KeyChar, johan.Symbol);
            //Console.SetCursorPosition(8, 40);
        } while(true);
    }
}

