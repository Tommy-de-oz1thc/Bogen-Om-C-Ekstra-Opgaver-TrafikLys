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
    public class LoadRecords
    {
        public LoadRecords()
        {
            try
            {
                // Now read the data from the file
                using (StreamReader reader11 = new StreamReader(StartForm.filePathRecords))
                {
                    // Skip the header line
                    reader11.ReadLine();
                    string line11;
                    while ((line11 = reader11.ReadLine()) != null)
                    {
                        string[] parts11 = line11.Split(',');
                        if (parts11.Length >= 4) // Check if there are enough parts
                        {


                            Guid userid = Guid.Parse(parts11[0]);
                            string title = parts11[1];
                            string description = parts11[2];
                            string author = parts11[3];
                            int max_days_of_lending = int.Parse(parts11[4]);
                            DateTime rendingDate = Convert.ToDateTime(parts11[5]);
                            if (Enum.TryParse(parts11[6], out StartForm.StatusType type))
                            {
                                StartForm.records.addListRecords(new Records(userid, title, description, author, max_days_of_lending, rendingDate, type));
                            }
                            else
                            {
                                MessageBox.Show($"Invalid book type: Recordss {parts11[6]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show($"Invalid book type: Records {line11}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
