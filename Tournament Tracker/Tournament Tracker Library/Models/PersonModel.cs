using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker_Library.Models
{
    public class PersonModel
    {
        public PersonModel()
        {
        }

        public PersonModel(string firstName, string lastName, string email, string cellphone)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
            CellphoneNumber = cellphone; ;
        }

        /// <summary>
        /// The unique indetifier for the person.
        /// </summary>
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellphoneNumber { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
