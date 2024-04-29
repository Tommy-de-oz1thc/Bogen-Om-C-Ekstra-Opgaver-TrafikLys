using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_s_Lending_Administration.Data.Load
{
    internal class LoadPayments
    {
        public LoadPayments() 
        {

            try
            {
                // Now read the data from the file
                using (StreamReader reader8 = new StreamReader(StartForm.filePathPayments))
                {
                    // Skip the header line
                    reader8.ReadLine();
                    string line8;
                    while ((line8 = reader8.ReadLine()) != null)
                    {
                        string[] parts8 = line8.Split(',');
                        if (parts8.Length >= 4) // Check if there are enough parts
                        {
                            Guid id = Guid.Parse(parts8[0]);

                            int tolate = int.Parse(parts8[2]);
                            int tolatelong = int.Parse(parts8[3]);
                            int daysLate = int.Parse(parts8[4]);
                            int daysLong = int.Parse(parts8[5]);
                            if (Enum.TryParse(parts8[1], out PaymentType paymentType))
                            {
                                StartForm.payments.addListPayments(new Payments(id, paymentType, tolate, tolatelong, daysLate, daysLong));

                            }
                            else
                            {
                                MessageBox.Show($"Invalid book type: Payments {parts8[1]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Invalid line in CSV: {line8}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Payments from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
