using System;
using System.Collections.Generic;
using System.Linq;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: class Game is part of the project TikTakToe.
 *                 Datum: 2013-09-25
 *            Programare: Hrodvar Johannsson
 *                        Mikael Wilkon
 *                        Philip Andreasson
 */

public class Game
{
    // properties
    public int WinnerPoints = 2;
    public string TableColor = "DarkBlue";
    public string WinnerColor = "Gray";
    public string InstructionColor = "Gray";
    public string SmileysColor = "Yellow";
    public string SmileysWinnerColor = "Red";
    public string WinnerSymbolColor = "Red";
    public AI AIAuthor { get; set; }
    // end of properties

    // constructor
    public Game(int boardSize, Player human, Player computer, AI ai)
    {
        AIAuthor = ai;
        bool AIRunner = ai.Name == " " ? false : true;
        bool gameSituation = true;
        Board board = new Board(boardSize);
        //Intelligence intelligence = new Intelligence();
        board.PlayerInformation(human.PlayerName, human.Symbol, computer.PlayerName, computer.Symbol);
        int i = 0;
        do
        {
            if (!(gameSituation = PlayValue(human, computer.PlayerMoves, board, i, false)))
                break;
            if (!(gameSituation = PlayValue(computer, human.PlayerMoves, board, i, AIRunner)))
            {
                i++;
                break; 
            }   // end of if
        } while (gameSituation);
    }   // end of Game()
    // end of constructor

    // methods
    public bool PlayValue(Player player, int[] competitor, Board board, int i, bool ai)
    {
        string Draw = "";
        bool gameSituation = true;
        Intelligence intelligence = new Intelligence(WinnerPoints);
        int length = player.PlayerMoves.Length + 1;
        Array.Resize<int>(ref player.PlayerMoves, length);
        length = player.PlayerMoves.Length - 1;
        int value = 0;
        char choose = ' ';
        do
        {
            Turn(player);
            if (ai)
            {
                switch (AIAuthor.Name)
                {
                    case "Mikaels AI":
                        {
                            MikaelsAI2 mikaelsAI2 = new MikaelsAI2(player.PlayerMoves, competitor, player);
                            value = mikaelsAI2.RoysVariabel;
                            choose = Convert.ToChar(value.ToString());
                            break;
                        }   // end of case Mikael
                    case "Fatos AI":
                        {
                            break;
                        }   // end of case Fatos 
                    case "Philips AI":
                        {
                            break;
                        }   // end of case Philip
                    case "Xins AI":
                        {
                            break;
                        }   // end of case Xin
                    case "Hrois AI":
                        {
                            AIHroi hroi = new AIHroi(player.PlayerMoves, competitor);
                            value = hroi.ReturnValue;
                            choose = Convert.ToChar(value.ToString());
                            break;
                        }   // end of case Hroi
                }   // end of switch
            }   // end of if
            else
            {
                choose = Console.ReadKey(true).KeyChar;
                value = (int)Char.GetNumericValue(choose);
            }   // end of else

            if (value < 1 || value > 9)
                continue;
            
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
                Draw = "\t  Draw";
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
        String emptyOutput = new String(' ', 20);
        string output = "";
        if (draw != "" && !gameSituation)
        {
            gameSituation = true;
            output = draw;
        }   // end of if
        else
        {
            ("☺").CW(8, 18, SmileysWinnerColor, TableColor);
            ("☺").CW(32, 18, SmileysWinnerColor, TableColor);
            output = player.PlayerName + " is a winner";
        }
        if (gameSituation)
        {
            (emptyOutput).CW(11, 18, TableColor, TableColor);
            (output).CW(11, 18, WinnerColor, TableColor);
            ("Press Enter - Play again").CW(9, 20, InstructionColor, TableColor);
            ("Press F1    - Menu").CW(9, 21, InstructionColor, TableColor);
            ("Press Esc   - Exit").CW(9, 22, InstructionColor, TableColor);
            if (draw == "")
                foreach (int value in array)
                    board.Play(Convert.ToChar(value.ToString()), player.Symbol, WinnerSymbolColor);
                
            return false;
        }   // end of if
        else 
            return true;
    }   // end of GameSituation()

    public void Turn(Player Player)
    {
        string name = Player.PlayerName;
        name = name.Length > 8 ? name.Substring(0, 8) : name;
        String output = new String(' ', 25);
        (output).CW(11, 18, TableColor, TableColor);
        ("☺").CW(8, 18, SmileysColor, TableColor);
        ("☺").CW(32, 18, SmileysColor, TableColor);
        output = name.EndsWith("s") ? ("It's " + name + " turn!") : ("It's " + name + "s turn!");
        (output).CW(11, 18, WinnerColor, TableColor);        
    }   // end of Turn()

    // end of methods

}   // end of class Game

