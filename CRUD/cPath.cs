using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class cPath
    {
        //PATH OF FOLDER
        public static string pathFolder = Environment.CurrentDirectory + @"\Db";

        //PATH OF TEXT FILES
        public static string pathPlayers = Environment.CurrentDirectory + @"\Db\players.txt";
        public static string pathRole = Environment.CurrentDirectory + @"\Db\role.txt";
        public static string pathBatting = Environment.CurrentDirectory + @"\Db\batting.txt";
        public static string pathBowling = Environment.CurrentDirectory + @"\Db\bowling.txt";
        public static string pathSignYear = Environment.CurrentDirectory + @"\Db\signYear.txt";
        public static string pathCountry = Environment.CurrentDirectory + @"\Db\country.txt";
    }
}
