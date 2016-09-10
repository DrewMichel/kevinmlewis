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

namespace Lecture3Demo2
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

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            int spaceIndex = nameTextBox.Text.IndexOf(" ");

            string firstName = nameTextBox.Text.Substring(0, spaceIndex);
            string lastName = nameTextBox.Text.Substring(spaceIndex + 1);

            //First letter change
            char firstLetter = firstName[];
            //little trick for the lab, converts the char to a string, remember char's and strings are different. 
            string upperFirstLetter = firstLetter.ToString().ToUpper();

            OutputTextBox.Text = lastName + ", " + firstName;
        }
    }
}
