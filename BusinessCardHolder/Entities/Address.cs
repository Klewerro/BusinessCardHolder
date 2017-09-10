using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessCardHolder.Entities
{
    class Address
    {
        [Key]
        //[ForeignKey("BusinessCard")]
        public int AddressId { get; set; }

        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Zip { get; set; }

        public BusinessCard BusinessCard { get; set; }
    }
}
