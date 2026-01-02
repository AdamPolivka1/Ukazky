// 1. Příklad, Přečtení dat ze souboru JSON
using System.Text.Json;
using System.Text.Json.Serialization;
using json;

string filePath = "data.json";
string fileOutPath1 = "data_output1.json";

int chooseOption = 0;

Console.WriteLine("=== Priklad soubory JSON ===");
Console.WriteLine("1. Cteni z JSON souboru");
Console.WriteLine("2. Zapis do JSON souboru");
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

// 1. Čtení z JSON souboru
if (chooseOption == 1) {
    string jsonContent = File.ReadAllText(filePath);
    var peopleJsonNet = JsonSerializer.Deserialize<List<Person>>(jsonContent);
    if (peopleJsonNet != null)
        foreach (var person in peopleJsonNet)
        {
            Console.WriteLine($"Jmeno: {person.Name}");
            Console.WriteLine($"Vek: {person.Age}");
            Console.WriteLine($"Email: {person.Email}");
            Console.WriteLine($"Telefonni cislo: {person.PhoneNumber}\n");
        }
}

// 2. Zápis do JSON souboru
if (chooseOption == 2)
{
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

    JsonSerializerOptions _options = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        WriteIndented = true
    };

    var jsonString2 = JsonSerializer.Serialize(peopleOut, _options);
    File.WriteAllText(fileOutPath1, jsonString2);
    Console.WriteLine("Zapis do souboru byl proveden");
}

// 3 Utf8JsonReader data.json 
if (chooseOption == 3)
{
    ReadOnlySpan<byte> jsonData = File.ReadAllBytes(filePath);
    Utf8JsonReader reader = new Utf8JsonReader(jsonData);
    while (reader.Read())
    {
        JsonTokenType tokenType = reader.TokenType;
        switch (tokenType)
        {
            case JsonTokenType.String:
                {
                    string? text = reader.GetString();
                    Console.Write(text);
                    Console.WriteLine();
                    break;
                }
        }
    }
}