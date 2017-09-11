using BusinessCardHolder.Entities;
using System;
using System.Threading;
using BusinessCardHolder.Actions;

namespace BusinessCardHolder
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BusinessCardContext())
            {
                db.Firm.Add(new Firm()
                {
                    Name = "Zeto",
                    City = "Rzeszow",
                    Street = "Kopisto",
                    Number = 8,
                    Zip = "35-350"
                });
                db.Person.Add(new Person() { Name = "Grzegorz" });

                db.SaveChanges();
            }
        }

        public static void DbInit()
        {
            using (var db = new BusinessCardContext())
            {
               
            }
        }

        
    }
}
