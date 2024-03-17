public class Motorcycle : Vehicle
{
    public override void Accept(IVisitor visitor)
    {
        visitor.VisitMotorcycle(this);
    }
}
