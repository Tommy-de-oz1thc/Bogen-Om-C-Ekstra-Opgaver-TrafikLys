using Library_s_Lending_Administration.Lending;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_s_Lending_Administration.Lending
{
    public class ChildrenBooks
    {
        private List<ChildrenBooks> listChildrenBooks = new List<ChildrenBooks>();
       
        public List<ChildrenBooks> getListChildrenBooks()
        {
            return listChildrenBooks;
        }
        public Guid Id { get; set; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Author { set; get; }

        public int Max_Days_for_Lending { set; get; }


        public DateTime RendingDate { set; get; }

        public StartForm.StatusType Status_for_Lending { set; get; }

        public ChildrenBooks(int max_Days_for_Lending)
        {
            Max_Days_for_Lending = max_Days_for_Lending;
        }
        public ChildrenBooks() { }

        public ChildrenBooks(Guid id, string title, string description, string author, int max_Days_for_Lending, DateTime rendingDate, StartForm.StatusType type)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Max_Days_for_Lending = max_Days_for_Lending;
            RendingDate = rendingDate;
            Status_for_Lending = (StartForm.StatusType)type;

        }
        
        public void addListChildrenBooks(ChildrenBooks book)
        {
            listChildrenBooks.Add(book);
        }
        public void removeListChildrenBooks(ChildrenBooks book)
        {
            listChildrenBooks.Remove(book);
        }

        public StartForm.StatusType GetStatus_for_Lending()
        {
            return Status_for_Lending;
        }

        
        public List<ChildrenBooks> readChildrenBooksCSV()
        {
            string filePathChildrenBooks = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, StartForm.filePathChildrenBooks);

            listChildrenBooks = LendingShared.ReadCSV(listChildrenBooks, typeof(ChildrenBooks), filePathChildrenBooks);

            
            return listChildrenBooks;
        }

        public void AddChildrenBooksToCSV(ChildrenBooks book)
        {
            SaveToCSV.AddToCSV(book, typeof(ChildrenBooks), StartForm.filePathChildrenBooks);
        }

        public void UpdateChildrenBooksInCSV(ChildrenBooks user, List<ChildrenBooks> booklist)
        {
            SaveToCSV.UpdateFromCSV(typeof(ChildrenBooks), StartForm.filePathChildrenBooks, booklist);
        }

        
    }
}
