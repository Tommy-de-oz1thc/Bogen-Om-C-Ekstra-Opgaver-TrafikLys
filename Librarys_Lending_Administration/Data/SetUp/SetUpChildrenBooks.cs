using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_s_Lending_Administration.Data.SetUp
{
    public class SetUpChildrenBooks
    {
        public SetUpChildrenBooks() 
        {
            if (!File.Exists(StartForm.filePathChildrenBooks))
            {
                // Create the file if it doesn't exist
                using (StreamWriter writer = new StreamWriter(StartForm.filePathChildrenBooks))
                {
                    // Write the header
                    writer.WriteLine("Id,Title,Description,Author,Max_Days_for_Lending,RendingDate,Status_for_Lending");
                    // Write sample data
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb02,Children for Coding,A learning book for Children - available online,Michell Cronberg,30,26-04-2024,Home");
                }
            }
        }
    }
}
