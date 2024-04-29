using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Library_s_Lending_Administration.Lending
{
    public class Forum
    {
        // Static list to store all forum posts
        private static List<Forum> listForum = new List<Forum>();

        public Guid Userid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime WritingDate { get; set; }

        public Forum() { }

        public Forum(Guid userid, string title, string description, string author, DateTime writingDate)
        {
            Userid = userid;
            Title = title;
            Description = description;
            Author = author;
            WritingDate = writingDate;
        }
        public List<Forum> getListForum()
        {
            return listForum;
        }
        // Add a forum post to the static list
        public void AddForumPost(Forum post)
        {
            listForum.Add(post);
        }
        public void removeListForumPost(Forum post)
        {
            listForum.Remove(post);
        }
        // Read forum data from a CSV file
        public List<Forum> ReadForumCSV()
        {
            listForum.Clear();
            // Implement CSV parsing logic here
            // Read lines from the file, split by commas, and create Forum objects
            // Add each Forum object to the listForum
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, StartForm.filePathForum);
            // Example:
            using (StreamReader reader = new StreamReader(filePath))
            {
                reader.ReadLine(); // Skip header
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 5)
                    {
                        // Parse data and create Forum object
                        // Add it to listForum
                        Guid UserId = Guid.Parse(parts[0]);
                        string Title = parts[1];
                        string Description = parts[2];
                        string Author = parts[3];
                        DateTime WritingDate = Convert.ToDateTime(parts[4]);
                        listForum.Add(new Forum(UserId, Title, Description, Author, WritingDate));
                    }
                }
            }

            // Return the list of forum posts
            return listForum;
        }
        public void AddForumToCSV(Forum user)
        {
            try
            {
                // Append the new user's information to the CSV file
                using (StreamWriter writer = new StreamWriter(StartForm.filePathForum, true))
                {
                    // Format the user's information as a CSV line
                    string forumLine = $"{user.Userid},{user.Title},{user.Description},{user.Author},{user.WritingDate}";

                    // Write the CSV line to the file
                    writer.WriteLine(forumLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user to CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteForumFromCSV(Forum user, List<Forum> userList)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(StartForm.filePathForum))
                {
                    writer.WriteLine("Id,Name,Password,Type_Of_User");
                    foreach (Forum u in userList)
                    {
                        if (u.Userid != user.Userid)
                        {
                            writer.WriteLine($"{u.Userid},{u.Title},{u.Description},{u.Author},{u.WritingDate}");
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
