namespace EFProgram;
public partial class Program
{
    public static void Main()
    {

        QueryPurchaseByCustomer("Mary");
        AddCustomer("Burhan");
        AddCustomer("Jeki");

        AddPurchase("Bensin", 450d, "2023-08-15 00:00:00");
    }
}
