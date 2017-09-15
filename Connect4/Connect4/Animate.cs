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
        internal static void setRed(Button button)
        {
            button.Background = button.Background == Brushes.Red ? (SolidColorBrush)
                (new BrushConverter().ConvertFrom("SlateGray")) : Brushes.Red;
        }

        internal static void setBlue(Button button)
        {
            button.Background = button.Background == Brushes.Blue ? (SolidColorBrush)
                (new BrushConverter().ConvertFrom("SlateGray")) : Brushes.Blue;
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

        internal static void dropPiece(Button A, Button B, Button C, Button D, Button E, Button F, Dictionary<string,bool> state)
        {
            if(state[A.Name])
            {
               //Column is full
            }
            else if (state[B.Name])
            {
                Animate.setRed(A);
                state[A.Name] = true;
            }
            else if (state[C.Name])
            {
                Animate.setRed(A);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setRed(B), .3);
                state[B.Name] = true;
            }
            else if (state[D.Name])
            {
                Animate.setRed(A);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setRed(B), .3);
                Animate.delayedExecute(() => Animate.setGrey(B), .4);

                Animate.delayedExecute(() => Animate.setRed(C), .35);
                state[C.Name] = true;
            }
            else if (state[E.Name])
            {
                Animate.setRed(A);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setRed(B), .3);
                Animate.delayedExecute(() => Animate.setGrey(B), .4);

                Animate.delayedExecute(() => Animate.setRed(C), .35);
                Animate.delayedExecute(() => Animate.setGrey(C), .45);

                Animate.delayedExecute(() => Animate.setRed(D), .4);
                state[D.Name] = true;
            }
            else if (state[F.Name])
            {
                Animate.setRed(A);
                Animate.delayedExecute(() => Animate.setGrey(A), .4);

                Animate.delayedExecute(() => Animate.setRed(B), .3);
                Animate.delayedExecute(() => Animate.setGrey(B), .4);

                Animate.delayedExecute(() => Animate.setRed(C), .35);
                Animate.delayedExecute(() => Animate.setGrey(C), .45);

                Animate.delayedExecute(() => Animate.setRed(D), .4);
                Animate.delayedExecute(() => Animate.setGrey(D), .5);

                Animate.delayedExecute(() => Animate.setRed(E), .45);
                state[E.Name] = true;
            }
            else 
            {
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
                state[F.Name] = true;
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

