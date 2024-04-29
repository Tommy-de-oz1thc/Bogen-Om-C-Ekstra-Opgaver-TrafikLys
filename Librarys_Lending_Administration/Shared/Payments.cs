using Library_s_Lending_Administration.Lending;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Library_s_Lending_Administration
{
    // Define an enum for payment types
    public enum PaymentType
    {
        AdultBooks,
        ChildrenBooks,
        Cartoons,
        DVDMovies,
        CDs,
        Records
    }

    public class Payments
    {
        private static List<Payments> listPayments = new List<Payments>();
        public Guid PaymentId { get; set; }
        public PaymentType PaymentType { get; set; } // Use the enum here instead of string
        public int ToLate { get; set; }
        public int ToLateLong { get; set; }

        public int daysLate { get; set; }
        public int daysLong {  get; set; }

        // Constructor to set the values
        public Payments() { }
        public Payments(Guid id, PaymentType type, int tolate, int tolatelong,  int daysLate, int daysLong)
        {
            // The value is shown in $ and ToLate is a payment when you return lending too late,
            // the Long is the payment if you return too late and there has been over a month since
            // you should have returned the lending material.
            // The message will show up in a MessageBox when returning lending if it is past the return last date.
            PaymentId = id;
            PaymentType = type;
            ToLate = tolate;
            ToLateLong = tolatelong;
            this.daysLate = daysLate;
            this.daysLong = daysLong;

        }

        public List<Payments> getListPayment()
        { 
            return listPayments; 
        }

        public void addListPayments(Payments book)
        {
            listPayments.Add(book);
        }
        public void removeListPayments(Payments book)
        {
            listPayments.Remove(book);
        }

        public void AddPaymentsToCSV(Payments user)
        {
            try
            {
                // Append the new user's information to the CSV file
                using (StreamWriter writer = new StreamWriter(StartForm.filePathPayments, true))
                {
                    // Format the user's information as a CSV line
                    string bookLine = $"{user.PaymentId},{user.PaymentType},{user.ToLate},{user.ToLateLong},{user.daysLate},{user.daysLong}";

                    // Write the CSV line to the file
                    writer.WriteLine(bookLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user to CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdatePaymentsInCSV(Payments user, List<Payments> booklist)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(StartForm.filePathPayments))
                {
                    writer.WriteLine("Id,PaymentType,ToLate,LongToLate,daysLate, daysLong");
                    foreach (Payments u in booklist)
                    {
                        if (u.PaymentType == user.PaymentType)
                        {
                            writer.WriteLine($"{u.PaymentId},{u.PaymentType},{user.ToLate},{user.ToLateLong},{user.daysLate},{user.daysLong}");
                        }
                        else
                        {
                            writer.WriteLine($"{u.PaymentId},{u.PaymentType},{u.ToLate},{u.ToLateLong},{u.daysLate},{u.daysLong}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user in CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Payments> readPaymentsCSV(PaymentType type)
        {
            string filePathChildrenBooks = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, StartForm.filePathPayments);
            List<Payments> _paymentlist = new List<Payments>();

            // Now read the data from the file
            using (StreamReader reader = new StreamReader(filePathChildrenBooks))
            {
                
                // Skip the header line
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4) // Check if there are enough parts
                    {
                        Guid PaymentId = Guid.Parse(parts[0]);
                        int ToLate = int.Parse(parts[2]);
                        int ToLateLong = int.Parse(parts[3]);
                        int daysLate = int.Parse(parts[4]);
                        int daysLong = int.Parse(parts[5]);
                        
                        if (Enum.TryParse(parts[1], out PaymentType Type))
                        {
                            if (type == Type)
                            {
                                _paymentlist.Add(new Payments(PaymentId, Type, ToLate, ToLateLong, daysLate, daysLong));
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Invalid user type: {parts[6]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show($"Invalid line in CSV: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return _paymentlist;
        }
    }
}
