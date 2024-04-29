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
using static Library_s_Lending_Administration.Lending.Records;

namespace Library_s_Lending_Administration.Admin
{
    public partial class AdminRecordsForm : Form
    {
        private Records records = new Records(7);
        private Payments payments = new Payments();
        private List<Payments> _listPayment = new List<Payments>();
        private List<Records> recordlist;
        private ContextMenuStrip contextMenuStrip;
        private bool create = true;
        public AdminRecordsForm()
        {
            InitializeComponent();
            InitializeContextMenuStrip();

            _listPayment = payments.readPaymentsCSV(PaymentType.AdultBooks);
            setPayment();
          
            getMax_Days_for_Lending();
            getShowAdminRecords();
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
            if (records != null)
            {
                // Ensure that SelectedItem is not null and is of type string
                if (comboBoxStatusType.SelectedItem != null && comboBoxStatusType.SelectedItem is string selectedStatus)
                {
                    // Parse the selected string to StartForm.StatusType enum
                    if (Enum.TryParse(selectedStatus, out StartForm.StatusType status))
                    {
                        records.Status_for_Lending = status;
                    }
                    else
                    {
                        // Handle parsing failure if needed
                        MessageBox.Show("Invalid status selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateRecords(Records userToUpdate)
        {
            Records existingUser = recordlist.FirstOrDefault(u => u.Id == userToUpdate.Id);
            if (existingUser != null)
            {
                existingUser.Id = userToUpdate.Id;
                existingUser.Title = userToUpdate.Title;
                existingUser.Description = userToUpdate.Description;
                existingUser.Author = userToUpdate.Author;

                existingUser.RendingDate = userToUpdate.RendingDate;
                existingUser.Status_for_Lending = userToUpdate.Status_for_Lending;
                records.UpdateRecordsInCSV(existingUser, recordlist);

            }
        }
        private void getShowAdminRecords()
        {
            try
            {
                recordlist = records.readRecordsCSV();
                foreach (Records user in recordlist)
                {
                    listBoxShowRecords.Items.Add($"Id: {user.Id}, \tTitle: {user.Title}, \tAuthor: {user.Author}, \tStatus: {user.Status_for_Lending}");
                }
            }
            catch (Exception ex) { }
        }


        //int ToLate, int ToLateLong, int dayLast, int dayLong, PaymentType paymentType)
        private void getMax_Days_for_Lending()
        {
            txtMax_Days_for_Lending.Text = records.Max_Days_for_Lending.ToString();
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
            listBoxShowRecords.ContextMenuStrip = contextMenuStrip;
        }
        private Records FindBookById(string id)
        {
            // Assuming you have a collection of books named 'booksList'
            foreach (Records book in recordlist)
            {
                if (book.Id.ToString() == id)
                {
                    return book;
                }
            }
            return null; // Book with the given ID not found
        }
        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxShowRecords.SelectedItem != null)
            {
                string selectedUserString = listBoxShowRecords.SelectedItem.ToString();
                string[] userData = selectedUserString.Split(',');
                btnUpdateRecords.Enabled = true;
                btnUpdateRecords.BackColor = Color.Green;
                create = false;

                if (userData.Length > 40) { }
                Guid id = Guid.Parse(userData[0].Substring(4).Trim());

                Records user = FindBookById(id.ToString());
                txtAdminRecordId.Text = user.Id.ToString();
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
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxShowRecords.SelectedItem != null)
            {
                string selectedUserString = listBoxShowRecords.SelectedItem.ToString();
                string[] userData = selectedUserString.Split(',');
                btnDeleteRecords.Enabled = true;
                btnDeleteRecords.BackColor = Color.Green;
                create = false;


                if (userData.Length > 4) { }
                Guid id = Guid.Parse(userData[0].Substring(4).Trim());

                Records user= FindBookById(id.ToString());
                txtAdminRecordId.Text = user.Id.ToString();
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
        private void btnCreateRecords_Click(object sender, EventArgs e)
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


            Records newBook = new Records(int.Parse(txtMax_Days_for_Lending.Text))
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
            recordlist.Add(newBook);
            records.AddRecordsToCSV(newBook);

            // Clear input fields and update UI elements
            txtAdminRecordId.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtAuthor.Text = "";

            listBoxShowRecords.Items.Clear();
            btnCreateRecords.Enabled = false;
            btnCreateRecords.BackColor = Color.Red;
            create = false;
            getShowAdminRecords();
        }
        private void btnUpdateRecords_Click(object sender, EventArgs e)
        {

            if (listBoxShowRecords.SelectedItem != null)
            {
                // Generate a new unique GUID for the user
                Guid Id = Guid.Parse(txtAdminRecordId.Text); ;

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


                Records newBook = new Records(int.Parse(txtMax_Days_for_Lending.Text))
                {
                    Id = Id,
                    Title = Title,
                    Description = Description,
                    Author = Author,
                    Max_Days_for_Lending = Max_Days_for_Lending,
                    RendingDate = RendingDate,
                    Status_for_Lending = StatusType
                };

                recordlist.Remove(newBook);
                UpdateRecords(newBook);

                // Clear input fields and update UI elements
                txtAdminRecordId.Text = "";
                txtTitle.Text = "";
                txtDescription.Text = "";
                txtAuthor.Text = "";
                listBoxShowRecords.Items.Clear();

                btnUpdateRecords.Enabled = false;
                btnUpdateRecords.BackColor = Color.Red;
                create = true;
                getShowAdminRecords();
            }
        }
        private void btnDeleteRecords_Click(object sender, EventArgs e)
        {
            if (listBoxShowRecords.SelectedItem != null)
            {
                Guid userId = Guid.Parse(txtAdminRecordId.Text);
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

                    Records newrec = new Records(int.Parse(txtMax_Days_for_Lending.Text))
                    {
                        Id = userId,
                        Title = Title,
                        Description = Description,
                        Author = Author,
                        Max_Days_for_Lending = Max_Days_for_Lending,
                        RendingDate = RendingDate,
                        Status_for_Lending = StatusType
                    };
                    Records per = null;
                    foreach (Records p in recordlist)
                    {
                        if (newrec.Id == p.Id)
                        {
                            per = p;
                        }

                    }

                    recordlist.Remove(per);
                  
                    // Clear input fields and update UI elements
                    txtAdminRecordId.Text = "";
                    txtTitle.Text = "";
                    txtDescription.Text = "";
                    txtAuthor.Text = "";
                    listBoxShowRecords.Items.Clear();
                    getShowAdminRecords();
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
            btnDeleteRecords.Enabled = false;
            btnDeleteRecords.BackColor = Color.Red;
            create = true;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

            if ((txtTitle.Text.Length > 0) && create)
            {
                btnCreateRecords.Enabled = true;
                btnCreateRecords.BackColor = Color.Green;
                txtRendingDate.Text = DateTime.Now.ToString("dd-MM-yyy");

            }
            else
            {
                btnCreateRecords.Enabled = false;
                btnCreateRecords.BackColor = Color.Red;

            }
        }

    }
}
