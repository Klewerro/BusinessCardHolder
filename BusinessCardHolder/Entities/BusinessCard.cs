using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessCardHolder.Entities
{
    class BusinessCard
    {
        public BusinessCard()
        {
            this.Employees = new List<Person>();
        }

        [Key]
        [ForeignKey("Address")]
        public int BusinessCardId { get; set; }

        [MaxLength(50), Required]
        public string Name { get; set; }    //Nazwa
        public List<Person> Employees { get; set; }

        //public int AddressId { get; set; }
        public Address Address { get; set; }

        

    }
}
