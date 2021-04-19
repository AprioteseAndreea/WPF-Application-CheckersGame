using System.ComponentModel;
using System.Windows.Input;
using CheckersGame.Commands;
using CheckersGame.Services;

namespace CheckersGame.Model
{
    public class Square : INotifyPropertyChanged
    {

      
        public Square(int x, int y, string image)
        {
            this.X = x;
            this.Y = y;
            this.Image = image;
        }
       
        private int x;
        public int X
        {
            get { return x; }
            set
            {
                x = value;
                NotifyPropertyChanged("X");
            }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                NotifyPropertyChanged("Y");
            }
        }
        
        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                NotifyPropertyChanged("Image");
            }
        }
        
        private void UpdateBoard(object param)
        {
            GameBusinessLogic.UpdateGame(this);
          
        }
        private ICommand clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                if (clickCommand == null)
                {
                    clickCommand = new RelayCommand<Square>(UpdateBoard);

                }
                return clickCommand;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
