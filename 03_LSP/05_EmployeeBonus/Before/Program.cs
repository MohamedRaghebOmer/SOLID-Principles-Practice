using System;

public class Employee
{
    public virtual decimal CalculateBonus(decimal salary)
    {
        return salary * 0.10m;
    }
}

public class Intern : Employee
{
    public override decimal CalculateBonus(decimal salary)
    {
        throw new NotSupportedException("Interns do not receive bonuses.");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Intern();
        Console.WriteLine(employee.CalculateBonus(1000m)); // LSP violation.
    }
}
