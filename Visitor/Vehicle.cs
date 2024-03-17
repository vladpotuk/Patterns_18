public abstract class Vehicle : IVisitable
{
    public string Model { get; set; }
    public int Year { get; set; }

    public abstract void Accept(IVisitor visitor);
}
