
# Day 3 Key Takeaways

Basic OOP: Inheritance by Interface, Abstract Class, concrete class; Polymorphism by overriding and overloading virtual and abstract method.

## Lessons Learned

### The Pillars: Inheritance and Polymorphism

When defining multiple classes in C#, one might found a class that has similar attributes, properties, and even methods.

To avoid redundancy and improve the reusability of the code, implementing inheritance and Polymorphism pillar is a must.

1. **Inheritance**

    The concept of deriving properties, methods, and behaviour of parent class to child class. In C#, a class can be inherited by default as a concrete class. C# provides `abstract` modifier to define an abstract class and `Interface` reference type to define a behaviour contract without base implementation.

2. **Polymorphism**

    Polymorphism emphasizes a specific behaviour implementation in child/derived classes while still maintaining the ability to be considered as common base type class. C# enables this by implementing `Override` methods in child classes to a `virtual` methods in parent class.

Observe the pillars implementation in a C# code snippet below:

```csharp
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
```

The code defines the abstract class `BankAccount`. In this example, the defined class has multiple properties:

- AccountName
- AccountNumber
- accountBalance

In this example we also overload the `ctor` of the `BankAccount` so it allows the user to construct its instance in multiple ways.

Observe how the abstract class only provides the definition in its `ctor` methods, but leave the `Deposit` and `Withdraw` methods empty and abstract. This implies that the `BankAccount` class only provides information for its implementation purposes but binds contract with every child class attempting to inherit its properties by those empty abstract methods.

This is different from Interface reference type that only provides the contracts to be bind when refered by child class.

```csharp
public interface IAccountCloseable
{
    void CloseAccount();
}
```

The provided examples imply that the `BankAccount` abstract class did not inherit `IAccountCloseable` interface so it doesn't have to implement `CloseAccount` method.

Moving on, now observe a child class sample code snippet below:

```csharp
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
```

The `CheckingAccount` class is a child class derived from `BankAccount` and complies with the `IAccountCloseable` interface. Here `CheckingAccount` inherits every property in `BankAccount` and extends by defining the integer attribute `overdraftLimit`. It implements the contract binded by the `BankAccount` class by overriding their abstract methods.

`CheckingAccount` class also implements the interface `IAccountCloseable` by implementing the void `CloseAccount` method. Removing any of the overriden methods or the interface contract would result in a compilation error.

`CheckingAccount` could also be extended by defining methods exclusive to its class' instances. But this is not provided by the example as the main purpose of the example is to emphasize Polymorphism Inheritance by introducing two different classes inheriting the parent `BankAccount` and imply the `IAccountCloseable` interface.

```csharp
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
```

Observe `SavingsAccount` another child class inherited from `BankAccount` above. The behaviour of the overriden methods are different from each child class, thus we have implemented the polymorphism pillar in this namespace.

`SavingsAccount` have defined another method `CalculateInterest` to extend its functionallity. This is allowable as long as the binded contracts have already fulfilled by the class definition.

### Example Class Diagram

The day 3 program class structure can be represented by this following class diagram.

![class diagram from day3 program](/Week1/Day3/Images/Class_Diagram.png)

## When To Use What

**Abstract Class**

- when you want to have a base implementation of a class
- when you want to derive this class to other specific implementation (polymorph)
- when you want the derived implementation of this class to have a default methods

**Interface**

- You want to determine a common set of enforced methods that multiple unrelated class can implement
- You want methods to be inherited by multiple classes, as C# doesn't support multiple inheritance by class

**Concrete Class**

- You want to have a single well-defined implementation of a class
- You want the child classes that inherit this class to only extend the behaviour of this class.

**Virtual Method**

- You want a method in the base class that can be overriden by its child
- You want the base class to have a default implementation of a method, but you let the children to have their own logic in implementing this method
- You don't want to enforce the implementation of this method in its children

**Abstract Method**

- You want to enforce the implementation of this method in every class that inherits this class
- You are okay with the base class for not implementing this method, but troubled to death if the child class not implementing this method
