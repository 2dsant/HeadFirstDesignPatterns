namespace HeadFirstDesignPatterns.Chapter01.RightWay.QuackBehavior;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("I can't quack!");
    }
}
