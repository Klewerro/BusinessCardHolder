using System.Collections.Generic;
using System.Linq;
using BusinessCardHolder.Entities;
using System.Windows.Forms;
using System;
using System.Data.Entity;

namespace BusinessCardHolder.Forms.Actions
{

    /// <summary>
    /// Contain methods using to operate on Firm table in database
    /// </summary>
    public class FirmActions
    {
        public FirmActions()
        {
        }

        public List<Firm> DownloadFirmDataIntoList()
        {
            using (var context = new BusinessCardContext())
            {
                //var firms = from Firm in context.Firm
                //            select Firm;
                var firms2 = context.Firm.Select(n => n).ToList();
                return firms2;
            }
        }

        public Firm DownloadSingleFirmData(int idProp)
        {
            using(var context = new BusinessCardContext())
            {
                Firm firm = context.Firm.Where(x => x.FirmId == idProp).FirstOrDefault();
                //return context.Firm.Find(idProp);
                return firm;
            }
            
        }

        public void Add(string name, string city, string street, int number, string zip)
        {
            using (var context = new BusinessCardContext())
            {
                Firm firm = new Firm() { Name = name, City = city, Street = street, Number = number, Zip = zip};
                context.Firm.Add(firm);
                //context.Entry(firm).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Edit(int firmId, string name, string city, string street, int number, string zip)
        {
            using (var context = new BusinessCardContext())
            {
                try
                {
                    var f = context.Firm.Find(firmId);

                    f.FirmId = firmId;
                    f.Name = name;
                    f.City = city;
                    f.Street = street;
                    f.Number = number;
                    f.Zip = zip;
                    context.SaveChanges();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString() ,"Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
                

                
            }
        }

        public void Edit(Firm firmProp)
        {
            using(var context = new BusinessCardContext())
            {
                var firm = context.Firm.Where(x => x.FirmId == firmProp.FirmId).FirstOrDefault();
                firm.FirmId = firmProp.FirmId;
                firm.Name = firmProp.Name;
                firm.City = firmProp.City;
                firm.Street = firmProp.Street;
                firm.Number = firmProp.Number;
                firm.Zip = firmProp.Zip;    
                context.SaveChanges();
            }
        }

        public void Remove(int idProp)
        {
            using(var context = new BusinessCardContext())
            {
                try
                {
                    var firm = context.Firm.Where(x => x.FirmId == idProp).FirstOrDefault();
                    context.Firm.Remove(firm);
                    context.SaveChanges();
                } catch(System.ArgumentNullException ex)
                {
                    MessageBox.Show("Brak rekordu w bazie danych!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        /// <summary>
        /// Deleting whole Table (WARNING: This action won't be able to see in logs!)
        /// </summary>
        /// <param name="tableName"></param>
        public void Nuke()
        {
            using(var context = new BusinessCardContext())
            {
                context.Firm.RemoveRange(context.Firm);
                context.Person.RemoveRange(context.Person);
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Firms', RESEED, 0)");  //reseting id's
                //context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Person', RESEED, 0)");
            }
        }

        public bool CheckIfExist(int idProp)
        {
            using(var context = new BusinessCardContext())
            {
                //var firm = context.Firm.Where(x => x.FirmId == idProp).FirstOrDefault();
                if (context.Firm.Where(x => x.FirmId == idProp).Count() > 0)
                {
                    return true;
                }
                else return false;
            }
        }

        

    }
}
