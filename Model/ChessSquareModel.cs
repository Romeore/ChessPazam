using ChessPazam.Enums;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPazam.Model
{
    public class ChessSquareModel : ObservableObject
    {
        private bool _isBlack;
        private ChessPiece _chessPiece;
        private PlayerColor _playerColor;

        public bool IsBlack
        {
            get { return _isBlack; }
            set { Set("IsBlack", ref _isBlack, value); }
        }

        public ChessPiece ChessPiece
        {
            get { return _chessPiece; }
            set { Set("ChessPiece", ref _chessPiece, value); }
        }

        public PlayerColor PlayerColor
        {
            get { return _playerColor; }
            set { Set("PlayerColor", ref _playerColor, value); }
        }
    }
}
