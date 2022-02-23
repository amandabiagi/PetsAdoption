using PetsAdoption.Domain.Entities.Enum;
using PetsAdoption.Domain.Entities.Validation;
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
        public int InstituteId { get; set; }
        public Institute Institute { get; set; }


        public Pet(
            string name,
            PetTypeEnum type,
            int year,
            int months,
            PetSexEnum sex,
            PetSexEnum size,
            string breed)
        {

            ValidationPets(name, type, year, months, sex, size, breed);
        }

        public Pet(
          int id,
          string name,
          PetTypeEnum type,
          int year,
          int months,
          PetSexEnum sex,
          PetSexEnum size,
          string breed)
        {
            DomainExceptionValidation.When(id < 0, "Invalid ID value. ");
            ValidationPets(name, type, year, months, sex, size, breed);
        }

        public void Update(
         string name,
         PetTypeEnum type,
         int year,
         int months,
         PetSexEnum sex,
         PetSexEnum size,
         string breed,
         int instituteId)
        {

            ValidationPets(name, type, year, months, sex, size, breed);
            InstituteId = instituteId;
        }

        private void ValidationPets(
            string name,
            PetTypeEnum type,
            int year,
            int months,
            PetSexEnum sex,
            PetSexEnum size,
            string breed
            )
        {
            DomainExceptionValidation.When(name.Length <= 1,
                                            "Invalid name, too short, minimum 2 caracteres");
            DomainExceptionValidation.When(name.Length > 10,
                                            "Invalid name, too long, maximum 10 caracteres");
            DomainExceptionValidation.When(type == null, 
                                            "Invalid type, Type is required");
            DomainExceptionValidation.When(year < 0,
                                            "Invalid year value");
            DomainExceptionValidation.When(months < 0,
                                            "Invalid monthes value");
            DomainExceptionValidation.When(sex == null, 
                                            "Invalid sex, Sex is required");
            DomainExceptionValidation.When(size == null,        
                                            "Invalid size, Size is required");
            DomainExceptionValidation.When(breed.Length > 25, 
                                            "Invalid breed, too long, maximum 25 caracteres");

            Name = name;
            Type = type;
            Year = year;
            Months = months;
            Sex = sex;
            Size = (PetSizeEnum)size;
            Breed = breed;


        }

    }
}
