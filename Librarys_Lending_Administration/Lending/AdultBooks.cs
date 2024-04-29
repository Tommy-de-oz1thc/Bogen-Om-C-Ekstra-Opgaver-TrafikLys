using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library_s_Lending_Administration.Person;



namespace Library_s_Lending_Administration.Lending
{
    public class AdultBooks
    {
        private static List<AdultBooks> listAdultBooks = new List<AdultBooks>(); 
              
        
      
        public Guid Id { get; set; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Author { set; get; }

        public int Max_Days_for_Lending { set; get; }


        public DateTime RendingDate { set;get; }

        public StartForm.StatusType Status_for_Lending { set; get; }

        public AdultBooks() { }

        public AdultBooks(int max_Days_for_Lending)
        {
           Max_Days_for_Lending = max_Days_for_Lending;
        }

        public AdultBooks(Guid id, string title, string description, string author, int max_Days_for_Lending, DateTime rendingDate,StartForm.StatusType type )
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Max_Days_for_Lending = max_Days_for_Lending;
            RendingDate = rendingDate;
           Status_for_Lending = (StartForm.StatusType)type;
            
        }
        public void ClearList()
        {
            listAdultBooks.Clear();
        }
        public List<AdultBooks> getListAdultBooks()
        {
            return listAdultBooks;
        }
        public void addListAdultBooks(AdultBooks book)
        {
            listAdultBooks.Add(book);
        }
        public void removeListAdultBooks(AdultBooks book)
        {
            listAdultBooks.Remove(book);
        }

        public StartForm.StatusType GetStatus_for_Lending()
        {
            return Status_for_Lending;
        }

        public List<AdultBooks> readAdultBooksCSV()
        {
            string filePathAdultBooks = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/AdultBooks.csv");

            listAdultBooks = LendingShared.ReadCSV(listAdultBooks, typeof(AdultBooks), filePathAdultBooks);
            
            return listAdultBooks;
        }

        public void AddAdultBooksToCSV(AdultBooks book)
        {
            SaveToCSV.AddToCSV(book, typeof(AdultBooks), StartForm.filePathAdultBooks);
        }




        public void UpdateAdultBooksInCSV(AdultBooks book, List<AdultBooks> booklist)
        {
            SaveToCSV.UpdateFromCSV(typeof(AdultBooks), StartForm.filePathAdultBooks, booklist);
        }

    }
}
