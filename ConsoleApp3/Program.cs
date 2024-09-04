using ConsoleApp3.LINQ.Implementation;
using ConsoleApp3.LINQ.Interface;

public class Program
{
    private static readonly IProduct productService = new ProductService();
    public static void Main(string[] args)
    {
        double minimumPrice = 500.00;

        var expensiveProducts = productService.GetProductNamesAbovePrice(minimumPrice);

        Console.WriteLine("Products with price greater than or equal to " + minimumPrice + ":");
        foreach (var productName in expensiveProducts)
        {
            Console.WriteLine(productName);
        }
    }
}