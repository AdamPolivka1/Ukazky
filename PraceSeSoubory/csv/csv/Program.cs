using csv;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

string csv_path = "data.csv";
string csv_path_2 = "data_out.csv";

int chooseOption = 0;

// Moznosti
Console.WriteLine("=== Priklad soubory CSV ===");
Console.WriteLine("1. Cteni z CSV souboru (standardni knihovny)");
Console.WriteLine("2. Zapis do CSV souboru (standardni knihovny)");
Console.WriteLine("3. Cteni z CSV souboru pomoci CsvHelper");
Console.WriteLine("4. Zapis do CSV souboru pomoci CsvHelper");
Console.Write("\nProsim, vyberte moznost: ");
ConsoleKeyInfo keyInfo = Console.ReadKey();
char c = keyInfo.KeyChar;

if (char.IsDigit(c))
{
    chooseOption = c - '0';
}

if (!char.IsDigit(c) || (chooseOption <= 1) || (chooseOption > 4))
{
    Console.WriteLine("\nVybrana moznost neexistuje");
}

// STANDARDNI KNIHOVNY =======================================================
// 1. Priklad, cteni (standardni knihovny)
if (chooseOption == 1)
{
    List<Person> persons = new List<Person>();
    string[] lns = File.ReadAllLines(csv_path);
    foreach (string line in lns)
    {
        string[] vals = line.Split(';'); // rozdely radek na sloupce
                                         
        if (vals[0] == "Name") // kontrola prvniho radku (hlavicky)
            continue;

        Person person = new Person();
        // prvni je jmeno
        Console.WriteLine($"\nJmeno: {vals[0]}");
        person.Name = vals[0];
        // druhy je vek
        Console.WriteLine($"Vek: {vals[1]}");
        person.Age = Convert.ToInt32(vals[1]);
        persons.Add(person);
    }
}

// 2. Priklad, zapis (standardni knihovny)
if (chooseOption == 2)
{
    // vyber prvnich 10 osob
    var peopleOut = new List<Person>
    {
        new Person { Name = "adam", Age = 18, Email = "adam@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 900", Hobby = "plavani" },
        new Person { Name = "petr", Age = 15, Email = "petr@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 901", Hobby = "beh" },
        new Person { Name = "helena", Age = 21, Email = "helena@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 902", Hobby = "cyklistika" },
        new Person { Name = "dana", Age = 25, Email = "dana@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 903", Hobby = "cyklistika" },
        new Person { Name = "daniela", Age = 26, Email = "dana@mymail.com", City = "Praha", Country = "CZ", PhoneNumber = "420 777 888 904", Hobby = "zpev" },
        new Person { Name = "jan", Age = 27, Email = "jan@mymail.com", City = "Brno", Country = "CZ", PhoneNumber = "420 777 888 905", Hobby = "turistika" },
        new Person { Name = "tomas", Age = 28, Email = "tomas@mymail.com", City = "Brno", Country = "CZ", PhoneNumber = "420 777 888 906", Hobby = "DIY" },
        new Person { Name = "tobias", Age = 29, Email = "tobias@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 907", Hobby = "tanec" },
        new Person { Name = "daniel", Age = 30, Email = "daniel@mymail.com", City = "Praha", Country = "CZ", PhoneNumber = "420 777 888 908", Hobby = "posilovani" },
        new Person { Name = "vladimir", Age = 31, Email = "vladimir@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 910", Hobby = "hudba" }
    };

    List<string> lns = new List<string>();
    lns.Add("Name;Age;Email;City;Country;PhoneNumber;Hobby"); // hlavicka

    foreach (Person person in peopleOut)
    {
        lns.Add($"{person.Name};{person.Age};{person.Email};{person.City};{person.Country};{person.PhoneNumber};{person.Hobby}");
    }

    File.WriteAllLines(csv_path_2, lns);
    Console.WriteLine($"\nZapis dat byl proveden (soubor: {csv_path_2})");
}

// CSV HELPER ================================================================
// 3. Priklad, cteni pomoci CsvHelper
if (chooseOption == 3)
{
    // Vytvoreni konfigurace
    // HasHeaderRecord = true ... Soubor obsahuje hlavicku
    // Delimiter = ";" ... Sloupce jsou oddeleny stredníkem
    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        HasHeaderRecord = true,
        Delimiter = ";",
    };

    using (var reader = new StreamReader(csv_path))
    using (var csv = new CsvReader(reader, config))
    {
        var people = csv.GetRecords<Person>(); // ziskani List<Person>

        foreach (Person p in people)
        {
            Console.WriteLine($"\nJmeno: {p.Name}");
            Console.WriteLine($"Vek: {p.Age}");
        }
    }
}
// 4. Priklad, zapis pomoci CsvHelper
if (chooseOption == 4)
{
    var configOut = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };

    // vyber prvnich 10 osob
    var peopleOut = new List<Person>
    {
        new Person { Name = "adam", Age = 18, Email = "adam@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 900", Hobby = "plavani" },
        new Person { Name = "petr", Age = 15, Email = "petr@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 901", Hobby = "beh" },
        new Person { Name = "helena", Age = 21, Email = "helena@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 902", Hobby = "cyklistika" },
        new Person { Name = "dana", Age = 25, Email = "dana@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 903", Hobby = "cyklistika" },
        new Person { Name = "daniela", Age = 26, Email = "dana@mymail.com", City = "Praha", Country = "CZ", PhoneNumber = "420 777 888 904", Hobby = "zpev" },
        new Person { Name = "jan", Age = 27, Email = "jan@mymail.com", City = "Brno", Country = "CZ", PhoneNumber = "420 777 888 905", Hobby = "turistika" },
        new Person { Name = "tomas", Age = 28, Email = "tomas@mymail.com", City = "Brno", Country = "CZ", PhoneNumber = "420 777 888 906", Hobby = "DIY" },
        new Person { Name = "tobias", Age = 29, Email = "tobias@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 907", Hobby = "tanec" },
        new Person { Name = "daniel", Age = 30, Email = "daniel@mymail.com", City = "Praha", Country = "CZ", PhoneNumber = "420 777 888 908", Hobby = "posilovani" },
        new Person { Name = "vladimir", Age = 31, Email = "vladimir@mymail.com", City = "Jihlava", Country = "CZ", PhoneNumber = "420 777 888 910", Hobby = "hudba" }
    };

    using (var writer = new StreamWriter(csv_path_2))
    using (var csv = new CsvWriter(writer, configOut))
    {
        csv.WriteRecords(peopleOut);
        Console.WriteLine($"\nZapis dat byl proveden (soubor: {csv_path_2})");
    }
}
//===========================================================================