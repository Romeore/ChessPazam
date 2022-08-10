using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPazam
{
    public static class UserSettings
    {
        public static DateTime? ReleaseDate { get; set; }

        public static void LoadUserSettings()
        {
            ReleaseDate = (DateTime)Properties.Settings.Default["ReleaseDate"];
        }

        public static void SaveUserSettings()
        {
            Properties.Settings.Default["ReleaseDate"] = ReleaseDate;
            Properties.Settings.Default.Save();
        }
    }
}
