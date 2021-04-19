using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckersGame.Model;
using CheckersGame.ViewModel;

namespace CheckersGame.Services
{
    class InternalHelper
    {
        public static ObservableCollection<Square> PossibleMoves { get; set; }
        public static int NumberOfClicks { get; set; }
        public static int CurrentPlayer { get; set; }
        public static int whitePieceOut;
        public static int redPieceOut;
        public static int RedWinners { get; set; }
        public static int WhiteWinners { get; set; }
        public static string simpleSquare = "/CheckersGame;component/Resources/Pieces/SimpleSquare.jpg";

        public static string redPiece = "/CheckersGame;component/Resources/Pieces/RedSimplePiece.jpg";
        public static string whitePiece = "/CheckersGame;component/Resources/Pieces/WhiteSimplePiece.jpg";

        public static string redPos = "/CheckersGame;component/Resources/Pieces/RedCirclePiece.jpg";
        public static string whitePos = "/CheckersGame;component/Resources/Pieces/WhiteCirclePiece.jpg";

        public static string redKing = "/CheckersGame;component/Resources/Pieces/RedCrownPiece.jpg";
        public static string whiteKing = "/CheckersGame;component/Resources/Pieces/WhiteCrownPiece.jpg";


        public static ObservableCollection<ObservableCollection<Square>> InitGameBoard()
        {

            return new ObservableCollection<ObservableCollection<Square>>()
            {
                new ObservableCollection<Square>()
                {
                    new Square(0, 0, simpleSquare),
                    new Square(0, 1, redPiece),
                    new Square(0, 2, simpleSquare),
                    new Square(0, 3, redPiece),
                    new Square(0, 4, simpleSquare),
                    new Square(0, 5, redPiece),
                    new Square(0, 6, simpleSquare),
                    new Square(0, 7, redPiece)


                },
                new ObservableCollection<Square>()
                {
                    new Square(1, 0, redPiece),
                    new Square(1, 1, simpleSquare),
                    new Square(1, 2, redPiece),
                    new Square(1, 3, simpleSquare),
                    new Square(1, 4, redPiece),
                    new Square(1, 5, simpleSquare),
                    new Square(1, 6, redPiece),
                    new Square(1, 7, simpleSquare)


                },
                new ObservableCollection<Square>()
                {
                    new Square(2, 0, simpleSquare),
                    new Square(2, 1, redPiece),
                    new Square(2, 2, simpleSquare),
                    new Square(2, 3, redPiece),
                    new Square(2, 4, simpleSquare),
                    new Square(2, 5, redPiece),
                    new Square(2, 6, simpleSquare),
                    new Square(2, 7, redPiece)



                },
                new ObservableCollection<Square>()
                {
                    new Square(3, 0, simpleSquare),
                    new Square(3, 1, simpleSquare),
                    new Square(3, 2, simpleSquare),
                    new Square(3, 3, simpleSquare),
                    new Square(3, 4, simpleSquare),
                    new Square(3, 5, simpleSquare),
                    new Square(3, 6, simpleSquare),
                    new Square(3, 7, simpleSquare)

                },
                new ObservableCollection<Square>()
                {
                    new Square(4, 0, simpleSquare),
                    new Square(4, 1, simpleSquare),
                    new Square(4, 2, simpleSquare),
                    new Square(4, 3, simpleSquare),
                    new Square(4, 4, simpleSquare),
                    new Square(4, 5, simpleSquare),
                    new Square(4, 6, simpleSquare),
                    new Square(4, 7, simpleSquare)


                },
                new ObservableCollection<Square>()
                {
                    new Square(5, 0, whitePiece),
                    new Square(5, 1, simpleSquare),
                    new Square(5, 2, whitePiece),
                    new Square(5, 3, simpleSquare),
                    new Square(5, 4, whitePiece),
                    new Square(5, 5, simpleSquare),
                    new Square(5, 6, whitePiece),
                    new Square(5, 7, simpleSquare)




                },
                 new ObservableCollection<Square>()
                {
                    new Square(6, 0, simpleSquare),
                    new Square(6, 1, whitePiece),
                    new Square(6, 2, simpleSquare),
                    new Square(6, 3, whitePiece),
                    new Square(6, 4, simpleSquare),
                    new Square(6, 5, whitePiece),
                    new Square(6, 6, simpleSquare),
                    new Square(6, 7, whitePiece)




                },
                 new ObservableCollection<Square>()
                {
                    new Square(7, 0, whitePiece),
                    new Square(7, 1, simpleSquare),
                    new Square(7, 2, whitePiece),
                    new Square(7, 3, simpleSquare),
                    new Square(7, 4, whitePiece),
                    new Square(7, 5, simpleSquare),
                    new Square(7, 6, whitePiece),
                    new Square(7, 7, simpleSquare)




                }

            };

        }
    }
        
}
