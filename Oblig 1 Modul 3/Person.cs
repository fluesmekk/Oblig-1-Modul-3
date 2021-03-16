using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig_1_Modul_3
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int? BirthYear;
        public int? DeathYear;
        public Person Father;
        public Person Mother;
        public int? Id;


        public string GetDescription()
        {
            string description = "";
            if (FirstName != null) description += $"{FirstName} ";
            if (LastName != null) description += $"{LastName} ";
            if (Id != null) description += $"(Id={Id}) ";
            if (BirthYear != null) description += $"Født: {BirthYear} ";
            if (DeathYear != null) description += $"Død: {DeathYear} ";
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
