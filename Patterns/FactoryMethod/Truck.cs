namespace DemoDesignPatterns.Patterns.FactoryMethod
{
  public class Truck : ITransport
  {
    public string Description { get; set; } = string.Empty;
    public void Send(string message)
    {
      Console.WriteLine("Truck is sending: " + message);
      Console.WriteLine("Description: " + Description);
    }
  }
}