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
            const short SIZE = 41;

            bool currentPlayer = state.redTurn;
            short countH, countV, countD1, countD2;
            countD1 = 0;
            countD2 = 0;
            countH = 0;
            countV = 0;

            //loop top to bottom
            for (int i = 0; i <= SIZE; i = i + 7)
            {
                if (state.getSlotState(i) != null)
                {
                    if (state.getSlotState(i) == state.redTurn)
                    {
                        countV++;
                    }
                    else
                    {
                        countV = 0;
                    }
                }
                else
                {
                    countV = 0;
                }

                //Check for winner
                if (countV >= 4)
                {
                    return Convert.ToInt16(currentPlayer);
                }

                if (i >= 35 && i < 41)
                {
                    if (i == 35)
                    {   //Start column 2
                        i = -6;
                        countV = 0;
                    }
                    else if (i == 36)
                    {   //Start column 3
                        i = -5;
                        countV = 0;
                    }
                    else if (i == 37)
                    {   //Start column 4
                        i = -4;
                        countV = 0;
                    }
                    else if (i == 38)
                    {   //Start column 5
                        i = -3;
                        countV = 0;
                    }
                    else if (i == 39)
                    {   //Start column 6
                        i = -2;
                        countV = 0;
                    }
                    else if (i == 40)
                    {   //Start column 7
                        i = -1;
                        countV = 0;
                    }
                }

            }
            //--- loop left to right --
            for (int i = 0; i < SIZE; i++)
            {
                if (state.getSlotState(i) != null)
                {
                    if (state.getSlotState(i) == state.redTurn)
                    {
                        countH++;
                    }
                    else
                    {
                        countH = 0;
                    }
                }
                else
                {
                    countH = 0;
                }

                //Check for winner
                if (countH >= 4)
                {
                    return Convert.ToInt16(currentPlayer);
                }

                if (i == 6 || i == 13 || i == 20 || i == 27 || i == 34)
                {   //Start new row
                    countH = 0;
                }

            }

            //--- Diagonal 1--- L/R
            for (int i = 0; i <= SIZE; i=i+8)
            {
                if (state.getSlotState(i) != null)
                {
                    if (state.getSlotState(i) == state.redTurn)
                    {
                        countD1++;
                    }
                    else
                    {
                        countD1 = 0;
                    }
                }
                else
                {
                    countD1 = 0;
                }

                if (countD1 >= 4)
                {
                    return Convert.ToInt16(currentPlayer);
                }

                if (i == 40)
                {   //Start line 2
                    i = -7;
                    countD1 = 0;
                }
                else if (i == 41)
                {   //Start line 3
                    i = -6;
                    countD1 = 0;
                }
                else if (i == 34)
                {   //Start line 4
                    i = -5;
                    countD1 = 0;
                }
                else if (i == 27)
                {   //Start line 5
                    i = -1;
                    countD1 = 0;
                }
                else if (i == 39)
                {   //Start line 6
                    i = 6;
                    countD1 = 0;
                }
                else if (i == 38)
                {   //End
                    i = 42;
                    countD1 = 0;
                }
            }

            //--- Diagonal 2--- R/L
            for (int i = 3; i <= SIZE; i = i + 6)
            {
                if (state.getSlotState(i) != null)
                {
                    if (state.getSlotState(i) == state.redTurn)
                    {
                        countD2++;
                    }
                    else
                    {
                        countD2 = 0;
                    }
                }
                else
                {
                    countD2 = 0;
                }

                if (countD2 >= 4)
                {
                    return Convert.ToInt16(currentPlayer);
                }

                if (i == 21)
                {   //Start line 2
                    i = -2;
                    countD2 = 0;
                }
                else if (i == 28)
                {   //Start line 3
                    i = -1;
                    countD2 = 0;
                }
                else if (i == 35)
                {   //Start line 4
                    i = 0;
                    countD2 = 0;
                }
                else if (i == 36)
                {   //Start line 5
                    i = 7;
                    countD2 = 0;
                }
                else if (i == 37)
                {   //Start line 6
                    i = 14;
                    countD2 = 0;
                }
                else if (i == 38)
                {   //End
                    i = 42;
                    countD2 = 0;
                }
            }

            //Next player's turn. Return with no winner
            state.redTurn = !state.redTurn;
            return 3;
        }
    }
}
