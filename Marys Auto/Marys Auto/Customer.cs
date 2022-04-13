using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marys_Auto
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerStreetAddress { get; set; }
        public string CustomerCity { get; set; }    
        public string CustomerState { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public List<Customer> CustomersList { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
