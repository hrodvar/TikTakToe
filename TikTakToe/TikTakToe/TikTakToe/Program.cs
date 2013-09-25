using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            utseende();
            Game game = new Game(); 
        }
         
        static void utseende()
        {
            Console.SetWindowSize(40, 20);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
        }
    }
}
