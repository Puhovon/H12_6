using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H12_6
{
    internal class Client
    {
        public string FirstName { get; set; }
        public string MidleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportData { get; set; }
        public DateTime DateOfChange { get; set; }
        public string WhoChanged { get; set; }

        public Client(string firstName, string midleName, string lastName, string phoneNumber, string passportData, DateTime dateOfChange, string whoChanged)
        {
            FirstName = firstName;
            MidleName = midleName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            PassportData = passportData;
            DateOfChange = dateOfChange;
            WhoChanged = whoChanged;
        }
    }
}
