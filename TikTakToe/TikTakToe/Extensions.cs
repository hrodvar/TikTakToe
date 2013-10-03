using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

public static class Extensions
{
    public static void CW(this string strValue, int xPosition = 0, int yPosition = 0,
        string forgroundColor = "White", string backgroundColor = "Black")
    {
        String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
        foreach (string forgroundColorName in colorNames)
            if (forgroundColorName == forgroundColor)
            {
                ConsoleColor newForgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), forgroundColorName);
                Console.ForegroundColor = newForgroundColor;
                break;
            }   // end of if   

        foreach (string backgroundColorName in colorNames)
            if (backgroundColorName == backgroundColor)
            {
                ConsoleColor newBackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backgroundColorName);
                Console.BackgroundColor = newBackgroundColor;
                break;
            }   // end of if 

        Console.SetCursorPosition(xPosition, yPosition);
        Console.Write(strValue);
    }   // end of CW()

    public static string CR(this string strValue, int xPosition = 0, int yPosition = 0,
        string forgroundColor = "White", string backgroundColor = "Black")
    {
        String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
        foreach (string forgroundColorName in colorNames)
            if (forgroundColorName == forgroundColor)
            {
                ConsoleColor newForgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), forgroundColorName);
                Console.ForegroundColor = newForgroundColor;
                break;
            }   // end of if   

        foreach (string backgroundColorName in colorNames)
            if (backgroundColorName == backgroundColor)
            {
                ConsoleColor newBackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backgroundColorName);
                Console.BackgroundColor = newBackgroundColor;
                break;
            }   // end of if 

        Console.SetCursorPosition(xPosition, yPosition);

        strValue = Console.ReadLine();
        return strValue;
    }   // end of CR()

}   // end of class Extensions