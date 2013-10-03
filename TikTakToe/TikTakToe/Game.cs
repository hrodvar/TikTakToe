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
 *                        Xin Hansen
 */

public class Game
{
    // properties
    public string WinnerColor = "Green";
    public char[] WinningNumbers = {'l','k','j','h','g','f','d','s','a',};
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
            if (!(gameSituation = PlayValue(human, computer.PlayerMoves, board, i)))
                break;
            if (!(gameSituation = PlayValue(computer, human.PlayerMoves, board, i)))
                break;
            i++;
        } while (gameSituation);
    }   // end of Game()
    // end of constructor

    // methods

    public bool PlayValue(Player player, int[] competitor, Board board, int i)
    {
        bool gameSituation = true;
        Intelligence intelligence = new Intelligence();
        //if(player.PlayerMoves.Count() != 1)
            Array.Resize<int>(ref player.PlayerMoves, i + 1);
        int value = 0;
        char choose = ' ';
        do
        {
            choose = Console.ReadKey(true).KeyChar;
            value = (int)Char.GetNumericValue(choose);
            foreach (int valuePlayer in player.PlayerMoves)
            {
                if (valuePlayer == value)
                {
                    gameSituation = false;
                    break;
                }   // end of if
                else if (competitor.Length == 0)
                {
                    board.Play(choose, player.Symbol, board.SymbolColor);
                    gameSituation = true;
                    break;
                }   // end of else if 
                else
                {
                    foreach (int valueCompetitor in competitor)
                    {
                        if (valueCompetitor == value)
                        {
                            gameSituation = false;
                            break;
                        }   // end of if
                        else
                        {
                            board.Play(choose, player.Symbol, board.SymbolColor);
                            gameSituation = true;
                            break;
                        }   // end of else
                    }   // end of foreach
                }   // end of else
            }   // end of foreach
        } while (!gameSituation);

        gameSituation = true;
        player.PlayerMoves[i] = value;
        if (GameSituation(player.PlayerName, intelligence.IntelligenceCalculator(player.PlayerMoves)))
            gameSituation = true;
        else
            gameSituation = false;
        return gameSituation;
    }   // end of PlayValue()

    public bool GameSituation(string name, bool gameSituation)
    {
        if (gameSituation)
        {
            (name + " is a winner!").CW(0, 0, WinnerColor);
            return false;
        }   // end of if
        else
            return true;
    }   // end of GameSituation()

    public void Turn(Player Player)
    {
        string name = Player.PlayerName;

        if (name.EndsWith("s"))
        {
            ("Det är: " + name + " (" + Player.Symbol + ") " + "tur att spela!").CW(5, 4, "Green");
        }
        else
            ("Det är: " + name + " (" + Player.Symbol + ") " + "s tur att spela!").CW(5, 4, "Green");
       
        /* int i = name.Length;
        char[] nameArrey = name.ToCharArray();

        if (nameArrey[i - 1] != 's')
            name = name + "s";
        ("Det är: " + name + " (" + Player.Symbol + ") " + "Tur att spela!").CW(5, 4, "Green");*/

    }   // end of Turn()

    // end of methods

}   // end of class Game

