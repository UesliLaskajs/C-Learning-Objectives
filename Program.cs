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

            double averageTemperature = averageWeather(totalTemperature, temperatures.Length);
            int maxTemp = findMax(temperatures);
            string commonWord = conditionCheck(conditions);
            // Display the results
            Console.WriteLine("\nWeather Report:");
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"Day {i + 1}: Temperature = {temperatures[i]}°C, Condition = {weatherConditions[i]},Max Temp:{maxTemp} Most Common Word:{commonWord}");
            }

            // Display the average temperature
            Console.WriteLine($"\nAverage Temperature: {averageTemperature:F2}°C");

            Console.ReadKey();
        }

        static double averageWeather(int totalTemp, int divider)
        {
            double average = totalTemp / divider;
            return average;
        }

        static int findMax(int[] tempreatures)
        {
            int max = tempreatures[0];
            for (var i = 0; i < tempreatures.Length; i++)
            {
                if (tempreatures[i] > max)
                {
                    max = tempreatures[i];
                }
            }
            return max;
        }

        static string conditionCheck(string[] conditons)
        {
            int count = 0;//Keep and Updated The count of most common Word
            string mostCommon = conditons[0];//Start with the first iteration

            for (var i = 0; i < conditons.Length; i++)//Itereate Through Conditions
            {
                int tempcount = 0;//Initalise A counter to be used on counting Common words
                for (var j = 0; j < conditons.Length; j++)//Iterate through the common words 
                {
                    if (conditons[i] == conditons[j])//Condition while iteration if current iteration is same with The iterating values
                    {
                        tempcount++;//Count added if condition met
                    }
                }

                if (tempcount > count)//if temp count is bigger than current cound swap with the last iteration
                {
                    count = tempcount;
                    mostCommon = conditons[i];
                }

            }
            return mostCommon;
        }


    }
    }

