class Program
{
    static void Main()
    {
        Product p1 = new Product("Notebook", 25000);
        Product p2 = new Product("Myš", 500);
        Product p3 = new Product("Klávesnice", 1000);

        Product.PrintWarehouseSummary();
    }
}