using ReverseEngineering;
using Microsoft.EntityFrameworkCore;
namespace EFProgram;

partial class Program
{
    static void QueryAllCustomers()
    {
        using (Nutshell db = new())
        {
            var customers = db.Customers;

            if (!customers.Any())
            {
                return;
            }

            foreach (var cust in customers)
            {
                Console.WriteLine($"{cust.Id}] {cust.Name}");
            }
        }
    }

    static void QueryAllPurchases()
    {
        using (Nutshell db = new())
        {
            var purchases = db.Purchases
                            .Include(c => c.Customer);

            if (!purchases.Any())
            {
                return;
            }

            foreach(var purch in purchases)
            {
                if (purch.Customer?.Name is null)
                {
                    Console.WriteLine($"{purch.Id}] {purch.Description} has not made as purchase by any customer");
                    return;
                }
                Console.WriteLine($"{purch.Id}] {purch.Description} purchase made by: {purch.Customer?.Name}");
            }
        }
    }

    static void QueryPurchaseByCustomer(string customerName)
    {
        using (Nutshell db = new())
        {
            var purchaseMadeBy = db.Customers?
                                    .Where(c => c.Name == customerName)
                                    .Include(c => c.Purchases);
            foreach(var purchBy in purchaseMadeBy)
            {
                Console.WriteLine($"{purchBy.Name} has the following purchases:");
                foreach (var purchase in purchBy.Purchases)
                {
                    Console.WriteLine($"{purchase.Description} priced ${purchase.Price}");
                }
            }
        }
    }
}