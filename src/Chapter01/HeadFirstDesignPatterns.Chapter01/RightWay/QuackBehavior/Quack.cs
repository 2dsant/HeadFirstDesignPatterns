namespace HeadFirstDesignPatterns.Chapter01.RightWay.QuackBehavior;

public class Quack : IQuackBehavior
{
    void IQuackBehavior.Quack()
    {
        Console.WriteLine("QUA QUA QUA!");
    }
}
