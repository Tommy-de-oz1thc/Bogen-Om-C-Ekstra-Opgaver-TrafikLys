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

namespace Library_s_Lending_Administration.Admin
{
    public partial class AdminForm : Form
    {
        private Person _user { set; get; }
        public AdminForm(Person user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            AdminUserForm adminUserForm = new AdminUserForm();
            adminUserForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();

        }

        private void btnAdultBooks_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            AdminAdultBooksForm adminAdultBooksForm = new AdminAdultBooksForm();
            adminAdultBooksForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();

        }

        private void btnChildrenBooks_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            AdminChildrenBooksForm adminChildrenBooksForm = new AdminChildrenBooksForm();
            adminChildrenBooksForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnCartoons_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            AdminCartoonsForm adminCartoonsForm = new AdminCartoonsForm();
            adminCartoonsForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnCDs_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            AdminCDsForm adminCDsForm = new AdminCDsForm();
            adminCDsForm.ShowDialog();

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

        private void btnDVDMovies_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            AdminDVDMoviesForm dvdMoviesForm = new AdminDVDMoviesForm();
            dvdMoviesForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            AdminRecordsForm recordsForm = new AdminRecordsForm();
            recordsForm.ShowDialog();

            // Show the login form again after the admin or user form is closed
            this.Show();
        }
    }
}
