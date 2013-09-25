using System;

class Player
{
    // properties
    public string PlayerName { get; set; }
    public Char Symbol { get; set; }
    // end of properties

    // constructor
    public Player(string name, char symbol)
    {
        PlayerName = name;
        Symbol = symbol;
    }
}
