using Library_s_Lending_Administration.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library_s_Lending_Administration.StartForm;

namespace Library_s_Lending_Administration.User
{
    
    public partial class UserForm : Form
    {
        private Person _user { set; get; }
        public UserForm(Person user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnUserData_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            UserDataForm userDataForm = new UserDataForm(_user);
            userDataForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnShowLending_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            ShowForm showForm = new ShowForm(_user);
            showForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnForum_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            ForumForm forumForm = new ForumForm(_user);
            forumForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnAdultBooks_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            UserAdultBooksForm adultBooksForm = new UserAdultBooksForm(_user);
            adultBooksForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnChildrenBooks_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            UserChildrenBooksForm childrenBooksForm = new UserChildrenBooksForm(_user);
            childrenBooksForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnCartoons_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            UserCartoonsForm cartoonsForm = new UserCartoonsForm(_user);
            cartoonsForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnCDs_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            UserCDsForm cdsForm = new UserCDsForm(_user);
            cdsForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnDVDMovies_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            UserDVDMoviesForm dvdMoviesForm = new UserDVDMoviesForm(_user);
            dvdMoviesForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            UserRecordsForm recordsForm = new UserRecordsForm(_user);
            recordsForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }
    }
}
