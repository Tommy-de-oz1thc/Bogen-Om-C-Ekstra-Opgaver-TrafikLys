using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_s_Lending_Administration.Data.SetUp
{
    public class SetUpPayments
    {
        public SetUpPayments() 
        {
            if (!File.Exists(StartForm.filePathPayments))
            {
                // Create the file if it doesn't exist
                using (StreamWriter writer = new StreamWriter(StartForm.filePathPayments))
                {
                    // Write the header
                    writer.WriteLine("Id,PaymentType,ToLate,LongToLate,daysLate, daysLong");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb0a,AdultBooks,20,100,7,60");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb0b,ChildrenBooks,20,100,7,60");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb0c,Cartoons,20,100,7,60");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb0d,CDs,20,100,7,60");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb0e,DVDMovies,20,100,7,60");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb0f,Records,20,100,7,60");

                }
            }
        }
    }
}
