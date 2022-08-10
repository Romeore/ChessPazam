using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPazam.Services
{
    public class FileService : IFileService
    {
        private string _chessPuzzlesFileUrl = Directory.GetCurrentDirectory() + "/ChessPuzzles.txt"; 

        public string GetFenFromDaysLeft(int daysLeft)
        {
            return File.ReadAllLines(_chessPuzzlesFileUrl)[Math.Abs(daysLeft)];
        }
    }
}
