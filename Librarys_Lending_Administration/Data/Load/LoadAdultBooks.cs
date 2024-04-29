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
    public class LoadAdultBooks
    {
        public LoadAdultBooks()
        {
            try
            {
                // Now read the data from the file
                using (StreamReader reader1 = new StreamReader(StartForm.filePathAdultBooks))
                {
                    // Skip the header line
                    reader1.ReadLine();
                    string line1;
                    while ((line1 = reader1.ReadLine()) != null)
                    {
                        string[] parts1 = line1.Split(',');
                        if (parts1.Length >= 4) // Check if there are enough parts
                        {
                            Guid userid = Guid.Parse(parts1[0]);
                            string title = parts1[1];
                            string description = parts1[2];
                            string author = parts1[3];
                            int max_days_of_lending = int.Parse(parts1[4]);
                            DateTime rendingDate = Convert.ToDateTime(parts1[5]);
                            if (Enum.TryParse(parts1[6], out StartForm.StatusType type))
                            {
                                StartForm.adultBooks.addListAdultBooks(new AdultBooks(userid, title, description, author, max_days_of_lending, rendingDate, type));
                            }
                            else
                            {
                                MessageBox.Show($"Invalid book type: AdultBooks {parts1[6]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Invalid line in CSV: {line1}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading AdultBooks from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
