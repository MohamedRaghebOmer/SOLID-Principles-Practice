using System;

public class Employee
{
    public decimal Salary { get; }

    public Employee(decimal salary)
    {
        Salary = salary;
    }
}

public interface IBonusEligible
{
    decimal CalculateBonus();
}

public class FullTimeEmployee : Employee, IBonusEligible
{
    public FullTimeEmployee(decimal salary) : base(salary) { }

    public decimal CalculateBonus()
    {
        return Salary * 0.10m;
    }
}

public class Intern : Employee
{
    public Intern(decimal salary) : base(salary) { }
}

class Program
{
    static void Main()
    {
        IBonusEligible fullTime = new FullTimeEmployee(1000m);
        Console.WriteLine($"Full-time bonus: {fullTime.CalculateBonus():C}");

        Employee intern = new Intern(500m);
        Console.WriteLine($"Intern salary: {intern.Salary:C}");
    }
}
