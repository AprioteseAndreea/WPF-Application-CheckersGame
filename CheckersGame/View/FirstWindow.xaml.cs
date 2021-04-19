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
using System.Windows.Shapes;
using CheckersGame.View;
using CheckersGame.ViewModel;

namespace CheckersGame
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
           
            DataContext = new CheckersGameViewModel();
            CheckersGameViewModel.loadFromFile = false;

            
            
        }

        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new StatisticsViewModel();

          
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AboutViewModel();

        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new HelpViewModel();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new CheckersGameViewModel();
            CheckersGameViewModel.loadFromFile = true;

        }
    }
}
