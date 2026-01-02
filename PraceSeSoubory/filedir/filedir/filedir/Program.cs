using System.Text;

Console.WriteLine("=== Soubory TXT ===");


if (!File.Exists("ABC.txt")) // kontrola existence souboru ABC.txt
{
    File.WriteAllText("ABC.txt", "ABC"); // zápis řetězce "ABC" do souboru ABC.txt
}

if (!File.Exists("ABC_dest.txt"))
{
    File.Copy("ABC.txt", "ABC_dest.txt"); // zdroj -> cíl
}

if (!File.Exists("ABC_dest2.txt"))
{
    File.Copy("ABC_dest.txt", "ABC_dest2.txt"); // zdroj -> cíl
}

if (!File.Exists("ABC_dest2.txt"))
{
    File.Delete("ABC_dest2.txt"); // smaž soubor ABC_dest2.txt
}

using (FileStream fs = new FileStream("ABC_dest.txt", FileMode.Append))
using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
{
    // Přidá obsah na konec souboru
    writer.Write("DEF");
}

// aktuální stav souborů
string abcContent = File.ReadAllText("ABC.txt");
Console.WriteLine($"[1] Aktuální obsah souboru ABC.txt: {abcContent}");
string abcDestContent = File.ReadAllText("ABC_dest.txt");
Console.WriteLine($"[1] Aktuální obsah souboru ABC_dest.txt: {abcDestContent}");

string currDir = Directory.GetCurrentDirectory();

// vyjmenuje všechny soubory v adresáři
var files = Directory.EnumerateFiles(currDir);
if (files.Any())
{
    Console.WriteLine("Adresář obsahuje následující soubory:");
    foreach (var file in files)
    {
        Console.WriteLine($"-- {Path.GetFileName(file)}");
    }
}

