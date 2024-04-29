using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_s_Lending_Administration.Data.Load
{
    public class LoadDVDMovies
    {
        public LoadDVDMovies() 
        {
            try
            {
                // Now read the data from the file
                using (StreamReader reader10 = new StreamReader(StartForm.filePathDVDMovies))
                {
                    // Skip the header line
                    reader10.ReadLine();
                    string line10;
                    while ((line10 = reader10.ReadLine()) != null)
                    {
                        string[] parts10 = line10.Split(',');
                        if (parts10.Length >= 4) // Check if there are enough parts
                        {


                            Guid userid = Guid.Parse(parts10[0]);
                            string title = parts10[1];
                            string description = parts10[2];
                            string author = parts10[3];
                            int max_days_of_lending = int.Parse(parts10[4]);
                            DateTime rendingDate = Convert.ToDateTime(parts10[5]);
                            if (Enum.TryParse(parts10[6], out StartForm.StatusType type))
                            {
                                StartForm.cartoons.addListCartoons(new Cartoons(userid, title, description, author, max_days_of_lending, rendingDate, type));
                            }
                            else
                            {
                                MessageBox.Show($"Invalid book type: DVDss {parts10[6]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show($"Invalid book type: DVDDs {line10}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
