using ChessPazam.Enums;
using ChessPazam.Services;
using GalaSoft.MvvmLight;
using System;

namespace ChessPazam.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private readonly IFENParserService _fenParserService;
        private readonly IFileService _fileService;
        private ChessBoardViewModel _chessBoardViewModel;
        private PlayerColor _playerToMove;
        private DateTime? _selectedReleaseDate;
        private int _daysLeft;

        public PlayerColor PlayerToMove
        {
            get { return _playerToMove; }
            set { Set("PlayerToMove", ref _playerToMove, value); }
        }

        public DateTime? SelectedReleaseDate
        {
            get { return _selectedReleaseDate; }
            set
            {
                UserSettings.ReleaseDate = value;
                Set("SelectedReleaseDate", ref _selectedReleaseDate, value);
                CalculateDays();
                InitChessBoard();
            }
        }

        public int DaysLeft
        {
            get { return _daysLeft; }
            set { Set("DaysLeft", ref _daysLeft, value); }
        }

        public MainViewModel(ChessBoardViewModel chessBoardViewModel, IFENParserService fenParserService, IFileService fileService)
        {
            UserSettings.LoadUserSettings();
            _fenParserService = fenParserService;
            _fileService = fileService;
            _chessBoardViewModel = chessBoardViewModel;
            SelectedReleaseDate = UserSettings.ReleaseDate;
            InitChessBoard();
        }

        private void InitChessBoard()
        {
            string fen = _fileService.GetFenFromDaysLeft(DaysLeft);
            PlayerToMove = _fenParserService.GetPlayerToMove(fen);
            _chessBoardViewModel.InitBoard(_fenParserService.ParseFEN(fen));
        }

        private void CalculateDays()
        {
            TimeSpan? daysLeft = SelectedReleaseDate - DateTime.Now;
            DaysLeft = (int)(Math.Ceiling(daysLeft.Value.TotalDays));
        }
    }
}
