using HeadFirstDesignPatterns.Chapter01.RightWay;
using HeadFirstDesignPatterns.Chapter01.RightWay.FlyBehavior;

namespace HeadFirstDesignPatterns.Chapter01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();

            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            mallardDuck.SetFlyBehavior(new FlyNoWay());

            mallardDuck.PerformFly();
        }
    }
}
