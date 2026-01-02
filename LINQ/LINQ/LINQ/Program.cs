using LINQ;

Console.WriteLine("=== LINQ ===");

// definování zdrojových dat
int[] data1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

List<Order> data2 = new List<Order>
{
    new Order { Id = 1, ProductName = "Kreslo", ProductQty = 2, TotalPrice = 2000 },
    new Order { Id = 2, ProductName = "Kvetinac", ProductQty = 4, TotalPrice = 440 },
    new Order { Id = 3, ProductName = "Svicka", ProductQty = 1, TotalPrice = 90 },
    new Order { Id = 4, ProductName = "Vysavac", ProductQty = 1, TotalPrice = 3800 },
    new Order { Id = 5, ProductName = "Nabijecka 20V", ProductQty = 1, TotalPrice = 600 }
};

// [A] Filtrace
IEnumerable<int> data1list = data1.Where(i => i > 5);
// POUZE ZAČÍNAJÍCÍ NA "K"
IEnumerable<Order> data2list = data2.Where(d => d.ProductName.StartsWith("K"));
// [B] Seřazení
data1list.Order();
data2list = data2list.OrderBy(c => c.Id); // seřadí objekty dle jejich Id
// [C] Výběr určitých hodnot (selekce)
var data2list_vyber = data2.Select(c => new { c.Id, c.ProductName });
// [D] Agregační funkce aplikovana na data1
int maxNum = data1.Max();
int minNum = data1.Min();
int qtyNum = data1.Count();
double avgNum = data1.Average();
int sumNum = data1.Sum();
Console.WriteLine($"[DATA1]\nMax: {maxNum}\nMin: {minNum}"
    +$"\nPocet: {qtyNum}\nPrumer: {avgNum}\nSuma: {sumNum}");
// Složitější dotaz
// vybere data začínající na "V"
// pro návrat vybere pouze Id
var queryData = data2
    .Where(c => c.ProductName.StartsWith("V"))
    .OrderBy(c => c.ProductName)
    .Select(c => new { c.Id });

// Výstup 1
Console.WriteLine("Kde i > 5: ");
foreach (int val in data1list) {
    Console.WriteLine(val);
}

// Výstup 2
Console.WriteLine("ProductName kde zacina na K: ");
foreach (Order o in data2list) {
    Console.WriteLine(o.ProductName);
}

// Výstup 3
Console.WriteLine("Id kde ProductName zacina na V: ");
foreach (var product in queryData) {
    Console.WriteLine($"Produkt Id: {product.Id}");
}