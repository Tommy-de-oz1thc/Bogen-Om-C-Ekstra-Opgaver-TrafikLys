using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_s_Lending_Administration.Data.SetUp
{
    public class SetUpAdultBooks
    {
        public SetUpAdultBooks()
        {
            if (!File.Exists(StartForm.filePathAdultBooks))
            {
                // Create the file if it doesn't exist
                using (StreamWriter writer = new StreamWriter(StartForm.filePathAdultBooks))
                {
                    // Write the header
                    writer.WriteLine("Id,Title,Description,Author,Max_Days_for_Lending,RendingDate,Status_for_Lending");
                    // Write sample data
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb01,Bogen om C# 1,A learning book for C# - available online,Michell Cronberg,30,26-04-2024,Home");
                    writer.WriteLine("2c50360b-6e4d-46b8-8905-9e19d82cbb01,Bogen om C# 2,A learning book for C# - available online,Michell Cronberg,30,26-04-2024,Home");
                    writer.WriteLine("2c50360b-6e4d-46b9-8905-9e19d82cbb01,Bogen om C# 3,A learning book for C# - available online,Michell Cronberg,30,26-04-2024,Home");
                }
            }
        }
    }
}
