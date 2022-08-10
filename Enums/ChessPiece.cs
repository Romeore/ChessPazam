using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPazam.Enums
{
    public enum ChessPiece
    {
        None = PackIconKind.None,
        Pawn = PackIconKind.ChessPawn,
        Knight = PackIconKind.ChessKnight,
        Bishop = PackIconKind.ChessBishop,
        Rook = PackIconKind.ChessRook,
        King = PackIconKind.ChessKing,
        Queen = PackIconKind.ChessQueen
    }
}
