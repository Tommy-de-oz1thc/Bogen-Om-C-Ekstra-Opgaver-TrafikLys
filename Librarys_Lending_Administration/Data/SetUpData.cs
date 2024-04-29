using Library_s_Lending_Administration.Data.SetUp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_s_Lending_Administration.Data
{
    public class SetUpData
    {
        public SetUpData()
        {

                try
                {

                    // Specifiser stien til mappen
                    string dataDirectory = @"Data";

                    // Sjekk om mappen eksisterer
                    if (!Directory.Exists(dataDirectory))
                    {
                        // Opprett mappen hvis den ikke eksisterer
                        Directory.CreateDirectory(dataDirectory);
                    }

                    SetUpPerson SetUpDataPerson = new SetUpPerson();
                    SetUpAdultBooks SetupDataAdultBooks = new SetUpAdultBooks();
                    SetUpChildrenBooks SetUpDataChildrenBooks = new SetUpChildrenBooks();
                    SetUpCartoons SetUpDataCartoons = new SetUpCartoons();
                    SetUpCDs SetUpDataCDs = new SetUpCDs();
                    SetUpDVDMovies SetUpDataDVDMovies = new SetUpDVDMovies();
                    SetUpRecords SetUpDataRecords = new SetUpRecords();
                    SetUpForum SetUpDataForum = new SetUpForum();
                    SetUpLendings SetUpDataLendings = new SetUpLendings();
                    SetUpPayments setUpDataPayments = new SetUpPayments();

                }
                catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }
       
    
    }
}
