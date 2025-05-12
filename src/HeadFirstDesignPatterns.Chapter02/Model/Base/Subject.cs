namespace HeadFirstDesignPatterns.Chapter02.Model.Base;

public abstract class Subject
{
    public abstract void RegisterObserver(Observer o);
    public abstract void RemoveObserver(Observer o);
    public abstract void NotifyObservers();
}
