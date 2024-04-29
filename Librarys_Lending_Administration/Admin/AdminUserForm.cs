using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_s_Lending_Administration;
using static Library_s_Lending_Administration.Person;

namespace Library_s_Lending_Administration.Admin
{
    public partial class AdminUserForm : Form
    {
        
        private ContextMenuStrip contextMenuStrip;
        private Person person = new Person();
        private bool create = true;
        private List<Person> userList;

        public AdminUserForm()
        {
            InitializeComponent();
            InitializeContextMenuStrip();
            
            getShowAdminUser();
            txtUsername.Focus();
        }

        private void getShowAdminUser()
        {
            foreach (Person user in StartForm.personList)
            {
                 listBoxShowAdminUser.Items.Add($"Id: {user.UserId}, \tName: {user.Username}, \tPassword: {user.Password}, \tType: {user.Type_Of_User}");
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            // Generate a new unique GUID for the user
            Guid userId = Guid.NewGuid();

            // Get the username, password, and type from the input fields or controls
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            StartForm.UserType userType;
            if (Enum.TryParse<StartForm.UserType>(comboBoxUserType.SelectedItem.ToString(), out userType))
            {
                // Successfully parsed the selected text to UserType enum
                // You can now use the userType variable
            }
            else
            {
                // Failed to parse the selected text to UserType enum
                // Handle the error or provide feedback to the user
            }

            // Create a new Person object with the provided properties
            Person newUser = new Person
            {
                UserId = userId,
                Username = username,
                Password = password,
                Type_Of_User = userType
            };

            // Add the new user to the list or database
            StartForm.personList.Add(newUser);
            person.AddUserToCSV(newUser);
            txtUsername.Text = "";
            txtPassword.Text = "";
            listBoxShowAdminUser.Items.Clear();
            btnCreateUser.Enabled = false;
            btnCreateUser.BackColor = Color.Red;
            create = false;
            getShowAdminUser();
        }

        // Initialize the ContextMenuStrip
        private void InitializeContextMenuStrip()
        {
            contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem updateMenuItem = new ToolStripMenuItem("Update");
            updateMenuItem.Click += UpdateMenuItem_Click;
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            deleteMenuItem.Click += DeleteMenuItem_Click;
            contextMenuStrip.Items.Add(updateMenuItem);
            contextMenuStrip.Items.Add(deleteMenuItem);
            listBoxShowAdminUser.ContextMenuStrip = contextMenuStrip;
        }

        // Handle the Click event of the Update menu item
        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxShowAdminUser.SelectedItem != null)
            {
                string selectedUserString = listBoxShowAdminUser.SelectedItem.ToString();
                string[] userData = selectedUserString.Split(',');

                if (userData.Length >= 4)
                {
                    string userid = userData[0].Substring(4).Trim();
                    string username = userData[1].Substring(8).Trim();
                    string password = userData[2].Substring(11).Trim();
                    string userTypeString = userData[3].Substring(8).Trim();
                    btnUpdateUser.Enabled = true;
                    btnUpdateUser.BackColor = Color.Green;
                    create = false;
                    if (Enum.TryParse(userTypeString, out StartForm.UserType userType))
                    {
                        txtUserId.Text = userid;
                        txtUsername.Text = username;
                        txtPassword.Text = password;
                        comboBoxUserType.SelectedItem = userType.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user type: " + userTypeString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user data format: " + selectedUserString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No user selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handle the Click event of the Delete menu item
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxShowAdminUser.SelectedItem != null)
            {
                string selectedUserString = listBoxShowAdminUser.SelectedItem.ToString();
                string[] userData = selectedUserString.Split(',');

                if (userData.Length >= 4)
                {
                    string userid = userData[0].Substring(4).Trim();
                    string username = userData[1].Substring(8).Trim();
                    string password = userData[2].Substring(11).Trim();
                    string userTypeString = userData[3].Substring(8).Trim();
                    btnDeleteUser.Enabled = true;
                    btnDeleteUser.BackColor = Color.Green;
                    create = false;
                    if (Enum.TryParse(userTypeString, out StartForm.UserType userType))
                    {
                        txtUserId.Text = userid;
                        txtUsername.Text = username;
                        txtPassword.Text = password;
                        comboBoxUserType.SelectedItem = userType.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user data format: " + selectedUserString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No user selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxShowAdminUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listBoxShowAdminUser.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    listBoxShowAdminUser.SelectedIndex = index;
                    contextMenuStrip.Show(listBoxShowAdminUser, e.Location);
                }
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (listBoxShowAdminUser.SelectedItem != null)
            {
                Guid userId = Guid.Parse(txtUserId.Text);
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                StartForm.UserType userType;
                if (Enum.TryParse<StartForm.UserType>(comboBoxUserType.SelectedItem.ToString(), out userType))
                {
                    Person newUser = new Person
                    {
                        UserId = userId,
                        Username = username,
                        Password = password,
                        Type_Of_User = userType
                    };
                    userList.Remove(newUser);
                    UpdateUser(newUser);
                    userList.Add(newUser);
                    txtUserId.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    listBoxShowAdminUser.Items.Clear();
                    getShowAdminUser();
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
            btnUpdateUser.Enabled = false;
            btnUpdateUser.BackColor = Color.Red;
            create = true;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (listBoxShowAdminUser.SelectedItem != null)
            {
                Guid userId = Guid.Parse(txtUserId.Text);
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                StartForm.UserType userType;
                if (Enum.TryParse<StartForm.UserType>(comboBoxUserType.SelectedItem.ToString(), out userType))
                {
                    Person newUser = new Person
                    {
                        UserId = userId,
                        Username = username,
                        Password = password,
                        Type_Of_User = userType
                    };
                    Person per = null;
                    foreach (Person p in userList)
                    {
                        if (newUser.UserId == p.UserId)
                        {
                            per = p;
                        }
                       
                    }
                    userList.Remove(per);
                    person.DeleteUserFromCSV(newUser, userList);

                    txtUserId.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    listBoxShowAdminUser.Items.Clear();
                    getShowAdminUser();
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
            btnUpdateUser.Enabled = false;
            btnUpdateUser.BackColor = Color.Red;
            create = true;
        }


       

        private void UpdateUser(Person userToUpdate)
        {
            Person existingUser = userList.FirstOrDefault(u => u.UserId == userToUpdate.UserId);
            if (existingUser != null)
            {
                existingUser.UserId = userToUpdate.UserId;
                existingUser.Username = userToUpdate.Username;
                existingUser.Password = userToUpdate.Password;
                existingUser.Type_Of_User = userToUpdate.Type_Of_User;
                person.UpdateUserInCSV(existingUser, userList);
                listBoxShowAdminUser.Items.Clear();
                getShowAdminUser();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if ((txtUsername.Text.Length > 0) && create)
            {
                btnCreateUser.Enabled = true;
                btnCreateUser.BackColor = Color.Green;
            }
            else
            {
                btnCreateUser.Enabled = false;
                btnCreateUser.BackColor = Color.Red;
            }
        }
    }
}
