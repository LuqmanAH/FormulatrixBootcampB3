using NoPattern;
namespace NoPatternProgram;

public class NoPatternProgram
{
    static void Main()
    {
        EmployeePortal employeePortal = new EmployeePortal();

        Manager burhan = new Manager("burhan");
        Manager khoirudin = new Manager("khoirudin");
        Manager alek = new Manager("alek");

        Engineer ahmat = new Engineer("ahmat");
        Engineer soleh = new Engineer("soleh");

        string workInfo = employeePortal.ManagerAssignWork(burhan, soleh, ahmat);
        Display(workInfo);

        Separate("-----");

        //! compilation error because type mismatch : alek
        // string workManager = employeePortal.ManagerAssignWork(khoirudin, alek);
        // Display(workManager);


    }

    static void Display<T>(T message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    static void Separate<T>(T message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}