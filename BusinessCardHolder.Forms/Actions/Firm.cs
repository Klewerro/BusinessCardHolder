using System.Linq;

namespace BusinessCardHolder.Forms.Actions
{
    public class Firm
    {
        public void Add(string name, string city, string street, int number, string zip)
        {
            using (var context = new BusinessCardContext())
            {
                Entities.Firm firm = new Entities.Firm() { Name = name, City = city, Street = street, Number = number, Zip = zip};
                context.Firm.Add(firm);
                context.SaveChanges();
            }
        }

        public void Edit(int firmId, string name, string city, string street, int number, string zip)
        {
            using (var context = new BusinessCardContext())
            {
                var f = context.Firm.Where(x => x.FirmId == firmId).FirstOrDefault();
                f.Name = name;
                f.City = city;
                f.Street = street;
                f.Number = number;
                f.Zip = zip;
                context.Firm.Add(f);
                context.SaveChanges();
            }
        }
    }
}
