using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Tracker_Library;
using Tournament_Tracker_Library.Models;

namespace Tournament_Tracker
{
    public partial class DashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

        public DashboardForm()
        {
            InitializeComponent();
            WireUpList();
        }
        
        private void WireUpList()
        {
            LoadExistingTournamentcomboBox.DataSource = tournaments;
            LoadExistingTournamentcomboBox.DisplayMember = "TournamentName";
        }

        private void CreateTournamentBTN_Click(object sender, EventArgs e)
        {
            TournamentCreateForm frm = new TournamentCreateForm();
            frm.Show();
        }

        private void LoadTournamentBTN_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)LoadExistingTournamentcomboBox.SelectedItem;
            TournamentForm frm = new TournamentForm(tm);
            if (tm != null)
            {
                frm.Show();
                this.Hide();
            }
          
        }
    }
}
