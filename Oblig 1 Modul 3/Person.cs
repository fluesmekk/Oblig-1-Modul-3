using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig_1_Modul_3
{
    public class Person
    {
        public string FirstName;
        public string LastName;
<<<<<<< HEAD
        public int? BirthYear;
        public int? DeathYear;
        public Person Father;
        public Person Mother;
        public int? Id;
=======
        public int BirthYear;
        public int DeathYear;
        public Person Father;
        public Person Mother;
        public int Id;
>>>>>>> 7a484b8a20c97eb7f560896ed9f72e08014909ba


        public string GetDescription()
        {
            string description = "";
            if (FirstName != null) description += $"{FirstName} ";
            if (LastName != null) description += $"{LastName} ";
<<<<<<< HEAD
            if (Id != null) description += $"(Id={Id}) ";
            if (BirthYear != null) description += $"Født: {BirthYear} ";
            if (DeathYear != null) description += $"Død: {DeathYear} ";
=======
            if (Id != 0) description += $"(Id={Id}) ";
            if (BirthYear != 0) description += $"Født: {BirthYear} ";
            if (DeathYear != 0) description += $"Død: {DeathYear} ";
>>>>>>> 7a484b8a20c97eb7f560896ed9f72e08014909ba
            if (Father != null)
            {
                if (Father.FirstName != null) description += $"Far: {Father.FirstName} ";
                if (Father.Id != 0) description += $"(Id={Father.Id}) ";
            }

            if (Mother != null)
            {
                if (Mother.FirstName != null) description += $"Mor: {Mother.FirstName} ";
                if (Mother.Id != 0) description += $"(Id={Mother.Id})";
            }

            description = description.Trim();

            return description;
        }
    }
}
