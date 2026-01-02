using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace json
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string PhoneNumber { get; set; }

        public string Hobby { get; set; }
    }
}