namespace CompositePattern;

public class Engineer : Employee
{
    public Engineer(string name) : base(name)
    {
        
    }
    public override string Role()
    {
        return "Developer";
    }
    public override string Work()
    {
        return"Diligently writing some codes..";
    }
    public override bool HasSubordinates()
    {
        return false;
    }
    
}
