using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library_s_Lending_Administration.Person;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.IO;

namespace Library_s_Lending_Administration.Data.SetUp
{
    public class SetUpPerson
    {
        public SetUpPerson()
        {
            if (!File.Exists(StartForm.filePathPerson))
            {
                // Create the file if it doesn't exist
                using (StreamWriter writer = new StreamWriter(StartForm.filePathPerson))
                {
                    // Write the header
                    writer.WriteLine("Id,Name,Password,Type_Of_User");
                    // Write the default data
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb0c,admin,1234,Admin");
                    writer.WriteLine("6a7b62fd-cb92-4f53-af18-69b05dc8a36f,user,4321,User");
                }
            }

        }

    }
}
