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
 
    public partial class ScorePage : Page
    {
        public ScorePage(bool win)
        {
            InitializeComponent();
            lblWinLoose.Visibility = Visibility.Hidden;
            if (win)
                YouWin();// namista visibility na sta triba ili dodaje vrijednosti lbl...
            else
                YouLoose();
        }

        public void YouWin()
        {
            lblWinLoose.Visibility = Visibility.Visible;
            
            
        }
        public void YouLoose()
        {
            grdScore.Background = Brushes.Gray;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
        }
    }
}
