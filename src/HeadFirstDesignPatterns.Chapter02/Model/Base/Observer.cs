namespace HeadFirstDesignPatterns.Chapter02.Model.Base;

public abstract class Observer
{
    public abstract void Update(float temp, float humidity, float pressure);
}
