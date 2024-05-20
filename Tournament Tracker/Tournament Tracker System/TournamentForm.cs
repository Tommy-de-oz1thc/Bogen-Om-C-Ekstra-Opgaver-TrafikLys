using Tournament_Tracker_Library;
using Tournament_Tracker_Library.Models;

namespace Tournament_Tracker
{
    public partial class TournamentForm : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();


        public TournamentForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            labelTournament.Text = tournament.TournamentName;

        }
        private void LoadComboBox()
        {
            RoundComboBox.DataSource = null;

            // Extract unique rounds from the tournament
            

            RoundComboBox.DataSource = rounds;
        }

        private void WireUpList()
        {


            matchupListBox.DataSource = null;
            matchupListBox.DataSource = GlobalConfig.matches;
            matchupListBox.DisplayMember = "DisplayName";
        }
        private void LoadRounds()
        {

            rounds.Add(1);
            int currRound = 1;

            
                foreach (List<MatchupModel> matchups in tournament.Rounds)
                {
                    if (matchups.Count != 0)
                    {
                        if (matchups.First().MatchupRound > currRound)
                        {
                            currRound = matchups.First().MatchupRound;
                            rounds.Add(currRound);
                        }
                    }
                }
            
            LoadComboBox();
        }

        private void RoundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchups()
        {
            if (RoundComboBox.SelectedIndex != -1)
            {
                GlobalConfig.matches.Clear();
                int round = (int)RoundComboBox.SelectedItem;


                foreach (List<MatchupModel> matchups in tournament.Rounds)
                {
                    // Use FindAll to get all matchups in the current list that match the selected round
                    var roundMatchups = matchups.FindAll(m => m.MatchupRound == round);

                    if (roundMatchups.Count > 0)
                    {
                        foreach (MatchupModel rm in roundMatchups)
                        {
                            if (rm.WinnerId == 0 || !checkBoxUnPlayed.Checked)
                            {
                                GlobalConfig.matches.Add(rm);
                            }
                        }
                    }
                }

                WireUpList();
            }
        }
        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

            Team1LB.Text = "Not Yet Set";
            Team2LB.Text = "Not Yet Set";
            ScoreTeam1TB.Text = "";
            ScoreTeam2TB.Text = "";
            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompetingId != null)
                        {

                            TeamModel team = GlobalConfig.Connection.GetTeam(m.Entries[0].TeamCompetingId);
                            if (team != null)
                            {
                                Team1LB.Text = team.TeamName;
                                ScoreTeam1TB.Text = m.Entries[0].Score.ToString();

                                Team2LB.Text = "<Bye>";
                            }
                        }
                        else
                        {
                            Team1LB.Text = "Not Yet Set";

                        }
                    }
                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompetingId != null)
                        {
                            TeamModel team = GlobalConfig.Connection.GetTeam(m.Entries[1].TeamCompetingId);
                            if (team != null)
                            {
                                Team2LB.Text = team.TeamName;
                                ScoreTeam2TB.Text = m.Entries[1].Score.ToString();
                            }
                        }
                        else
                        {
                            Team2LB.Text = "Not Yet Set";

                        }
                    }

                }
            }
            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (GlobalConfig.matches.Count > 0);

            Team1LB.Visible = isVisible;
            Team2LB.Visible = isVisible;
            ScoreTeam1LB.Visible = isVisible;
            ScoreTeam2LB.Visible = isVisible;
            ScoreTeam1TB.Visible = isVisible;
            ScoreTeam2TB.Visible = isVisible;
            VSLB.Visible = isVisible;
            ScoreBTN.Visible = isVisible;
            SampleTeam1LB.Visible = isVisible;
            SampleTeam2LB.Visible = isVisible;
        }
        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }

        private void checkBoxUnPlayed_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void ScoreBTN_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            foreach (MatchupEntryModel me in m.Entries)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompetingId != null)
                        {

                            TeamModel team = GlobalConfig.Connection.GetTeam(m.Entries[0].TeamCompetingId);
                            if (team != null)
                            {
                               
                               
                                bool scoreValid = double.TryParse(ScoreTeam1TB.Text, out teamOneScore);
                                if (scoreValid)
                                {
                                m.Entries[0].Score = teamOneScore;
                                }
                                else
                                {
                                    MessageBox.Show($"Please Enter a valid score for {team.TeamName}.");
                                    return;
                                }
                               
                            }
                        }
                        else
                        {
                            Team1LB.Text = "Not Yet Set";

                        }
                    }
                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompetingId != null)
                        {
                            TeamModel team = GlobalConfig.Connection.GetTeam(m.Entries[1].TeamCompetingId);
                            if (team != null)
                            {
                               

                                
                                bool scoreValid = double.TryParse(ScoreTeam2TB.Text, out teamTwoScore);
                                if (scoreValid)
                                {
                                    m.Entries[1].Score = teamTwoScore;
                                }
                                else
                                {
                                    MessageBox.Show($"Please Enter a valid score for {team.TeamName}");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            Team2LB.Text = "Not Yet Set";

                        }
                    }

                }
                
            }

            if (teamOneScore > teamTwoScore)
            {
                // Team one wins
                m.WinnerId = m.Entries[0].TeamCompetingId;
            }
            else if ( (teamTwoScore > teamOneScore))
            {
                m.WinnerId = m.Entries[1].TeamCompetingId;
            }
            else
            {
                MessageBox.Show("i do not handle tie games.");
            }
            LoadMatchups(); 

            GlobalConfig.Connection.UpdateMatchup(m);
            GlobalConfig.Connection.UpdateMatchupEntries(m);
        }
    }
}
