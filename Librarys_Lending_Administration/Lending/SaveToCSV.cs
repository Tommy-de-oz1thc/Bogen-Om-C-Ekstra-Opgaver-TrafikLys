using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Library_s_Lending_Administration.Lending
{
    public class SaveToCSV
    {
        public SaveToCSV() { }

        public static void AddToCSV(object data, Type classType,  string filePath)
        {
            try
            {
                // Retrieve object information based on the classType provided
                dynamic obj = data;

                // Append the object's information to the CSV file
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Retrieve properties of the object
                    PropertyInfo[] properties = classType.GetProperties();

                    // Format the object's information as a CSV line
                    string objLine = string.Join(",", properties.Select(p => obj.GetType().GetProperty(p.Name).GetValue(obj, null)));

                    // Write the CSV line to the file
                    writer.WriteLine(objLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding data to CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateFromCSV<T>(Type classType, string filePath, List<T> list)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Id,Title,Description,Author,Max_Days_for_Lending,RendingDate,Status_for_Lending");
                    foreach (object obj in list)
                    {
                        // Konverter objektet til den korrekte type ved hjælp af refleksion
                        PropertyInfo[] properties = classType.GetProperties(); // Få alle egenskaber for den givne type
                        string[] values = new string[properties.Length];
                        for (int i = 0; i < properties.Length; i++)
                        {
                            values[i] = properties[i].GetValue(obj).ToString(); // Hent værdien af hver egenskab og konverter til streng
                        }
                        writer.WriteLine(string.Join(",", values)); // Skriv egenskabsværdierne som en CSV-linje
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl ved opdatering af data i CSV: " + ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
