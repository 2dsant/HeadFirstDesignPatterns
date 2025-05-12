using HeadFirstDesignPatterns.Chapter02.Interfaces;
using HeadFirstDesignPatterns.Chapter02.Model.Base;
using System.Text;

namespace HeadFirstDesignPatterns.Chapter02.Model;

public class ForecastDisplay : Observer, IDisplayElement
{
    private float CurrentPressure = 29.92f;
    private float LastPressure;
    private Subject WeatherData;

    public ForecastDisplay(Subject weatherData)
    {
        this.WeatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public override void Update(float temperature, float humidity, float pressure)
    {
        LastPressure = CurrentPressure;
        CurrentPressure = pressure;
    }

    public void Display()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Forecast: ");

        if (CurrentPressure > LastPressure)
        {
            sb.Append("Improving weather on the way!");
        }
        else if (CurrentPressure == LastPressure)
        {
            sb.Append("More of the same");
        }
        else if (CurrentPressure < LastPressure)
        {
            sb.Append("Watch out for cooler, rainy weather");
        }

        Console.WriteLine(sb.ToString());
    }
}
