/*
 * GameState.cs
 * by Adam del Rosario
 * 
 * Contains Connect 4 game status information
 * 
 * slotArray      array<Slot>        Holds information on all 42 slots on the board     
 * redTurn        bool
 * 
 */

using System;
using System.Collections;
using System.Text;

namespace Connect4
{
    class GameState
    {
        internal bool redTurn;
        private Slot[] slotArray = new Slot[42]
        {
            new Slot("A1"),new Slot("A2"),new Slot("A3"),new Slot("A4"),new Slot("A5"),new Slot("A6"),new Slot("A7"),
            new Slot("B1"),new Slot("B2"),new Slot("B3"),new Slot("B4"),new Slot("B5"),new Slot("B6"),new Slot("B7"),
            new Slot("C1"),new Slot("C2"),new Slot("C3"),new Slot("C4"),new Slot("C5"),new Slot("C6"),new Slot("C7"),
            new Slot("D1"),new Slot("D2"),new Slot("D3"),new Slot("D4"),new Slot("D5"),new Slot("D6"),new Slot("D7"),
            new Slot("E1"),new Slot("E2"),new Slot("E3"),new Slot("E4"),new Slot("E5"),new Slot("E6"),new Slot("E7"),
            new Slot("F1"),new Slot("F2"),new Slot("F3"),new Slot("F4"),new Slot("F5"),new Slot("F6"),new Slot("F7")
        };

        internal GameState()
        {
            //Red goes first
            redTurn = true;
        }

        internal bool? getSlotState(int loc)
        {
            return slotArray[loc].isRed;
        }

        internal bool? getSlotState(string loc)
        {
            int row;
            int column;
            row = (int)Encoding.ASCII.GetBytes(loc.Substring(0, 1))[0] - 65;
            column = int.Parse(loc.Substring(1, 1))-1;

            return slotArray[row*7+column].isRed;
        }

        internal void setSlotState(string loc, bool? newState)
        {
            int row;
            int column;
            row = (int)Encoding.ASCII.GetBytes(loc.Substring(0, 1))[0] - 65;
            column = int.Parse(loc.Substring(1, 1))-1;

            slotArray[row * 7 + column].setState(newState);
        }

        private class Slot
        {
            private string _location;
            internal string location
            {
                get { return _location; }
                private set { _location = value; }
            }

            private bool? _isRed;
            internal bool? isRed
            {
                get { return _isRed; }
                private set { _isRed = value; }
            }

            internal Slot(string location)
            {
                this.location = location;
                isRed = null;
            }

            internal void setState(bool? newState)
            {
                this.isRed = newState;
            }

        }
    }
}
