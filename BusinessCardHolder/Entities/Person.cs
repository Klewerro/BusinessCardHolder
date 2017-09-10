using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessCardHolder.Entities
{
    class Person
    {
        [Key]
        public int PersonId { get; set; }

        //[MaxLength(30)]
        //public string Forname { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        //[MaxLength(9), MinLength(7)]
        //public string Phone { get; set; }
        //[MaxLength(11), MinLength(9)]
        //public string CellPhone { get; set; }
        //[EmailAddress]
        //public string Email { get; set; }
        //public DateTime BithDate { get; set; }

    }
}
