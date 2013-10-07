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
    public string TableColor = "DarkBlue";
    public string WinnerColor = "Green";
    public string InstructionColor = "Gray";
    public bool AIMikael { get; set; }
    // end of properties

    // constructor
    public Game(int boardSize, Player human, Player computer, bool aiMikael)
    {
        AIMikael = aiMikael;
        bool gameSituation = true;
        Board board = new Board(boardSize);
        Intelligence intelligence = new Intelligence();
        board.PlayerInformation(human.PlayerName, human.Symbol, computer.PlayerName, computer.Symbol);
        int i = 0;
        do
        {
            if (!(gameSituation = PlayValue(human, computer.PlayerMoves, board, i, false)))
                break;
 
            if (!(gameSituation = PlayValue(computer, human.PlayerMoves, board, i, true)))
            {
                i++;
                break; 
            }

        } while (gameSituation);
    }   // end of Game()
    // end of constructor

    // methods


    public bool PlayValue(Player player, int[] competitor, Board board, int i, bool AI)
    {
        string Draw = "";
        bool gameSituation = true;
        Intelligence intelligence = new Intelligence();
        int length = player.PlayerMoves.Length + 1;
        Array.Resize<int>(ref player.PlayerMoves, length);
        length = player.PlayerMoves.Length - 1;
        int value = 0;
        char choose = ' ';
        do
        {
            // AI is true player is competing with the computer.
            // then 'choose' take value from the AI else from player 2.
            //if (ai)
            //{
            //    AIMikael mikael = new AIMikael(player.PlayerMoves, competitor, player);
            //    choose = mikael.resultat;
            //    value = ((int)Char.GetNumericValue(choose)) + 1;
            //}
            //else
            //{
            if (AI)
            {
                MikaelsAI2 MikaelsBot = new MikaelsAI2(player.PlayerMoves, competitor, player);
                value = MikaelsBot.RoysVariabel;
                choose = Convert.ToChar(value.ToString());
               
            }
            else
            {
                choose = Console.ReadKey(true).KeyChar;
                value = (int)Char.GetNumericValue(choose);

            }

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
            if (player.PlayerMoves.Count() + competitor.Count() == 9)
                Draw = "Draw";
        } while (!gameSituation);

        gameSituation = true;

        player.PlayerMoves[length] = value;
        if (GameSituation(player, intelligence.IntelligenceCalculator(player.PlayerMoves), 
            board, intelligence.WinningsLine, Draw))

            gameSituation = true;
        else
            gameSituation = false;
        return gameSituation;
    }   // end of PlayValue()

    public bool GameSituation(Player player, bool gameSituation, Board board, int[] array, string draw)
    {
        string output = "";
        if (draw != "" && !gameSituation)
        {
            gameSituation = true;
            output = draw;
        }
        else
            output = player.PlayerName + " is a winner!";
        if (gameSituation)
        {
            (output).CW(11, 18, WinnerColor, TableColor);
            ("Press Enter to continue or Esc to quite").CW(1, 20, InstructionColor, TableColor);
            foreach (int value in array)
            {
                board.Play(Convert.ToChar(value.ToString()), player.Symbol, "Red");
            }
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
            ("Det är: " + name + " (" + Player.Symbol + ") " + "tur att spela!").CW(5, 4, WinnerColor, TableColor);
        }
        else
            ("Det är: " + name + " (" + Player.Symbol + ") " + "s tur att spela!").CW(5, 4, WinnerColor, TableColor);       
        
    }   // end of Turn()

    // end of methods

}   // end of class Game

