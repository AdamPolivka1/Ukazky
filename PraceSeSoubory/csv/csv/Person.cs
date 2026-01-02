using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;

namespace csv
{
    public class Person
    {
        [Name("Name")]
        public string Name { get; set; }

        [Name("Age")]
        public int Age { get; set; }

        [Name("Email")]
        public string Email { get; set; }

        [Name("City")]
        public string City { get; set; }

        [Name("Country")]
        public string Country { get; set; }

        [Name("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Name("Hobby")]
        public string Hobby { get; set; }
    }
}
