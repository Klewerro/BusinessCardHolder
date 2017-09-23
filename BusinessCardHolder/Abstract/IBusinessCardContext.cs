using System.Data.Entity;
using BusinessCardHolder.Entities;

namespace BusinessCardHolder
{
    public interface IBusinessCardContext
    {
        DbSet<Firm> Firm { get; set; }
        DbSet<Person> Person { get; set; }
    }
}