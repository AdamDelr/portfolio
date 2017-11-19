using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Connect4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        GameState gameState = new GameState();

        private void button_A1_Click(object sender, RoutedEventArgs e)
        {
            Button A1 = sender as Button;
            disableButtons();
            Animate.dropPiece(A1, B1, C1, D1, E1, F1, gameState);
            setMsg(Logic.checkWin(gameState));
        }

        private void button_A2_Click(object sender, RoutedEventArgs e)
        {
            Button A2 = sender as Button;
            disableButtons();
            Animate.dropPiece(A2, B2, C2, D2, E2, F2, gameState);
            setMsg(Logic.checkWin(gameState));
        }

        private void button_A3_Click(object sender, RoutedEventArgs e)
        {
            Button A3 = sender as Button;
            disableButtons();
            Animate.dropPiece(A3, B3, C3, D3, E3, F3, gameState);
            setMsg(Logic.checkWin(gameState));
        }

        private void button_A4_Click(object sender, RoutedEventArgs e)
        {
            Button A4 = sender as Button;
            disableButtons();
            Animate.dropPiece(A4, B4, C4, D4, E4, F4, gameState);
            setMsg(Logic.checkWin(gameState));
        }

        private void button_A5_Click(object sender, RoutedEventArgs e)
        {
            Button A5 = sender as Button;
            disableButtons();
            Animate.dropPiece(A5, B5, C5, D5, E5, F5, gameState);
            setMsg(Logic.checkWin(gameState));
        }

        private void button_A6_Click(object sender, RoutedEventArgs e)
        {
            Button A6 = sender as Button;
            disableButtons();
            Animate.dropPiece(A6, B6, C6, D6, E6, F6, gameState);
            setMsg(Logic.checkWin(gameState));
        }

        private void button_A7_Click(object sender, RoutedEventArgs e)
        {
            Button A7 = sender as Button;
            disableButtons();
            Animate.dropPiece(A7, B7, C7, D7, E7, F7, gameState);
            setMsg(Logic.checkWin(gameState));
        }

        //Prevent user from double clicking
        private void disableButtons()
        {
            A1.IsHitTestVisible = false;
            A2.IsHitTestVisible = false;
            A3.IsHitTestVisible = false;
            A4.IsHitTestVisible = false;
            A5.IsHitTestVisible = false;
            A6.IsHitTestVisible = false;
            A7.IsHitTestVisible = false;
            Animate.delayedExecute(() => A1.IsHitTestVisible = true, .8);
            Animate.delayedExecute(() => A2.IsHitTestVisible = true, .8);
            Animate.delayedExecute(() => A3.IsHitTestVisible = true, .8);
            Animate.delayedExecute(() => A4.IsHitTestVisible = true, .8);
            Animate.delayedExecute(() => A5.IsHitTestVisible = true, .8);
            Animate.delayedExecute(() => A6.IsHitTestVisible = true, .8);
            Animate.delayedExecute(() => A7.IsHitTestVisible = true, .8);
        }

        private void setMsg(int result)
        {
            if (result == 3)
            {
                return;
            }
            else if (result == 1)
            {
                message.Text = "Red Player Wins";
            }
            else
            {
                message.Text = "Blue Player Wins";
            }
        
        }
    }
}
