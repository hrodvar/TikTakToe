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
    public static void CW(this string strValue, int xPosition = 0, int yPosition = 0, string color = "White")
    {
        String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
        foreach (string colorName in colorNames)
            if (colorName == color)
            {
                ConsoleColor newColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
                Console.ForegroundColor = newColor;
                break;
            }   // end of if       

        Console.SetCursorPosition(xPosition, yPosition);
        Console.Write(strValue);
    }   // end of CW()
}