using System.Windows;
using System.Windows.Controls;
using CheckersGame.Services;

namespace CheckersGame.View
{
    /// <summary>
    /// Interaction logic for PlayGameView.xaml
    /// </summary>
    public partial class PlayGameView : UserControl
    {
        public PlayGameView()
        {
            InitializeComponent();
            ExternalHelper.ReadWinnersFromFile();

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RedPieceOut.Content = InternalHelper.redPieceOut.ToString();
            WhitePieceOut.Content = InternalHelper.whitePieceOut.ToString();


            InternalHelper.NumberOfClicks++;

            verifyIsFinnish();
            if (InternalHelper.NumberOfClicks % 2 == 0)
            {
                if (CurrentPlayerLabel.Content.Equals("1"))
                {
                    CurrentPlayerLabel.Content = "2";
                    InternalHelper.CurrentPlayer = 2;
                }
                else
                {
                    CurrentPlayerLabel.Content = "1";
                    InternalHelper.CurrentPlayer = 1;
                }

            }
        }
        public static void verifyIsFinnish()
        {
            if (InternalHelper.redPieceOut == 12)
            {
                MessageBox.Show(" Player 1 is the winner!");
                InternalHelper.WhiteWinners++;
            }
            if (InternalHelper.whitePieceOut == 12)
            {
                MessageBox.Show(" Player 2 is the winner!");
                InternalHelper.RedWinners++;
            }
            ExternalHelper.WriteWinnersToFile();
        }

        private void SaveGameButton_Click(object sender, RoutedEventArgs e)
        {
            ExternalHelper.SaveGameInFile();
        }
    }
}
