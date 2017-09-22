using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCardHolder.Entities;

namespace BusinessCardHolder.Actions
{
    /// <summary>
    /// Contain methods using to operate on Persons (with employees) table in database
    /// </summary>
    public class PersonActions
    {
        public PersonActions()
        {
        }

        public List<Person> DownloadAllPersonsIntoList()
        {
            using (var context = new BusinessCardContext())
            {
                var persons = context.Person.Select(n => n).ToList();
                return persons;
            }
        }

        public Person DownloadSinglePerson(int idProp)
        {
            using(var context = new BusinessCardContext())
            {
                    Person person = context.Person.Find(idProp);
                    return person;
            }
        }
        public Person DownloadSinglePerson(string nameProp)
        {
            using(var context = new BusinessCardContext())
            {
                Person person = context.Person.Where(x => x.Name == nameProp).FirstOrDefault();
                return person;
            }
        }

        public List<Person> DownloadPersonsForFirm(Firm firmProp)
        {
            using (var context = new BusinessCardContext())
            {
                //Lazy Loading
                List<Person> peopleList = context.Person.Where(x => x.Firm.FirmId == firmProp.FirmId + 1).ToList();
                return peopleList;
            }
        }


        public void Add(string forename, string name, string phone, string cellPhone, string email, DateTime birthDate)
        {
            Person person = new Person()
            {
                Forename = forename,
                Name = name,
                Phone = phone,
                CellPhone = cellPhone,
                Email = email,
                BithDate = birthDate
            };

            using (var context = new BusinessCardContext())
            {
                context.Person.Add(person);
                context.SaveChanges();
            }
        }

        public void Add(Person personProp)
        {
            using(var context = new BusinessCardContext())
            {
                context.Person.Add(personProp);
                context.SaveChanges();
            }
        }

        public void AddNewPersonToFirm(Person personProp, int firmIdProp)
        {
            using(var context = new BusinessCardContext())
            {
                Firm firm = context.Firm.Find(firmIdProp);
                firm.Employees.Add(personProp);
                context.SaveChanges();
            }
        }

        

        public void AddExistingPersonToFirm(int personIdProp, int firmIdProp)
        {
            using(var context = new BusinessCardContext())
            {
                Firm firm = context.Firm.Find(firmIdProp);
                Person person = context.Person.Find(personIdProp);
                firm.Employees.Add(person);
                context.SaveChanges();
            }
        }

        public void AddExistingPersonToFirm(string personNameProp, string firmNameProp)
        {
            using(var context = new BusinessCardContext())
            {
                Firm firm = context.Firm.Where(x => x.Name == firmNameProp).FirstOrDefault();
                Person person = context.Person.Where(x => x.Name == personNameProp).FirstOrDefault();
                firm.Employees.Add(person);
                context.SaveChanges();
            }
        }

        public void AddExistingPersonToFirm(Person personProp, Firm firmProp)
        {
            using(var context = new BusinessCardContext())
            {
                Firm firm = context.Firm.Find(firmProp.FirmId);
                Person person = context.Person.Find(personProp.PersonId);
                firm.Employees.Add(person);
                context.SaveChanges();
            }
        }

        public void RemovePerson(string nameProp)
        {
            using(var context = new BusinessCardContext())
            {
                Person person = context.Person.Where(x => x.Name == nameProp).FirstOrDefault();
                context.Person.Remove(person);
                context.SaveChanges();
            }
        }
        public void RemovePerson(int idProp)
        {
            using(var context = new BusinessCardContext())
            {
                Person person = context.Person.Find(idProp);
                context.Person.Remove(person);
                context.SaveChanges();
            }
        }

        public void RemovePersonsRange(List<Person> personsList)
        {
            using(var context = new BusinessCardContext())
            {
                context.Person.RemoveRange(personsList);
                context.SaveChanges();
            }
        }
        
        public void RemoveAllEmployeesFromFirm(Firm firmProp)
        {
            using(var context = new BusinessCardContext())
            {
                var listToRemove = new List<Person>();
                listToRemove = context.Person.Where(x => x.Firm.FirmId == firmProp.FirmId).ToList<Person>();
                context.Person.RemoveRange(listToRemove);
                context.SaveChanges();
            }
        }
        public void RemoveAllEmployeesFromFirm(int idProp)
        {
            using (var context = new BusinessCardContext())
            {
                var listToRemove = new List<Person>();
                listToRemove = context.Person.Where(x => x.Firm.FirmId == idProp).ToList<Person>();
                context.Person.RemoveRange(listToRemove);
                context.SaveChanges();
            }
        }


    }
}
