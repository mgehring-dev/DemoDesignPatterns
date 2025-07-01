namespace DemoFactory;

public class Client
{
  public void Main()
  {
    var logistic = new RoadLogistics();
    logistic.SomeOperation();
  }
}