using HeadFirstDesignPatterns.Chapter02.Interfaces;
using HeadFirstDesignPatterns.Chapter02.Model.Base;

namespace HeadFirstDesignPatterns.Chapter02.Model;

public class HeatIndexDisplay : Observer, IDisplayElement
{
    private float HeatIndex = 0.0f;
    private Subject WeatherData;

    public HeatIndexDisplay(Subject weatherData)
    {
        this.WeatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine("Heat index is " + HeatIndex);
    }

    public override void Update(float temp, float humidity, float pressure)
    {
        HeatIndex = ComputeHeatIndex(temp, humidity);
    }

    private float ComputeHeatIndex(float temperature, float relativeHumidity)
    {
        float heatIndex = (float)((16.923 + (0.185212 * temperature) +
            (5.37941 * relativeHumidity) - (0.100254 * temperature * relativeHumidity) +
            (0.00941695 * (temperature * temperature)) +
            (0.00728898 * (relativeHumidity * relativeHumidity)) +
            (0.000345372 * (temperature * temperature * relativeHumidity)) -
            (0.000814971 * (temperature * relativeHumidity * relativeHumidity)) +
            (0.0000102102 * (temperature * temperature * relativeHumidity * relativeHumidity)) -
            (0.000038646 * (temperature * temperature * temperature)) +
            (0.0000291583 * (relativeHumidity * relativeHumidity * relativeHumidity)) +
            (0.00000142721 * (temperature * temperature * temperature * relativeHumidity)) +
            (0.000000197483 * (temperature * relativeHumidity * relativeHumidity * relativeHumidity)) -
            (0.0000000218429 * (temperature * temperature * temperature * relativeHumidity * relativeHumidity)) +
            0.000000000843296 * (temperature * temperature * relativeHumidity * relativeHumidity * relativeHumidity)) -
            (0.0000000000481975 * (temperature * temperature * temperature * relativeHumidity * relativeHumidity * relativeHumidity)));

        return heatIndex;
    }
}
