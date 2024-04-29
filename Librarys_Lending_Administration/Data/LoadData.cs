using Library_s_Lending_Administration.Lending;
using System;
using System.IO;
using System.Windows.Forms;
using Library_s_Lending_Administration.Data.Load;

namespace Library_s_Lending_Administration.Data
{
    public class LoadData
    {

        
        public LoadData() 
        {
            LoadPerson loadDataPerson = new LoadPerson();
          //LoadAdultBooks loadDataAdultBooks = new LoadAdultBooks();   
          //LoadChildrenBooks loadDataChildrenBooks = new LoadChildrenBooks();
          //LoadCartoons loadDataCartoons = new LoadCartoons(); 
          //LoadCDs loadDataCDs = new LoadCDs();
            LoadForum loadDataForum = new LoadForum();
            LoadLendings loadDataLending = new LoadLendings();
          //LoadDVDMovies loadDataDVDMovies = new LoadDVDMovies();
          //LoadRecords loaddataRecords = new LoadRecords();              
        }
    }
}
