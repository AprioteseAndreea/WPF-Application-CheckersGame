using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.ViewModel
{
    public class StatisticsViewModel
    {
        public string RedWinners { get; set; }
        public string WhiteWinners { get; set; }

        public StatisticsViewModel()
        {
            ReadFromFile();
        }
        public void ReadFromFile()
        {

            String line = null;
            try
            {
                StreamReader sr = new StreamReader("C:/Users/PC HOME/source/repos/CheckersGame/Resources/winners.txt");
                line = sr.ReadLine();
                WhiteWinners = line;
                while (line != null)
                {

                    RedWinners = sr.ReadLine();
                    line = null;

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
    }
}
