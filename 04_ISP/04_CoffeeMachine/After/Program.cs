using System;

public interface ICoffeeBrewer
{
    void BrewCoffee();
}

public interface IMilkSteamer
{
    void SteamMilk();
}

public interface IBeanGrinder
{
    void GrindBeans();
}

public interface ISelfCleaner
{
    void SelfClean();
}

public class BasicCoffeeMachine : ICoffeeBrewer
{
    public void BrewCoffee()
    {
        Console.WriteLine("Brewing coffee...");
    }
}

public class BaristaCoffeeMachine : ICoffeeBrewer, IMilkSteamer, IBeanGrinder, ISelfCleaner
{
    public void BrewCoffee()
    {
        Console.WriteLine("Brewing coffee...");
    }

    public void SteamMilk()
    {
        Console.WriteLine("Steaming milk...");
    }

    public void GrindBeans()
    {
        Console.WriteLine("Grinding beans...");
    }

    public void SelfClean()
    {
        Console.WriteLine("Self cleaning...");
    }
}

class Program
{
    static void Main()
    {
        BasicCoffeeMachine basic = new BasicCoffeeMachine();
        basic.BrewCoffee();

        BaristaCoffeeMachine barista = new BaristaCoffeeMachine();
        barista.BrewCoffee();
        barista.SteamMilk();
        barista.GrindBeans();
        barista.SelfClean();
    }
}
