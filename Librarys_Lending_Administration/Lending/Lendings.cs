using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library_s_Lending_Administration.StartForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_s_Lending_Administration.Lending
{

    public class Lendings
    {
        private List<Lendings> listLendings = new List<Lendings>();
        public Guid LendingId { get; set; } 
        public Guid UserId { get; set; }

        public string Username { get; set; }
        public PaymentType PaymentType { get; set; }

        public Guid Id_for_Lending { get; set; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Author { set; get; }
        public DateTime RendingDate { get; set; }
        public Lendings() { }

        public Lendings(Guid lendingId, Guid userId, string username, PaymentType paymentType, Guid id_for_Lending, string title, string description, string author, DateTime rendingDate)
        {
          
            LendingId = lendingId;
            UserId = userId;
            Username = username;
            PaymentType = paymentType;
            Id_for_Lending = id_for_Lending;
            Title = title;
            Description = description;
            Author = author;
            RendingDate = rendingDate;
        }
        public List<Lendings> getListLendings()
        {
            return listLendings;
        }

        public void addListLendings(Lendings len)
        {
            listLendings.Add(len);
        }
        public void removeListLendings(Lendings len)
        {
            listLendings.Remove(len);
        }

        public List<Lendings> readLendingsCSV()
        {
            string filePathLendings = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\Lendings.csv");

            try
            {
                using (StreamReader reader = new StreamReader(filePathLendings))
                {
                    // Skip the header line
                    reader.ReadLine();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 9) // Check if there are enough parts
                        {
                            if (Guid.TryParse(parts[0], out Guid lendingId) &&
                                Guid.TryParse(parts[1], out Guid userId) &&
                                Enum.TryParse(parts[3], out PaymentType paymentType) &&
                                Guid.TryParse(parts[4], out Guid id_for_Lending) &&
                                DateTime.TryParse(parts[8], out DateTime rendingDate))
                            {
                                Lendings newLending = new Lendings(
                                    lendingId,
                                    userId,
                                    parts[2],
                                    paymentType,
                                    id_for_Lending,
                                    parts[5],
                                    parts[6],
                                    parts[7],
                                    rendingDate
                                );

                                listLendings.Add(newLending);
                            }
                            else
                            {
                                MessageBox.Show($"Invalid data in CSV: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Invalid line in CSV: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listLendings;
        }

        public void AddLendingToCSV(Lendings lending)
        {
            try
            {
                // Append the new lending's information to the CSV file
                using (StreamWriter writer = new StreamWriter(StartForm.filePathLendings, true))
                {
                    // Format the lending's information as a CSV line
                    string lendingLine = $"{lending.LendingId},{lending.UserId},{lending.Username},{lending.PaymentType},{lending.Id_for_Lending},{lending.Title},{lending.Description},{lending.Author},{lending.RendingDate}";

                    // Write the CSV line to the file
                    writer.WriteLine(lendingLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding lending to CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void UpdateLendingsInCSV(Lendings user, List<Lendings> booklist)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(StartForm.filePathLendings))
                {
                    writer.WriteLine("Id,Title,Description,Author,Max_Days_for_Lending,RendingDate,Status_for_Lending");
                    foreach (Lendings u in listLendings)
                    {
                        writer.WriteLine($"{u.LendingId},{u.UserId}, {u.Username}, {u.PaymentType}, {u.Id_for_Lending}, {u.Title}, {u.Description}, {u.Author}, {u.RendingDate}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user in CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteLendingsFromCSV(Lendings user, List<Lendings> userList)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(StartForm.filePathLendings))
                {
                    writer.WriteLine("Id,Name,Password,Type_Of_User");
                    foreach (Lendings u in userList)
                    {
                        if (u.LendingId != user.LendingId)
                        { 
                            writer.WriteLine($"{u.LendingId},{ u.UserId}, { u.Username}, { u.PaymentType}, { u.Id_for_Lending}, { u.Title}, { u.Description}, { u.Author}, { u.RendingDate}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
