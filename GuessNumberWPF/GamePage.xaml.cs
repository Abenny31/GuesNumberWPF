using System;
using System.Collections.Generic;
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

namespace GuessNumberWPF
{
    /// <summary>
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        Human Human = new Human();
        Machine Machine = new Machine();
        public GamePage(Human human)
        {
            Human = human;
            InitializeComponent();
            lblHumanName.Content = Human.Name;
            lblHumanWin.Visibility = Visibility.Hidden;
            lblMachineWin.Visibility = Visibility.Hidden;
            lblWrongNumber.Visibility = Visibility.Hidden;

        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            lblWrongNumber.Visibility = Visibility.Hidden;
            lblHumanWin.Visibility = Visibility.Hidden;
            lblMachineWin.Visibility = Visibility.Hidden;
            Machine.Getrandom();
            Human.Guess = checkGuess(txtGuess.Text);
            if (Human.Guess < 0)
            {
                lblWrongNumber.Visibility = Visibility.Visible;
                lblWrongNumber.Content = "You must enter number between 0 and 5!";

            }
            else
            {
                lblMachineNumber.Content = Machine.rand.ToString();
                lblHumanNumber.Content = Human.Guess.ToString();
            }

            bool winner = isHumanWinner(Human.Guess, Machine.rand);
            if (winner)
            {
                Human.WinCount += 1;
                lblHumanWin.Visibility = Visibility.Visible;
            }
            else
            {
                Machine.WinCount += 1;
                lblMachineWin.Visibility = Visibility.Visible;
            }
            lblHumanScore.Content = Human.WinCount.ToString();
            lblMachineScore.Content = Machine.WinCount.ToString();

        }

        private void btnStopPlay_Click(object sender, RoutedEventArgs e)
        {
            bool win;
            string msg = "Are you sure you want to finish??? ";
            var result = MessageBox.Show(msg, "", MessageBoxButton.YesNo);
            if (Human.WinCount > Machine.WinCount)
                win = true;
            else
                win = false;
            if (result == MessageBoxResult.Yes)
            { 
                
                MainWindow main = new MainWindow(win);
            }

                

        }

        private int checkGuess(string guess)
        {
            int checkGuess;
            try
            {
                checkGuess = int.Parse(guess);
                return checkGuess;
            }
            catch
            {
                return -1;
            }

        }
        private bool isHumanWinner(int human, int machine)
        {
            if (human == machine)
            {
                return true;
            }
            else
                return false;

        }
    }
}
