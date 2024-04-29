using Library_s_Lending_Administration.Lending;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_s_Lending_Administration
{
    public class Cartoons
    {
        private static List<Cartoons> listCartoons = new List<Cartoons>();
       
        public List<Cartoons> getListCartoons()
        {
            return listCartoons;
        }

        public void addListCartoons(Cartoons book)
        {
            listCartoons.Add(book);
        }
        public void removeListCartoons(Cartoons book)
        {
            listCartoons.Remove(book);
        }
        public Guid Id { get; set; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Author { set; get; }

        public int Max_Days_for_Lending { set; get; }


        public DateTime RendingDate { set; get; }

        public StartForm.StatusType Status_for_Lending { set; get; }

        public Cartoons() { }

        public Cartoons(int max_Days_for_Lending)
        {
            Max_Days_for_Lending = max_Days_for_Lending;
        }

        public Cartoons(Guid id, string title, string description, string author, int max_Days_for_Lending, DateTime rendingDate, StartForm.StatusType type)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Max_Days_for_Lending = max_Days_for_Lending;
            RendingDate = rendingDate;
           Status_for_Lending = (StartForm.StatusType)type;

        }

       
        
        public List<Cartoons> readCartoonsCSV()
        {
            string filePathCartoons = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, StartForm.filePathCartoons);

            listCartoons = LendingShared.ReadCSV(listCartoons, typeof(Cartoons), filePathCartoons); 

            return listCartoons;
        }

        public void AddCartoonsToCSV(Cartoons cartoon)
        {
            SaveToCSV.AddToCSV(cartoon, typeof(Cartoons), StartForm.filePathCartoons);
           
        }
        public void UpdateCartoonsInCSV(Cartoons book, List<Cartoons> cartoonlist)
        {
            SaveToCSV.UpdateFromCSV(typeof(Cartoons), StartForm.filePathCartoons, cartoonlist);
        }

    }
}
