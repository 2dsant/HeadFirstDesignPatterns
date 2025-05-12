namespace HeadFirstDesignPatterns.Chapter01.RightWay.FlyBehavior;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly!");
    }
}
