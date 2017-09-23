using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCardHolder.Entities;

namespace BusinessCardHolder.Actions
{
    public class FirmPersonActions
    {
        private FirmActions firmActions = new FirmActions();
        private PersonActions personActions = new PersonActions();

        public void CreateNewFirmAndNewPerson(Firm firmProp, Person personProp)
        {
            using(var context = new BusinessCardContext())
            {
                context.Firm.Add(firmProp);
                firmProp.Employees.Add(personProp);
                context.SaveChanges();
            }
        }

        public void DeleteFirmAndEmployees(int firmIdProp)
        {
            personActions.DeleteAllEmployeesFromFirm(firmIdProp);
            firmActions.DeleteFirm(firmIdProp);
        }

        public void AddExistingPersonToExistingFirm(int personIdProp, int firmIdProp)
        {
            using (var context = new BusinessCardContext())
            {
                Firm firm = context.Firm.Find(firmIdProp);
                Person person = context.Person.Find(personIdProp);
                firm.Employees.Add(person);
                context.SaveChanges();
            }
        }
        public void AddExistingPersonToExistingFirm(string personNameProp, string firmNameProp)
        {
            using (var context = new BusinessCardContext())
            {
                Firm firm = context.Firm.Where(x => x.Name == firmNameProp).FirstOrDefault();
                Person person = context.Person.Where(x => x.Name == personNameProp).FirstOrDefault();
                firm.Employees.Add(person);
                context.SaveChanges();
            }
        }
        public void AddExistingPersonToExistingFirm(Person personProp, Firm firmProp)
        {
            using (var context = new BusinessCardContext())
            {
                Firm firm = context.Firm.Find(firmProp.FirmId);
                Person person = context.Person.Find(personProp.PersonId);
                firm.Employees.Add(person);
                context.SaveChanges();
            }
        }

    }
}
