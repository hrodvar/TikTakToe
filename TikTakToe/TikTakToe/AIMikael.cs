

public class AIMikael
{

    char[] CB = new char[9];
    

    public AIMikael(char[] currentBoard, Player Player)
    {


        BotMove(Player, CB);
    }
   

    public void BotMove(Player Player, char[] CB)
    {
        /*

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
                   CB[4] = Player.Symbol ;

        */


        if (CB[0] == 'X' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[4] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[4] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[4] = Player.Symbol;

        }



        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 0 && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[4] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'X' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 0 && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[4] = Player.Symbol;

        }

        if (CB[0] == 0 & CB[1] == 0 & CB[2] == 0 &&
            CB[3] == 0 & CB[4] == 0 & CB[5] == 0 &&
            CB[6] == 'X' & CB[7] == 0 & CB[8] == 0)
        {
            CB[4] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
        {
            CB[4] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
        {
            CB[4] = Player.Symbol;

        }



        
        if (CB[0] == 'X' && CB[1] == 'X' && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[2] = Player.Symbol;

        }
        if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 'X' && CB[1] == 0 && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[1] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 'X' && CB[8] == 0)
        {
            CB[8] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 0 && CB[8] == 'X')
        {
            CB[7] = Player.Symbol;

        }

        if (CB[0] == 'X' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[6] = Player.Symbol;

        }

        if (CB[0] == 'X' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 0 && CB[8] == 0)
        {
            CB[3] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 & CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
        {
            CB[5] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 0 && CB[8] == 0)
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
        {
            CB[2] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'X' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[7] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'X' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
        {
            CB[1] = Player.Symbol;

        }

        if (CB[0] == 0 & CB[1] == 0 && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[8] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 0 & CB[7] == 0 && CB[8] == 'X')
        {
            CB[2] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'X' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[5] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'X' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[3] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 'X' && CB[8] == 0)
        {
            CB[8] = Player.Symbol;

        }



        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
        {
            CB[6] = Player.Symbol;
           
        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 0 && CB[8] == 'X')
        {
            CB[7] = Player.Symbol;

        }




        
        if (CB[0] == 'X' && CB[1] == 'X' && CB[2] == 'O' &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[6] = Player.Symbol;

        }

        if (CB[0] == 'O' & CB[1] == 'X' && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[8] = Player.Symbol;

        }

        if (CB[0] == 'X' && CB[1] == 'O' && CB[2] == 'X' &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[6] = Player.Symbol;

        }


        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 'X' && CB[8] == 'O')
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 'O' && CB[7] == 'X' && CB[8] == 'X')
        {
            CB[2] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 & CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 'O' && CB[8] == 'X')
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 'X' && CB[7] == 'O' && CB[8] == 'X')
        {
            CB[2] = Player.Symbol;

        }

        if (CB[0] == 'X' && CB[1] == 'X' && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'O' && CB[7] == 0 && CB[8] == 0)
        {
            CB[2] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[8] = Player.Symbol;

        }

        if (CB[0] == 'X' && CB[1] == 'X' && CB[2] == 0 &&
            CB[3] == 'O' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 0 && CB[8] == 0)
        {
            CB[2] = Player.Symbol;

        }

        if (CB[0] == 'X' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'O' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 'X' && CB[8] == 0)
        {
            CB[8] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
        {
            CB[1] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 'X' && CB[8] == 0)
        {
            CB[8] = Player.Symbol;

        }


        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'O' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
        {
            CB[6] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'X' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 'O' && CB[8] == 0)
        {
            CB[3] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'X' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 'O' && CB[8] == 0)
        {
            CB[5] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 'O' && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'X' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
        {
            CB[3] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 'O' && CB[2] == 0 &
            CB[3] == 'X' && CB[4] == 'X' && CB[5] == 0 &
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
        {
            CB[5] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 'O')
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'O' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
        {
            CB[6] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
        {
            CB[6] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'X' && CB[5] == 'O' &&
            CB[6] == 'X' && CB[7] == 0 && CB[8] == 0)
        {
            CB[2] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 'X' &&
            CB[3] == 'X' && CB[4] == 'X' && CB[5] == 'O' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[6] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'X' && CB[5] == 'O' &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
        {
            CB[1] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'X' && CB[5] == 'O' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[7] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 0 &&
            CB[3] == 'O' && CB[4] == 'X' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[7] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'O' && CB[4] == 'X' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
        {
            CB[1] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 'X' &&
            CB[3] == 'O' && CB[4] == 'X' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
        {
            CB[8] = Player.Symbol;

        }

        if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'O' && CB[4] == 'X' && CB[5] == 'X' &&
            CB[6] == 0 && CB[7] == 0 & CB[8] == 'X')
        {
            CB[2] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 'X' && CB[8] == 'O')
        {
            CB[0] = Player.Symbol;

        }

        if (CB[0] == 'X' && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 0 && CB[7] == 'X' && CB[8] == 'O')
        {
            CB[6] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
            CB[6] == 'O' && CB[7] == 'X' && CB[8] == 'X')
        {
            CB[2] = Player.Symbol;

        }


        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'X' &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 'O' && CB[7] == 'X' && CB[8] == 0)
        {
            CB[8] = Player.Symbol;

        }


        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 'O' && CB[8] == 'X')
        {
            CB[1] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
            CB[6] == 'X' && CB[7] == 'O' && CB[8] == 'X')
        {
            CB[3] = Player.Symbol;

        }

        if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
            CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
            CB[6] == 'X' && CB[7] == 'O' && CB[8] == 'X')
        {
            CB[1] = Player.Symbol;

        }
            /*
             * rnd is a random number from 1 -9
        else if (CB[rnd] == 'X' || CB[rnd] == 'O')
        {
            //get a new random number
        }
        else
        {
            CB[rnd] = Player.Symbol;
        }
             */
    }

}


