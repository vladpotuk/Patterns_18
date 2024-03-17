public class Car : Vehicle
{
    public override void Accept(IVisitor visitor)
    {
        visitor.VisitCar(this);
    }
}
