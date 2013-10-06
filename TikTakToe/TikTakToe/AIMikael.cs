using System;

public class AIMikael
{
    public char resultat { get; set; }
	char[] CB = new char[9];
	

	public AIMikael(int[] player1, int[] player2, Player Player)
	{
		ConvertingArrays(player1, player2);

		resultat = BotMove(Player, CB);
	}
   
	public void ConvertingArrays(int[] array1, int[] array2)
	{
        char[] cb = new char[9];

        foreach (int item1 in array1)
        {
            char c = Convert.ToChar(item1.ToString());
            CB[item1] = c;
        }
        
        foreach (int item2 in array2)
        {
            char c = Convert.ToChar(item2.ToString());
            CB[item2] = c;
        }

        //for (int i = 0; i < cb.Length; i++)
        //{
        //    CB[i] = cb[i]; 
        //}
		
	}
	
	public char BotMove(Player Player, char[] CB)
	{
		/*

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
				   CB[4] = Player.Symbol ;

		*/
		// rnd is a random number from 1 -9
        Random rnd = new Random();
        int i = 0; //rnd.Next(1, 9);
        char resultat = ' ';

        if (CB[0] == 'X' & CB[1] == 0 & CB[2] == 0 &
            CB[3] == 0 & CB[4] == 0 & CB[5] == 0 &
            CB[6] == 0 & CB[7] == 0 & CB[8] == 0)
		{
			CB[4] = Player.Symbol;
            resultat = '4';

		}

		else if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[4] = Player.Symbol;
            resultat = '4';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[4] = Player.Symbol;
            resultat = '4';
		}



		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 0 && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[4] = Player.Symbol;
            resultat = '4';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'X' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[0] = Player.Symbol;
            resultat = '0';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 0 && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[4] = Player.Symbol;
            resultat = '4';
		}

		if (CB[0] == 0 & CB[1] == 0 & CB[2] == 0 &&
			CB[3] == 0 & CB[4] == 0 & CB[5] == 0 &&
			CB[6] == 'X' & CB[7] == 0 & CB[8] == 0)
		{
			CB[4] = Player.Symbol;
            resultat = '4';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
		{
			CB[4] = Player.Symbol;
            resultat = '4';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 0 && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
		{
			CB[4] = Player.Symbol;
            resultat = '4';
		}



		
		if (CB[0] == 'X' && CB[1] == 'X' && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[2] = Player.Symbol;
            resultat = '2';
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
            resultat = '1';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 'X' && CB[8] == 0)
		{
			CB[8] = Player.Symbol;
            resultat = '8';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
		{
			CB[0] = Player.Symbol;
            resultat = '0';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 0 && CB[8] == 'X')
		{
			CB[7] = Player.Symbol;
            resultat = '7';
		}

		if (CB[0] == 'X' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[6] = Player.Symbol;
            resultat = '6';
		}

		if (CB[0] == 'X' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 0 && CB[8] == 0)
		{
			CB[3] = Player.Symbol;
            resultat = '3';
		}

		if (CB[0] == 0 && CB[1] == 0 & CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
		{
			CB[5] = Player.Symbol;
            resultat = '5';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 0 && CB[8] == 0)
		{
			CB[0] = Player.Symbol;
            resultat = '0';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
		{
			CB[2] = Player.Symbol;
            resultat = '2';
		}

		if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'X' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[7] = Player.Symbol;
            resultat = '7';
		}

		if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'X' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
		{
			CB[1] = Player.Symbol;
            resultat = '1';
		}

		if (CB[0] == 0 & CB[1] == 0 && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[8] = Player.Symbol;
            resultat = '8';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 0 & CB[7] == 0 && CB[8] == 'X')
		{
			CB[2] = Player.Symbol;
            resultat = '2';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
		{
			CB[0] = Player.Symbol;
            resultat = '0';
		}

		if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'X' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[5] = Player.Symbol;
            resultat = '5';
		}

		if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'X' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[3] = Player.Symbol;
            resultat = '3';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 'X' && CB[8] == 0)
		{
			CB[8] = Player.Symbol;
            resultat = '8';
		}



		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
		{
			CB[6] = Player.Symbol;
		    resultat = '6';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 0 && CB[8] == 'X')
		{
			CB[7] = Player.Symbol;
            resultat = '7';
		}




		
		if (CB[0] == 'X' && CB[1] == 'X' && CB[2] == 'O' &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[6] = Player.Symbol;
            resultat = '6';
		}

		if (CB[0] == 'O' & CB[1] == 'X' && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[8] = Player.Symbol;
            resultat = '8';
		}

		if (CB[0] == 'X' && CB[1] == 'O' && CB[2] == 'X' &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[6] = Player.Symbol;
            resultat = '6';
		}


		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 'X' && CB[8] == 'O')
		{
			CB[0] = Player.Symbol;
            resultat = '0';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 'O' && CB[7] == 'X' && CB[8] == 'X')
		{
			CB[2] = Player.Symbol;
            resultat = '2';
		}

		if (CB[0] == 0 && CB[1] == 0 & CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 'O' && CB[8] == 'X')
		{
			CB[0] = Player.Symbol;
            resultat = '0';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 'X' && CB[7] == 'O' && CB[8] == 'X')
		{
			CB[2] = Player.Symbol;
            resultat = '2';
		}

		if (CB[0] == 'X' && CB[1] == 'X' && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'O' && CB[7] == 0 && CB[8] == 0)
		{
			CB[2] = Player.Symbol;
            resultat = '2';
		}

		if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[8] = Player.Symbol;
            resultat = '8';
		}

		if (CB[0] == 'X' && CB[1] == 'X' && CB[2] == 0 &&
			CB[3] == 'O' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 0 && CB[8] == 0)
		{
			CB[2] = Player.Symbol;
            resultat = '2';
		}

		if (CB[0] == 'X' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'O' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 'X' && CB[8] == 0)
		{
			CB[8] = Player.Symbol;
            resultat = '8';
		}

		if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
		{
			CB[0] = Player.Symbol;
            resultat = '0';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
		{
			CB[1] = Player.Symbol;
            resultat = '1';
		}

		if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 'X' && CB[8] == 0)
		{
			CB[8] = Player.Symbol;
            resultat = '8';
		}


		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'O' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
		{
			CB[6] = Player.Symbol;
            resultat = '6';
		}

		if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'X' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 'O' && CB[8] == 0)
		{
			CB[3] = Player.Symbol;
            resultat = '3';
		}

		if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'X' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 'O' && CB[8] == 0)
		{
			CB[5] = Player.Symbol;
            resultat = '5';
		}

		if (CB[0] == 'O' && CB[1] == 'O' && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'X' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
		{
			CB[3] = Player.Symbol;
            resultat = '3';
		}

		if (CB[0] == 'O' && CB[1] == 'O' && CB[2] == 0 &
			CB[3] == 'X' && CB[4] == 'X' && CB[5] == 0 &
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
		{
			CB[5] = Player.Symbol;
            resultat = '5';
		}

		if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 'O')
		{
			CB[0] = Player.Symbol;
            resultat = '0';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'O' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
		{
			CB[6] = Player.Symbol;
            resultat = '6';
		}

		if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 'X')
		{
			CB[0] = Player.Symbol;
            resultat = '0';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 'X')
		{
			CB[6] = Player.Symbol;
            resultat = '6';
		}

		if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'X' && CB[5] == 'O' &&
			CB[6] == 'X' && CB[7] == 0 && CB[8] == 0)
		{
			CB[2] = Player.Symbol;
            resultat = '2';
		}

		if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 'X' &&
			CB[3] == 'X' && CB[4] == 'X' && CB[5] == 'O' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[6] = Player.Symbol;
            resultat = '6';
		}

		if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'X' && CB[5] == 'O' &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
		{
			CB[1] = Player.Symbol;
            resultat = '1';
		}

		if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'X' && CB[5] == 'O' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[7] = Player.Symbol;
            resultat = '7';
		}

		if (CB[0] == 'O' && CB[1] == 'X' && CB[2] == 0 &&
			CB[3] == 'O' && CB[4] == 'X' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[7] = Player.Symbol;
            resultat = '7';
		}

		if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'O' && CB[4] == 'X' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 0)
		{
			CB[1] = Player.Symbol;
            resultat = '1';
		}

		if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 'X' &&
			CB[3] == 'O' && CB[4] == 'X' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 0 && CB[8] == 0)
		{
			CB[8] = Player.Symbol;
            resultat = '8';
		}

		if (CB[0] == 'O' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'O' && CB[4] == 'X' && CB[5] == 'X' &&
			CB[6] == 0 && CB[7] == 0 & CB[8] == 'X')
		{
			CB[2] = Player.Symbol;
            resultat = '2';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 'X' && CB[8] == 'O')
		{
			CB[0] = Player.Symbol;
            resultat = '0';
		}

		if (CB[0] == 'X' && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 0 && CB[7] == 'X' && CB[8] == 'O')
		{
			CB[6] = Player.Symbol;
            resultat = '6';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'O' &&
			CB[6] == 'O' && CB[7] == 'X' && CB[8] == 'X')
		{
			CB[2] = Player.Symbol;
            resultat = '2';
		}


		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 'X' &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 'O' && CB[7] == 'X' && CB[8] == 0)
		{
			CB[8] = Player.Symbol;
            resultat = '8';
		}


		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 'X' && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 'O' && CB[8] == 'X')
		{
			CB[1] = Player.Symbol;
            resultat = '1';
		}

		if (CB[0] == 0 && CB[1] == 'X' && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 0 &&
			CB[6] == 'X' && CB[7] == 'O' && CB[8] == 'X')
		{
			CB[3] = Player.Symbol;
            resultat = '3';
		}

		if (CB[0] == 0 && CB[1] == 0 && CB[2] == 0 &&
			CB[3] == 0 && CB[4] == 'O' && CB[5] == 'X' &&
			CB[6] == 'X' && CB[7] == 'O' && CB[8] == 'X')
		{
			CB[1] = Player.Symbol;
            resultat = '1';
		}
			
		else
		{
            do
            {
                i = rnd.Next(1, 9);
            } while (CB[i] == 'X' || CB[i] == 'O');

			CB[i] = Player.Symbol;
            resultat = Convert.ToChar(i.ToString());
		}
        return resultat;	 
	}

}


