namespace CompositePattern;

public class EmployeePortal
{
    public string AssignWork(Employee employee, params Employee[] subordinates)
    {
        if (employee.HasSubordinates())
        {
            employee.AddSubordinate(subordinates);
        }
        return employee.Work();
    }
}
