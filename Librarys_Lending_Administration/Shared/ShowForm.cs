using Library_s_Lending_Administration.Lending;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library_s_Lending_Administration.Lending.AdultBooks;

namespace Library_s_Lending_Administration.Shared
{
    public partial class ShowForm : Form
    {
        Lendings lendings = new Lendings();
        List<Lendings> localLen = new List<Lendings>();
        List<Lendings> lends = new List<Lendings>();
        private Person _user = new Person();
        private AdultBooks adultBooks = new AdultBooks();
        private ChildrenBooks childrenBooks = new ChildrenBooks();
        private Cartoons cartoons = new Cartoons();
        private CDs cds = new CDs();
        private DVDMovies dvds = new DVDMovies();    
        private Records records = new Records();
        private List<AdultBooks> listAdultBooks = new List<AdultBooks>();
        private List<ChildrenBooks> listChildrenBooks = new List<ChildrenBooks>();
        private List<Cartoons> listCartoons = new List<Cartoons>();
        private List<CDs> listCDs = new List<CDs>();
        private List<DVDMovies> listDVDMovies = new List<DVDMovies>();
        private List<Records> listRecords = new List<Records>();
        private Payments payment = new Payments();
        private List<Payments> listPayment = new List<Payments>();


        public ShowForm(Person user)
        {
            _user = user;
            InitializeComponent();
            listBoxShow.Items.Clear();
            
            fillShowList();
        }

        private void fillShowList()
        {
            listBoxShow.Items.Clear();
            lends = lendings.readLendingsCSV();

            foreach (Lendings l in lends)
            {
                if(_user.Type_Of_User.ToString() == "Admin")
                {
                    listBoxShow.Items.Add($"ID: {l.LendingId}, Username: {l.Username}, \tAuthor: {l.Author}, \tRendingDate: {l.RendingDate.ToString("dd-MM-yyyy")}, \tTitle: {l.Title}");

                }
                else if (_user.UserId == l.UserId)
                {
                    listBoxShow.Items.Add($"ID: {l.LendingId}, Username: {l.Username}, \tAuthor: {l.Author}, \tRendingDate: {l.RendingDate.ToString("dd-MM-yyyy")}, \tTitle: {l.Title}");
                    localLen.Add(l);
                }


            }
        }

        private void listBoxShow_Click(object sender, EventArgs e)
        {
            string alltext = listBoxShow.Text;
            string[] text = alltext.Split(',');
            Guid subtext = Guid.Parse(text[0].Substring(4));
            string title = text[4].Substring(8);
           // lends = lendings.readLendingsCSV();
           
            foreach (Lendings l in lends)
            {
               

                if ((l.LendingId == subtext) && (l.Title.Trim() == title.Trim()))
                {
                    txtTitle.Text = l.Title;
                    txtDescription.Text = l.Description;
                    txtAuthor.Text = l.Author;
                    txtUser.Text = l.Username;
                    comboBoxPaymentType.Text = l.PaymentType.ToString();
                    txtRendingDate.Text = l.RendingDate.ToString("dd-MM-yyyy");
                }

            }

            if (_user.Type_Of_User.ToString() == "User")
            {
                btnReturn.Visible = true;
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            btnReturn.Visible = false;
            string alltext = listBoxShow.Text;
            string[] text = alltext.Split(',');
            Guid subtext = Guid.Parse(text[0].Substring(4));
            string title = text[4].Substring(8);
            string type = "";
            DateTime dateTime = DateTime.Now;
            DateTime rendingDate = new DateTime();
            Guid itemId = new Guid();
            Lendings p = new Lendings();
            foreach (Lendings l in lends) 
            {
                if ((l.LendingId == subtext) && (l.Title.Trim() == title.Trim()))
                {
                    p = l;
                    itemId = l.Id_for_Lending;
                    type = l.PaymentType.ToString();
                    
                    rendingDate = l.RendingDate;
                }

            }
           
           
            lendings.DeleteLendingsFromCSV(p, lends);
            lendings.removeListLendings(p);
            TimeSpan days = dateTime - rendingDate;
            int totaldays = days.Days;
            bool tolate = false;
            int price = 0;
            listPayment = payment.getListPayment();
            switch (type)
            {
                case "AdultBooks":
                    List<AdultBooks> books1 = adultBooks.getListAdultBooks();
                    
                    foreach (AdultBooks b1 in books1)
                    {
                        if (b1.Id == itemId)
                        {
                            b1.Status_for_Lending = (StartForm.StatusType)StartForm.StatusType.Home;
                            
                        }
                    }
                    
                    foreach (Payments l1 in listPayment)
                    {
                        if (l1.PaymentType.ToString() == "AdultBooks")
                        if (l1.daysLong < totaldays)
                        { price = l1.ToLateLong; }
                        else if (l1.daysLate < totaldays)
                        { price = l1.ToLate; }                     
                    }
                    
                    break;
                case "ChildrenBooks":
                    List<ChildrenBooks> books2 = childrenBooks.getListChildrenBooks();
                   
                    foreach (ChildrenBooks b2 in books2)
                    {
                        if (b2.Id == itemId)
                        {
                            b2.Status_for_Lending = (StartForm.StatusType)StartForm.StatusType.Home;
                          
                        }
                    }
                    foreach (Payments l1 in listPayment)
                    {
                        if (l1.PaymentType.ToString() == "ChildrenBooks")
                            if (l1.daysLong < totaldays)
                            { price = l1.ToLateLong; }
                            else if (l1.daysLate < totaldays)
                            { price = l1.ToLate; }
                    }
                    break;
                case "Cartoons":
                    List<Cartoons> books3 = cartoons.getListCartoons();
                   
                    foreach (Cartoons b3 in books3)
                    {
                        if (b3.Id == itemId)
                        {
                            b3.Status_for_Lending = (StartForm.StatusType)StartForm.StatusType.Home;
                           
                        }
                    }
                    foreach (Payments l1 in listPayment)
                    {
                        if (l1.PaymentType.ToString() == "Cartoons")
                            if (l1.daysLong < totaldays)
                            { price = l1.ToLateLong; }
                            else if (l1.daysLate < totaldays)
                            { price = l1.ToLate; }
                    }
                    break;
                case "DVDMovies":
                    List<DVDMovies> books4 = dvds.getListDVDMovies();
                   
                    foreach (DVDMovies b4 in books4)
                    {
                        if (b4.Id == itemId)
                        {
                            b4.Status_for_Lending = (StartForm.StatusType)StartForm.StatusType.Home;
                            
                        }
                    }
                    foreach (Payments l1 in listPayment)
                    {
                        if (l1.PaymentType.ToString() == "DVDMovies")
                            if (l1.daysLong < totaldays)
                            { price = l1.ToLateLong; }
                            else if (l1.daysLate < totaldays)
                            { price = l1.ToLate; }
                    }
                    break;
                case "CDs":
                    List<CDs> books5 = cds.getListCDs();
                   
                    foreach (CDs b5 in books5)
                    {
                        if (b5.Id == itemId)
                        {
                            b5.Status_for_Lending = (StartForm.StatusType)StartForm.StatusType.Home;
                           
                        }
                    }
                    foreach (Payments l1 in listPayment)
                    {
                        if (l1.PaymentType.ToString() == "CDs")
                            if (l1.daysLong < totaldays)
                            { price = l1.ToLateLong; }
                            else if (l1.daysLate < totaldays)
                            { price = l1.ToLate; }
                    }
                    break;
                case "Reords":
                    List<Records> books6 = records.getListRecords();
                   
                    foreach (Records b6 in books6)
                    {
                        if (b6.Id == itemId)
                        {
                            b6.Status_for_Lending = (StartForm.StatusType)StartForm.StatusType.Home;
                          
                        }
                    }
                    foreach (Payments l1 in listPayment)
                    {
                        if (l1.PaymentType.ToString() == "Records")
                            if (l1.daysLate < totaldays)
                            { price = l1.ToLateLong; }
                            else if (l1.daysLate < totaldays)
                            { price = l1.ToLate; }
                    }
                    break;
                }
            btnReturn.Visible = false;
            if (price > 0)
            {
                MessageBox.Show($"You have to pay {price}$ \nbecause you had returned the item too late.");

            }
            fillShowList();
        }
        
    }
}
