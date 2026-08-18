using System;
class TemperatureSensor
{
    public delegate void TemperatureAlertHandler(string message);

    public event TemperatureAlertHandler TemperatureExceeded;
    private double threshold = 40;

    public void checkTemperature(double temperature)
    {
        Console.WriteLine("Current Temperature:" + temperature);
        if (temperature > threshold)
        {
            TemperatureExceeded?.Invoke("Alert! temperature has crossed the threshold.");
        }
    }
}
class Program
{
    static void Main()
    {
        TemperatureSensor sensor = new TemperatureSensor();
        sensor.TemperatureExceeded += ShowAlert;
        sensor.checkTemperature(35);
        sensor.checkTemperature(42);

    }
    static void ShowAlert(string message)
    {
        Console.WriteLine(message);
    }
}