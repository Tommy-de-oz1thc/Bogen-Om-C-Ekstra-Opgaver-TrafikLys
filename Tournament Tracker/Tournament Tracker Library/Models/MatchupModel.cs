using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker_Library.Models
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The unique indetifier for the macthup.
        /// </summary>
        public int Id { get; set; }

        public int WinnerId { get; set; }
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
              
                string output = "";
                // Fetch all teams once
                List<TeamModel> teams = GlobalConfig.Connection.GetTeam_All();
                foreach (MatchupEntryModel me in Entries)
                {
                  

                        TeamModel team = GlobalConfig.Connection.GetTeam(me.TeamCompetingId);
                    if (team != null)
                    {
                        if (output.Length == 0)
                        {
                            output += team.TeamName;
                        }
                        else
                        {
                            output += $" vs. {team.TeamName} ";
                        }
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }

                return output;
            }
        }


    }
}
