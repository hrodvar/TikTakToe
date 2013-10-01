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

    public class StartUp
    {
        public int BoardSize = 3;
        public string BoardColor = "Yellow";

        public Player Human { get; set; }
        public Player Computer { get; set; }

        public StartUp()
        {
            
            CreateFront(BoardSize);
            
        }
        

        public void CreateFront(int boardsize)
        {
            
            int ySheet = 2;
            int xSheet = 4;
            string strLeftTopCorner = new String('╔', 1);
            string strRightTopCorner = new String('╗', 1);
            string strLeftBottomCorner = new String('╚', 1);
            string strRightBottomCorner = new String('╝', 1);
            string strHorisontell = new String('═', 30);
            string strVertikal = new String('║', 1);
            
            Console.SetWindowSize(boardsize * 13, boardsize * 7);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            

           
           (strLeftTopCorner + strHorisontell + strRightTopCorner).CW(xSheet, ySheet, BoardColor);
           ("Välkommen!").CW(15,4,"Yellow");
            

            
                
            for (int l = 0; l < 14; l++)
            {
                (strVertikal).CW(xSheet, ySheet + 1 +l, BoardColor);
                (strVertikal).CW(xSheet + 31, ySheet + 1+ l, BoardColor);
            }

            (strLeftBottomCorner + strHorisontell + strRightBottomCorner).CW(xSheet, ySheet + 15, BoardColor);
            
            GetNames();
            
            
        }

        public void GetNames()
        {
           
            
            ("Spelare1 namn: ").CW(6, 8, "Yellow");
            Console.SetCursorPosition(21,8);

            Human = new Player(Console.ReadLine(), 'X');
            
            ("Spelare2 namn:").CW(6, 12, "Yellow");
            Console.SetCursorPosition(21, 12);

            Computer = new Player(Console.ReadLine(), 'O');
            Console.Clear();
        }
            
}
    

