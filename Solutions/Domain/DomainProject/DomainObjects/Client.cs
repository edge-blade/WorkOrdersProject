using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainProject.DomainObjects
{
    public class Client
    {
        public int ClientId { get; set; }
        public ISet<ClientLocation> ClientLocations { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
