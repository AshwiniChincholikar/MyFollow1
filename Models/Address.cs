using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.Models
{
    class Address
    {
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string pin;


        public string Street1
        {
            get { return street1; }
            set { street1 = value; }
        }

        public string Street2
        {
            get { return street2; }
            set { street2 = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }
    }
}
