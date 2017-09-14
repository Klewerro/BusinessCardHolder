using System.Collections.Generic;
using System.Linq;
using BusinessCardHolder.Entities;

namespace BusinessCardHolder.Forms.Actions
{

    /// <summary>
    /// Contain methods using to operate on Firm table in database
    /// </summary>
    public class FirmActions
    {
        BusinessCardContext businessCardContext;

        public FirmActions()
        {
            businessCardContext = new BusinessCardContext();
        }

        public List<Firm> DownloadFirmDataIntoList()
        {
            
            var firms = from Firm in businessCardContext.Firm
                        select Firm;
            return firms.ToList();
        }

        public Firm DownloadSingleFirmData(int idProp)
        {
            Firm firm = businessCardContext.Firm.Where(x => x.FirmId == idProp).FirstOrDefault();
            return firm;
        }

        public void Add(string name, string city, string street, int number, string zip)
        {
            using (var context = businessCardContext)
            {
                Entities.Firm firm = new Entities.Firm() { Name = name, City = city, Street = street, Number = number, Zip = zip};
                context.Firm.Add(firm);
                context.SaveChanges();
            }
        }

        public void Edit(int firmId, string name, string city, string street, int number, string zip)
        {
            using (var context = businessCardContext)
            {
                var f = context.Firm.Where(x => x.FirmId == firmId).FirstOrDefault();
                f.FirmId = firmId;
                f.Name = name;
                f.City = city;
                f.Street = street;
                f.Number = number;
                f.Zip = zip;
                context.SaveChanges();
            }
        }

        public void Edit(Entities.Firm firm)
        {
            
        }
    }
}
