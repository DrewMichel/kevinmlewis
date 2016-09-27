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

namespace Lecture4InClass
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

        private void ShowColorButton_Click(object sender, RoutedEventArgs e)
        {
            int temperature = Int32.Parse(TemperatureTextBox.Text);

            if (temperature >= 90)
            {
                ColorCanvas.Background = Brushes.Red;
            }
            else if (temperature >= 80) //80-89
            {
                ColorCanvas.Background = Brushes.Yellow;
            }
            else if (temperature >= 65 ) //65-79
            {
                ColorCanvas.Background = Brushes.Green;
            }
            else
            {
                ColorCanvas.Background = Brushes.Blue;
            }
            TempLabel.Content = TemperatureTextBox.Text;
        }
    }
}
