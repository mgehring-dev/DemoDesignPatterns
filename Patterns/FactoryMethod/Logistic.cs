namespace DemoDesignPatterns.Patterns.FactoryMethod
{
  public abstract class Logistic
  {
    public abstract ITransport FactoryMethod();

    public void SomeOperation()
    {
      var transport = FactoryMethod();
      transport.Description = "Description of transport";
      transport.Send("Hello from Logistic!");
    }
  }
}