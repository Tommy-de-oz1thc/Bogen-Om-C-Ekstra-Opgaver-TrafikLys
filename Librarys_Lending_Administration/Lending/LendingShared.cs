using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static Library_s_Lending_Administration.StartForm;

namespace Library_s_Lending_Administration.Lending
{
    public class LendingShared
    {
        public LendingShared() { }


        public static List<T> ReadCSV<T>(List<T> list, Type classType, string filePath)
        {
            // Now read the data from the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Skip the header line
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 7) // Check if there are enough parts
                    {
                        if (Guid.TryParse(parts[0], out Guid Id) &&
                            int.TryParse(parts[4], out int Max_Days_for_Lending) &&
                            DateTime.TryParse(parts[5], out DateTime RendingDate) &&
                            Enum.TryParse(parts[6], out StatusType Status_for_Lending))
                        {
                            // Instantiate object using reflection
                            object obj = Activator.CreateInstance(classType,
                                Id,
                                parts[1],
                                parts[2],
                                parts[3],
                                Max_Days_for_Lending,
                                RendingDate,
                                Status_for_Lending);

                            // Add object to list
                            list.Add((T)obj);
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
            return list;
        }



    }


}

