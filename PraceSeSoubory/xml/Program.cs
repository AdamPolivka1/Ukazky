using System.Xml;
using System.Xml.Serialization;
using xml;

int chooseOption = 0;

Console.WriteLine("=== Priklad soubory XML ===");
Console.WriteLine("1. Cteni z XML souboru (standardni knihovny)");
Console.WriteLine("2. Cteni z XML souboru (standardni knihovny)");
Console.WriteLine("3. Zapis do XML souboru");
Console.Write("\nProsim, vyberte moznost: ");
ConsoleKeyInfo keyInfo = Console.ReadKey();
Console.WriteLine();
char c = keyInfo.KeyChar;

if (char.IsDigit(c))
{
    chooseOption = c - '0';
}

if (!char.IsDigit(c) || (chooseOption < 1) || (chooseOption > 4))
{
    Console.WriteLine("\nVybrana moznost neexistuje");
}
string crdir = Environment.CurrentDirectory;

// 1. Příklad XmlReader
if (chooseOption == 1)
{
    using (XmlReader readerXML = XmlReader.Create(Path.Combine(crdir, "data.xml")))
    {
        readerXML.ReadToFollowing("People");
        while (readerXML.ReadToFollowing("Person"))
        {
            Console.WriteLine("==============");
            readerXML.ReadToFollowing("Name");
            Console.WriteLine($"Jmeno: {readerXML.ReadElementContentAsString()}");

            readerXML.ReadToFollowing("Age");
            Console.WriteLine($"Vek: {readerXML.ReadElementContentAsString()}");

            readerXML.ReadToFollowing("PhoneNumber");
            Console.WriteLine($"Telefon: {readerXML.ReadElementContentAsString()}");

            readerXML.ReadToFollowing("City");
            Console.WriteLine($"Mesto: {readerXML.ReadElementContentAsString()}");
        }
    }
}

// 2. Příklad XmlReader
if (chooseOption == 2)
{
    XmlSerializer serializer = new XmlSerializer(typeof(Person));

    using (FileStream fstream = new FileStream("person.xml", FileMode.Open))
    {
        Person? person = serializer.Deserialize(fstream) as Person;
        if (person != null)
        {
            Console.WriteLine("==============");
            Console.WriteLine($"Jmeno: {person.Name}");
            Console.WriteLine($"Vek: {person.Age}");
            Console.WriteLine($"Telefon: {person.PhoneNumber}");
            Console.WriteLine($"Email: {person.Email}");
            Console.WriteLine($"Mesto: {person.City}");
            Console.WriteLine($"Zeme: {person.City}");
            Console.WriteLine($"Telefonni cislo: {person.PhoneNumber}");
            Console.WriteLine($"Konicek: {person.Hobby}");
        }
    }
}

// 3. Příklad XmlWriter
if (chooseOption == 3)
{
    XmlWriter xmlWriter = XmlWriter.Create("user_write.xml");
    xmlWriter.WriteStartElement("user");
    xmlWriter.WriteStartElement("name");
    xmlWriter.WriteString("Adam");
    xmlWriter.WriteEndElement();
    xmlWriter.WriteStartElement("age");
    xmlWriter.WriteString("24");
    xmlWriter.WriteEndElement();
    xmlWriter.WriteEndElement();

    xmlWriter.Close();
    Console.WriteLine("Byl proveden zapis do souboru");
}
