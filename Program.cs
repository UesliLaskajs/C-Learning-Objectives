using System;

namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days:");
            int days = int.Parse(Console.ReadLine()); // Enter the number of days to make the array size

            int[] temperatures = new int[days]; // Created an integer array with the size of days
            string[] conditions = { "Sunny", "Rainy", "Snowing", "Cloudy" }; // Created the conditions for weather
            string[] weatherConditions = new string[days]; // Created a string array to store random weather conditions

            Random random = new Random(); // Create a single Random object

            for (int i = 0; i < days; i++) // Iterate through days
            {
                temperatures[i] = random.Next(-5, 35); // Generate random temperature

                // Determine weather condition based on temperature
                if (temperatures[i] >= 25)
                {
                    weatherConditions[i] = conditions[0]; // Sunny
                }
                else if (temperatures[i] >= 15)
                {
                    weatherConditions[i] = conditions[3]; // Cloudy
                }
                else if (temperatures[i] >= 5)
                {
                    weatherConditions[i] = conditions[2]; // Snowing
                }
                else
                {
                    weatherConditions[i] = conditions[1]; // Rainy
                }
            }

            // Calculate the sum of temperatures
            int totalTemperature = 0;
            foreach (var temp in temperatures)
            {
                totalTemperature += temp;
            }

            double averageTemperature=averageWeather(totalTemperature, temperatures.Length);

            // Display the results
            Console.WriteLine("\nWeather Report:");
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"Day {i + 1}: Temperature = {temperatures[i]}°C, Condition = {weatherConditions[i]}");
            }

            // Display the average temperature
            Console.WriteLine($"\nAverage Temperature: {averageTemperature:F2}°C");

            Console.ReadKey();
        }

        static double averageWeather(int totalTemp, int divider)
        {
            double average= totalTemp / divider;
            return average;
        }
    }
}
