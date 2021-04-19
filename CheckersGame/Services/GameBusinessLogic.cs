using System;
using System.Collections.Generic;
using CheckersGame.Model;
using CheckersGame.ViewModel;

namespace CheckersGame.Services
{
    class GameBusinessLogic
    {
        public static Square PreviousCell { get; set; }
        public static List<KeyValuePair<int, int>> possibleMoves = new List<KeyValuePair<int, int>>();

        public static bool IsRedPiece(int x, int y)
        {
            if (CheckersGameViewModel.Squares[x][y].Image.Equals(InternalHelper.redPiece)) return true;
            return false;

        }
        public static bool IsWhitePiece(int x, int y)
        {
            if (CheckersGameViewModel.Squares[x][y].Image.Equals(InternalHelper.whitePiece)) return true;
            return false;

        }
        public static bool IsEmptyCell(int x, int y)
        {
            if (CheckersGameViewModel.Squares[x][y].Image.Equals(InternalHelper.simpleSquare)) return true;
            return false;

        }
        public static bool IsRedKingCell(int x, int y)
        {
            if (CheckersGameViewModel.Squares[x][y].Image.Equals(InternalHelper.redKing)) return true;
            return false;

        }
        public static bool IsWhiteKingCell(int x, int y)
        {
            if (CheckersGameViewModel.Squares[x][y].Image.Equals(InternalHelper.whiteKing)) return true;
            return false;

        }

        public static bool IsValidCoordonates(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < 8 && y < 8) return true;
            return false;

        }
        public static List<KeyValuePair<int, int>> PossiblesMovesForRedPiece(Square obj)
        {

            var myList = new List<KeyValuePair<int, int>>();
            if (IsValidCoordonates(obj.X + 1, obj.Y - 1) && IsEmptyCell(obj.X + 1, obj.Y - 1)) myList.Add(new KeyValuePair<int, int>(obj.X + 1, obj.Y - 1));
            if (IsValidCoordonates(obj.X + 1, obj.Y + 1) && IsEmptyCell(obj.X + 1, obj.Y + 1)) myList.Add(new KeyValuePair<int, int>(obj.X + 1, obj.Y + 1));
            if (IsValidCoordonates(obj.X + 1, obj.Y - 1) && (IsWhitePiece(obj.X + 1, obj.Y - 1) || IsWhiteKingCell(obj.X + 1, obj.Y - 1)) &&
                IsValidCoordonates(obj.X + 2, obj.Y - 2) && IsEmptyCell(obj.X + 2, obj.Y - 2))
            {
                myList.Add(new KeyValuePair<int, int>(obj.X + 2, obj.Y - 2));
            }
            if (IsValidCoordonates(obj.X + 1, obj.Y + 1) && (IsWhitePiece(obj.X + 1, obj.Y + 1) || IsWhiteKingCell(obj.X + 1, obj.Y + 1)) &&
               IsValidCoordonates(obj.X + 2, obj.Y + 2) && IsEmptyCell(obj.X + 2, obj.Y + 2))
            {
                myList.Add(new KeyValuePair<int, int>(obj.X + 2, obj.Y + 2));
            }


            return myList;


        }

        public static List<KeyValuePair<int, int>> PossiblesMovesForWhitePiece(Square obj)
        {
            var myList = new List<KeyValuePair<int, int>>();
            if (IsValidCoordonates(obj.X - 1, obj.Y - 1) && IsEmptyCell(obj.X - 1, obj.Y - 1)) myList.Add(new KeyValuePair<int, int>(obj.X - 1, obj.Y - 1));
            if (IsValidCoordonates(obj.X - 1, obj.Y + 1) && IsEmptyCell(obj.X - 1, obj.Y + 1)) myList.Add(new KeyValuePair<int, int>(obj.X - 1, obj.Y + 1));
            if (IsValidCoordonates(obj.X - 1, obj.Y - 1) && (IsRedPiece(obj.X - 1, obj.Y - 1) || IsRedKingCell(obj.X - 1, obj.Y - 1)) &&
                IsValidCoordonates(obj.X - 2, obj.Y - 2) && IsEmptyCell(obj.X - 2, obj.Y - 2))
            {
                myList.Add(new KeyValuePair<int, int>(obj.X - 2, obj.Y - 2));
            }
            if (IsValidCoordonates(obj.X - 1, obj.Y + 1) && (IsRedPiece(obj.X - 1, obj.Y + 1) || IsRedKingCell(obj.X - 1, obj.Y + 1)) &&
               IsValidCoordonates(obj.X - 2, obj.Y + 2) && IsEmptyCell(obj.X - 2, obj.Y + 2))
            {
                myList.Add(new KeyValuePair<int, int>(obj.X - 2, obj.Y + 2));
            }


            return myList;

        }
        public static List<KeyValuePair<int, int>> PossiblesMovesForWhiteKingPiece(Square obj)
        {
            var myList = new List<KeyValuePair<int, int>>();
            myList = PossiblesMovesForWhitePiece(obj);
            var myList2 = new List<KeyValuePair<int, int>>();
            myList2 = new List<KeyValuePair<int, int>>();
            if (IsValidCoordonates(obj.X + 1, obj.Y - 1) && IsEmptyCell(obj.X + 1, obj.Y - 1)) myList2.Add(new KeyValuePair<int, int>(obj.X + 1, obj.Y - 1));
            if (IsValidCoordonates(obj.X + 1, obj.Y + 1) && IsEmptyCell(obj.X + 1, obj.Y + 1)) myList2.Add(new KeyValuePair<int, int>(obj.X + 1, obj.Y + 1));
            if (IsValidCoordonates(obj.X + 1, obj.Y - 1) && (IsRedPiece(obj.X + 1, obj.Y - 1) || IsRedKingCell(obj.X + 1, obj.Y - 1)) &&
                IsValidCoordonates(obj.X + 2, obj.Y - 2) && IsEmptyCell(obj.X + 2, obj.Y - 2))
            {
                myList2.Add(new KeyValuePair<int, int>(obj.X + 2, obj.Y - 2));
            }
            if (IsValidCoordonates(obj.X + 1, obj.Y + 1) && (IsRedPiece(obj.X + 1, obj.Y + 1) || IsRedKingCell(obj.X + 1, obj.Y + 1)) &&
               IsValidCoordonates(obj.X + 2, obj.Y + 2) && IsEmptyCell(obj.X + 2, obj.Y + 2))
            {
                myList2.Add(new KeyValuePair<int, int>(obj.X + 2, obj.Y + 2));
            }




            foreach (KeyValuePair<int, int> cell in myList2)
            {

                myList.Add(cell);
            }
            return myList;

        }
        public static List<KeyValuePair<int, int>> PossiblesMovesForRedKingPiece(Square obj)
        {
            var myList = new List<KeyValuePair<int, int>>();
            if (IsValidCoordonates(obj.X - 1, obj.Y - 1) && IsEmptyCell(obj.X - 1, obj.Y - 1)) myList.Add(new KeyValuePair<int, int>(obj.X - 1, obj.Y - 1));
            if (IsValidCoordonates(obj.X - 1, obj.Y + 1) && IsEmptyCell(obj.X - 1, obj.Y + 1)) myList.Add(new KeyValuePair<int, int>(obj.X - 1, obj.Y + 1));
            if (IsValidCoordonates(obj.X - 1, obj.Y - 1) && (IsWhitePiece(obj.X - 1, obj.Y - 1) || IsWhiteKingCell(obj.X - 1, obj.Y - 1)) &&
                IsValidCoordonates(obj.X - 2, obj.Y - 2) && IsEmptyCell(obj.X - 2, obj.Y - 2))
            {
                myList.Add(new KeyValuePair<int, int>(obj.X - 2, obj.Y - 2));
            }
            if (IsValidCoordonates(obj.X - 1, obj.Y + 1) && (IsWhitePiece(obj.X - 1, obj.Y + 1) || IsWhiteKingCell(obj.X - 1, obj.Y + 1)) &&
               IsValidCoordonates(obj.X - 2, obj.Y + 2) && IsEmptyCell(obj.X - 2, obj.Y + 2))
            {
                myList.Add(new KeyValuePair<int, int>(obj.X - 2, obj.Y + 2));
            }

            var myList2 = new List<KeyValuePair<int, int>>();
            myList2 = PossiblesMovesForRedPiece(obj);
            foreach (KeyValuePair<int, int> cell in myList2)
            {

                myList.Add(cell);
            }
            return myList;

        }
        
        public static void VerifyJumpOverOpponent(Square obj)

        {
            if (IsRedPiece(PreviousCell.X, PreviousCell.Y) || IsRedKingCell(PreviousCell.X, PreviousCell.Y))
            {
                InternalHelper.whitePieceOut++;
            }
            else if (IsWhitePiece(PreviousCell.X, PreviousCell.Y) || IsWhiteKingCell(PreviousCell.X, PreviousCell.Y))
            {
                InternalHelper.redPieceOut ++; 

            }

            if (obj.X == (PreviousCell.X - 2) && obj.Y == (PreviousCell.Y - 2) && possibleMoves.Contains(new KeyValuePair<int, int>(obj.X, obj.Y)))
            {
                CheckersGameViewModel.Squares[PreviousCell.X - 1][PreviousCell.Y - 1].Image = InternalHelper.simpleSquare;

            }
            if (obj.X == (PreviousCell.X - 2) && obj.Y == (PreviousCell.Y + 2) && possibleMoves.Contains(new KeyValuePair<int, int>(obj.X, obj.Y)))
            {
                CheckersGameViewModel.Squares[PreviousCell.X - 1][PreviousCell.Y + 1].Image = InternalHelper.simpleSquare;

            }
            if (obj.X == (PreviousCell.X + 2) && obj.Y == (PreviousCell.Y - 2) && possibleMoves.Contains(new KeyValuePair<int, int>(obj.X, obj.Y)))
            {
                CheckersGameViewModel.Squares[PreviousCell.X + 1][PreviousCell.Y - 1].Image = InternalHelper.simpleSquare;

            }
            if (obj.X == (PreviousCell.X + 2) && obj.Y == (PreviousCell.Y + 2) && possibleMoves.Contains(new KeyValuePair<int, int>(obj.X, obj.Y)))
            {
                CheckersGameViewModel.Squares[PreviousCell.X + 1][PreviousCell.Y + 1].Image = InternalHelper.simpleSquare;

            }




        }
        private static bool IsOkClick(Square obj)
        {
            if (((IsRedPiece(obj.X, obj.Y) || IsRedKingCell(obj.X, obj.Y)) && InternalHelper.CurrentPlayer == 2) ||
                (IsWhitePiece(obj.X, obj.Y) || IsWhiteKingCell(obj.X, obj.Y) && InternalHelper.CurrentPlayer == 1)) return true;
            return false;
        }

        public static List<KeyValuePair<int, int>> UpdateGame(Square obj)

        {
           

            if (InternalHelper.NumberOfClicks % 2 != 0 && IsOkClick(obj))
            {
                PreviousCell = obj;
                if (IsRedPiece(obj.X, obj.Y))
                {
                    possibleMoves = PossiblesMovesForRedPiece(obj);
                    CheckersGameViewModel.ShowPossibleMovesForRedPiece(possibleMoves);
                }
                else if (IsWhitePiece(obj.X, obj.Y))
                {
                    possibleMoves = PossiblesMovesForWhitePiece(obj);
                    CheckersGameViewModel.ShowPossibleMovesForWhitePiece(possibleMoves);

                }
                else if (IsRedKingCell(obj.X, obj.Y))
                {
                    possibleMoves = PossiblesMovesForRedKingPiece(obj);
                    CheckersGameViewModel.ShowPossibleMovesForRedPiece(possibleMoves);


                }
                else if (IsWhiteKingCell(obj.X, obj.Y))
                {
                    possibleMoves = PossiblesMovesForWhiteKingPiece(obj);
                    CheckersGameViewModel.ShowPossibleMovesForWhitePiece(possibleMoves);


                }

            }
            else if (InternalHelper.NumberOfClicks % 2 == 0 && possibleMoves.Contains(new KeyValuePair<int, int>(obj.X, obj.Y)))
            {
                foreach (KeyValuePair<int, int> cell in possibleMoves)
                {

                    CheckersGameViewModel.Squares[cell.Key][cell.Value].Image = InternalHelper.simpleSquare;

                }
                if (IsRedPiece(PreviousCell.X, PreviousCell.Y) && obj.X == 7)
                {
                    CheckersGameViewModel.Squares[obj.X][obj.Y].Image = InternalHelper.redKing;

                }
                else if (IsWhitePiece(PreviousCell.X, PreviousCell.Y) && obj.X == 0)
                {
                    CheckersGameViewModel.Squares[obj.X][obj.Y].Image = InternalHelper.whiteKing;


                }
                else
                {
                    CheckersGameViewModel.Squares[obj.X][obj.Y].Image = PreviousCell.Image;

                }

                if (Math.Abs(PreviousCell.X - obj.X) == 2 && Math.Abs(PreviousCell.Y - obj.Y) == 2)
                {
                    VerifyJumpOverOpponent(obj);
                }
                CheckersGameViewModel.Squares[PreviousCell.X][PreviousCell.Y].Image = InternalHelper.simpleSquare;




            }

            return possibleMoves;
        }
    }
}
