using Library_s_Lending_Administration.Lending;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library_s_Lending_Administration.DVDMovies;

using static Library_s_Lending_Administration.Person;

namespace Library_s_Lending_Administration.Admin
{
    public partial class AdminDVDMoviesForm : Form
    {
        private DVDMovies dvdMovies = new DVDMovies(7);
        private Payments payments = new Payments();
        private List<Payments> _listPayment = new List<Payments>();
        private List<DVDMovies> dvdlist;
        private ContextMenuStrip contextMenuStrip;
        private bool create = true;
        public AdminDVDMoviesForm()
        {

            InitializeComponent();
            InitializeContextMenuStrip();

            _listPayment = payments.readPaymentsCSV(PaymentType.AdultBooks);
            setPayment();
        
            getMax_Days_for_Lending();
            getShowDVDMovies();
        }

        

        private void setPayment()
        {
            try
            {
                foreach (Payments user in _listPayment)
                {
                    txtToLate.Text = user.ToLate.ToString();
                    txtToLateLong.Text = user.ToLateLong.ToString();
                    txtDaysLate.Text = user.ToLate.ToString();
                    txtDaysLong.Text = user.ToLateLong.ToString();

                }
            }
            catch (Exception ex) { }

        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            Guid id;
            PaymentType paymentType;
            Payments newUser = new Payments();
            try
            {
                foreach (Payments user in payments.getListPayment())
                {

                    newUser.PaymentId = user.PaymentId;

                }
                newUser.PaymentType = PaymentType.AdultBooks;
                newUser.ToLate = int.Parse(txtToLate.Text);
                newUser.ToLateLong = int.Parse(txtToLateLong.Text);
                newUser.daysLate = int.Parse(txtDaysLate.Text);
                newUser.daysLong = int.Parse(txtDaysLong.Text);


                payments.UpdatePaymentsInCSV(newUser, payments.getListPayment());
                MessageBox.Show("Payment sucess Update.");
            }
            catch (Exception ex) { }


        }
        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Assuming adultBooks is an instance of the AdultBooks class
            // and Status_for_Lending is an enum property in AdultBooks class
            if (dvdMovies != null)
            {
                // Ensure that SelectedItem is not null and is of type string
                if (comboBoxStatusType.SelectedItem != null && comboBoxStatusType.SelectedItem is string selectedStatus)
                {
                    // Parse the selected string to StartForm.StatusType enum
                    if (Enum.TryParse(selectedStatus, out StartForm.StatusType status))
                    {
                        dvdMovies.Status_for_Lending = status;
                    }
                    else
                    {
                        // Handle parsing failure if needed
                        MessageBox.Show("Invalid status selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void UpdateDVDMovies(DVDMovies userToUpdate)
        {
            DVDMovies existingUser = dvdlist.FirstOrDefault(u => u.Id == userToUpdate.Id);
            if (existingUser != null)
            {
                existingUser.Id = userToUpdate.Id;
                existingUser.Title = userToUpdate.Title;
                existingUser.Description = userToUpdate.Description;
                existingUser.Author = userToUpdate.Author;

                existingUser.RendingDate = userToUpdate.RendingDate;
                existingUser.Status_for_Lending = userToUpdate.Status_for_Lending;
                dvdMovies.UpdateDVDMoviesInCSV(existingUser, dvdlist);

            }
        }
        private void getShowDVDMovies()
        {
            try
            {
                dvdlist = dvdMovies.readDVDMoviesCSV();
                foreach (DVDMovies user in dvdlist)
                {
                    listBoxShowDVDMovies.Items.Add($"Id: {user.Id}, \tTitle: {user.Title}, \tAuthor: {user.Author}, \tStatus: {user.Status_for_Lending}");
                }
            }
            catch (Exception ex) { }
        }
        private void getMax_Days_for_Lending()
        {
            txtMax_Days_for_Lending.Text = dvdMovies.Max_Days_for_Lending.ToString();
        }

        private void InitializeContextMenuStrip()
        {
            contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem updateMenuItem = new ToolStripMenuItem("Update");
            updateMenuItem.Click += UpdateMenuItem_Click;
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            deleteMenuItem.Click += DeleteMenuItem_Click;
            contextMenuStrip.Items.Add(updateMenuItem);
            contextMenuStrip.Items.Add(deleteMenuItem);
            listBoxShowDVDMovies.ContextMenuStrip = contextMenuStrip;
        }

        private DVDMovies FindBookById(string id)
        {
            // Assuming you have a collection of books named 'booksList'
            foreach (DVDMovies dvd in dvdlist)
            {
                if (dvd.Id.ToString() == id)
                {
                    return dvd;
                }
            }
            return null; // Book with the given ID not found
        }
        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxShowDVDMovies.SelectedItem != null)
            {
                string selectedUserString = listBoxShowDVDMovies.SelectedItem.ToString();
                string[] userData = selectedUserString.Split(',');
                btnUpdateDVDMovies.Enabled = true;
                btnUpdateDVDMovies.BackColor = Color.Green;
                create = false;

                if (userData.Length > 40) { }
                Guid id = Guid.Parse(userData[0].Substring(4).Trim());

                DVDMovies user = FindBookById(id.ToString());
                txtDVDMovieId.Text = user.Id.ToString();
                txtTitle.Text = user.Title;
                txtDescription.Text = user.Description;
                txtAuthor.Text = user.Author;
                txtMax_Days_for_Lending.Text = user.Max_Days_for_Lending.ToString();
                txtRendingDate.Text = user.RendingDate.ToString("dd-MM-yyyy");
                comboBoxStatusType.SelectedItem = user.Status_for_Lending.ToString();

            }
            else
            {
                MessageBox.Show("No user selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Handle the Click event of the Delete menu item
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxShowDVDMovies.SelectedItem != null)
            {
                string selectedUserString = listBoxShowDVDMovies.SelectedItem.ToString();
                string[] userData = selectedUserString.Split(',');
                btnDeleteDVDMovies.Enabled = true;
                btnDeleteDVDMovies.BackColor = Color.Green;
                create = false;


                if (userData.Length > 4) { }
                Guid id = Guid.Parse(userData[0].Substring(4).Trim());

                DVDMovies user = FindBookById(id.ToString());
                txtDVDMovieId.Text = user.Id.ToString();
                txtTitle.Text = user.Title;
                txtDescription.Text = user.Description;
                txtAuthor.Text = user.Author;
                txtMax_Days_for_Lending.Text = user.Max_Days_for_Lending.ToString();
                txtRendingDate.Text = user.RendingDate.ToString("dd-MM-yyyy");

                comboBoxStatusType.SelectedItem = user.Status_for_Lending.ToString();

            }
            else
            {
                MessageBox.Show("No user selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreateDVDMovies_Click(object sender, EventArgs e)
        {
            // Generate a new unique GUID for the user
            Guid Id = Guid.NewGuid();

            // Define variables to hold user input
            string Title = txtTitle.Text;
            string Description = txtDescription.Text;
            string Author = txtAuthor.Text;
            int Max_Days_for_Lending;
            DateTime RendingDate;


            // Validate and parse max days for lending
            if (!int.TryParse(txtMax_Days_for_Lending.Text, out Max_Days_for_Lending))
            {
                // Handle invalid input for max days for lending
                MessageBox.Show("Please enter a valid number for max days for lending.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Max_Days_for_Lending = 30; // Set a default value or any other appropriate action

                return;
            }

            // Get the current date formatted as "dd-MM-yyyy"
            RendingDate = DateTime.Now;
            StartForm.StatusType StatusType;
            if (Enum.TryParse<StartForm.StatusType>(comboBoxStatusType.SelectedItem.ToString(), out StatusType))
            {
                // Successfully parsed the selected text to UserType enum
                // You can now use the userType variable
            }
            else
            {
                // Failed to parse the selected text to UserType enum
                // Handle the error or provide feedback to the user
            }


            DVDMovies newdvd = new DVDMovies(int.Parse(txtMax_Days_for_Lending.Text))
            {
                Id = Id,
                Title = Title,
                Description = Description,
                Author = Author,
                Max_Days_for_Lending = Max_Days_for_Lending,
                RendingDate = RendingDate,
                Status_for_Lending = StatusType
            };

            // Add the new book to the list or database
            dvdlist.Add(newdvd);
            dvdMovies.AddDVDMoviesToCSV(newdvd);

            // Clear input fields and update UI elements
            txtDVDMovieId.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtAuthor.Text = "";

            listBoxShowDVDMovies.Items.Clear();
            btnCreateDVDMovies.Enabled = false;
            btnCreateDVDMovies.BackColor = Color.Red;
            create = false;
            getShowDVDMovies();
        }
        private void btnUpdateDVDMovies_Click(object sender, EventArgs e)
        {

            if (listBoxShowDVDMovies.SelectedItem != null)
            {
                // Generate a new unique GUID for the user
                Guid Id = Guid.Parse(txtDVDMovieId.Text); ;

                // Define variables to hold user input
                string Title = txtTitle.Text;
                string Description = txtDescription.Text;
                string Author = txtAuthor.Text;
                int Max_Days_for_Lending;
                DateTime RendingDate;


                // Validate and parse max days for lending
                if (!int.TryParse(txtMax_Days_for_Lending.Text, out Max_Days_for_Lending))
                {
                    // Handle invalid input for max days for lending
                    MessageBox.Show("Please enter a valid number for max days for lending.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Max_Days_for_Lending = 30; // Set a default value or any other appropriate action

                    return;
                }

                // Get the current date formatted as "dd-MM-yyyy"
                RendingDate = DateTime.Now;
                StartForm.StatusType StatusType;
                if (Enum.TryParse<StartForm.StatusType>(comboBoxStatusType.SelectedItem.ToString(), out StatusType))
                {
                    // Successfully parsed the selected text to UserType enum
                    // You can now use the userType variable
                }
                else
                {
                    // Failed to parse the selected text to UserType enum
                    // Handle the error or provide feedback to the user
                }


                DVDMovies newdvd = new DVDMovies(int.Parse(txtMax_Days_for_Lending.Text))
                {
                    Id = Id,
                    Title = Title,
                    Description = Description,
                    Author = Author,
                    Max_Days_for_Lending = Max_Days_for_Lending,
                    RendingDate = RendingDate,
                    Status_for_Lending = StatusType
                };

                dvdlist.Remove(newdvd);
                UpdateDVDMovies(newdvd);

                // Clear input fields and update UI elements
                txtDVDMovieId.Text = "";
                txtTitle.Text = "";
                txtDescription.Text = "";
                txtAuthor.Text = "";
                listBoxShowDVDMovies.Items.Clear();

                btnUpdateDVDMovies.Enabled = false;
                btnUpdateDVDMovies.BackColor = Color.Red;
                create = true;
                getShowDVDMovies();
            }
        }
        private void btnDeleteDVDMovies_Click(object sender, EventArgs e)
        {
            if (listBoxShowDVDMovies.SelectedItem != null)
            {
                Guid userId = Guid.Parse(txtDVDMovieId.Text);
                // Define variables to hold user input
                string Title = txtTitle.Text;
                string Description = txtDescription.Text;
                string Author = txtAuthor.Text;
                int Max_Days_for_Lending;
                DateTime RendingDate;


                // Validate and parse max days for lending
                if (!int.TryParse(txtMax_Days_for_Lending.Text, out Max_Days_for_Lending))
                {
                    // Handle invalid input for max days for lending
                    MessageBox.Show("Please enter a valid number for max days for lending.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Max_Days_for_Lending = 30; // Set a default value or any other appropriate action

                    return;
                }

                // Get the current date formatted as "dd-MM-yyyy"
                RendingDate = DateTime.Now;
                StartForm.StatusType StatusType;
                if (Enum.TryParse<StartForm.StatusType>(comboBoxStatusType.SelectedItem.ToString(), out StatusType))
                {
                    // Successfully parsed the selected text to UserType enum
                    // You can now use the userType variable

                    DVDMovies newdvd = new DVDMovies(int.Parse(txtMax_Days_for_Lending.Text))
                    {
                        Id = userId,
                        Title = Title,
                        Description = Description,
                        Author = Author,
                        Max_Days_for_Lending = Max_Days_for_Lending,
                        RendingDate = RendingDate,
                        Status_for_Lending = StatusType
                    };
                    DVDMovies per = null;
                    foreach (DVDMovies p in dvdlist)
                    {
                        if (newdvd.Id == p.Id)
                        {
                            per = p;
                        }

                    }

                    dvdlist.Remove(per);
                   

                    // Clear input fields and update UI elements
                    txtDVDMovieId.Text = "";
                    txtTitle.Text = "";
                    txtDescription.Text = "";
                    txtAuthor.Text = "";
                    listBoxShowDVDMovies.Items.Clear();
                    getShowDVDMovies();
                }
                else
                {
                    // Failed to parse the selected text to UserType enum
                    // Handle the error or provide feedback to the user
                }


            }

            else
            {
                MessageBox.Show("No user selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnDeleteDVDMovies.Enabled = false;
            btnDeleteDVDMovies.BackColor = Color.Red;
            create = true;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

            if ((txtTitle.Text.Length > 0) && create)
            {
                btnCreateDVDMovies.Enabled = true;
                btnCreateDVDMovies.BackColor = Color.Green;
                txtRendingDate.Text = DateTime.Now.ToString("dd-MM-yyy");

            }
            else
            {
                btnCreateDVDMovies.Enabled = false;
                btnCreateDVDMovies.BackColor = Color.Red;

            }
        }

    }
}
