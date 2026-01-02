using EFapp;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

Console.WriteLine("=== Entity Framework ===");

using (var ctx = new AppDbContext())
{
    Batteries.Init();

    // vložení dat (metoda přímého SQL)
    var insertCmd = ctx.Database.GetDbConnection;
    string commandTxt =
    @"
    INSERT INTO Products (Id, Name, Price, Description) VALUES
    (1, 'USB', 250, 'Určeno pro rychlý přenos dat.'),
    (2, 'Notebook', 20000, 'Výkonný herní notebook.'),
    (3, 'Mobil', 5000, 'Mobil se systémem android.'),
    (4, 'Lampa', 1200, 'Stolní lampa určená i k dekoraci.'),
    (5, 'Baterka', 1000, 'Baterka s velkou svítivostí.')
    ";
    ctx.Database.ExecuteSqlRaw("Delete From Products"); // vyprázdní tabulku Products
    ctx.Database.ExecuteSqlRaw(commandTxt);
    Console.WriteLine("Data byla úspěšně vložena do databáze");

    // načtení uložených dat (pomocí kontextu)
    var products = ctx.Products.ToList();
    foreach (var p in products)
        Console.WriteLine($"[{p.Id}] {p.Name} - {p.Price:C}");
}

