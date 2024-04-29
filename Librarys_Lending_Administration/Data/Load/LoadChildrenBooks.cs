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
    public class LoadChildrenBooks
    {
        public LoadChildrenBooks()
        {
            try
            {
                // Now read the data from the file
                using (StreamReader reader2 = new StreamReader(StartForm.filePathChildrenBooks))
                {
                    // Skip the header line
                    reader2.ReadLine();
                    string line2;
                    while ((line2 = reader2.ReadLine()) != null)
                    {
                        string[] parts2 = line2.Split(',');
                        if (parts2.Length >= 4) // Check if there are enough parts
                        {
                            Guid userid = Guid.Parse(parts2[0]);
                            string title = parts2[1];
                            string description = parts2[2];
                            string author = parts2[3];
                            int max_days_of_lending = int.Parse(parts2[4]);
                            DateTime rendingDate = Convert.ToDateTime(parts2[5]);
                            if (Enum.TryParse(parts2[6], out StartForm.StatusType type))
                            {
                                StartForm.childrenBooks.addListChildrenBooks(new ChildrenBooks(userid, title, description, author, max_days_of_lending, rendingDate, type));
                            }
                            else
                            {
                                MessageBox.Show($"Invalid book type: ChildrenBooks {parts2[6]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Invalid line in CSV: {line2}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ChildrenBooks from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
