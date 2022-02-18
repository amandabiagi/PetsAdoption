using PetsAdoption.Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsAdoption.Domain.Entities
{
    internal class Pet
    {
        public string Name { get; set; }
        public PetTypeEnum Type { get; set; }
        public int Year { get; set; }
        public int Months { get; set; }
        public PetSexEnum Sex { get; set; }
        public PetSizeEnum Size { get; set; }
        public string Breed { get; set; }
        public Institute Institute { get; set; }

    }
}
