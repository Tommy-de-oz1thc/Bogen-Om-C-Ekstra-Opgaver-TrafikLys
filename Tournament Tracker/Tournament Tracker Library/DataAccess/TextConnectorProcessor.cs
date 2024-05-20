using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tournament_Tracker_Library.Models;
using System.IO;
using System.Net.NetworkInformation; // Add this namespace for directory operations



namespace Tournament_Tracker_Library.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {


        public static string FullFilePath(this string fileName)
        {
            // Get the directory path from the app settings
            string directoryPath = ConfigurationManager.AppSettings["filePath"];

            // Combine the directory path with the file name
            string fullPath = Path.Combine(directoryPath, fileName);

            // Check if the directory exists; if not, create it
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Return the full file path
            return fullPath;
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }

            return output;
        }


        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string PersonsFile)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> persons = PersonsFile.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel team = new TeamModel();
                team.Id = int.Parse(cols[0].Trim()); // Trim spaces around ID
                team.TeamName = cols[1].Trim(); // Trim spaces around team name

                if (cols.Length > 2 && !string.IsNullOrWhiteSpace(cols[2]))
                {
                    string[] memberIds = cols[2].Trim().Split('|'); // Trim spaces around member IDs
                    foreach (string memberId in memberIds)
                    {
                        if (int.TryParse(memberId, out int id))
                        {
                            PersonModel person = persons.FirstOrDefault(p => p.Id == id);
                            if (person != null)
                            {
                                team.TeamMembers.Add(person);
                            }
                        }
                    }
                }

                output.Add(team);
            }

            return output;
        }





        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel t in models)
            {
                string memberIds = string.Join("|", t.TeamMembers.Select(m => m.Id)); // Concatenate member IDs with '|'
                lines.Add($"{t.Id},{t.TeamName}, {memberIds}"); // Include member IDs in the line
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static List<PersonModel> ConvertStringToPersonList(string teamMemberString)
        {
            List<PersonModel> teamMembers = new List<PersonModel>();

            // Split the string by the pipe character to get individual person IDs
            string[] personIds = teamMemberString.Split('|');

            foreach (string personId in personIds)
            {
                if (int.TryParse(personId, out int id))
                {
                    // Here you need to retrieve the PersonModel object corresponding to the ID from your data source.
                    // Assuming you have a method to get a PersonModel by ID, you can call it here.
                    // For demonstration purposes, let's assume you have a GetPersonById method in your data source.
                    PersonModel person = teamMembers.FirstOrDefault(p => p.Id == id);
                    if (person != null)
                    {
                        teamMembers.Add(person);
                    }
                    else
                    {
                        // Handle the case where the PersonModel for the given ID is not found
                        // You can throw an exception, log a warning, or handle it based on your application's requirements.
                    }
                }
                else
                {
                    // Handle the case where the person ID is not a valid integer
                    // You can throw an exception, log a warning, or handle it based on your application's requirements.
                }
            }

            return teamMembers;
        }

        private static string ConvertPersonListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }
            //2|5|
            foreach (PersonModel person in people)
            {
                output += $"{person.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
        {
            //id,TournamentName, EntryFee,(id|id|id - Entered Teams),(id|id|id -Prizes).(Rounds - id^id^id|id^id^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(GlobalConfig.PersonsFile);
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = int.Parse(cols[2]);

                string[] teamIds = cols[3].Split("|");

                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }
                if (cols[4].Length > 0)
                {
                    string[] prizeIds = cols[4].Split('|');

                    foreach (string id in prizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }
                }
                // TODO - Capture Round inforamtion
                string[] rounds = cols[5].Split('|');
                List<MatchupModel> ms = new List<MatchupModel>();

                foreach (string round in rounds)
                {
                    string[] msText = round.Split('^');
                   
                    if (msText.Length > 0)
                    {
                          foreach (string matchupModelTextId in msText)
                        {
                            try
                            {
                                ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                            }
                            catch { }
                        }
                        tm.Rounds.Add(ms);
                    }
                }
               
                
                output.Add(tm);
            }

            return output;
        }
        public static void SaveRoundsToFile(this TournamentModel model, string MatchupsFile, string MatchupEntrysFile)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    matchup.SaveMatchupToFile(MatchupsFile,MatchupEntrysFile);  

                }
            }
        }
        private static string ConvertMatchupEntrysListToString(List<MatchupEntryModel> entries)
        {
            string output = "";

            if (entries.Count == 0)
            {
                return "";
            }
            //2|5|
            foreach (MatchupEntryModel entry in entries)
            {
                output += $"{entry.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static TeamModel LookupTeamById(int id)
        {
            List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(GlobalConfig.PersonsFile);
            return teams.FirstOrDefault(x => x.Id == id);
        }

        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {   
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                p.Winner = LookupTeamById(int.Parse(cols[2]));
                p.MatchupRound = int.Parse(cols[3]);

                output.Add(p);
            }

            return output;
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry, string MatchupEntryFile)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntrysFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 1;

            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;

            }
            entry.Id = currentId;
            entries.Add(entry);
            List<string> lines = new List<string>();

            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                lines.Add($"{e.Id},{e.MatchupId},{e.ParentMatchupId},{e.Score},{e.TeamCompetingId}");


            }
                        
            File.WriteAllLines(MatchupEntryFile.FullFilePath(), lines);
        }

        public static void SaveMatchupToFile(this MatchupModel matchup, string MatchupsFile, string MatchupEntrysFile)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            List<string> en = new List<string>();
            int currentId = 1;

            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            matchup.Id = currentId;
            
            foreach (MatchupEntryModel p in matchup.Entries)
            {
                

                    string parent = "";
                    string teamCompetingId = "";
                    if (p.TeamCompeting != null)
                    {
                        teamCompetingId = p.TeamCompeting.Id.ToString();
                    }
                    if (p.ParentMatchup != null)
                    {
                        parent = p.ParentMatchup.Id.ToString();
                    }
                    en.Add($"{p.Id},{teamCompetingId},{p.Score},{parent}");
               

                File.WriteAllLines(MatchupsFile.FullFilePath(), en);
            }
            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                { 
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{ConvertMatchupEntrysListToString(m.Entries)},{winner},{m.MatchupRound}");


            }
            File.WriteAllLines(MatchupsFile.FullFilePath(), lines);


        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntrysFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();


            foreach (string id in ids)
            {
                output.Add(entries.First(x => x.Id == int.Parse(id)));
            }

            return output;
        }


        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
             foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupEntryModel me = new MatchupEntryModel
                {
                    Id = int.Parse(cols[0]),
                    TeamCompeting = int.TryParse(cols[1], out int teamId) ? LookupTeamById(teamId) : null,
                    Score = double.Parse(cols[2]),
                    
                    ParentMatchup = int.TryParse(cols[3], out int parentId) ? LookupMatchupById(parentId) : null
                };

                output.Add(me);
            }

            return output;
        }

        

        
        private static MatchupModel LookupMatchupById(int id)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            return matchups.FirstOrDefault(x => x.Id == id);
        }

       
        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel p in models)
            {
                lines.Add($"{p.Id},{p.TournamentName},{p.EntryFee},{ ConvertTeamListToString(p.EnteredTeams) },{ ConvertPrizeListToString(p.Prizes) },{ ConvertRoundListToString(p.Rounds) },True ");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }
            //2|5|
            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ ConvertMatchupListToString(r) }|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }
            //2|5|
            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length - 1);

            return output;

        }

        public static string ConvertMatchupEntryListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }
            //2|5|
            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length - 1);

            return output;

        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }
            //2|5|
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }
            //2|5|
            foreach (TeamModel team in teams)
            {
                output += $"{team.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static List<MatchupEntryModel> ConvertToTeamModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupEntryModel p = new MatchupEntryModel();
                p.Id = int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    p.TeamCompeting = null;
                }
                else
                {
                    p.TeamCompeting.Id = int.Parse(cols[1]);
                }
              
                TeamModel team = TextConnector.FindTeamById(p.TeamCompeting.Id); // You need to implement this method
                p.TeamCompeting = team;
                p.Score = int.Parse(cols[2]);
                if (cols[3].Length == 0)
                { p.ParentMatchup = null;
                } else {
                    p.ParentMatchup.Id = int.Parse(cols[3]);
                }
                
                MatchupModel matchup = TextConnector.FindMatchupById(p.ParentMatchup.Id); // You need to implement this method
                p.ParentMatchup = matchup;

                output.Add(p);
            }

            return output;
        }

        public static void SaveToMatchupEntryFile(this List<MatchupEntryModel> models, string fileName)
        {
            
        }

     
        public static void SaveToMatchupFile(this List<MatchupModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (MatchupModel p in models)
            {
                string winner = "";
                if(p.Winner != null)
                {
                    winner = p.Winner.Id.ToString();
                }
                lines.Add($"{p.Id},{winner},{p.MatchupRound}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
