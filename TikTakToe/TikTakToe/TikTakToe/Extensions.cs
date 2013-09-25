using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Extensions
{
    public static void CW(this string strValue, int lineBreak = 0, int antlaTab = 0, string color = "White")
    {
        String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
        foreach (string colorName in colorNames)
            if (colorName == color)
            {
                ConsoleColor newColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
                Console.ForegroundColor = newColor;
                break;
            }   // end of if       

        string strLineBreak = new String('\n', lineBreak);
        string strTab = new String('\t', antlaTab);
        Console.Write(strLineBreak + strTab + strValue);
    }   // end of CW()
}