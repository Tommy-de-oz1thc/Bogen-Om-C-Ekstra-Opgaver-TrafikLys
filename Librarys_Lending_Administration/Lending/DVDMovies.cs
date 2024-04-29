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
    public class DVDMovies
    {
        private static List<DVDMovies> listDVDMovies = new List<DVDMovies>();
       
        public Guid Id { get; set; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Author { set; get; }

        public int Max_Days_for_Lending = 7;

        public DateTime RendingDate { set; get; }

        public StartForm.StatusType Status_for_Lending { set; get; }
        public DVDMovies() { }

        public DVDMovies(int max_Days_for_Lending)
        {
            Max_Days_for_Lending = max_Days_for_Lending;
        }

        public DVDMovies(Guid id, string title, string description, string author, int max_Days_for_Lending, DateTime rendingDate, StartForm.StatusType type)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Max_Days_for_Lending = max_Days_for_Lending;
            RendingDate = rendingDate;
           Status_for_Lending = (StartForm.StatusType)type;

        }
        public List<DVDMovies> getListDVDMovies()
        {
            return listDVDMovies;
        }
        public void addListDVDMovies(DVDMovies dvd)
        {
            listDVDMovies.Add(dvd);
        }
        public void removeListDVDMovies(DVDMovies dvd)
        {
            listDVDMovies.Remove(dvd);
        }

        public StartForm.StatusType GetStatus_for_Lending()
        {
            return Status_for_Lending;
        }

        public List<DVDMovies> readDVDMoviesCSV()
        {
            string filePathDVDMovies = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, StartForm.filePathDVDMovies);

            listDVDMovies = LendingShared.ReadCSV(listDVDMovies, typeof(DVDMovies), filePathDVDMovies);
           
            return listDVDMovies;
        }
        public void AddDVDMoviesToCSV(DVDMovies dvd)
        {
            SaveToCSV.AddToCSV(dvd, typeof(DVDMovies), StartForm.filePathDVDMovies);
        }

        public void UpdateDVDMoviesInCSV(DVDMovies user, List<DVDMovies> dvdlist)
        {
            SaveToCSV.UpdateFromCSV(typeof(DVDMovies), StartForm.filePathDVDMovies, dvdlist);
        }
      
    }
}
