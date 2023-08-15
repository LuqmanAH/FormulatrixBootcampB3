using ReverseEngineering;

namespace EFProgram;

public partial class Program
{
    static void AddCustomer(string name)
    {
        using (Nutshell db = new())
        {
            Customer customer= new Customer()
            {
                Name = name
            };

            db.Customers?.Add(customer);
            db.SaveChanges();
        }
        Console.WriteLine($"Successfully added {name} to the db");
    }

    static void AddPurchase(string desc, double price, string date)
    {
        using (Nutshell db = new()) 
        {
            Purchase purchase = new Purchase
            {
                Description = desc,
                Date = date,
                Price = price
            };

            db.Purchases.Add(purchase);
            db.SaveChanges();
        }
        Console.WriteLine($"Successfully added new purchase: {desc}");
    }
}