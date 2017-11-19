using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Connect4
{
    internal static class Animate
    {
        //List of timers to avoid garbage collection
        private static IList<DispatcherTimer> timers = new List<DispatcherTimer>();

        //--- Delay action ---
        internal static void delayedExecute(Action action, double delay )
        {
            var dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

            timers.Add(dispatcherTimer);

            EventHandler handler = null;
            handler = (sender, e) =>
            {

                dispatcherTimer.Tick -= handler;
                dispatcherTimer.Stop();

                timers.Remove(dispatcherTimer);

                action();
            };

            dispatcherTimer.Tick += handler;
            dispatcherTimer.Interval = TimeSpan.FromSeconds(delay);
            dispatcherTimer.Start();
        }

        //--- Set Button Color helper functions ---------------------------------------------------------
        internal static void setColor(Button button, bool redTurn)
        {
            if (redTurn == true)
            {
                button.Background = button.Background == Brushes.Red ? (SolidColorBrush)
                (new BrushConverter().ConvertFrom("SlateGray")) : Brushes.Red;
            }
            else
            {
                button.Background = button.Background == Brushes.Blue ? (SolidColorBrush)
                (new BrushConverter().ConvertFrom("SlateGray")) : Brushes.Blue;
            }
        }

        internal static void setGrey(Button button)
        {
            if (button.Background == Brushes.Red)
            {
                button.Background = button.Background == Brushes.SlateGray ? (SolidColorBrush)
                (new BrushConverter().ConvertFrom("Red")) : Brushes.SlateGray;
            }
            else
            {
                button.Background = button.Background == Brushes.SlateGray ? (SolidColorBrush)
                (new BrushConverter().ConvertFrom("Blue")) : Brushes.SlateGray;
            }
        }

        //--- "Drop" Token in a slot ---------------------------------------------------------
        /* Button A-F      == Slots 1-7
         * GameState state == Token location data 
         * 
         */
        internal static void dropPiece(Button A, Button B, Button C, Button D, Button E, Button F, GameState state)
        {
            bool Redturn = state.redTurn;

            if (state.getSlotState(A.Name)!= null)
            {
               //Column is full
            }
            else if (state.getSlotState(B.Name)!= null)
            {
                Animate.setColor(A, Redturn);
                if (Redturn == true)
                {
                    state.setSlotState(A.Name,true);                 
                }
                else
                {
                    state.setSlotState(A.Name, false);
                }
            }
            else if (state.getSlotState(C.Name) != null)
            {
                Animate.setColor(A, Redturn);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setColor(B, Redturn), .3);
                if (Redturn == true)
                {
                    state.setSlotState(B.Name, true);
                }
                else
                {
                    state.setSlotState(B.Name, false);
                }
            }
            else if (state.getSlotState(D.Name) != null)
            {
                Animate.setColor(A, Redturn);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setColor(B, Redturn), .3);
                Animate.delayedExecute(() => Animate.setGrey(B), .4);

                Animate.delayedExecute(() => Animate.setColor(C, Redturn), .35);
                if (Redturn == true)
                {
                    state.setSlotState(C.Name, true);
                }
                else
                {
                    state.setSlotState(C.Name, false);
                }
            }
            else if (state.getSlotState(E.Name) != null)
            {
                Animate.setColor(A, Redturn);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setColor(B, Redturn), .3);
                Animate.delayedExecute(() => Animate.setGrey(B), .4);

                Animate.delayedExecute(() => Animate.setColor(C, Redturn), .35);
                Animate.delayedExecute(() => Animate.setGrey(C), .45);

                Animate.delayedExecute(() => Animate.setColor(D, Redturn), .4);
                if (Redturn == true)
                {
                    state.setSlotState(D.Name, true);
                }
                else
                {
                    state.setSlotState(D.Name, false);
                }
            }
            else if (state.getSlotState(F.Name) != null)
            {
                Animate.setColor(A, Redturn);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setColor(B, Redturn), .3);
                Animate.delayedExecute(() => Animate.setGrey(B), .4);

                Animate.delayedExecute(() => Animate.setColor(C, Redturn), .35);
                Animate.delayedExecute(() => Animate.setGrey(C), .45);

                Animate.delayedExecute(() => Animate.setColor(D, Redturn), .4);
                Animate.delayedExecute(() => Animate.setGrey(D), .5);

                Animate.delayedExecute(() => Animate.setColor(E, Redturn), .45);
                if (Redturn == true)
                {
                    state.setSlotState(E.Name, true);
                }
                else
                {
                    state.setSlotState(E.Name, false);
                }
            }
            else 
            {
                Animate.setColor(A, Redturn);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setColor(B, Redturn), .3);
                Animate.delayedExecute(() => Animate.setGrey(B), .4);

                Animate.delayedExecute(() => Animate.setColor(C, Redturn), .35);
                Animate.delayedExecute(() => Animate.setGrey(C), .45);

                Animate.delayedExecute(() => Animate.setColor(D, Redturn), .4);
                Animate.delayedExecute(() => Animate.setGrey(D), .5);

                Animate.delayedExecute(() => Animate.setColor(E, Redturn), .45);
                Animate.delayedExecute(() => Animate.setGrey(E), .55);

                Animate.delayedExecute(() => Animate.setColor(F, Redturn), .5);
                if (Redturn == true)
                {
                    state.setSlotState(F.Name, true);
                }
                else
                {
                    state.setSlotState(F.Name, false);
                }
            };
        }
    }
}

