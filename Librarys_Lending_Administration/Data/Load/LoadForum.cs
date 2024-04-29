using Library_s_Lending_Administration.Lending;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_s_Lending_Administration.Data.Load
{
    public class LoadForum
    {
        public LoadForum() 
        {
            try
            {
                // Now read the data from the file
                using (StreamReader reader7 = new StreamReader(StartForm.filePathForum))
                {
                    // Skip the header line
                    reader7.ReadLine();
                    string line7;
                    while ((line7 = reader7.ReadLine()) != null)
                    {
                        string[] parts7 = line7.Split(',');
                        if (parts7.Length >= 4) // Check if there are enough parts
                        {
                            Guid forumid = Guid.Parse(parts7[0]);
                            string title = parts7[1];
                            string description = parts7[2];
                            string author = parts7[3];

                            DateTime writingDate = Convert.ToDateTime(parts7[4]);

                            // Assuming you have a method addListForums similar to addListCDs
                            StartForm.forum.AddForumPost(new Forum(forumid, title, description, author, writingDate));

                        }
                        else
                        {
                            MessageBox.Show($"Invalid line in CSV: {line7}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Forums from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
