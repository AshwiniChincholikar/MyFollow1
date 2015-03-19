using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.Models
{
    class ProductOwner
    {
        private string companyName;
        private string description;
        private string foundedIn;
        private string websiteUrl;
        private string twitterUrl;
        private string fbUrl;


        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string FoundedIn
        {
            get { return foundedIn; }
            set { foundedIn = value; }
        }
        public string WebsiteUrl
        {
            get { return websiteUrl; }
            set { websiteUrl = value; }
        }
        public string TwitterUrl
        {
            get { return twitterUrl; }
            set { twitterUrl = value; }
        }

        public string FbUrl
        {
            get { return fbUrl; }
            set { fbUrl = value; }
        }
    }
}
