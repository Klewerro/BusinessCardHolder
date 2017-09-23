using BusinessCardHolder.Entities;
using System;
using System.Threading;
using BusinessCardHolder.Actions;
using System.Collections.Generic;
using System.Linq;

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
            var p3 = new Person() { Name = "Petru", Forename = "Ryszard", Phone = "17212354", CellPhone = "696173873", Email = "petru@blame.com", BithDate = new DateTime(1992, 1, 22) };



            //var firma = firmActions.ReadFirm("Zeto");
            //personActions.CreatePersonAndAddToFirm(p2, firma.FirmId);

            using (var context = new BusinessCardContext())
            {
                f2.Employees.Add(p3);
                context.Firm.Add(f2);
                context.SaveChanges();
            }


            //using (var context = new BusinessCardContext())
            //{
            //    var firm = context.Firm.Find(5);
            //    Console.WriteLine(firm.Name);


            //    foreach (var item in firm.Employees)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //    Console.WriteLine(firm.Employees.Count);

            //}


            using (var context = new BusinessCardContext())
            {
                var a = context.Person.Where(x => x.Firm.FirmId == 6).ToList() ;
                foreach (var item in a)
                {
                    Console.WriteLine(item.Name);
                }
            }



            //var firma2 = firmActions.ReadFirm("Zeto");
            //Console.WriteLine(firma2.Employees[0].Name);
            //Console.WriteLine(firma2.Employees.Count);



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
