using ChessPazam.Model;
using ChessPazam.Services;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPazam.ViewModel
{
    public class ChessBoardViewModel : ViewModelBase
    {
        private ObservableCollection<ChessSquareModel> _squares;

        public ObservableCollection<ChessSquareModel> Squares
        {
            get { return _squares; }
            set { Set("Squares", ref _squares, value); }
        }

        public void InitBoard(List<ChessSquareModel> squares)
        {
            Squares = new ObservableCollection<ChessSquareModel>(squares);
        }
    }
}
