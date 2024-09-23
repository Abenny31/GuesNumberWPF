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

namespace GuessNumberWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartStateVisibility();

        }
        public MainWindow(bool win)
        {
            InitializeComponent();
            frmFrame.Content = new ScorePage(win);
            frmFrame.Visibility = Visibility.Visible;
            
        }
        
        
        private void btnSendName_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != "")
            {
                SendNameVisibility();
                lblPlay.Content = "How about a game " + txtName.Text + " ?";
            }
            else
                lblEnterName.Visibility = Visibility.Visible;

              //pitaj za pokretanje igre
            //prikazi botun
        }

        private void btnYesPlay_Click(object sender, RoutedEventArgs e)
        {
            Human human = new Human(txtName.Text);
            human.WannaPlay = true;
            frmFrame.Visibility = Visibility.Visible;
            frmFrame.Content= new GamePage(human);

            

        }
        private void btnNoPlay_Click(object sender, RoutedEventArgs e)
        {
            string NoPlay = " Are you affraid to loose " + txtName.Text + " !?";
            MessageBoxResult result;
            result= MessageBox.Show(NoPlay, "", MessageBoxButton.YesNo);
            

            if (result == MessageBoxResult.Yes)
                StartStateVisibility();
            
            
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            string restartGame = "Do you want to restart the game?";
            
            MessageBoxResult result = MessageBox.Show(restartGame, "Restart", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
                RefreshMain();

               
        }

        

        private void RefreshMain()
        {
            if (frmFrame.Content!=null)
            {
                frmFrame.Content=null;
            }
            StartStateVisibility();

            
        }

        private void StartStateVisibility()
        {

            txtName.Text = "";
            lblEnterName.Visibility = Visibility.Visible;
            btnSendName.Visibility = Visibility.Visible;
            lblName.Visibility = Visibility.Visible;
            txtName.Visibility = Visibility.Visible;

            frmFrame.Visibility = Visibility.Hidden;
            lblPlay.Visibility = Visibility.Hidden;
            btnYesPlay.Visibility = Visibility.Hidden;
            btnNoPlay.Visibility = Visibility.Hidden;
            lblEnterName.Visibility = Visibility.Hidden;
            lblThinkNumber.Visibility = Visibility.Hidden;

        }
        private void SendNameVisibility()
        {
            lblEnterName.Visibility = Visibility.Hidden;
            btnSendName.Visibility = Visibility.Hidden;
            lblName.Visibility = Visibility.Hidden;
            txtName.Visibility = Visibility.Hidden;

            lblPlay.Visibility = Visibility.Visible;
            btnYesPlay.Visibility = Visibility.Visible;
            btnNoPlay.Visibility = Visibility.Visible;
            lblThinkNumber.Visibility = Visibility.Visible;

        }



        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Close();
        }

        
    }
}
