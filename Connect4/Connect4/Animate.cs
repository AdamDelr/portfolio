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

        //Delay action
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

        //Set Button Color Functions ---------------------------------------------------------
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

        internal static void dropPiece(Button A, Button B, Button C, Button D, Button E, Button F, GameState state)
        {
            bool Redturn = state.redTurn;

            if (state.getSlot(A.Name).isRed != null)
            {
               //Column is full
            }
            else if (state.getSlot(B.Name).isRed != null)
            {
                Animate.setColor(A, Redturn);
                if (Redturn == true)
                {
                    state.getSlot(A.Name).isRed = true;                 
                }
                else
                {
                    state.getSlot(A.Name).isRed = false;
                }
                state.redTurn = !Redturn;
            }
            else if (state.getSlot(C.Name).isRed != null)
            {
                Animate.setColor(A, Redturn);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setColor(B, Redturn), .3);
                if (Redturn == true)
                {
                    state.getSlot(B.Name).isRed = true;
                }
                else
                {
                    state.getSlot(B.Name).isRed = false;
                }
                state.redTurn = !Redturn;
            }
            else if (state.getSlot(D.Name).isRed != null)
            {
                Animate.setColor(A, Redturn);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setColor(B, Redturn), .3);
                Animate.delayedExecute(() => Animate.setGrey(B), .4);

                Animate.delayedExecute(() => Animate.setColor(C, Redturn), .35);
                if (Redturn == true)
                {
                    state.getSlot(C.Name).isRed = true;
                }
                else
                {
                    state.getSlot(C.Name).isRed = false;
                }
                state.redTurn = !Redturn;
            }
            else if (state.getSlot(E.Name).isRed != null)
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
                    state.getSlot(D.Name).isRed = true;
                }
                else
                {
                    state.getSlot(D.Name).isRed = false;
                }
                state.redTurn = !Redturn;
            }
            else if (state.getSlot(F.Name).isRed != null)
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
                    state.getSlot(E.Name).isRed = true;
                }
                else
                {
                    state.getSlot(E.Name).isRed = false;
                }
                state.redTurn = !Redturn;
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
                    state.getSlot(F.Name).isRed = true;
                }
                else
                {
                    state.getSlot(F.Name).isRed = false;
                }
                state.redTurn = !Redturn;
            };
            /*
            Animate.setRed(A);
            Animate.delayedExecute(() => Animate.setGrey(A), .4);

            Animate.delayedExecute(() => Animate.setRed(B), .3);
            Animate.delayedExecute(() => Animate.setGrey(B), .4);

            Animate.delayedExecute(() => Animate.setRed(C), .35);
            Animate.delayedExecute(() => Animate.setGrey(C), .45);

            Animate.delayedExecute(() => Animate.setRed(D), .4);
            Animate.delayedExecute(() => Animate.setGrey(D), .5);

            Animate.delayedExecute(() => Animate.setRed(E), .45);
            Animate.delayedExecute(() => Animate.setGrey(E), .55);

            Animate.delayedExecute(() => Animate.setRed(F), .5);
            Animate.delayedExecute(() => Animate.setGrey(F), .6);
            */
        }
    }
}

