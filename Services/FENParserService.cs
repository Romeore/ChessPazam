using ChessPazam.Enums;
using ChessPazam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPazam.Services
{
    public class FENParserService : IFENParserService
    {
        public PlayerColor GetPlayerToMove(string FEN)
        {
            string[] fenSubStrings = FEN.Split(' ');
            return fenSubStrings[1].Equals("w") ? PlayerColor.White : PlayerColor.Black;
        }

        public List<ChessSquareModel> ParseFEN(string FEN)
        {
            List<ChessSquareModel> squares = new List<ChessSquareModel>();
            ChessSquareModel square = new ChessSquareModel();
            int currentSquare = 0;
            string[] fenSubStrings = FEN.Split(' ');
            string[] ranks = fenSubStrings[0].Split('/');

            foreach (string rank in ranks)
            {
                foreach (char symbol in rank)
                {
                    if (Char.IsDigit(symbol))
                    {
                        for (int i = 0; i < symbol - '0'; i++)
                        {
                            square = new ChessSquareModel() { ChessPiece = ChessPiece.None, IsBlack = ((currentSquare++ / 8) % 2 - currentSquare % 2) == 0 };
                            squares.Add(square);
                        }
                    }
                    else
                    {
                        switch (symbol)
                        {
                            case 'p':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.Black, ChessPiece = ChessPiece.Pawn };
                                }
                                break;
                            case 'P':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.White, ChessPiece = ChessPiece.Pawn };
                                }
                                break;

                            case 'k':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.Black, ChessPiece = ChessPiece.King };
                                }
                                break;
                            case 'K':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.White, ChessPiece = ChessPiece.King };
                                }
                                break;

                            case 'n':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.Black, ChessPiece = ChessPiece.Knight };
                                }
                                break;
                            case 'N':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.White, ChessPiece = ChessPiece.Knight };
                                }
                                break;

                            case 'b':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.Black, ChessPiece = ChessPiece.Bishop };
                                }
                                break;
                            case 'B':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.White, ChessPiece = ChessPiece.Bishop };
                                }
                                break;

                            case 'q':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.Black, ChessPiece = ChessPiece.Queen };
                                }
                                break;
                            case 'Q':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.White, ChessPiece = ChessPiece.Queen };
                                }
                                break;

                            case 'r':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.Black, ChessPiece = ChessPiece.Rook };
                                }
                                break;
                            case 'R':
                                {
                                    square = new ChessSquareModel() { PlayerColor = PlayerColor.White, ChessPiece = ChessPiece.Rook };
                                }
                                break;
                        }
                        square.IsBlack = ((currentSquare++ / 8) % 2 - currentSquare % 2) == 0;
                        squares.Add(square);
                    }
                }
            }
            return squares;
        }
    }
}
