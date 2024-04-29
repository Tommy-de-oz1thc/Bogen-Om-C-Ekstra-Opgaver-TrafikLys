using System;
using System.Collections.Generic;

using System.Linq;
using System.Windows.Forms;
using Library_s_Lending_Administration.Admin;
using Library_s_Lending_Administration.User;


using Library_s_Lending_Administration.Lending;
using Library_s_Lending_Administration.Data;



namespace Library_s_Lending_Administration
{
    // Define the UserType enum outside of the Start class

    public partial class StartForm : Form
    {
        public enum UserType
        {
            Admin,
            User
        }
        public enum StatusType
        {
            Home,
            Out_Of_House
        }

        public static Person person = new Person();
        public static List<Person> personList = new List<Person>(); 
        public static AdultBooks adultBooks = new AdultBooks();
        public static ChildrenBooks childrenBooks = new ChildrenBooks();
        public static Cartoons cartoons = new Cartoons();
        public static CDs cds = new CDs();
        private DVDMovies dvdMovies = new DVDMovies();
        public static  Forum forum = new Forum();
        public static Lendings lendings = new Lendings();
        public static Records records = new Records();
        public static string filePathPerson = "Data/Person.csv";
        public static string filePathAdultBooks = "Data/AdultBooks.csv";
        public static string filePathChildrenBooks = "Data/ChildrenBooks.csv";
        public static string filePathCartoons = "Data/Cartoons.csv";
        public static string filePathCDs = "Data/CDs.csv";
        public static string filePathDVDMovies = "Data/DVDMovies.csv";
        public static string filePathRecords = "Data/Records.csv";
        public static string filePathForum = "Data/Forum.csv";
        public static string filePathPayments = "Data/Payments.csv";
        public static string filePathLendings = "Data/Lendings.csv";    
        public static Payments payments = new Payments();

        public StartForm()
        {
            InitializeComponent();        
            LoadUsersFromCSV();
        }

        private void LoadUsersFromCSV()
        {

            SetUpData SetUpAllData = new SetUpData();
            LoadData LoadAllData = new LoadData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check the credentials against the users loaded from CSV
            Person user = CheckCredentials(username, password);

            if (user != null)
            {
                // Hide the login form
                this.Hide();

                // Show the appropriate form based on the user type
                if (user.Type_Of_User == UserType.Admin)
                {
                    AdminForm adminForm = new AdminForm(user);
                    adminForm.ShowDialog();
                }
                else if (user.Type_Of_User == UserType.User)
                {
                    UserForm userForm = new UserForm(user);
                    userForm.ShowDialog();
                }

                // Show the login form again after the admin or user form is closed
                this.Show();
            }
            else
            {
                labelAnswer.Text = "Wrong Username or Password";
            }
        }

        private Person CheckCredentials(string username, string password)
        {
            if (personList == null)
            {
                MessageBox.Show("Failed to load users from CSV.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Check if there's a user with the provided username and password
            return personList.FirstOrDefault(u => u.Username == username && u.Password == password);
        }    
    }
}

        
   
   