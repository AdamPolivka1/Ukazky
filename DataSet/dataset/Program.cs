using System.Data;

Console.WriteLine("=== DATASET ===");

DataSet ds = new DataSet(); // vytvoření instance DataSetu

// Vytvoření tabulky Products
DataTable dtProduct = new DataTable("Product");

DataColumn dcProductId = new DataColumn("ProductId", typeof(int));
DataColumn dcName = new DataColumn("Name", typeof(string));
DataColumn dcPrice = new DataColumn("Price", typeof(decimal));
DataColumn dcAvailableQty = new DataColumn("AvailableQty", typeof(int));
DataColumn dcDescr = new DataColumn("Descr", typeof(string));
DataColumn dcCategoryId = new DataColumn("ProductCategoryId", typeof(int));

dtProduct.Columns.Add(dcProductId);
dtProduct.Columns.Add(dcName);
dtProduct.Columns.Add(dcPrice);
dtProduct.Columns.Add(dcAvailableQty);
dtProduct.Columns.Add(dcDescr);
dtProduct.Columns.Add(dcCategoryId);
// určení primárního klíče
dtProduct.PrimaryKey = new DataColumn[] { dtProduct.Columns["ProductId"] };

// Vytvoření tabulky ProductCategory
DataTable dtProductCategory = new DataTable("ProductCategory");

DataColumn dcProductCategoryId = new DataColumn("ProductCategoryId", typeof(int));
DataColumn dcCategoryName = new DataColumn("Name", typeof(string));

dtProductCategory.Columns.Add(dcProductCategoryId);
dtProductCategory.Columns.Add(dcCategoryName);
// určení primárního klíče
dtProductCategory.PrimaryKey = new DataColumn[] { dtProductCategory.Columns["ProductCategoryId"] };

ds.Tables.Add(dtProduct);
ds.Tables.Add(dtProductCategory);

// 2. Vazby mezi tabulkami
DataRelation ProductCategoryRelation = new DataRelation(
    "ProductCategory",
    dtProductCategory.Columns["ProductCategoryId"],
    dtProduct.Columns["ProductCategoryId"]
);
ds.Relations.Add(ProductCategoryRelation);

// 3. Relation Constraints
// při smazání přidružené kategorie ProductCategory
// se smaže řádek v přidružené tabulce Product
ProductCategoryRelation.ChildKeyConstraint.DeleteRule = Rule.Cascade;

// 4. Naplnění daty

// A ProductCategory
dtProductCategory.Rows.Add(1, "Nábytek");
dtProductCategory.Rows.Add(2, "Elektronika");
dtProductCategory.Rows.Add(3, "Domácí spotřebiče");

// B Product
dtProduct.Rows.Add(1, "Stůl", 4999.90, 10, "", 1);
dtProduct.Rows.Add(2, "Televize", 6000.00, 10, "", 2);
dtProduct.Rows.Add(3, "Notebook", 23679.60, 10, "", 2);
dtProduct.Rows.Add(4, "Varná konvice", 1299.90, 10, "", 3);
dtProduct.Rows.Add(5, "Nabíječka", 800, 10, "", 2);

// 5. Výpis

Console.WriteLine("Zvolte výpis (A|B|C): ");
Console.WriteLine("[A] Výpis tabulky");
Console.WriteLine("[B] Výpis relací tabulky");
Console.WriteLine("[C] DataView tabulky Product (aplikování filtru Price < 2000)");
Console.WriteLine("[D] Linq to DataSet (aplikování filtru Price < 2000)");
Console.WriteLine("[E] Uložení datasetu do XML (soubor.xml)");
Console.WriteLine("[jiná klávesa] Přeskočí tuto akci");
Console.Write("\nVáš výběr: ");

char Action = 'A';
try
{
    Action = Console.ReadKey().KeyChar;
}
catch (Exception e) { 
    Console.WriteLine("Uživatel zadal nevalidní vstup, bude použita volba [A]");
}

Console.WriteLine("\n"); // oddělení

// A výpis struktury tabulky Product
if (Action == 'A') {
    foreach (DataRow productRow in ds.Tables["Product"].Rows)
    {
        Console.WriteLine("Product");
        Console.WriteLine($"\tProductId: {productRow["ProductID"].ToString()}");
        Console.WriteLine($"\tName: {productRow["Name"].ToString()}");
        Console.WriteLine($"\tPrice: {productRow["Price"].ToString()}");
        Console.WriteLine($"\tAvailableQty: {productRow["AvailableQty"].ToString()}");
        Console.WriteLine($"\tDescr: {productRow["Descr"].ToString()}");
        Console.WriteLine($"\tProductCategoryId: {productRow["ProductCategoryId"].ToString()}");
        DataRow parent = productRow.GetParentRow("ProductCategory"); // přidaný sloupec ProductCategory.Name
        Console.WriteLine($"\t[ProductCategoryName]: {parent["Name"].ToString()}");
        Console.WriteLine("\n");  
    }
}
// B výpis relací tabulky Product, ProductCategory
if (Action == 'B') {
    // -> Product
    Console.WriteLine("Product");
    // Parent
    foreach (DataRelation dr in dtProduct.ParentRelations) {
        Console.WriteLine($"Název relace (Parent): {dr.RelationName}");
    }
    // Child
    foreach (DataRelation dr in dtProduct.ChildRelations) {
        Console.WriteLine($"Název relace (Child): {dr.RelationName}");
    }

    // -> ProductCategory
    Console.WriteLine("ProductCategory");
    // Parent
    foreach (DataRelation dr in dtProductCategory.ParentRelations)
    {
        Console.WriteLine($"Název relace (Parent): {dr.RelationName}");
    }
    // Child
    foreach (DataRelation dr in dtProductCategory.ChildRelations)
    {
        Console.WriteLine($"Název relace (Child): {dr.RelationName}");
    }
}

// C dataview tabulky Product výpis
if (Action == 'C') {
    dtProduct.DefaultView.RowFilter = "Price < 2000";

    // DefaultView s aplikovaným RowFilterem
    Console.WriteLine("---- Všechny Produkty DataView (Price < 2000) -----------------");
    foreach (DataRowView drw in dtProduct.DefaultView)
    {
        Console.WriteLine($"ProductId: {drw["ProductId"]}");
        Console.WriteLine($"Name: {drw["Name"]}");
        Console.WriteLine($"Price: {drw["Price"]}");
        Console.WriteLine($"AvailableQty: {drw["AvailableQty"]}");
        Console.WriteLine($"Descr: {drw["Descr"]}");
        Console.WriteLine($"ProductCategoryId: {drw["ProductCategoryId"]}");
        Console.WriteLine("----");
    }

    // Všechny produkty
    Console.WriteLine("------ Všechny Produkty ---------------------------------------");
    foreach (DataRow dr in dtProduct.Rows)
    {
        Console.WriteLine($"ProductId: {dr["ProductId"]}");
        Console.WriteLine($"Name: {dr["Name"]}");
        Console.WriteLine($"Price: {dr["Price"]}");
        Console.WriteLine($"AvailableQty: {dr["AvailableQty"]}");
        Console.WriteLine($"Descr: {dr["Descr"]}");
        Console.WriteLine($"ProductCategoryId: {dr["ProductCategoryId"]}");
        Console.WriteLine("----");
    }
}

// D LINQ to DataSet
if (Action == 'D')
{
    Console.Write("LINQ to DataSet\n");
    IEnumerable<DataRow> query =
        from product in dtProduct.AsEnumerable()
        where product != null && product.Field<decimal>("Price") < 2000
        select product;

    foreach (DataRow dr in query)
    {
        Console.WriteLine($"ProductId: {dr["ProductId"]}");
        Console.WriteLine($"Name: {dr["Name"]}");
        Console.WriteLine($"Price: {dr["Price"]}");
        Console.WriteLine($"AvailableQty: {dr["AvailableQty"]}");
        Console.WriteLine($"Descr: {dr["Descr"]}");
        Console.WriteLine($"ProductCategoryId: {dr["ProductCategoryId"]}");
        Console.WriteLine("----");
    }
}
// Zápis do XML souboru
if (Action == 'E') 
{
    ds.DataSetName = "Data"; // název kořenového elementu
    ds.WriteXml("soubor.xml");
}