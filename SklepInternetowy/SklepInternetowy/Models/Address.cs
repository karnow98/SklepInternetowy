using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public string City { get; set; }
        public string ZIPCode { get; set; }
        public string PostOfficePlace { get; set; }
        public string Street { get; set; }
        public string PhoneNumber { get; set; }
    }
}