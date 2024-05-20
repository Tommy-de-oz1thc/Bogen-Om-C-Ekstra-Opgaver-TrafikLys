using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker_Library.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// The unique indetifier for the tournament.
        /// </summary>
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }

        public bool Active { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
        
        public TournamentModel(string tournamentName, decimal entryFee)
        {
            TournamentName = tournamentName;
            EntryFee = entryFee;
        }

        public TournamentModel() { }
    }


}
