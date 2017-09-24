using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCardHolder.Entities;

namespace BusinessCardHolder.Actions
{
    /// <summary>
    /// Contain CRUD(create, read, update and delete) methods using to operate on Persons (Employees) table in database
    /// </summary>
    public class PersonActions
    {
        public PersonActions()
        {
        }

        /// <summary>
        /// Reading all persons from database
        /// </summary>
        /// <returns>Returning persons into List</returns>
        public List<Person> ReadPersons()
        {
            using (var context = new BusinessCardContext())
            {
                var persons = context.Person.Select(n => n).ToList();
                return persons;
            }
        }

        /// <summary>
        /// Reading single person from database
        /// </summary>
        /// <param name="idProp">Id of person</param>
        /// <returns></returns>
        public Person ReadPerson(int idProp)
        {
            using(var context = new BusinessCardContext())
            {
                    Person person = context.Person.Find(idProp);
                    return person;
            }
        }
        /// <summary>
        /// Reading single person from database
        /// </summary>
        /// <param name="nameProp">Name of person</param>
        /// <returns></returns>
        public Person ReadPerson(string nameProp)
        {
            using(var context = new BusinessCardContext())
            {
                Person person = context.Person.Where(x => x.Name == nameProp).FirstOrDefault();
                return person;
            }
        }

        public List<Person> ReadPersonsForFirm(Firm firmProp)
        {
            //using (var context = new BusinessCardContext())
            //{
            //    //Lazy Loading
            //    //List<Person> peopleList = context.Person.Where(x => x.Firm.FirmId == firmProp.FirmId + 1).ToList();
            //    List<Person> peopleList = new List<Person>();
            //    foreach (var item in context.Firm)
            //    {
            //        peopleList.Add(item.Employees);
            //    }
            //    return peopleList;
            //}
            using (var context = new BusinessCardContext())
            {
                var employeesList = context.Person.Where(x => x.Firm.FirmId == firmProp.FirmId).ToList();
                return employeesList;
            }
        }
        public List<Person> ReadPersonsForFirm(int firmIdProp)
        {
            using (var context = new BusinessCardContext())
            {
                var employeesList = context.Person.Where(x => x.Firm.FirmId == firmIdProp).ToList();
                return employeesList;
            }
        }


        public void CreatePerson(string forename, string name, string phone, string cellPhone, string email, DateTime birthDate)
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

        public void CreatePerson(Person personProp)
        {
            using(var context = new BusinessCardContext())
            {
                context.Person.Add(personProp);
                context.SaveChanges();
            }
        }
        
        public void CreatePersonAndAddToFirm(Person personProp, int firmIdProp)
        {
            using(var context = new BusinessCardContext())
            {
                Firm firm = context.Firm.Find(firmIdProp);
                firm.Employees.Add(personProp);
                context.SaveChanges();
            }
        }
        

        public void DeletePerson(string nameProp)
        {
            using(var context = new BusinessCardContext())
            {
                Person person = context.Person.Where(x => x.Name == nameProp).FirstOrDefault();
                context.Person.Remove(person);
                context.SaveChanges();
            }
        }
        public void DeletePerson(int idProp)
        {
            using(var context = new BusinessCardContext())
            {
                Person person = context.Person.Find(idProp);
                context.Person.Remove(person);
                context.SaveChanges();
            }
        }

        public void DeletePersonsRange(int startId, int stopId)
        {         
            using(var context = new BusinessCardContext())
            {
                var ppleToDelete = new List<Person>();
                for (int i = startId; i < stopId+1; i++)
                {
                    ppleToDelete.Add(context.Person.Find(i));
                }
                context.Person.RemoveRange(ppleToDelete);
                context.SaveChanges();
            }
        }
        
        public void DeleteAllEmployeesFromFirm(Firm firmProp)
        {
            using(var context = new BusinessCardContext())
            {
                var listToRemove = new List<Person>();
                listToRemove = context.Person.Where(x => x.Firm.FirmId == firmProp.FirmId).ToList<Person>();
                context.Person.RemoveRange(listToRemove);
                context.SaveChanges();
            }
        }
        public void DeleteAllEmployeesFromFirm(int idProp)
        {
            using (var context = new BusinessCardContext())
            {
                var listToRemove = new List<Person>();
                listToRemove = context.Person.Where(x => x.Firm.FirmId == idProp).ToList();
                context.Person.RemoveRange(listToRemove);
                context.SaveChanges();
            }
        }

        
        public void UpdatePerson(Person personProp)
        {
            using (var context = new BusinessCardContext())
            {
                //var person = context.Person.Find(personProp.PersonId);
                var person = context.Person.Where(x => x.PersonId == personProp.PersonId).FirstOrDefault();
                person.Forename = personProp.Forename;
                person.Name = personProp.Name;
                person.Phone = personProp.Phone;
                person.CellPhone = personProp.CellPhone;
                person.Email = personProp.Email;
                person.BithDate = personProp.BithDate;

                context.SaveChanges();
            }
        }
        public void UpdatePerson(int idProp, Person personProp)
        {
            using (var context = new BusinessCardContext())
            {
                var person = context.Person.Find(idProp);
                person.Forename = personProp.Forename;
                person.Name = personProp.Name;
                person.Phone = personProp.Phone;
                person.CellPhone = personProp.CellPhone;
                person.Email = personProp.Email;
                person.BithDate = personProp.BithDate;

                context.SaveChanges();
            }
        }

    }
}
