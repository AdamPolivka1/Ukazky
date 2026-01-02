namespace LINQ
{
    // Třída reprezentující objednávku
    class Order
    {
        public int Id { get; set; } 
        public decimal TotalPrice { get; set; }
        public string ProductName { get; set; }
        public int ProductQty { get; set; }
    }
}