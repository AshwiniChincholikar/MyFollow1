using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.Models
{
    class User
    {
        private int id;
        private string email;
        private string dateOfJoining;
        private string password;
        private string contactNo;
        private Address address;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }
        
        public Address AddressObject
        {
            get { return address; }
            set { address = value; }
        }
    }
}
