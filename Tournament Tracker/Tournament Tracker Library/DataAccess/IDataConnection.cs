using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Tracker_Library.Models;

namespace Tournament_Tracker_Library.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);

        TeamModel CreateTeam(TeamModel model);

        void CreateTournament(TournamentModel model);

        void UpdateMatchup(MatchupModel model);
        void UpdateMatchupEntries(MatchupModel model);
        MatchupEntryModel CreateMatchupEntry(MatchupEntryModel model);
        MatchupEntryModel UpdateMatchupEntry(MatchupEntryModel model);

    

        MatchupModel SaveWinner(MatchupModel model);
        List<PersonModel> GetPerson_All();

        List<TeamModel> GetTeam_All();

        List<TournamentModel> GetTournament_All();
        List<MatchupEntryModel> SelectAllEntries();

        TeamModel GetTeam(int id);
    }
}
