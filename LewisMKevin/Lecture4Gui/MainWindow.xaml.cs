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

namespace Lecture4Gui
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

        private void YellowButton_Click(object sender, RoutedEventArgs e)
        {
            ColorCanvas.Background = Brushes.Yellow;
        }

        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            ColorCanvas.Background = Brushes.Blue;
        }

        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            ColorCanvas.Background = Brushes.Green;
        }
    }
}
