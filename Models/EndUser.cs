using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.Models
{
    class EndUser
    {
        private string gender;
        private string dateOfBirth;

        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public String DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
    }
}
