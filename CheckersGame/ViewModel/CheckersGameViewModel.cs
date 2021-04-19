using System.Collections.Generic;
using System.Collections.ObjectModel;
using CheckersGame.Model;
using CheckersGame.Services;

namespace CheckersGame.ViewModel
{
    public class CheckersGameViewModel
    {
        public static ObservableCollection<ObservableCollection<Square>> Squares { get; set; }
        public static bool loadFromFile;

        public CheckersGameViewModel()
        {
            if (loadFromFile == true)
            {
                Squares = new ObservableCollection<ObservableCollection<Square>>(ExternalHelper.InitGameBoardFromFile());
            }
            else
            {
                Squares = new ObservableCollection<ObservableCollection<Square>>(InternalHelper.InitGameBoard());

            }

        }


        public static void ShowPossibleMovesForRedPiece(List<KeyValuePair<int, int>> possibleSimpleMoves)
        {


            foreach (KeyValuePair<int, int> pair in possibleSimpleMoves)
            {
                Squares[pair.Key][pair.Value].Image = "/CheckersGame;component/Resources/Pieces/RedCirclePiece.jpg";
            }

        }
        public static void ShowPossibleMovesForWhitePiece(List<KeyValuePair<int, int>> possibleSimpleMoves)
        {


            foreach (KeyValuePair<int, int> pair in possibleSimpleMoves)
            {
                Squares[pair.Key][pair.Value].Image = "/CheckersGame;component/Resources/Pieces/WhiteCirclePiece.jpg";
            }

        }


    }
}
