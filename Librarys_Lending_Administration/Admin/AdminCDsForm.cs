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
using static Library_s_Lending_Administration.CDs;


namespace Library_s_Lending_Administration.Admin
{
    public partial class AdminCDsForm : Form
    {
        private CDs cds = new CDs(7);
        private Payments payments = new Payments();
        private List<Payments> _listPayment = new List<Payments>();
        private List<CDs> cdlist;
        private ContextMenuStrip contextMenuStrip;
        private bool create = true;
        public AdminCDsForm()
        {

            InitializeComponent();
            InitializeContextMenuStrip();

            _listPayment = payments.readPaymentsCSV(PaymentType.CDs);
            setPayment();
          
            getMax_Days_for_Lending();
            getShowAdminCDs();
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
                newUser.PaymentType = PaymentType.CDs;
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
            if (cds != null)
            {
                // Ensure that SelectedItem is not null and is of type string
                if (comboBoxStatusType.SelectedItem != null && comboBoxStatusType.SelectedItem is string selectedStatus)
                {
                    // Parse the selected string to StartForm.StatusType enum
                    if (Enum.TryParse(selectedStatus, out StartForm.StatusType status))
                    {
                        cds.Status_for_Lending = status;
                    }
                    else
                    {
                        // Handle parsing failure if needed
                        MessageBox.Show("Invalid status selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void UpdateAdultBooks(CDs userToUpdate)
        {
            CDs existingUser = cdlist.FirstOrDefault(u => u.Id == userToUpdate.Id);
            if (existingUser != null)
            {
                existingUser.Id = userToUpdate.Id;
                existingUser.Title = userToUpdate.Title;
                existingUser.Description = userToUpdate.Description;
                existingUser.Author = userToUpdate.Author;

                existingUser.RendingDate = userToUpdate.RendingDate;
                existingUser.Status_for_Lending = userToUpdate.Status_for_Lending;
                cds.UpdateCDsInCSV(existingUser, cdlist);

            }
        }

        private void getShowAdminCDs()
        {
            try
            {
                cdlist = cds.readCDsCSV();
                foreach (CDs user in cdlist)
                {
                    listBoxShowAdminCDs.Items.Add($"Id: {user.Id}, \tTitle: {user.Title}, \tAuthor: {user.Author}, \tStatus: {user.Status_for_Lending}");
                }
            }
            catch (Exception ex) { }
        }

        //int ToLate, int ToLateLong, int dayLast, int dayLong, PaymentType paymentType)
        private void getMax_Days_for_Lending()
        {
            txtMax_Days_for_Lending.Text = cds.Max_Days_for_Lending.ToString();
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
            listBoxShowAdminCDs.ContextMenuStrip = contextMenuStrip;
        }
        private CDs FindCDById(string id)
        {
            // Assuming you have a collection of books named 'booksList'
            foreach (CDs cd in cdlist)
            {
                if (cd.Id.ToString() == id)
                {
                    return cd;
                }
            }
            return null; // cd with the given ID not found
        }
        // Handle the Click event of the Update menu item
        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxShowAdminCDs.SelectedItem != null)
            {
                string selectedUserString = listBoxShowAdminCDs.SelectedItem.ToString();
                string[] userData = selectedUserString.Split(',');
                btnUpdateCDs.Enabled = true;
                btnUpdateCDs.BackColor = Color.Green;
                create = false;

                if (userData.Length > 40) { }
                Guid id = Guid.Parse(userData[0].Substring(4).Trim());

                CDs user = FindCDById(id.ToString());
                txtCDId.Text = user.Id.ToString();
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
            if (listBoxShowAdminCDs.SelectedItem != null)
            {
                string selectedUserString = listBoxShowAdminCDs.SelectedItem.ToString();
                string[] userData = selectedUserString.Split(',');
                btnDeleteCDs.Enabled = true;
                btnDeleteCDs.BackColor = Color.Green;
                create = false;


                if (userData.Length > 4) { }
                Guid id = Guid.Parse(userData[0].Substring(4).Trim());

                CDs user = FindCDById(id.ToString());
                txtCDId.Text = user.Id.ToString();
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

        private void btnCreateCDs_Click(object sender, EventArgs e)
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
            CDs newBook = new CDs(int.Parse(txtMax_Days_for_Lending.Text))
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
            cdlist.Add(newBook);
            cds.AddCDsToCSV(newBook);

            // Clear input fields and update UI elements
            txtCDId.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtAuthor.Text = "";

            listBoxShowAdminCDs.Items.Clear();
            btnCreateCDs.Enabled = false;
            btnCreateCDs.BackColor = Color.Red;
            create = false;
            getShowAdminCDs();
        }
        private void btnUpdateCDs_Click(object sender, EventArgs e)
        {

            if (listBoxShowAdminCDs.SelectedItem != null)
            {
                // Generate a new unique GUID for the user
                Guid Id = Guid.Parse(txtCDId.Text); ;

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


                CDs newBook = new CDs(int.Parse(txtMax_Days_for_Lending.Text))
                {
                    Id = Id,
                    Title = Title,
                    Description = Description,
                    Author = Author,
                    Max_Days_for_Lending = Max_Days_for_Lending,
                    RendingDate = RendingDate,
                    Status_for_Lending = StatusType
                };

                cdlist.Remove(newBook);
                UpdateAdultBooks(newBook);

                // Clear input fields and update UI elements
                txtCDId.Text = "";
                txtTitle.Text = "";
                txtDescription.Text = "";
                txtAuthor.Text = "";
                listBoxShowAdminCDs.Items.Clear();

                btnUpdateCDs.Enabled = false;
                btnUpdateCDs.BackColor = Color.Red;
                create = true;
                getShowAdminCDs();
            }
        }
        private void btnDeleteCDs_Click(object sender, EventArgs e)
        {
            if (listBoxShowAdminCDs.SelectedItem != null)
            {
                Guid userId = Guid.Parse(txtCDId.Text);
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

                    CDs newBook = new CDs(int.Parse(txtMax_Days_for_Lending.Text))
                    {
                        Id = userId,
                        Title = Title,
                        Description = Description,
                        Author = Author,
                        Max_Days_for_Lending = Max_Days_for_Lending,
                        RendingDate = RendingDate,
                        Status_for_Lending = StatusType
                    };
                    CDs per = null;
                    foreach (CDs p in cdlist)
                    {
                        if (newBook.Id == p.Id)
                        {
                            per = p;
                        }

                    }

                    cdlist.Remove(per);
                

                    // Clear input fields and update UI elements
                    txtCDId.Text = "";
                    txtTitle.Text = "";
                    txtDescription.Text = "";
                    txtAuthor.Text = "";
                    listBoxShowAdminCDs.Items.Clear();
                    getShowAdminCDs();
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
            btnDeleteCDs.Enabled = false;
            btnDeleteCDs.BackColor = Color.Red;
            create = true;
        }


        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

            if ((txtTitle.Text.Length > 0) && create)
            {
                btnCreateCDs.Enabled = true;
                btnCreateCDs.BackColor = Color.Green;
                txtRendingDate.Text = DateTime.Now.ToString("dd-MM-yyy");

            }
            else
            {
                btnCreateCDs.Enabled = false;
                btnCreateCDs.BackColor = Color.Red;

            }
        }
    }
}
