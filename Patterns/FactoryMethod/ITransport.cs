namespace DemoDesignPatterns.Patterns.FactoryMethod
{
  public interface ITransport
  {
    public string Description { get; set; }
    void Send(string message);
  }
}