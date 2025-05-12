using HeadFirstDesignPatterns.Chapter02.Model.Base;

namespace HeadFirstDesignPatterns.Chapter02.Model;

public class WeatherData : Subject
{
    private IList<Observer> Observers = new List<Observer>();
    private float Temperature;
    private float Humidity;
    private float Pressure;

    public WeatherData() { }

    public override void RegisterObserver(Observer o)
    {
        Observers.Add(o);
    }

    public override void NotifyObservers()
    {
        foreach (var observer in Observers)
        {
            observer.Update(Temperature, Humidity, Pressure);
        }
    }

    public override void RemoveObserver(Observer o)
    {
        Observers.Remove(o);
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void setMeasurements(float temperature, float humidity, float pressure)
    {
        this.Temperature = temperature;
        this.Humidity = humidity;
        this.Pressure = pressure;
        MeasurementsChanged();
    }
}
