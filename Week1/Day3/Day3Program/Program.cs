namespace BankWakanda;

public interface IAccountCloseable
{
    void CloseAccount();
}
public abstract class BankAccount
{
    public string AccountName {get; set;}
    public int AccountNumber {get; set;}
    public double AccountBalance {get; set;}
    public BankAccount(string accountName, double accountBalance)
    {
        this.AccountName = accountName;
        this.AccountBalance = accountBalance;
        this.AccountNumber = 12345678;
    }
    public BankAccount()
    {
        this.AccountName = "FulanAlFulani";
        this.AccountBalance = 100.0;
    }
    public BankAccount(string accountName, double accountBalance, int accountNumber)
    {
        this.AccountName = accountName;
        this.AccountBalance = accountBalance;
        this.AccountNumber = accountNumber;
    }
    public abstract double Deposit(double amount);
    public abstract double Withdraw(double amount);
}

public class CheckingAccount : BankAccount, IAccountCloseable
{
    public int overdraftLimit;
    
    public CheckingAccount(string accountName, int accountNumber, double accountBalance, int overdraftLimit): base(accountName, accountBalance, accountNumber)
    {
        this.overdraftLimit = overdraftLimit;
    }

    public override double Deposit(double amount)
    {
        this.AccountBalance += amount;
        return AccountBalance;
    }
    public override double Withdraw(double amount)
    {
        if (this.AccountBalance - amount < 0 && this.overdraftLimit <= 0){
            Console.WriteLine("Insufficient Funds!");
            return AccountBalance;
        }
        this.AccountBalance -= amount;
        return AccountBalance;
    }
    public void CloseAccount()
    {
        Console.WriteLine($"{this.AccountName} Checking Account has successfully closed and your entire balance is now ours");
    }
}

public class SavingsAccount : BankAccount, IAccountCloseable
{
    public double interestRate;
    public int savingDuration;
    public double balanceAfterInterest = 0.0;

    public SavingsAccount(string accountName, int accountNumber, double accountBalance, int savingDuration, double interestRate) : base(accountName, accountBalance, accountNumber)
    {
        this.savingDuration = savingDuration;
        this.interestRate = interestRate;
    }
    public override double Deposit(double amount)
    {
        AccountBalance += amount;
        return AccountBalance;
    }
    public override double Withdraw(double amount)
    {
        if (this.AccountBalance - amount < 0)
        {
            Console.WriteLine("Insufficient Funds!");
            return AccountBalance;
        }
        this.AccountBalance -= amount;
        return AccountBalance;
    }
    public double CalculateInterest(){
        this.balanceAfterInterest = AccountBalance * savingDuration * interestRate;
        return balanceAfterInterest;
    }
    public void CloseAccount()
    {
        Console.WriteLine($"{this.AccountName} Saving Account has successfully closed and your entire balance is now ours");
    }
}

public class Program
{
    public static void Main()
    {
        // SavingAccount Instance
        SavingsAccount savingsAccount1 = new("Hendrik Sudrajat", 56478832, 45690.40, 5, 0.35);
        double withdrawMoney = 100.0;
        double depositMoney = 500.0;
        double currBalance = savingsAccount1.Withdraw(withdrawMoney);
        Console.WriteLine("Interest Earned: {0}", savingsAccount1.CalculateInterest());
        Console.WriteLine(savingsAccount1.AccountBalance + "\n");
        Console.WriteLine(
            $"Successfully withdrawn {withdrawMoney} to {savingsAccount1.AccountName}. Balance is now {currBalance}");
        double depoBalance = savingsAccount1.Deposit(depositMoney);
        Console.WriteLine(
            $"Successfully deposited {depositMoney} to {savingsAccount1.AccountName}. Balance is now {depoBalance}\n");

        // CheckingAccount Instance
        CheckingAccount checkAccount1 = new("Slamet Riyadi", 678832, 145690.40, -345);
        checkAccount1.CloseAccount();
    }
}