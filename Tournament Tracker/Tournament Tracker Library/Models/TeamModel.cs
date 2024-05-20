using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker_Library.Models
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The unique indetifier for the team.
        /// </summary>
        public int Id { get; set; }
        public string TeamName { get; set; }

        public TeamModel(string teamName)
        {
            TeamName = teamName;
           
        }
        public TeamModel() { }
    }
}
