using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace xml
{
    [XmlRoot("People")]
    public class People
    {
        [XmlElement("Person")]
        public List<Person> PersonList { get; set; } = new();
    }
}
