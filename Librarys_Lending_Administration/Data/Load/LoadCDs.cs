using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_s_Lending_Administration.Data.Load
{
    public class LoadCDs
    {
        public LoadCDs() 
        {
            try
            {
                // Now read the data from the file
                using (StreamReader reader4 = new StreamReader(StartForm.filePathCDs))
                {
                    // Skip the header line
                    reader4.ReadLine();
                    string line4;
                    while ((line4 = reader4.ReadLine()) != null)
                    {
                        string[] parts4 = line4.Split(',');
                        if (parts4.Length >= 4) // Check if there are enough parts
                        {
                            Guid userid = Guid.Parse(parts4[0]);
                            string title = parts4[1];
                            string description = parts4[2];
                            string author = parts4[3];
                            int max_days_of_lending = int.Parse(parts4[4]);
                            DateTime rendingDate = Convert.ToDateTime(parts4[5]);
                            if (Enum.TryParse(parts4[6], out StartForm.StatusType type))
                            {
                                StartForm.cds.addListCDs(new CDs(userid, title, description, author, max_days_of_lending, rendingDate, type));
                            }
                            else
                            {
                                MessageBox.Show($"Invalid book type: CDs {parts4[6]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Invalid line in CSV: {line4}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Cartoons from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
