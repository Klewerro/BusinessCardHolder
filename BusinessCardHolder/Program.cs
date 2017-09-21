using BusinessCardHolder.Entities;
using System;
using System.Threading;
using BusinessCardHolder.Actions;

namespace BusinessCardHolder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var personActions = new PersonActions();
            //personActions.Add("Szymon", "Polziec", "172764084", "696173994", "szym@szym.com", new DateTime(1995, 6, 26));
            //personActions.AddExistingPersonToFirm("Polziec", "Zeto");
            personActions.RemovePerson("Polziec");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        public static void DbInit()
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

        
    }
}
