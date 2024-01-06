using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("/// Erzurum Weather ///");

        // Uncomment the line below to receive user input for temperature
        // Console.WriteLine("Please enter the temperature:");
        int temperature = 24; // Convert.ToInt32(Console.ReadLine());

        // Check the weather conditions based on the temperature
        if (temperature <= (int)WeatherCondition.VeryHot)
        {
            Console.WriteLine("The weather is ideal for outdoor activities :)");
        }
        else if (temperature <= (int)WeatherCondition.Cold)
        {
            Console.WriteLine("The weather is very cold; avoid going outside if not necessary!");
        }
        else if (temperature >= (int)WeatherCondition.Normal && temperature <= (int)WeatherCondition.VeryHot)
        {
            Console.WriteLine("The temperature is neither too hot nor too cold; it's the perfect time for coffee :)");
        }
    }
}

// Enum to represent different weather conditions
enum WeatherCondition
{
    Normal = 10,
    AboveNormal = 15,
    Hot = 20,
    VeryHot = 25,
    Cold = 0,
}
