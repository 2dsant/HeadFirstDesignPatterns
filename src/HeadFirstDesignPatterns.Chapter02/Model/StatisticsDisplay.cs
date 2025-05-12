using HeadFirstDesignPatterns.Chapter02.Interfaces;
using HeadFirstDesignPatterns.Chapter02.Model.Base;
using System.Runtime.InteropServices.JavaScript;

namespace HeadFirstDesignPatterns.Chapter02.Model;

public class StatisticsDisplay : Observer, IDisplayElement
{
    private float MaxTemp = 0.0f;
    private float MinTemp = 200;//set intial high so that minimum 
                                //is set first invokation
    private float TemperatureSum = 0.0f;
    private int NumReadings = 0;
    private Subject WeatherData;

    public StatisticsDisplay(Subject weatherData)
    {
        this.WeatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine("Avg/Max/Min temperature = " + RoundFloatToString(TemperatureSum / NumReadings) +
            "F/" + MaxTemp + "F/" + MinTemp + "F");
    }

    public override void Update(float temp, float humidity, float pressure)
    {
        TemperatureSum += temp;
        NumReadings++;

        if (temp > MaxTemp)
        {
            MaxTemp = temp;
        }

        if (temp < MinTemp)
        {
            MinTemp = temp;
        }
    }

    public static string RoundFloatToString(float floatToRound)
    {
        System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
        cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
        cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
        return floatToRound.ToString("F", cultureInfo);
    }
}
