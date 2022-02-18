using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsAdoption.Domain.Entities
{
    internal class Address
    {
        public string StreetName { get; set; }
        public int Number { get; set; }
        public string Postcode { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
