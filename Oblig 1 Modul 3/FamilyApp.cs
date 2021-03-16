using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oblig_1_Modul_3
{
    public class FamilyApp
    {
        public string CommandPrompt = "hjelp => viser en hjelpetekst som forklarer alle kommandoene\n liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert.\n vis <id> => viser en bestemt person med mor, far og barn (og id for disse, slik at man lett kan vise en av dem)\n";
        public string WelcomeMessage = "Hei";
        private List<Person> _people;
        public FamilyApp(params Person[] family)
        {
            _people = new List<Person>(family);
        }

        public string HandleCommand(string command)
        {
            command = command.ToLower();
            if (command == "liste")
            {
               return ShowFamily();
                
            }

            if (command.Contains("vis "))
            {
                return showPerson(command);
            }
            return "Feil kommando";
        }

        private string showPerson(string command)
        {
            var returnString = "";
            int index = Int32.Parse(command.Substring(4));
            returnString = GetPersonAndChildren(index);
            return returnString;

        }

        private string GetPersonAndChildren(int index)
        {
            var PersonAndChildren = "";
            foreach (var p in _people)
            {
                if (index == p.Id)
                {
                    PersonAndChildren +=
                        $"{p.FirstName} {p.LastName}(Id={p.Id}) Født: {p.BirthYear} Far: {p.Father.FirstName} (Id={p.Father.Id})\n";
                    PersonAndChildren += FindChildren(p);
                }
            }
            return PersonAndChildren;
        }

        private string FindChildren(Person person)
        {
            var returnString = "";
            var Children = "";
            foreach (var p in _people)
            {
                if (p.Father != null )
                {
                    if (p.Father.Id == person.Id)
                    {
                        Children += printChildren(p);
                    }
                }

                if (p.Mother == null) continue;
                if (p.Mother.Id == person.Id)
                {
                    Children += printChildren(p);
                }
            }

            if (Children == "") return returnString;
            returnString += "  Barn:\n";
            returnString += Children;
            return returnString;
        }

        private string printChildren(Person p)
        {
            return $"    {p.FirstName} {p.LastName}(Id={p.Id}) Født: {p.BirthYear}\n";
        }


        private string ShowFamily()
        {
            var familyString = "";
            foreach (var person in _people)
            {
                familyString += person.GetDescription();
                familyString += "\n";
            }

            return familyString;
        }
    }
}
