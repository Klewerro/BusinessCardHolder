using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessCardHolder.Entities
{
    public class Firm
    {
        public Firm()
        {
            this.Employees = new List<Person>();
        }

        public int FirmId { get; set; }
        public string Name { get; set; }    //Nazwa
        public List<Person> Employees { get; set; }

        //Address
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Zip { get; set; }


    }
}
