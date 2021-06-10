using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Information
{
    class Person
    {

        // Constructor to initalize values
        // Properties sets the variable names to their designated variable type
        public Person()
        {
             lastName = "";
             firstName = "";
             address = "";
             city = "";
             state = "";
             zip = "";
             phone = "";
        }

        // Methods
        // In C# "get" has the "return" method built in
        // The Property name and the Varable name must be the same
        // this way the Methods know which variable they are dealing with
        // For example the get and set Methods for "lastName" know they are
        // for the "lastName" variable from the Constructor because it shares the same
        // name with said variable. 
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }


    }

}
