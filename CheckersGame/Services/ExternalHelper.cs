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
    public class ExternalHelper
    {

        public static void ReadWinnersFromFile()
        {
            String line = null;
            try
            {
                StreamReader sr = new StreamReader("C:/Users/PC HOME/source/repos/CheckersGame/Resources/winners.txt");
                line = sr.ReadLine();
                InternalHelper.RedWinners = Int32.Parse(line);
                while (line != null)
                {

                    line = sr.ReadLine();
                    InternalHelper.WhiteWinners = Int32.Parse(line);
                }
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
        public static void WriteWinnersToFile()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:/Users/PC HOME/source/repos/CheckersGame/Resources/winners.txt");
                sw.WriteLine(InternalHelper.WhiteWinners);
                sw.WriteLine(InternalHelper.RedWinners);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
        public static int getItem(string imagePath)
        {
            int item = 0;
            if (imagePath.Equals(InternalHelper.simpleSquare)) item = 1;
            if (imagePath.Equals(InternalHelper.whitePiece)) item = 2;
            if (imagePath.Equals(InternalHelper.redPiece)) item = 3;
            if (imagePath.Equals(InternalHelper.whiteKing)) item = 4;
            if (imagePath.Equals(InternalHelper.redKing)) item = 5;



            return item;

        }
        public static void SaveGameInFile()
        {
            try
            {

                StreamWriter sw = new StreamWriter("C:/Users/PC HOME/source/repos/CheckersGame/Resources/lastGameSaved.txt");
                for (int row = 0; row < 8; row++)
                {

                    for (int col = 0; col < 8; col++)
                    {
                        sw.WriteLine(getItem(CheckersGameViewModel.Squares[row][col].Image));

                    }

                }
                sw.WriteLine(InternalHelper.redPieceOut);
                sw.WriteLine(InternalHelper.whitePieceOut);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
        public static string getPath(int number)
        {
            string imagePath = null;
            if (number == 1) imagePath = InternalHelper.simpleSquare;
            if (number == 2) imagePath = InternalHelper.whitePiece;
            if (number == 3) imagePath = InternalHelper.redPiece;
            if (number == 4) imagePath = InternalHelper.whiteKing;
            if (number == 5) imagePath = InternalHelper.redKing;

            return imagePath;

        }

        public static ObservableCollection<ObservableCollection<Square>> InitGameBoardFromFile()
        {
            ObservableCollection<ObservableCollection<Square>> gameBoard = new ObservableCollection<ObservableCollection<Square>>();


            try
            {
                StreamReader sr = new StreamReader("C:/Users/PC HOME/source/repos/CheckersGame/Resources/lastGameSaved.txt");

                for (int row = 0; row < 8; row++)
                {


                    ObservableCollection<Square> currentLine = new ObservableCollection<Square>();
                    for (int col = 0; col < 8; col++)
                    {
                        String line = sr.ReadLine();
                        Square currentCell = new Square(row, col, getPath(int.Parse(line)));
                        currentLine.Add(currentCell);

                    }
                    gameBoard.Add(currentLine);
                }
                InternalHelper.redPieceOut = int.Parse(sr.ReadLine());
                InternalHelper.whitePieceOut = int.Parse(sr.ReadLine());

                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }


            return gameBoard;

        }
    }
}

