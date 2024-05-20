using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Tracker_Library.Models;
using Tournament_Tracker_Library;

using System.ComponentModel.DataAnnotations;

namespace Tournament_Tracker
{
    public partial class TournamentCreateForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public TournamentCreateForm()
        {
            InitializeComponent();
            WireUpList();
        }

        private void WireUpList()
        {
            SelectTeamComboBox.DataSource = null;
            SelectTeamComboBox.DataSource = availableTeams;
            SelectTeamComboBox.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private List<PrizeModel> GetSelectedPrizes()
        {
            return selectedPrizes;
        }

        private void CreateTournamentBTN_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TournamentModel tm = new TournamentModel();

                tm.TournamentName = TournamentNameTB.Text;
                tm.EntryFee = decimal.Parse(EntryFeeTB.Text);

                
                tm.Prizes = selectedPrizes;
                tm.EnteredTeams = selectedTeams;

                TournamentModel model = TournamentLogic.CreateRounds(tm);   

                GlobalConfig.Connection.CreateTournament(model);


                TournamentNameTB.Text = "";
                EntryFeeTB.Text = "0";
                DashboardForm frm = new DashboardForm();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("This For, has invalid informations");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (TournamentNameTB.Text == "")
            {
                output = false;
            }
            if (!decimal.TryParse(EntryFeeTB.Text, out decimal entryFee))
            {
                output = false;
            }

            return output;
        }

        private void AddTeamBTN_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)SelectTeamComboBox.SelectedItem;
            if (p != null)
            {
                availableTeams.Remove(p);
                selectedTeams.Add(p);
                WireUpList();
            }
        }

        private void TeamPlayersDeleteBTN_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (p != null)
            {
                selectedTeams.Remove(p);
                availableTeams.Add(p);
                WireUpList();
            }
        }

        private void CreatePrizeBTN_Click(object sender, EventArgs e)
        {
            PrizeCreateForm frm = new PrizeCreateForm(this);
            frm.Show();


        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpList();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpList();
        }

        private void NewTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeamCreateForm frm = new TeamCreateForm(this);
            frm.Show();
        }

        private void PrizesDeleteBTN_Click(object sender, EventArgs e)
        {

            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpList();
            }
        }
    }

}
