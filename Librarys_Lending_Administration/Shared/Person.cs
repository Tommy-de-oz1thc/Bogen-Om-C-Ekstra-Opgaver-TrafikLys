using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Library_s_Lending_Administration
{
    
    public class Person
    {
        private static List<Person> listUsers = new List<Person>(); // List to store users read from CSV
       
        public Person() { }
        public Person(string userid, string username, string password, StartForm.UserType type)
        {
            UserId = Guid.Parse(userid);
            Username = username;
            Password = password;
            Type_Of_User = type;
        }

        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public StartForm.UserType Type_Of_User { get; set; }

        public List<Person> getListUsers()
        {
            return listUsers;
        }
        public void addListUsers(Person person)
        {
            listUsers.Add(person);
        }
        public void removeListUsers(Person person)
        {
            listUsers.Remove(person);
        }
        public void AddUserToCSV(Person user)
        {
            try
            {
                // Append the new user's information to the CSV file
                using (StreamWriter writer = new StreamWriter(StartForm.filePathPerson, true))
                {
                    // Format the user's information as a CSV line
                    string userLine = $"{user.UserId},{user.Username},{user.Password},{user.Type_Of_User}";

                    // Write the CSV line to the file
                    writer.WriteLine(userLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user to CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateUserInCSV(Person user, List<Person> userList)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(StartForm.filePathPerson))
                {
                    writer.WriteLine("Id,Name,Password,Type_Of_User");
                    foreach (Person u in userList)
                    {
                        writer.WriteLine($"{u.UserId},{u.Username},{u.Password},{u.Type_Of_User}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user in CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteUserFromCSV(Person user, List<Person> userList)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(StartForm.filePathPerson))
                {
                    writer.WriteLine("Id,Name,Password,Type_Of_User");
                    foreach (Person u in userList)
                    {
                        if (u.UserId != user.UserId)
                        {
                            writer.WriteLine($"{u.UserId},{u.Username},{u.Password},{u.Type_Of_User}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


