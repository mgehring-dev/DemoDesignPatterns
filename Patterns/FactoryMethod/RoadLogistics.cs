namespace DemoDesignPatterns.Patterns.FactoryMethod
{
  public class RoadLogistics : Logistic
  {
      
    public override ITransport FactoryMethod()
    {
      return new Truck();
    }
  }
}