using ChessPazam.Enums;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChessPazam.View
{
    /// <summary>
    /// Interaction logic for ChessSquare.xaml
    /// </summary>
    public partial class ChessSquare : UserControl
    {
        public ChessSquare()
        {
            InitializeComponent();
        }

        public static PlayerColor GetPlayerColor(DependencyObject obj)
        {
            return (PlayerColor)obj.GetValue(PlayerColorProperty);
        }

        public static void SetPlayerColor(DependencyObject obj, PlayerColor value)
        {
            obj.SetValue(PlayerColorProperty, value);
        }

        public static readonly DependencyProperty PlayerColorProperty =
            DependencyProperty.RegisterAttached("PlayerColor", typeof(PlayerColor), typeof(ChessSquare), new PropertyMetadata(PlayerColor.White));

        public static ChessPiece GetChessPiece(DependencyObject obj)
        {
            return (ChessPiece)obj.GetValue(ChessPieceProperty);
        }

        public static void SetChessPiece(DependencyObject obj, ChessPiece value)
        {
            obj.SetValue(ChessPieceProperty, value);
        }

        public static readonly DependencyProperty ChessPieceProperty =
            DependencyProperty.RegisterAttached("ChessPiece", typeof(ChessPiece), typeof(ChessSquare), new PropertyMetadata(ChessPiece.None));

        public static bool GetIsBlack(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsBlackProperty);
        }

        public static void SetIsBlack(DependencyObject obj, bool value)
        {
            obj.SetValue(IsBlackProperty, value);
        }

        public static readonly DependencyProperty IsBlackProperty =
            DependencyProperty.Register("IsBlack", typeof(bool), typeof(ChessSquare), new PropertyMetadata(false));
    }
}
