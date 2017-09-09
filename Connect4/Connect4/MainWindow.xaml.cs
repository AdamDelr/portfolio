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

        private void button_A1_Click(object sender, RoutedEventArgs e)
        {
            Button A1 = sender as Button;
            A1.Background = A1.Background == Brushes.Red ? (SolidColorBrush)
                (new BrushConverter().ConvertFrom("SlateGray")): Brushes.Red;

        }

        private void button_A2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_A3_Click(object sender, RoutedEventArgs e)
        {

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
