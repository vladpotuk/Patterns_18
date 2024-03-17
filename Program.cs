using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Making tea...");
        BeverageRecipe tea = new TeaRecipe();
        tea.PrepareBeverage();

        Console.WriteLine("\nMaking coffee...");
        BeverageRecipe coffee = new CoffeeRecipe();
        coffee.PrepareBeverage();
    }
}
