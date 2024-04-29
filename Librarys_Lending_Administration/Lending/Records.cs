using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_s_Lending_Administration.Lending
{
    public class Records
    {
        private static List<Records> listRecords = new List<Records>();

        public Guid Id { get; set; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Author { set; get; }

        public int Max_Days_for_Lending = 7;

        public DateTime RendingDate { set; get; }

        public StartForm.StatusType Status_for_Lending { set; get; }

        public Records() { }

        public Records(int max_Days_for_Lending)
        {
            Max_Days_for_Lending = max_Days_for_Lending;
        }

        public Records(Guid id, string title, string description, string author, int max_Days_for_Lending, DateTime rendingDate, StartForm.StatusType type)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Max_Days_for_Lending = max_Days_for_Lending;
            RendingDate = rendingDate;
            Status_for_Lending = (StartForm.StatusType)type;

        }
        public List<Records> getListRecords()
        {
            return listRecords;
        }
        public void addListRecords(Records rec)
        {
            listRecords.Add(rec);
        }
        public void removeListRecords(Records rec)
        {
            listRecords.Remove(rec);
        }

        public StartForm.StatusType GetStatus_for_Lending()
        {
            return Status_for_Lending;
        }

        public List<Records> readRecordsCSV()
        {
            string filePathRecords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, StartForm.filePathRecords);

            listRecords = LendingShared.ReadCSV(listRecords, typeof(Records), filePathRecords);


            return listRecords;
        }
        public void AddRecordsToCSV(Records rec)
        {
            SaveToCSV.AddToCSV(rec, typeof(Records), StartForm.filePathRecords);
        }

        public void UpdateRecordsInCSV(Records user, List<Records> reclist)
        {
            SaveToCSV.UpdateFromCSV(typeof(Records), StartForm.filePathRecords, reclist);
        }
        
    }
}
