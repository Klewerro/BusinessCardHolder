﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessCardHolder.Entities
{
    public class Firm
    {
        

        //public Firm(string name, string city, string street, int number, string zip)
        //{
        //    this.Name = name;
        //    this.City = city;
        //    this.Street = street;
        //    this.Number = number;
        //    this.Zip = zip;
        //}

        public int FirmId { get; set; }
        public string Name { get; set; }   
        public List<Person> Employees { get; set; }

        //Address
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        [RegularExpression(@"^\d{2}(?:[-\s]\d{3})?$", ErrorMessage = "Wrong ZIP code format")]
        public string Zip { get; set; }

        public Firm()
        {
            this.Employees = new List<Person>();
        }

    }
}
