using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Tracker_Library.Models;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using Dapper;
using static System.Formats.Asn1.AsnWriter;
using System.Reflection;
using System.Threading.Channels;
using System.Diagnostics;

namespace Tournament_Tracker_Library.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";
        /// TODO - Make the CreatePrize method actualle save to the database
        /// <summary>
        /// Saves a new prize to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including the unique inditifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query to insert the prize into the database
                string query = "INSERT INTO Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage) " +
                               "VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage)";

                // Execute the query
                connection.Execute(query, model);

                // Since you're inserting the prize, you might need to retrieve the generated ID
                // You can either use SCOPE_IDENTITY() or an output parameter to get the ID

                // Close the connection
                connection.Close();

                return model;
            }

        }

        public PersonModel CreatePerson(PersonModel model)
        {

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query to insert the prize into the database
                string query = "INSERT INTO Person (FirstName, LastName, EmailAddress, CellphoneNumber) " +
                                "VALUES (@FirstName, @LastName, @EmailAddress, @CellphoneNumber)";

                // Execute the query
                connection.Execute(query, model);

                // Since you're inserting the prize, you might need to retrieve the generated ID
                // You can either use SCOPE_IDENTITY() or an output parameter to get the ID

                // Close the connection
                connection.Close();

                return model;
            }
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query to insert the team into the database
                string query = "INSERT INTO Team (TeamName) VALUES (@TeamName); SELECT CAST(SCOPE_IDENTITY() AS INT)";

                // Execute the query and retrieve the generated team ID
                int teamId = connection.QuerySingle<int>(query, model);

                // Assign the generated team ID to the model
                model.Id = teamId;

                // Insert team members
                foreach (PersonModel tm in model.TeamMembers)
                {
                    string queryTeamMember = "INSERT INTO TeamMembers (TeamId, PersonId) VALUES (@TeamId, @PersonId)";
                    connection.Execute(queryTeamMember, new { TeamId = teamId, PersonId = tm.Id });
                }

                // Close the connection
                connection.Close();

                return model;
            }
        }


        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Open the connection
                connection.Open();
               
                SaveTournament(connection, model);
                SaveTournamentPrizes(connection, model);
                SaveTournamentTeams(connection, model);
                SaveTournamentRounds(connection, model);
                // Close the connection
                connection.Close();

                
            }
        }

        private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    string matchupQuery = "INSERT INTO Matchup (TournamentId, MatchupRound) " +
                                          "VALUES (@TournamentId, @MatchupRound); " +
                                          "SELECT CAST(SCOPE_IDENTITY() as int);";
                    var parameters = new { TournamentId = model.Id, MatchupRound = matchup.MatchupRound };
                    int matchupId = connection.QuerySingle<int>(matchupQuery, parameters);
                    matchup.Id = matchupId; // Assuming `MatchupModel` has an `Id` property

                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        string matchupEntriesQuery;
                        object parametersEntry;

                        if (entry.ParentMatchup != null && entry.ParentMatchup.Id != 0)
                        {
                            if (entry.TeamCompeting == null)
                            {
                                matchupEntriesQuery = "INSERT INTO MatchupEntries (MatchupId, ParentMatchupId) " +
                                                      "VALUES (@MatchupId, @ParentMatchupId)";
                                parametersEntry = new { MatchupId = matchupId, ParentMatchupId = entry.ParentMatchup.Id };
                            }
                            else
                            {
                                matchupEntriesQuery = "INSERT INTO MatchupEntries (MatchupId, ParentMatchupId, TeamCompetingId) " +
                                                      "VALUES (@MatchupId, @ParentMatchupId, @TeamCompetingId)";
                                parametersEntry = new { MatchupId = matchupId, ParentMatchupId = entry.ParentMatchup.Id, TeamCompetingId = entry.TeamCompeting.Id };
                            }
                        }
                        else
                        {
                            if (entry.TeamCompeting == null)
                            {
                                matchupEntriesQuery = "INSERT INTO MatchupEntries (MatchupId) " +
                                                      "VALUES (@MatchupId)";
                                parametersEntry = new { MatchupId = matchupId };
                            }
                            else
                            {
                                matchupEntriesQuery = "INSERT INTO MatchupEntries (MatchupId, TeamCompetingId) " +
                                                      "VALUES (@MatchupId, @TeamCompetingId)";
                                parametersEntry = new { MatchupId = matchupId, TeamCompetingId = entry.TeamCompeting.Id };
                            }
                        }

                        connection.Execute(matchupEntriesQuery, parametersEntry);
                    }
                }
            }
        }


        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            // Define the SQL query to insert the tournament and retrieve the new ID
            string query = "INSERT INTO Tournament (TournamentName, EntryFee, Active) " +
                           "VALUES (@TournamentName, @EntryFee, 1); " +
                           "SELECT CAST(SCOPE_IDENTITY() AS INT);";

            // Execute the query and retrieve the generated TournamentId
            int tournamentId = connection.QuerySingle<int>(query, model);

            // Assign the retrieved TournamentId to the model
            model.Id = tournamentId;

         
        }

        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            // Insert prizes
            foreach (PrizeModel pz in model.Prizes)
            {
                string prizeQuery = "INSERT INTO TournamentPrizes (TournamentId, PrizeId) " +
                                    "VALUES (@TournamentId, @PrizeId)";
                var parameters = new { TournamentId = model.Id, PrizeId = pz.Id };
                connection.Execute(prizeQuery, parameters);
            }
        }
            
        private void SaveTournamentTeams(IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel tm in model.EnteredTeams)
            {
                string pQuery = "INSERT INTO TournamentEntries (TournamentId, TeamId) " +
                                   "VALUES (@TournamentId, @TeamId)";
                var parameters = new { TournamentId = model.Id, TeamId = tm.Id };
                connection.Execute(pQuery, parameters);

            }
        }
            public MatchupEntryModel CreateMatchupEntry(MatchupEntryModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query to insert the prize into the database
                string query = "INSERT INTO MatchupEntry (TeamCompeting, Score, ParentMatchup) " +
                                "VALUES (@TeamCompeting, @Score, @ParentMatchup)";

                // Execute the query
                connection.Execute(query, model);

                // Since you're inserting the prize, you might need to retrieve the generated ID
                // You can either use SCOPE_IDENTITY() or an output parameter to get the ID

                // Close the connection
                connection.Close();

                return model;
            }
        }

        public MatchupEntryModel UpdateMatchupEntry(MatchupEntryModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Open the connection
                connection.Open();
                // Define the SQL query
                string query = "UPDATE MatchupEntry SET TeamCompeting = @TeamCompeting, Score = @Score, ParentMatchup = @ParentMatchup " +
                               "WHERE Id = @Id";

                // Execute the query
                connection.Execute(query, new { TeamCompeting = model.TeamCompeting, Score = model.Score, ParentMatchup = model.ParentMatchup, Id = model.Id });


                // Since you're inserting the prize, you might need to retrieve the generated ID
                // You can either use SCOPE_IDENTITY() or an output parameter to get the ID

                // Close the connection
                connection.Close();

                return model;
            }
        }

        public MatchupModel SaveWinner(MatchupModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query to insert the prize into the database
                string query = "INSERT INTO Matchup (TeamId, Winner, MatchupRound) " +
                                "VALUES (@TeamId, @Winner, @MatchupRound)";

                // Execute the query
                connection.Execute(query, model);

                // Since you're inserting the prize, you might need to retrieve the generated ID
                // You can either use SCOPE_IDENTITY() or an output parameter to get the ID

                // Close the connection
                connection.Close();

                return model;
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> peopleList;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query
                string query = "SELECT * FROM Person";

                // Execute the query and retrieve the results into a list of PersonModel objects
                peopleList = connection.Query<PersonModel>(query).ToList();
            }
            return peopleList;
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> teamList;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query
                string query = @"SELECT t.Id AS TeamId, t.TeamName, p.Id AS PersonId, p.FirstName, p.LastName, p.EmailAddress, p.CellphoneNumber
                         FROM Team t
                         INNER JOIN TeamMembers tm ON t.Id = tm.TeamId
                         INNER JOIN Person p ON tm.PersonId = p.Id";

                // Execute the query and retrieve the results into a list of TeamModel objects with members populated
                var teamDictionary = new Dictionary<int, TeamModel>(); // Using a dictionary to group team members by team id

                connection.Query<TeamModel, PersonModel, TeamModel>(
                    query,
                    (team, person) =>
                    {
                        if (!teamDictionary.TryGetValue(team.Id, out var teamEntry))
                        {
                            teamEntry = team;
                            teamEntry.TeamMembers = new List<PersonModel>();
                            teamDictionary.Add(teamEntry.Id, teamEntry);
                        }
                        teamEntry.TeamMembers.Add(person);
                        return teamEntry;
                    },
                    splitOn: "PersonId"
                );

                teamList = teamDictionary.Values.ToList();
            }

            return teamList;
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;
            List<MatchupModel> matchupList;
            List<TeamModel> enteredTeams = new List<TeamModel>();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query to get all active tournaments
                string query = "SELECT * FROM Tournament WHERE Active = 1";

                // Execute the query and retrieve the results into a list of TournamentModel objects
                output = connection.Query<TournamentModel>(query).ToList();

                foreach (TournamentModel t in output)
                {
                    // Get the prizes for each tournament
                    string prizeQuery = "SELECT p.* FROM Prizes p INNER JOIN TournamentPrizes tp ON p.Id = tp.PrizeId WHERE tp.TournamentId = @TournamentId";
                    t.Prizes = connection.Query<PrizeModel>(prizeQuery, new { TournamentId = t.Id }).ToList();
                    List<TeamModel> teams = GlobalConfig.Connection.GetTeam_All();
                    string  matchupentriesQuery = "SELECT * From MatchupEntries";
                    List<MatchupEntryModel> matchupenties = connection.Query<MatchupEntryModel>(matchupentriesQuery).ToList();
                    foreach (TeamModel team in teams)
                    {
                        foreach (MatchupEntryModel matchup in matchupenties)
                        {
                            if (team.Id == matchup.TeamCompetingId)
                            {
                                enteredTeams.Add(team);
                            }
                        }
                    }

                    // Get matchups for each tournament
                    string matchupsQuery = "SELECT * FROM Matchup WHERE TournamentId = @TournamentId ORDER BY MatchupRound";
                    matchupList = connection.Query<MatchupModel>(matchupsQuery, new { TournamentId = t.Id }).ToList();

                    foreach (MatchupModel m in matchupList)
                    {
                        // Get entries for each matchup
                        string entriesQuery = "SELECT * FROM MatchupEntries WHERE MatchupId = @MatchupId";
                        List<MatchupEntryModel> entriesList = connection.Query<MatchupEntryModel>(entriesQuery, new { MatchupId = m.Id }).ToList();
                        m.Entries = entriesList;

                        List<TeamModel> allTeams = GetTeam_All();

                        if (m.WinnerId > 0)
                        {
                            m.Winner = allTeams.FirstOrDefault(x => x.Id == m.WinnerId);
                        }

                        foreach (var me in m.Entries)
                        {
                            if (me.TeamCompetingId > 0)
                            {
                                me.TeamCompeting = allTeams.FirstOrDefault(x => x.Id == me.TeamCompetingId);
                            }

                            if (me.ParentMatchupId > 0)
                            {
                                me.ParentMatchup = matchupList.FirstOrDefault(x => x.Id == me.ParentMatchupId);
                            }
                        }
                    }

                    // List<List<MatchupModel>>
                    List<MatchupModel> currRow = new List<MatchupModel>();
                    int currRound = 1;
                    foreach (MatchupModel m in matchupList)
                    {
                        if (m.MatchupRound > currRound)
                        {
                            t.Rounds.Add(currRow);
                            currRow = new List<MatchupModel>();
                            currRound += 1;
                        }
                        currRow.Add(m);
                    }

                    t.Rounds.Add(currRow);
                }
            }

            return output;
        }

       

        public List<MatchupEntryModel> SelectAllEntries()
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Open();
                string query = "SELECT * FROM MatchupEntries";
                output = connection.Query<MatchupEntryModel>(query).ToList();

            }
            return output;
        }

        public TeamModel GetTeam(int id)
        {
            List<TeamModel> teamList = new List<TeamModel>();
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Open();
                string query = "SELECT * FROM Team Where id = " + id;
                teamList = connection.Query<TeamModel>(query).ToList();

            }
            if (teamList.Count > 0)
            {
                return teamList[0];
            }
            else { return null; }
        }

        public void UpdateMatchup(MatchupModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                string matchupWinnerQuery = "UPDATE Matchup SET WinnerId = @WinnerId WHERE Id = @Id";
                var parameters = new { WinnerId = model.WinnerId, Id = model.Id };

                connection.Execute(matchupWinnerQuery, parameters);
            }
        }


        public void UpdateMatchupEntries(MatchupModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                foreach (MatchupEntryModel entryModel in model.Entries)
                {
                    string scoreQuery = "UPDATE MatchupEntries SET Score = @Score WHERE Id = @Id";
                    var scoreParameters = new { Score = entryModel.Score, Id = entryModel.Id };
                    connection.Execute(scoreQuery, scoreParameters);

                    string teamCompetingQuery = "UPDATE MatchupEntries SET TeamCompetingId = @TeamCompetingId WHERE Id = @Id";
                    var teamCompetingParameters = new { TeamCompetingId = entryModel.TeamCompetingId, Id = entryModel.Id };
                    connection.Execute(teamCompetingQuery, teamCompetingParameters);
                }
            }
        }

    }
}