public abstract class BeverageRecipe
{
    
    public void PrepareBeverage()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    
    protected abstract void Brew();
    protected abstract void AddCondiments();

    
    protected void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    protected void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }
}
