using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Tracker_Library.Models;

namespace Tournament_Tracker_Library
{
    public static class TournamentLogic
    {
        public static TournamentModel CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumbersOfRounds(randomizedTeams.Count);
            int byes = NumbersOfByes(rounds, randomizedTeams.Count);
            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));
            CreateOtherRounds(model, rounds);
            return model;
        }
        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previusRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in previusRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }

                model.Rounds.Add(currRound);
                previusRound = currRound;

                currRound = new List<MatchupModel>();
                round += 1;
            }
        }
        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel { Entries = new List<MatchupEntryModel>() };

            foreach (var team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                // Check if a matchup is complete or if there are byes to handle
                if (curr.Entries.Count > 1 || byes > 0)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel { Entries = new List<MatchupEntryModel>() };

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }

            // Add any leftover matchup if not complete
            if (curr.Entries.Count > 0)
            {
                curr.MatchupRound = 1;
                output.Add(curr);
            }

            return output;
        }




        private static int NumbersOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i<= rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;

            return output;
        }
        private static int FindNumbersOfRounds(int teamsCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamsCount)
            {
                output += 1;
                val *= 2;
            }
            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(a => Guid.NewGuid()).ToList();
            
        }
    }
}
