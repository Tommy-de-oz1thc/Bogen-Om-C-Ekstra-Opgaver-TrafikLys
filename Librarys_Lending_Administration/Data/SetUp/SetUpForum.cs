using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_s_Lending_Administration.Data.SetUp
{
    public class SetUpForum
    {
        public SetUpForum()
        {
            if (!File.Exists(StartForm.filePathForum))
            {
                // Create the file if it doesn't exist
                using (StreamWriter writer = new StreamWriter(StartForm.filePathForum))
                {
                    // Write the header
                    writer.WriteLine("Id,Title,Discription,Author,WritningDate");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb01,Book 1,This the first book,Tommy,27-05-2024");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb02,Book 2,This the second book,Brian,27-06-2024");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb03,Book 3,This the third book,Michell,28-04-2024");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb04,Book 4,This the fourth book,Jan,23-04-2024");
                }
            }
        }
    }
}
