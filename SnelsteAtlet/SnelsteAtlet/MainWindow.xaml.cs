using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SnelsteAtlet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nameFastest;
        int secondsFastest = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void newButten_Click(object sender, RoutedEventArgs e)
        {   
                //int secondsCurrent;
            bool isvalidNumber = int.TryParse(secondsTextBox.Text, out int secondsCurrent);
            
            //if (isvalidNumber == true)
            if (isvalidNumber)
            {
                if (secondsFastest == 0 || secondsCurrent < secondsFastest)
                {
                    secondsFastest = secondsCurrent;
                    nameFastest = nameTextBox.Text;
                }
            }
        }

        private void CloseButten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton(object sender, RoutedEventArgs e)
        {
            nameTextBox.Clear();
            secondsTextBox.Clear();
            resultTextBox.Clear();

            nameTextBox.Focus();
        }

        private void resultTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void fastestButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = $"De snelste atleet is {nameFastest} met een tijd van {secondsFastest} seconden";
        }
    }
}