
using HeadFirstDesignPatterns.Chapter01.RightWay.FlyBehavior;
using HeadFirstDesignPatterns.Chapter01.RightWay.QuackBehavior;

namespace HeadFirstDesignPatterns.Chapter01.RightWay;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        this.quackBehaviour = new Quack();
        this.flyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("i'm a readl mallard duck");
    }

    public override void Swim()
    {
        Console.WriteLine("swimming...");
    }
}
