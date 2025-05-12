using HeadFirstDesignPatterns.Chapter02.Interfaces;
using HeadFirstDesignPatterns.Chapter02.Model.Base;

namespace HeadFirstDesignPatterns.Chapter02.Model;

public class CurrentConditionsDisplay : Observer, IDisplayElement
{
    private float Temperature;
    private float Humidity;
    private Subject WeatherData;

    public CurrentConditionsDisplay(Subject weatherData)
    {
        WeatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public override void Update(float temp, float humidity, float pressure)
    {
        this.Temperature = temp;
        this.Humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");
    }
}
