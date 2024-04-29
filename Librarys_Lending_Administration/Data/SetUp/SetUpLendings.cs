using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_s_Lending_Administration.Data.SetUp
{
    public class SetUpLendings
    {
        public SetUpLendings()
        {
            if (!File.Exists(StartForm.filePathLendings))
            {
                // Create the file if it doesn't exist
                using (StreamWriter writer = new StreamWriter(StartForm.filePathLendings))
                {
                    // Write the header
                    writer.WriteLine("LendingId,UserId,Username,PaymentType,Id_for_Lending,Title,Description,Author,RendingDate");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb04,2c50360b-6e4d-46b7-8905-9e19d82cbb05,Tommy,AdultBooks,2c50360b-6e4d-46b7-8905-9e19d82cbb06,Children for Coding,A learning book for DVDs - available online,Michell Cronberg,26-04-2024");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb02,6a7b62fd-cb92-4f53-af18-69b05dc8a36f,user,AdultBooks,2c50360b-6e4d-46b7-8905-9e19d82cbb06,Children for Coding,A learning book for DVDs - available online,Michell Cronberg,26-04-2024");
                }
            
            }

           
        }
    }
}
