using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPazam.Services
{
    public interface IFileService
    {
        string GetFenFromDaysLeft(int daysLeft);
    }
}
