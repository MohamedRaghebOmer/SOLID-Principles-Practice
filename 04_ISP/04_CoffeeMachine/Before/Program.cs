using System;

public interface ICoffeeMachine
{
    void BrewCoffee();
    void SteamMilk();
    void GrindBeans();
    void SelfClean();
}

public class BasicCoffeeMachine : ICoffeeMachine
{
    public void BrewCoffee()
    {
        Console.WriteLine("Brewing coffee...");
    }

    public void SteamMilk()
    {
        throw new NotImplementedException();
    }

    public void GrindBeans()
    {
        throw new NotImplementedException();
    }

    public void SelfClean()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        ICoffeeMachine machine = new BasicCoffeeMachine();
        machine.BrewCoffee();
    }
}
