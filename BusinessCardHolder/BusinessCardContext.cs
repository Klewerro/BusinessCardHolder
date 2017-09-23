using BusinessCardHolder.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardHolder
{
   /// <summary>
   /// Class using to take connection with DB
   /// </summary>
   public class BusinessCardContext : DbContext, IBusinessCardContext
    {
        public BusinessCardContext() :base("BusinessCardDb")
        {

        }

        public DbSet<Firm> Firm { get; set; }
        public DbSet<Person> Person { get; set; }
    }
}
