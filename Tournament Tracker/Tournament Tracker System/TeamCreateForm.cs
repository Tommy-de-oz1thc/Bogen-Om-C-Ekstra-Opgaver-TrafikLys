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

namespace Tournament_Tracker
{
    public partial class TeamCreateForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
       
        private ITeamRequester callingForm;

        public TeamCreateForm(ITeamRequester callingForm)
        {
            InitializeComponent();
            //CreateSampleData();
          
            this.callingForm = callingForm;
            WireUpList();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        }

        private void WireUpList()
        {
            SelectTeamMembercomboBox.DataSource = null;
            SelectTeamMembercomboBox.DataSource = availableTeamMembers;
            SelectTeamMembercomboBox.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void CreateMemberBTN_Click(object sender, EventArgs e)
        {
            int newId = availableTeamMembers.Concat(selectedTeamMembers).Select(p => p.Id).DefaultIfEmpty(0).Max() + 1;

            if (ValidateForm_Member())
            {
                PersonModel model = new PersonModel(
                    FirstNameTB.Text,
                    LastNameTB.Text,
                    EmailTB.Text,
                    CellphoneTB.Text);
                model.Id = newId;

                selectedTeamMembers.Add(model);
                GlobalConfig.Connection.CreatePerson(model);
                WireUpList();

                FirstNameTB.Text = "";
                LastNameTB.Text = "";
                EmailTB.Text = "";
                CellphoneTB.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information");
            }
        }


        private bool ValidateForm_Member()
        {
            bool output = true;



            if (FirstNameTB.Text == "")
            {
                output = false;
            }

            if (LastNameTB.Text == "")
            {
                output = false;
            }


            return output;
        }

        private void CreateTeamBTN_Click(object sender, EventArgs e)
        {
            
            if (TeamNameTB.Text != "")
            {
                // Create a new TeamModel
                TeamModel model = new TeamModel
                {
                    TeamName = TeamNameTB.Text,
                    TeamMembers = new List<PersonModel>() // Initialize the members list
                };

                // Add selected members to the team (assuming you have a way to select members in your UI)
                foreach (var selectedMember in selectedTeamMembers) // SelectedMembers is a list of PersonModel
                {
                    model.TeamMembers.Add(selectedMember);
                }
                
                // Save the team to the database or CSV
                GlobalConfig.Connection.CreateTeam(model);

                // Clear the input fields
                callingForm.TeamComplete(model);
                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information");
            }
        }


        private void AddMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectTeamMembercomboBox.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpList();
            }
        }

        private void RemoveBNT_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpList();
            }

        }
    }
}
