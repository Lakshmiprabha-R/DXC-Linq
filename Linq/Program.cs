// See https://aka.ms/new-console-template for more information
class Product
{
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public string Brand { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Product> productList = new List<Product>();
        SeedData(productList);

        static void SeedData(List<Product> productList)
        {
            productList.Add(new Product { ProductId = "P001", ProductName = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000 });
            productList.Add(new Product { ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500 });
            productList.Add(new Product { ProductId = "P003", ProductName = "Tablet", Brand = "Lenovo", Quantity = 4, Price = 15000 });
            productList.Add(new Product { ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000 });
            productList.Add(new Product { ProductId = "P005", ProductName = "Earphones", Brand = "Boat", Quantity = 2, Price = 1500 });
        }

        Console.WriteLine("Product names from Product List  where price is between 20000 to 40000:");
        var productsInRange = productList.Where(p => p.Price > 20000 && p.Price < 40000);
        
        foreach (var product in productsInRange)
        {
            Console.WriteLine($"{product.ProductId}||{product.ProductName}||{product.Brand}||{product.Quantity}||{product.Price}");
           
        }
        Console.WriteLine();

        Console.WriteLine("\nProduct List where ProductName contains letter 'a':");
        var productsWithNameContaininga = productList.Where(p => p.ProductName. ToLower().Contains("a"));
        foreach (var product in productsWithNameContaininga)
        {
            Console.WriteLine($"{product.ProductId}||{product.ProductName}||{product.Brand}||{product.Quantity}||{product.Price}");
            
        }
        Console.WriteLine();

        Console.WriteLine("\nProduct List arranged in alphabetical order based on ProductName:");
        var productsInAlphabeticalOrder = productList.OrderBy(p => p.ProductName);
        foreach (var product in productsInAlphabeticalOrder)
        {
            Console.WriteLine($"{product.ProductId}||{product.ProductName}|| {product.Brand}||{product.Quantity}||{product.Price}");
            
        }
        Console.WriteLine();

        Console.WriteLine("\nHighest Price from Product List:");
        var highestPrice = productList.Max(p => p.Price);
        Console.WriteLine(highestPrice);

        Console.WriteLine("\nCheck whether the Product with ProductId 'P003' exists in Product List or not:");
        var isProductExist = productList.Any(p => p.ProductId == "P003");
        Console.WriteLine(isProductExist);
    }

    
}


