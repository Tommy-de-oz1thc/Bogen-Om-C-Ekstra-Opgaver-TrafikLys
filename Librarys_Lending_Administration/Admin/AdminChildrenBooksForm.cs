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
using static Library_s_Lending_Administration.Lending.ChildrenBooks;

namespace Library_s_Lending_Administration.Admin
{
    public partial class AdminChildrenBooksForm : Form
    {
        private Payments payment = new Payments();
        private ChildrenBooks childrenBooks = new ChildrenBooks(30);
        private List<ChildrenBooks> booklist;
        private ContextMenuStrip contextMenuStrip;
        private List<Payments> _listPayment = new List<Payments>();
        private Payments payments = new Payments();
        private bool create = true;

        public AdminChildrenBooksForm()
        {
            InitializeComponent();
            InitializeContextMenuStrip();
            
            getMax_Days_for_Lending();
            getShowAdminChildrenBooks();
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
                newUser.PaymentType = PaymentType.ChildrenBooks;
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
            // Assuming ChildrenBooks is an instance of the ChildrenBooks class
            // and Status_for_Lending is an enum property in ChildrenBooks class
            if (childrenBooks != null)
            {
                // Ensure that SelectedItem is not null and is of type string
                if (comboBoxStatusType.SelectedItem != null && comboBoxStatusType.SelectedItem is string selectedStatus)
                {
                    // Parse the selected string to StartForm.StatusType enum
                    if (Enum.TryParse(selectedStatus, out StartForm.StatusType status))
                    {
                        childrenBooks.Status_for_Lending = status;
                    }
                    else
                    {
                        // Handle parsing failure if needed
                        MessageBox.Show("Invalid status selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateChildrenBooks(ChildrenBooks userToUpdate)
        {
            ChildrenBooks existingUser = booklist.FirstOrDefault(u => u.Id == userToUpdate.Id);
            if (existingUser != null)
            {
                existingUser.Id = userToUpdate.Id;
                existingUser.Title = userToUpdate.Title;
                existingUser.Description = userToUpdate.Description;
                existingUser.Author = userToUpdate.Author;

                existingUser.RendingDate = userToUpdate.RendingDate;
                existingUser.Status_for_Lending = userToUpdate.Status_for_Lending;
                childrenBooks.UpdateChildrenBooksInCSV(existingUser, booklist);

            }
        }

        private void getShowAdminChildrenBooks()
        {
            try
            {
                booklist = childrenBooks.readChildrenBooksCSV();
                foreach (ChildrenBooks user in booklist)
                {
                    listBoxShowAdminChildrenBooks.Items.Add($"Id: {user.Id}, \tTitle: {user.Title}, \tAuthor: {user.Author}, \tStatus: {user.Status_for_Lending}");
                }
            }
            catch (Exception ex) { }
        }


        //int ToLate, int ToLateLong, int dayLast, int dayLong, PaymentType paymentType)
        private void getMax_Days_for_Lending()
        {
            txtMax_Days_for_Lending.Text = childrenBooks.Max_Days_for_Lending.ToString();
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
            listBoxShowAdminChildrenBooks.ContextMenuStrip = contextMenuStrip;
        }

        private ChildrenBooks FindBookById(string id)
        {
            // Assuming you have a collection of books named 'booksList'
            foreach (ChildrenBooks book in booklist)
            {
                if (book.Id.ToString() == id)
                {
                    return book;
                }
            }
            return null; // Book with the given ID not found
        }

        // Handle the Click event of the Update menu item
        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxShowAdminChildrenBooks.SelectedItem != null)
            {
                string selectedUserString = listBoxShowAdminChildrenBooks.SelectedItem.ToString();
                string[] userData = selectedUserString.Split(',');
                btnUpdateChildrenBooks.Enabled = true;
                btnUpdateChildrenBooks.BackColor = Color.Green;
                create = false;

                if (userData.Length > 40) { }
                Guid id = Guid.Parse(userData[0].Substring(4).Trim());

                ChildrenBooks user = FindBookById(id.ToString());
                txtAdultBookId.Text = user.Id.ToString();
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
            if (listBoxShowAdminChildrenBooks.SelectedItem != null)
            {
                string selectedUserString = listBoxShowAdminChildrenBooks.SelectedItem.ToString();
                string[] userData = selectedUserString.Split(',');
                btnDeleteChildrenBooks.Enabled = true;
                btnDeleteChildrenBooks.BackColor = Color.Green;
                create = false;


                if (userData.Length > 4) { }
                Guid id = Guid.Parse(userData[0].Substring(4).Trim());

                ChildrenBooks user = FindBookById(id.ToString());
                txtAdultBookId.Text = user.Id.ToString();
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

        private void btnCreateChildrenBooks_Click(object sender, EventArgs e)
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


            ChildrenBooks newBook = new ChildrenBooks(int.Parse(txtMax_Days_for_Lending.Text))
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
            booklist.Add(newBook);
            childrenBooks.AddChildrenBooksToCSV(newBook);

            // Clear input fields and update UI elements
            txtAdultBookId.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtAuthor.Text = "";

            listBoxShowAdminChildrenBooks.Items.Clear();
            btnCreateChildrenBooks.Enabled = false;
            btnCreateChildrenBooks.BackColor = Color.Red;
            create = false;
            getShowAdminChildrenBooks();
        }

        private void btnUpdateChildrenBooks_Click(object sender, EventArgs e)
        {

            if (listBoxShowAdminChildrenBooks.SelectedItem != null)
            {
                // Generate a new unique GUID for the user
                Guid Id = Guid.Parse(txtAdultBookId.Text); ;

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


                ChildrenBooks newBook = new ChildrenBooks(int.Parse(txtMax_Days_for_Lending.Text))
                {
                    Id = Id,
                    Title = Title,
                    Description = Description,
                    Author = Author,
                    Max_Days_for_Lending = Max_Days_for_Lending,
                    RendingDate = RendingDate,
                    Status_for_Lending = StatusType
                };

                booklist.Remove(newBook);
                UpdateChildrenBooks(newBook);

                // Clear input fields and update UI elements
                txtAdultBookId.Text = "";
                txtTitle.Text = "";
                txtDescription.Text = "";
                txtAuthor.Text = "";
                listBoxShowAdminChildrenBooks.Items.Clear();

                btnUpdateChildrenBooks.Enabled = false;
                btnUpdateChildrenBooks.BackColor = Color.Red;
                create = true;
                getShowAdminChildrenBooks();
            }
        }
        private void btnDeleteChildrenBooks_Click(object sender, EventArgs e)
        {
            if (listBoxShowAdminChildrenBooks.SelectedItem != null)
            {
                Guid userId = Guid.Parse(txtAdultBookId.Text);
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

                    ChildrenBooks newBook = new ChildrenBooks(int.Parse(txtMax_Days_for_Lending.Text))
                    {
                        Id = userId,
                        Title = Title,
                        Description = Description,
                        Author = Author,
                        Max_Days_for_Lending = Max_Days_for_Lending,
                        RendingDate = RendingDate,
                        Status_for_Lending = StatusType
                    };
                    ChildrenBooks per = null;
                    foreach (ChildrenBooks p in booklist)
                    {
                        if (newBook.Id == p.Id)
                        {
                            per = p;
                        }

                    }

                    booklist.Remove(per);
                   

                    // Clear input fields and update UI elements
                    txtAdultBookId.Text = "";
                    txtTitle.Text = "";
                    txtDescription.Text = "";
                    txtAuthor.Text = "";
                    listBoxShowAdminChildrenBooks.Items.Clear();
                    getShowAdminChildrenBooks();
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
            btnDeleteChildrenBooks.Enabled = false;
            btnDeleteChildrenBooks.BackColor = Color.Red;
            create = true;
        }





        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

            if ((txtTitle.Text.Length > 0) && create)
            {
                btnCreateChildrenBooks.Enabled = true;
                btnCreateChildrenBooks.BackColor = Color.Green;
                txtRendingDate.Text = DateTime.Now.ToString("dd-MM-yyy");

            }
            else
            {
                btnCreateChildrenBooks.Enabled = false;
                btnCreateChildrenBooks.BackColor = Color.Red;

            }
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
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
    }
}
