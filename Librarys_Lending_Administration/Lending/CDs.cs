using Library_s_Lending_Administration.Lending;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_s_Lending_Administration
{
    public class CDs
    {
        private static List<CDs> listCDs = new List<CDs>();
       
        public List<CDs> getListCDs()
        {
            return listCDs;
        }

        public void addListCDs(CDs cd)
        {
            listCDs.Add(cd);
        }
        public void removeListCDs(CDs cd)
        {
            listCDs.Remove(cd);
        }
        public Guid Id { get; set; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Author { set; get; }

        public int Max_Days_for_Lending = 7;

        public DateTime RendingDate { set; get; }
        public StartForm.StatusType Status_for_Lending { set; get; }

        public CDs() { }
        public CDs(int max_Days_for_Lending)
        {
            Max_Days_for_Lending = max_Days_for_Lending;
        }
      
        public CDs(Guid id, string title, string description, string author, int max_Days_for_Lending, DateTime rendingDate, StartForm.StatusType type)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Max_Days_for_Lending = max_Days_for_Lending;
            RendingDate = rendingDate;
           Status_for_Lending = (StartForm.StatusType)type;

        }

        public StartForm.StatusType GetStatus_for_Lending()
        {
            return Status_for_Lending;
        }

        public List<CDs> readCDsCSV()
        {
            string filePathCDs = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, StartForm.filePathCDs);

            listCDs = LendingShared.ReadCSV(listCDs, typeof(CDs), filePathCDs);
           
            
            return listCDs;
        }
        public void AddCDsToCSV(CDs cd)
        {
            SaveToCSV.AddToCSV(cd, typeof(CDs), StartForm.filePathCDs); 
        }

        public void UpdateCDsInCSV(CDs book, List<CDs> cdlist)
        {
            SaveToCSV.UpdateFromCSV(typeof(CDs), StartForm.filePathCDs, cdlist);
        }


    }
}
