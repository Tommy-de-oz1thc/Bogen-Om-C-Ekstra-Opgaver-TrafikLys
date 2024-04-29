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
    public class LoadLendings
    {
        public LoadLendings()
        {
            try
            {
                // Now read the data from the file
                using (StreamReader reader9 = new StreamReader(StartForm.filePathLendings))
                {
                    // Skip the header line
                    reader9.ReadLine();
                    string line9;
                    while ((line9 = reader9.ReadLine()) != null)
                    {
                        string[] parts9 = line9.Split(',');
                        if (parts9.Length >= 4) // Check if there are enough parts
                        {

                            Guid lendingid = Guid.Parse(parts9[0]);
                            Guid userid = Guid.Parse(parts9[1]);
                            string username = parts9[2];
                            Guid id_for_lending = Guid.Parse(parts9[4]);
                            string title = parts9[5];
                            string description = parts9[6];
                            string author = parts9[7];
                            DateTime rendingDate = Convert.ToDateTime(parts9[8]);
                            if (Enum.TryParse(parts9[3], out PaymentType paymentType))
                            {
                                StartForm.lendings.addListLendings(new Lendings(lendingid, userid, username, paymentType, id_for_lending, title, description, author, rendingDate));
                            }
                            else
                            {
                                MessageBox.Show($"Invalid book type: CDs {parts9[6]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Invalid line in CSV: {line9}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Lendings from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
