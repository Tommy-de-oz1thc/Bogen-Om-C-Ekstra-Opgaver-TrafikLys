using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Tracker_Library.DataAccess;
using Tournament_Tracker_Library.Models;

namespace Tournament_Tracker_Library
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModel.csv";
        public const string PersonsFile = "PersonModel.csv";
        public const string TeamsFile = "TeamModel.csv";
        public const string TournamentsFile = "TournamentModel.csv";
        public const string MatchupEntrysFile = "MatchupEntryModel.csv";
        public const string MatchupsFile = "MatchupsModel.csv";
    
        public static List<MatchupModel> matches { get; set; }  = new List<MatchupModel>();
        public static IDataConnection Connection { get; private set; } 

        public static void InitialzeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            //else if (db == DatabaseType.TextFile)
            //{
            //    // TODO - Create the Text Connection
            //    TextConnector text = new TextConnector();
            //    Connection = text;
            //}
        }

        public static string CnnString(string name)
        {
            
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
