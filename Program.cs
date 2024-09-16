using System;

namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The input Of Days :");
            int days = int.Parse(Console.ReadLine());//Enter The Number Of Days to Make the Array number to pass

            int[] temprature = new int[days];//Created a Integer Array with the Days on input
            string[] conditions = { "Sunny", "Rainy", "Snowing", "Cloudy" };//Created The conditions For Weather
            string[] weatherConditions = new string[days];

            for(int i=0; i < days; i++)
            {
                Random random = new Random();
                temprature[i]=random.Next(-5,35);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

        }
    }
}
