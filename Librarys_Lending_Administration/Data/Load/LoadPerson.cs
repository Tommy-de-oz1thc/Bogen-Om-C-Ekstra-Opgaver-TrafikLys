using System;
using System.IO;
using System.Windows.Forms;
using static Library_s_Lending_Administration.StartForm; 

namespace Library_s_Lending_Administration.Data.Load
{
    public class LoadPerson
    {
       
        public LoadPerson()
        {
            try
            {
                using (StreamReader reader = new StreamReader(StartForm.filePathPerson))
                {
                    // Skip the header line
                    reader.ReadLine();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 4) // Check if there are enough parts
                        {
                            string userid = parts[0];
                            string username = parts[1];
                            string password = parts[2];
                            if (Enum.TryParse(parts[3], out UserType type))
                            {
                                StartForm.personList.Add(new Person(userid, username, password, type));
                            }
                            else
                            {
                                MessageBox.Show($"Invalid user type: Person {parts[3]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error loading Person from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
