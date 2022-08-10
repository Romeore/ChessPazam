using ChessPazam.Enums;
using ChessPazam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPazam.Services
{
    public interface IFENParserService
    {
        List<ChessSquareModel> ParseFEN(string FEN);

        PlayerColor GetPlayerToMove(string FEN);
    }
}
