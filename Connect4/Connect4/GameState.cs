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
using System.Collections.Generic;

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
            redTurn = true;
        }

        internal Slot getSlot(string loc)
        {
            for(int i=0;i<42;i++)
            {
                if(slotArray[i].location == loc)
                {
                    return slotArray[i];
                }
            }
            return null;
        }
        
        internal class Slot
        {
            private string _location;
            internal string location
            {
                get { return _location; }
                private set { _location = value; }
            }

            internal bool? isRed;

            internal Slot(string location)
            {
                this.location = location;
                isRed = null;
            }
        }
    }
}
