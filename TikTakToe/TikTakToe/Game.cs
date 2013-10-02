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
    //public Players[] PlayersArray = new Player(name, symbol);

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
                }
                else
                {
                    if (competitor.Length == 0)
                    {
                        //board.Play(choose, player.Symbol, board.SymbolColor);
                        gameSituation = true;
                        //break;
                    }
                    else
                    {
                        foreach (int valueCompetitor in competitor)
                        {
                            if (valueCompetitor == value)
                            {
                                gameSituation = false;
                                break;
                            }
                            else
                            {
                                //board.Play(choose, player.Symbol, board.SymbolColor);
                                gameSituation = true;
                                //break;
                            }
                        }
                    }
                    
                    //break;
                }
            }
        }
        while (!gameSituation);

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
        }
        else
            return true;
    }   // end of GameSituation()

    public string[] Winner(char pos, Player player)
    {
        
        int Pos = Convert.ToInt16(pos.ToString());
        //char[] WinningNumbers = new char[9];
        string[] winner = new string[4];
        
        WinningNumbers[Pos - 1] = player.Symbol;


        if (WinningNumbers[0] == WinningNumbers[1] && WinningNumbers[1] == WinningNumbers[2])
            winner = new string[] { player.PlayerName, "1", "2", "3" };
        else if (WinningNumbers[3] == WinningNumbers[4] && WinningNumbers[4] == WinningNumbers[5])
            winner = new string[] { player.PlayerName, "4", "5", "6" };
        else if (WinningNumbers[6] == WinningNumbers[7] && WinningNumbers[7] == WinningNumbers[8])
            winner = new string[] { player.PlayerName, "7", "8", "9" };
        else if (WinningNumbers[0] == WinningNumbers[3] && WinningNumbers[3] == WinningNumbers[6])
            winner = new string[] { player.PlayerName, "1", "4", "7" };
        else if (WinningNumbers[1] == WinningNumbers[4] && WinningNumbers[4] == WinningNumbers[7])
            winner = new string[] { player.PlayerName, "2", "5", "8" };
        else if (WinningNumbers[2] == WinningNumbers[5] && WinningNumbers[5] == WinningNumbers[8])
            winner = new string[] { player.PlayerName, "3", "6", "9" };
        else if (WinningNumbers[0] == WinningNumbers[4] && WinningNumbers[4] == WinningNumbers[8])
            winner = new string[] { player.PlayerName, "1", "5", "9" };
        else if (WinningNumbers[6] == WinningNumbers[4] && WinningNumbers[4] == WinningNumbers[2])
            winner = new string[] { player.PlayerName, "7", "5", "3" };
        else
            winner = null;
        return winner;
    }
    public void GameResult(string[] Winner)
    {
        
        string WinnerColor = "Yellow";
        if (Winner != null)
        {
            ("Vinnaren är " + Winner[0] + ". Grattis!").CW(9, 18, WinnerColor);
            ("Du placerade vinnande tecken på").CW(6, 19, WinnerColor);
            (Winner[1] + "," + Winner[2] + "," + Winner[3]).CW(18, 20, WinnerColor);

        }
    }   // end of GameResult()

    public void Turn(Player Player)
    {
        
        string name = Player.PlayerName;
        int i = name.Length;
        char[] nameArrey = name.ToCharArray();

        if (nameArrey[i - 1] != 's')
            name = name + "s";
        ("Det är: " + name + " (" + Player.Symbol + ") " + "Tur att spela!").CW(5, 4, "Green");
       
    }
    // end of methods

}

