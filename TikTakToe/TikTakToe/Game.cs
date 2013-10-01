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

public class Game
{
    // properties
    public string WinnerColor = "Green";
    //public Players[] PlayersArray = new Player(name, symbol);
    // end of properties

    // constructor
    public Game(int boardSize, Player human, Player computer)
    {
        bool gameSituation = true;
        Board board = new Board(boardSize);
        Intelligence intelligence = new Intelligence();
        board.PlayerInformation(human.PlayerName, human.Symbol, computer.PlayerName, computer.Symbol);
        int i = 0;
        do
        {
            Array.Resize<int>(ref human.PlayerMoves, i + 1);
            Array.Resize<int>(ref computer.PlayerMoves, i + 1);
            human.PlayerMoves[i] = (!human.PlayerMoves.Contains(i) && !computer.PlayerMoves.Contains(i)) ?
                board.Play(Console.ReadKey(true).KeyChar, human.Symbol, board.SymbolColor) :
                board.Play(Console.ReadKey(true).KeyChar, human.Symbol, board.SymbolColor);
            //human.PlayerMoves[i] = board.Play(Console.ReadKey(true).KeyChar, human.Symbol, board.SymbolColor);
            if (GameSituation(human.PlayerName,intelligence.IntelligenceCalculator(human.PlayerMoves)))
                gameSituation = true;
            else
                break;
            computer.PlayerMoves[i] = board.Play(Console.ReadKey(true).KeyChar, computer.Symbol, board.SymbolColor);
            if (GameSituation(computer.PlayerName, intelligence.IntelligenceCalculator(computer.PlayerMoves)))
                gameSituation = true;
            else
                break;
            i++;
        } while (gameSituation);
    }   // end of Game()
    // end of constructor

    // methods
    public bool GameSituation(string name, bool gameSituation)
    {
        if (gameSituation)
        {
            (name + " is a winner!").CW(0, 0, WinnerColor);
            return false;
        }
        else
            return true;
    }   // end of GameSituation()
    // end of methods

}

