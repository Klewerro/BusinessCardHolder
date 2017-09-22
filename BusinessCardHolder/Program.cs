using BusinessCardHolder.Entities;
using System;
using System.Threading;
using BusinessCardHolder.Actions;
using System.Collections.Generic;

namespace BusinessCardHolder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var personActions = new PersonActions();
            var firmActions = new FirmActions();
            var firmAndPersonActions = new FirmPersonActions();
            //personActions.Add("Szymon", "Polziec", "172764084", "696173994", "szym@szym.com", new DateTime(1995, 6, 26));
            //personActions.AddExistingPersonToFirm("Polziec", "Zeto");
            //personActions.RemovePerson("Polziec");
            var p1 = new Person()
            {
                Forename = "Szymon", Name = "Polziec", Phone = "172764084", CellPhone = "696173994", Email = "szym@szym.com", BithDate =  new DateTime(1995, 6, 26)
            };

            var f1 = new Firm()
            {
                Name = "Zeto", City = "Rzeszów", Street = "Kopisto", Number = 2, Zip = "23-120"
            };

            var p2 = new Person()
            {
                Forename = "Gosia",
                Name = "Mol",
                Phone = "172764084",
                CellPhone = "696173994",
                Email = "szym@szym.com",
                BithDate = new DateTime(1995, 6, 26)
            };

            var f2 = new Firm()
            {
                Name = "Asseco",
                City = "Rzeszów",
                Street = "Kopisto",
                Number = 2,
                Zip = "23-120"
            };


            firmAndPersonActions.CreateNewFirmAndNewPerson(f1, p1);
            personActions.CreatePersonAndAddToFirm(p2, f1.FirmId);
            //personActions.DownloadPersonsForFirm(f2);
            //Person person = personActions.DownloadSinglePerson("Mol");
            //Console.WriteLine(person.Name);
            //firmAndPersonActions.RemoveFirmAndEmployees(3);



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
