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


        int xWinCount, oWinCount, drawCount, turnCount;
        Brush black;
        Brush AliceBlue;

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
                currentTurn.Text = "X";
            }
            else
            {
                b.Content = "X";
                currentTurn.Text = "O";
            }
            b.IsEnabled = false;
            turn = !turn;
            winnerCheck();
            turnCount++;
        }
        private void winnerCheck()
        {
            bool gameIsWon = false;
            //Horizontal checks
            if ((A1.Content == A2.Content) && (A2.Content == A3.Content) && (!A1.IsEnabled))
                gameIsWon = true;
            else if ((B1.Content == B2.Content) && (B2.Content == B3.Content) && (!B1.IsEnabled))
                gameIsWon = true;
            else if ((C1.Content == C2.Content) && (C2.Content == C3.Content) && (!C1.IsEnabled))
                gameIsWon = true;


            //vertical checks

            else if ((A1.Content == B1.Content) && (B1.Content == C1.Content) && (!A1.IsEnabled))
                gameIsWon = true;
            else if ((A2.Content == B2.Content) && (B2.Content == C2.Content) && (!A2.IsEnabled))
                gameIsWon = true;
            else if ((A3.Content == B3.Content) && (B3.Content == C3.Content) && (!A3.IsEnabled))
                gameIsWon = true;

            //diagonal checks

            else if ((A1.Content == B2.Content) && (B2.Content == C3.Content) && (!A1.IsEnabled))
                gameIsWon = true;
            else if ((A3.Content == B2.Content) && (B2.Content == C1.Content) && (!C1.IsEnabled))
                gameIsWon = true;

            if (gameIsWon == true)
            {
                disableButtons();
                String winner;
                if (turn != true)
                {
                    winner = "O";
                    oWinCount++;
                    oWins.Text = oWinCount.ToString();
                    winnerText.Text += winner;
                }
                else
                {
                    winner = "X";
                    xWinCount++;
                    winnerText.Text += winner;
                    xWins.Text = xWinCount.ToString();
                }
            }
            else
            {
                if (turnCount == 8)
                {
                    ++drawCount;
                    drawS.Text = drawCount.ToString();

                }
            }
        }
        private void disableButtons()
        {

            A1.IsEnabled = false;
            A2.IsEnabled = false;
            A3.IsEnabled = false;
            B1.IsEnabled = false;
            B2.IsEnabled = false;
            B3.IsEnabled = false;
            C1.IsEnabled = false;
            C2.IsEnabled = false;
            C3.IsEnabled = false;
            GameBoard.Background = black;

        }
        private void ngButton(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            turn = true;
            turnCount = 0;

            A1.IsEnabled = true;
            A2.IsEnabled = true;
            A3.IsEnabled = true;
            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;
            C1.IsEnabled = true;
            C2.IsEnabled = true;
            C3.IsEnabled = true;


            A1.Content = "";
            A2.Content = "";
            A3.Content = "";
            B1.Content = "";
            B2.Content = "";
            B3.Content = "";
            C1.Content = "";
            C2.Content = "";
            C3.Content = "";
            winnerText.Text = "Winner is: ";
            currentTurn.Text = "O";
            GameBoard.Background = AliceBlue;
        }
        private void resetButton(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            turn = true;
            turnCount = 0;

            A1.IsEnabled = true;
            A2.IsEnabled = true;
            A3.IsEnabled = true;
            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;
            C1.IsEnabled = true;
            C2.IsEnabled = true;
            C3.IsEnabled = true;


            A1.Content = "";
            A2.Content = "";
            A3.Content = "";
            B1.Content = "";
            B2.Content = "";
            B3.Content = "";
            C1.Content = "";
            C2.Content = "";
            C3.Content = "";
            GameBoard.Background = AliceBlue;
            xWinCount = 0;
            oWinCount = 0;
            drawCount = 0;

            xWins.Text = xWinCount.ToString();
            oWins.Text = oWinCount.ToString();
            drawS.Text = drawCount.ToString();
            winnerText.Text = "Winner is: ";
            currentTurn.Text = "O";


        }
        private void saveButton(object sender, RoutedEventArgs e)
        {

        }
        private void muteButton(object sender, RoutedEventArgs e)
        {

        }
    }
    }
