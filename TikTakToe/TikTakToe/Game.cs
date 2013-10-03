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
    public bool AI { get; set; }
    // end of properties

    // constructor
    public Game(int boardSize, Player human, Player computer, bool ai)
    {
        AI = ai;
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
        Array.Resize<int>(ref player.PlayerMoves, i + 1);
        int value = 0;
        char choose = ' ';
        do
        {
            // AI is true player is competing with the computer.
            // then 'choose' take value from the AI else from player 2.
            if (AI)
                choose = ' ';// take the value from the AI!
            else

                choose = Console.ReadKey(true).KeyChar;
            
            // test if user choose used window!
            value = (int)Char.GetNumericValue(choose);
            if (value < 1 || value > 9)
            {
                continue;
            }
            foreach (int valuePlayer in player.PlayerMoves)
            {
                if (value == valuePlayer)
                {
                    gameSituation = false;
                    break;
                }   // end of if 
                else
                {
                    foreach (int valueCompetitor in competitor)
                    {
                        if (value == valueCompetitor)
                        {
                            gameSituation = false;
                            break;
                        }   // end of if
                        else
                            gameSituation = true;
                    }   // end of foreach
                }   // end of else
            }   // end of foreach

            if (gameSituation)
                board.Play(choose, player.Symbol, board.SymbolColor);
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
        
    }   // end of Turn()

    // end of methods

}   // end of class Game

