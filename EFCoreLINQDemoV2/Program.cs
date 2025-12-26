//using (var context = new AppDbContext())
//{
//    var products = context.Products.ToList();

//    foreach (var product in products)
//    {
//        Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
//    }
//}

//Console.WriteLine("LINQ Query Executed Successfully!");
//Console.ReadLine();


using (var context = new AppDbContext())
{
    var products = context.Products
                          .Where(p => p.Price > 1000)
                          .OrderBy(p => p.Name)
                          .ToList();

    foreach (var product in products)
    {
        Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
    }
}

Console.WriteLine("Filtered LINQ Query Executed Successfully!");
Console.ReadLine();
