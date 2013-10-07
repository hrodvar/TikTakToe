using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    class MikaelsAI
    {
        public char[] BoardInfo = new char[9];
        public char Symbol;
        
        MikaelsAI(char[] board, char symbol)
        {
            BoardInfo = board;
            Symbol = symbol;
        }
        public static bool Vinnare(char[] BI, Player Player)
        {
            bool winpossible = false;

            if (winpossible)
            {
                if (BI[0] == Player.Symbol && BI[1] == Player.Symbol)
                    winpossible = true;
               

            
            }
            
            return winpossible;
            
        }
        public static bool IsEmpty(char[] BI)
        {
            bool isempty = false;
            
            foreach (var pos in BI)
            {
                if (pos == 'X' && pos == 'O')
                {
                    isempty = false;
                    break;
                }

                else
                {
                    isempty = true;
                    break;
                }
            }
            return isempty;
        }
        
        public static void PositionValue(char[] BI,Player Player)
        {

           
            

            foreach (char c in BI)
            {
                bool isempty = IsEmpty(BI);
                
                
                    if (isempty == true)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            
                            if(i == 4)
                            {
                             BI[4] = Player.Symbol;
                            break;
                            }
                            
                            
                                
                            
                            if(i > 4)
                            {
                                BI[i] = Player.Symbol;
                                break;
                            }
                            
                        }

                    }
                
            }
            

        }

        public void Start()
        {
            if (BoardInfo.Length == 0)
            {
                BoardInfo[4] = Symbol;
            }
            if (BoardInfo.Length != 0)
            {
                if (BoardInfo[4] == 0)
                {
                    BoardInfo[4] = Symbol;
                }
            }
        }
    }
}
