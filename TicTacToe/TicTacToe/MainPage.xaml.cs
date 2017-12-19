using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TicTacToe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool turn = true; //True O turn false X turn
        int xWinCount, oWinCount, drawCount;

        public MainPage()
        {
            this.InitializeComponent();
        }
        private void buttonClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            if (turn == true)
            {
                b.Content = "O";
            }
            else
            {
                b.Content = "X";
            }
            b.IsEnabled = false;
            turn = !turn;
            winnerCheck();
        }
        private void winnerCheck()
        {
            bool gameIsWon = false;

            if ((a1.Content == a2.Content) && (a2.Content == a3.Content))
            {
                gameIsWon = true;
            }
           else if ((b1.Content == b2.Content) && (b2.Content == b3.Content))
            {
                gameIsWon = true;
            }
            else if((c1.Content == c2.Content) && (c2.Content == a3.Content))
            {
                gameIsWon = true;
            }
            else if((a1.Content == b1.Content) && (b1.Content == c1.Content))
            {
                gameIsWon = true;
            }
            else if ((a2.Content == b2.Content) && (b1.Content == c2.Content))
            {
                gameIsWon = true;
            }
            else if((a3.Content == b3.Content) && (b3.Content == c3.Content))
            {
                gameIsWon = true;
            }

            if (gameIsWon == true)
            {
                String winner;
                if (turn == true)
                {
                    winner = "O";
                    oWinCount++;
                }
                else
                {
                    winner = "X";
                    xWinCount++;
                }
            }
        }
        private async void youWin()
        {
            // Call app specific code to subscribe to the service. For example:
            ContentDialog submitDialog = new ContentDialog
            {
                Title = "Congratulations!",
                Content = "You win!",
                PrimaryButtonText = "Yay",
            };
        }
    }
}
