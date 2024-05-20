using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Tracker_Library.Models;
using Tournament_Tracker_Library.DataAccess.TextHelpers;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Tournament_Tracker_Library.DataAccess
{
    public class TextConnector : IDataConnection
    {
       
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            // Find the ID          
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            // Add the new record with the new ID (max + 1)
            prizes.Add(model);
            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            prizes.SaveToPrizeFile(GlobalConfig.PrizesFile);

            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            List<PersonModel> persons = GlobalConfig.PersonsFile.FullFilePath().LoadFile().ConvertToPersonModels();
            // Find the ID          
            int currentId = 1;
            if (persons.Count > 0)
            {
                currentId = persons.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            // Add the new record with the new ID (max + 1)
            persons.Add(model);
            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            persons.SaveToPersonFile(GlobalConfig.PersonsFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            // Load the text file
            List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(GlobalConfig.PersonsFile);

            // Find the ID
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            teams.Add(model);

            // Save the List<string> to the text file
            teams.SaveToTeamFile(GlobalConfig.TeamsFile);

            return model;
        }


        public void CreateTournament(TournamentModel model)
        {
            // Load the text file
            List<TournamentModel> tournaments = GlobalConfig.TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels();

            // Find the ID          
            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Save matchups and entries to their respective files
            model.SaveRoundsToFile(GlobalConfig.MatchupsFile, GlobalConfig.MatchupEntrysFile);

     

            // Add the new record with the new ID (max + 1)
            tournaments.Add(model);

            // Convert the tournaments to List<string>
            // Save the List<string> to the text file
            tournaments.SaveToTournamentFile(GlobalConfig.TournamentsFile);
        }

        public static TeamModel FindTeamById(int teamId)
        {
            // Load teams from the team file
            List<string> lines = File.ReadAllLines(GlobalConfig.TeamsFile).ToList();

            // Convert the lines to TeamModel objects
            List<TeamModel> teams = lines.ConvertToTeamModels(GlobalConfig.TeamsFile);

            // Find the team with the specified ID
            TeamModel team = teams.FirstOrDefault(t => t.Id == teamId);

            return team;
        }
        public static MatchupModel FindMatchupById(int matchupId)
        {
            // Load teams from the team file
            List<string> lines = File.ReadAllLines(GlobalConfig.MatchupsFile).ToList();

            // Convert the lines to TeamModel objects
            List<MatchupModel> matchups = TextConnectorProcessor.ConvertToMatchupModels(lines);

            // Find the team with the specified ID
            MatchupModel matchup = matchups.FirstOrDefault(t => t.Id == matchupId);

            return matchup;

        }
        public MatchupEntryModel CreateMatchupEntry(MatchupEntryModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            List<MatchupEntryModel> matchupEntrys = GlobalConfig.MatchupEntrysFile.FullFilePath().LoadFile().ConvertToTeamModels();
            // Find the ID          
            int currentId = 1;
            if (matchupEntrys.Count > 0)
            {
                currentId = matchupEntrys.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            // Add the new record with the new ID (max + 1)
            matchupEntrys.Add(model);
            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            matchupEntrys.SaveToMatchupEntryFile(GlobalConfig.MatchupEntrysFile);

            return model;
        }

        public MatchupEntryModel UpdateMatchupEntry(MatchupEntryModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            List<MatchupEntryModel> matchupEntrys = GlobalConfig.MatchupEntrysFile.FullFilePath().LoadFile().ConvertToTeamModels();
            foreach (MatchupEntryModel entry in matchupEntrys)
            {
                if (entry.Id == model.Id)
                {
                    entry.TeamCompeting.Id = model.TeamCompeting.Id;
                    entry.Score = model.Score;
                    entry.ParentMatchup.Id = model.ParentMatchup.Id;
                }
            }
            matchupEntrys.SaveToMatchupEntryFile(GlobalConfig.MatchupEntrysFile);
            return model;
        }

        public MatchupModel SaveWinner(MatchupModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            // Find the ID          
            int currentId = 1;
            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            // Add the new record with the new ID (max + 1)
            matchups.Add(model);
            // Convert the prizes to List<string>
            // Save the List<string> to the text file
            matchups.SaveToMatchupFile(GlobalConfig.MatchupsFile);


            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> persons = GlobalConfig.PersonsFile.FullFilePath().LoadFile().ConvertToPersonModels();
            return persons;
        }

        public List<TeamModel> GetTeam_All()
        {
            // Load data from CSV files
            List<TeamModel> teamList = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(GlobalConfig.PersonsFile);
            List<PersonModel> personList = GlobalConfig.PersonsFile.FullFilePath().LoadFile().ConvertToPersonModels();
         

            // Create a dictionary to group team members by team id
            var teamDictionary = new Dictionary<int, TeamModel>();

            // Iterate through team list and add them to dictionary
            foreach (var team in teamList)
            {
                if (!teamDictionary.ContainsKey(team.Id))
                {
                    team.TeamMembers = new List<PersonModel>();
                    teamDictionary.Add(team.Id, team);
                }
            }

            

            return teamDictionary.Values.ToList();
        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels();
        }


        public List<MatchupEntryModel> SelectAllEntries()
        {
            string[] matchupEntries = GlobalConfig.MatchupEntrysFile.Split(',');
            return null;
        }


        public TeamModel GetTeam(int id)
        {
            List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(GlobalConfig.PersonsFile);
            return teams.FirstOrDefault(t => t.Id == id);

        }

        public void UpdateMatchup(MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupsFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            MatchupModel oldMatchup = new MatchupModel();
            foreach (MatchupModel m in matchups)
            {
                if (m.Id == matchup.Id)
                {
                    oldMatchup = m;
                }
            }
            matchups.Remove(oldMatchup);
            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                UpdateEntryToFile(entry);
            }

            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.WinnerId != null)
                {
                    winner = m.WinnerId.ToString();
                }
                lines.Add($"{m.Id},{TextConnectorProcessor.ConvertMatchupEntryListToString(matchups) },{ winner },{m.MatchupRound} ");
            }
            File.WriteAllLines(GlobalConfig.MatchupsFile.FullFilePath(), lines);
        }

        private void UpdateEntryToFile(MatchupEntryModel entry)
        {
            List<string> lines = GlobalConfig.MatchupEntrysFile.Split(',').ToList();
            string entriesLine = lines[1];
            List<string> entrysplit = entriesLine.Split('|').ToList();
            List<MatchupEntryModel> entries = TextConnectorProcessor.ConvertToMatchupEntryModels(entrysplit);
            MatchupEntryModel oldEntry = new MatchupEntryModel();

            foreach(MatchupEntryModel e in entries)
                {
                if (e.Id == entry.Id)
                {
                    oldEntry = e;
                }
                entries.Remove(oldEntry);
                entries.Add(e);
            }
           
            lines = new List<string>();
            MatchupEntryModel p = entry;
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
                lines.Append($"{p.Id},{teamCompetingId},{p.Score},{parent}");
           


        }

        public void UpdateMatchupEntries(MatchupModel model)
        {
            
           

        }
    }
}
