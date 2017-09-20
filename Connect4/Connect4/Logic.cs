using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Connect4
{
    static class Logic
    {

        internal static int checkWin(GameState state)
        {
            const short HEIGHT = 6;
            const short WIDTH = 7;

            bool currentPlayer = state.redTurn;
            short countH, countD;
            short[] countV = new short[7];

            //loop top to bottom
            for (int i = 0; i < HEIGHT; i++)
            {
                countH = 0;
                char row = 'X';
                switch (i)
                {
                    case 5:
                        row = 'A';
                        break;
                    case 4:
                        row = 'B';
                        break;
                    case 3:
                        row = 'C';
                        break;
                    case 2:
                        row = 'D';
                        break;
                    case 1:
                        row = 'E';
                        break;
                    case 0:
                        row = 'F';
                        break;
                }
                //loop left to right
                for (int j = 0; j < WIDTH; j++)
                {
                    //initialize countV
                    if (i == 0)
                    {
                        countV[j] = 0;
                    }
                    string column = (j + 1).ToString();
                    //If not empty
                    if (state.getSlot(row + column) != null)
                    {
                        //Check player color and count
                        if (state.getSlot(row + column).isRed == state.redTurn)
                        {
                            countH++;
                            countV[j]++;
                        }
                        else
                        {
                            countH = 0;
                            countV[j] = 0;
                        }

                        //--- Horizontal ---
                        if (countH >= 4)
                        {
                            return Convert.ToInt16(currentPlayer);
                        }
                        //--- Vertical ---
                        if (i >= 3)
                        {
                            for (int k = 0; k < WIDTH; k++)
                            {
                                if (countV[k] >= 4)
                                {
                                    return Convert.ToInt16(currentPlayer);
                                }
                            }
                        }
                    }
                }
            }
            state.redTurn = !currentPlayer;
            return 3;
        }
    }
}
