using HeadFirstDesignPatterns.Chapter01.RightWay.FlyBehavior;
using HeadFirstDesignPatterns.Chapter01.RightWay.QuackBehavior;

namespace HeadFirstDesignPatterns.Chapter01.RightWay;

public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehaviour;

    public void PerformQuack()
    {
        quackBehaviour.Quack();
    }

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public abstract void Swim();

    public abstract void Display();

    public void SetQuackBehavior(IQuackBehavior behavior)
    {
        this.quackBehaviour = behavior;
    }

    public void SetFlyBehavior(IFlyBehavior behavior)
    {
        this.flyBehavior = behavior;
    }
}
