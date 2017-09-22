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

        public void RemoveFirmAndEmployees(int firmIdProp)
        {
            personActions.RemoveAllEmployeesFromFirm(firmIdProp);
            firmActions.Remove(firmIdProp);
        }


    }
}
