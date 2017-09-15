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

        /* Game state dictionary
        * Key == slot position
        * Value == occupied
        */
        private Dictionary<string, bool> gameState = new Dictionary<string, bool>
        {
            { "A1", false },{ "A2", false },{ "A3", false },{ "A4", false },{ "A5", false },{ "A6", false },{ "A7", false },
            { "B1", false },{ "B2", false },{ "B3", false },{ "B4", false },{ "B5", false },{ "B6", false },{ "B7", false },
            { "C1", false },{ "C2", false },{ "C3", false },{ "C4", false },{ "C5", false },{ "C6", false },{ "C7", false },
            { "D1", false },{ "D2", false },{ "D3", false },{ "D4", false },{ "D5", false },{ "D6", false },{ "D7", false },
            { "E1", false },{ "E2", false },{ "E3", false },{ "E4", false },{ "E5", false },{ "E6", false },{ "E7", false },
            { "F1", false },{ "F2", false },{ "F3", false },{ "F4", false },{ "F5", false },{ "F6", false },{ "F7", false },

        };

        private void button_A1_Click(object sender, RoutedEventArgs e)
        {
            Button A1 = sender as Button;

            Animate.dropPiece(A1, B1, C1, D1, E1, F1, gameState);
        }

        private void button_A2_Click(object sender, RoutedEventArgs e)
        {
            Button A2 = sender as Button;

            Animate.dropPiece(A2, B2, C2, D2, E2, F2, gameState);
        }

        private void button_A3_Click(object sender, RoutedEventArgs e)
        {
            Button A3 = sender as Button;

            Animate.dropPiece(A3, B3, C3, D3, E3, F3, gameState);
        }

        private void button_A4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_A5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_A6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_A7_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
