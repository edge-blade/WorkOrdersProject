using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainProject.DomainObjects
{
    public class ClientLocation
    {
        public int ClientLocationId { get; set; }
        public Client Client { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
