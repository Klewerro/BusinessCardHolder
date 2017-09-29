using BusinessCardHolder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardHolder.Actions
{
    public class SearchEnginePerson
    {
        public List<Person> SearchPersonAnyWord(string[] Terms)
        {
            using (var context = new BusinessCardContext())
            {
                var query = from p in context.Person
                            where (Terms.Any(x => p.Name.Contains(x)) ||
                            (Terms.Any(x => p.Forename.Contains(x)) ||
                            (Terms.Any(x => p.Email.Contains(x)))))
                            select p;
                return query.ToList();
            }
        }

        public List<Person> SearchPersonAnyWord(string name, string forename, string email, string firmname)
        {
            using (var context = new BusinessCardContext())
            {
                var list = new List<Person>();

                if (string.IsNullOrWhiteSpace(name))
                    name = "";
                if (string.IsNullOrWhiteSpace(forename))
                    forename = "";
                if (string.IsNullOrWhiteSpace(email))
                    email = "";
                if (string.IsNullOrWhiteSpace(firmname))
                    firmname = "";
                name = name.Replace(" ", String.Empty);
                forename = forename.Replace(" ", String.Empty);
                email = email.Replace(" ", String.Empty);
                firmname = firmname.Replace(" ", String.Empty);

                foreach (var person in context.Person)
                {
                    person.FirmName = person.Firm.Name;

                    if (person.Name.Contains(name) && person.Forename.Contains(forename)
                        && person.Email.Contains(email) && person.FirmName.Contains(firmname))
                    {
                        
                        list.Add(person);
                    }
                }
                return list;
            }
        }

        public List<Person> SearchPersonAnyWord(string name, string forename, string email, Firm firm)
        {
            using (var context = new BusinessCardContext())
            {
                var list = new List<Person>();

                if (string.IsNullOrWhiteSpace(name))
                    name = "";
                if (string.IsNullOrWhiteSpace(forename))
                    forename = "";
                if (string.IsNullOrWhiteSpace(email))
                    email = "";

                name = name.Replace(" ", String.Empty);
                forename = forename.Replace(" ", String.Empty);
                email = email.Replace(" ", String.Empty);

                foreach (var person in context.Person.Where(x => x.Firm.FirmId == firm.FirmId))
                {

                    if (person.Name.Contains(name) && person.Forename.Contains(forename)
                        && person.Email.Contains(email))
                    {

                        list.Add(person);
                    }
                }
                return list;
            }
        }

        public List<Person> SearchPersonByName(string term)
        {
            using (var context = new BusinessCardContext())
            {
                var list = context.Person.Where(x => x.Name == term).ToList();
                return list;
            }
        }
    }
}
