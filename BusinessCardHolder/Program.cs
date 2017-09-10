using BusinessCardHolder.Entities;

namespace BusinessCardHolder
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BusinessCardContext())
            {
                Address address = new Address() { City = "Rzeszów", Street = "Dąbrowskiego", Number = 10 };
                BusinessCard card = new BusinessCard() { Name = "Comarch", Address = address };
                Person person = new Person() { Name = "Grzegorz" };
                card.Employees.Add(person);
                db.BusinessCard.Add(card);
                db.SaveChanges();
            }
        }

        
    }
}
