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
    public class LoadCartoons
    {
        public LoadCartoons()
        {
            try
            {
                // Now read the data from the file
                using (StreamReader reader3 = new StreamReader(StartForm.filePathCartoons))
                {
                    // Skip the header line
                    reader3.ReadLine();
                    string line3;
                    while ((line3 = reader3.ReadLine()) != null)
                    {
                        string[] parts3 = line3.Split(',');
                        if (parts3.Length >= 4) // Check if there are enough parts
                        {
                            Guid userid = Guid.Parse(parts3[0]);
                            string title = parts3[1];
                            string description = parts3[2];
                            string author = parts3[3];
                            int max_days_of_lending = int.Parse(parts3[4]);
                            DateTime rendingDate = Convert.ToDateTime(parts3[5]);
                            if (Enum.TryParse(parts3[6], out StartForm.StatusType type))
                            {
                                StartForm.cartoons.addListCartoons(new Cartoons(userid, title, description, author, max_days_of_lending, rendingDate, type));
                            }
                            else
                            {
                                MessageBox.Show($"Invalid book type: Cartoons {parts3[6]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Invalid line in CSV: {line3}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Cartoons from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public object StartForms { get; private set; }
    }
}
