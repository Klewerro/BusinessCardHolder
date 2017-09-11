using BusinessCardHolder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardHolder.Actions
{
    public class AddAction
    {
        public void FirmAndAddress(string name, string city, string street, int number, string zip)
        {
            
        }

        public void PersonToFirm(string personName, string firmName)
        {
            using(var db = new BusinessCardContext())
            {
                Person person = new Person() { Name = personName };
                var c = db.Firm.Where(x => x.Name == firmName).FirstOrDefault();
                c.Employees.Add(person);
                db.SaveChanges();
            }
        }
    }
}
