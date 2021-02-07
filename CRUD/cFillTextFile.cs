using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class cFillTextFile
    {
        //FILLING A DATA INTO TEXTFILE
        //DEFAULT VALUES
        public string[] dataPlayers = { "Shahrukh Khan;33;45;0;0;0;10;2.1 Million;10",
                                        "Manisha Koirala;29;77;0;0;1;9;449,000;10",
                                        "Juhi Chawla;22;28;0;0;0;7;112,000;10",
                                        "Priyanka Chopra;33;55;3;0;2;5;757,000;8",
                                        "Ashmita Patel;29;33;3;1;3;10;1.2 Million;10",
                                        "Shumona Bhatia;27;13;2;1;5;11;393,000;6",
                                        "Alka Choudhary;21;1;1;0;4;10;266,000;10",
                                        "Anjali Sharma;26;93;1;0;2;10;981,400;10",
                                        "Kareena Kapoor;34;99;1;0;7;9;280,000;7",
                                        "Saif Ali Khan;31;6;1;0;8;8;1.1 Million;5",
                                      };
        public string[] dataRole = { "Batsman","Bowler","Wicket keeper","All Rounder"};

        public string[] dataBatting = {"Right-Handed","Left-Handed"};

        public string[] dataCountry = { "Afghanistan", "Australia", "Bangladesh", "England", "Netherlands", "New ZeaLand", "South Africa", "Sri Lanka", "West Indies", "Zimbabwe", "India" };

        public string[] dataBowling = { "Right-arm off break", "Right-arm medium", "Right-arm fast-medium", "Slow left-arm orthodox", "Right-arm leg break","Not Bowler", "Left-arm fast-medium", "Right-arm fast", "Left-arm fast" };

        public string[] dataSignedYear = { "2008","2009","2010","2011","2012","2013","2014","2015","2016","2017","2018","2019","2020" };
        
    }
}
