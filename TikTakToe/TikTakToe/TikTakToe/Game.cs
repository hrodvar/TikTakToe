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
        board.PlayerInformation(thomas.PlayerName, thomas.Symbol, johan.PlayerName, johan.Symbol);
        do
        {
            board.Play(Console.ReadKey(true).KeyChar, thomas.Symbol);
            board.Play(Console.ReadKey(true).KeyChar, johan.Symbol);
        } while(true);
    }
}

