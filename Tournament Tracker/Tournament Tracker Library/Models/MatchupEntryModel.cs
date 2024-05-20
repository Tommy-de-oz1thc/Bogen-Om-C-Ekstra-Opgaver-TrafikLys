using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker_Library.Models
{
    public class MatchupEntryModel
    {

        /// <summary>
        /// The unique indetifier for the matchup.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represent one team in the matchup. 
        /// </summary>
        /// 
        public int TeamCompetingId { set; get; }
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represent the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        public int ParentMatchupId { get; set; }
        /// <summary>
        /// Represent the matchup that this team came 
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        public int MatchupId { get; set; }
    }
}
