using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library_s_Lending_Administration.Person;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_s_Lending_Administration.User
{
    public partial class UserDataForm : Form
    {
        private Person person = new Person();
        private Person _user { set; get; }
        public UserDataForm(Person user)
        {
            InitializeComponent();
            _user = user;
            txtUserId.Text = _user.UserId.ToString();
            txtUsername.Text = _user.Username;
            txtPassword.Text = _user.Password;
            comboBoxUserType.SelectedItem = 0;

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            // Create a new Person object with updated information
            Person newUser = new Person
            {
                UserId = Guid.Parse(txtUserId.Text),
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            // Parse the selected UserType from the comboBox
            if (Enum.TryParse(comboBoxUserType.SelectedItem.ToString(), out StartForm.UserType type))
            {
                newUser.Type_Of_User = type;
            }
            else
            {
                // Handle invalid UserType selection
                MessageBox.Show("Invalid user type selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Update the user in the userList
            UpdateUser(newUser);

            // Remove the old user from the userList
            person.removeListUsers(newUser);

            // Add the updated user to the userList
            person.addListUsers(newUser);
        }


        private void UpdateUser(Person userToUpdate)
        {
            Person existingUser = person.getListUsers().FirstOrDefault(u => u.UserId == userToUpdate.UserId);
            if (existingUser != null)
            {
                existingUser.UserId = userToUpdate.UserId;
                existingUser.Username = userToUpdate.Username;
                existingUser.Password = userToUpdate.Password;
                existingUser.Type_Of_User = userToUpdate.Type_Of_User;
                person.UpdateUserInCSV(existingUser, person.getListUsers());
                MessageBox.Show("User had been Updated");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                btnUpdateUser.Enabled = true;
                btnUpdateUser.BackColor = Color.Green;
            }
            else
            {
                btnUpdateUser.Enabled = false;
                btnUpdateUser.BackColor = Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                btnUpdateUser.Enabled = true;
                btnUpdateUser.BackColor = Color.Green;
            }
            else
            {
                btnUpdateUser.Enabled = false;
                btnUpdateUser.BackColor = Color.Red;
            }

        }
    }
}
