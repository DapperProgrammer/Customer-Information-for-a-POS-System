using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Information
{
    class Customer : Person
    {
        // Constructor
        public Customer()
        {
            customerNumber = 0;
            mailingList = false;
            comments = "";
        }

        // Methods
        public int customerNumber {get; set; }
        public Boolean mailingList { get; set; }
        public string comments { get; set; }
    }
}
