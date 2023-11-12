using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Name = "Elma";
        product1.Price = 15;
        product1.Description = "Amasya Elması";

        Product product2 = new Product();
        product2.Name = "Karpuz";
        product2.Price = 80;
        product2.Description = "Diyarbakır Karpuzu";

        Product [] products = new Product[] { product1, product2 };
        // type-safe -- tip güvenli
        foreach (Product p in products)
        {
            Console.WriteLine(p.Name + "   "+ p.Price);
        }
        Console.WriteLine("------Metotlar---------");
        // intance - örnek
        // encapsulation
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(product1);

        
    }
}

// Dont repeat yourself - DRY - Cleam Code - Best Practice 