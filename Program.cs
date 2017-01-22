using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter distance in meters: ");
            int distanceInMetters = int.Parse(Console.ReadLine());
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            float mettersPerSecond = distanceInMetters / TimeInSes(hours, minutes, seconds);
            float kmPerHour = (distanceInMetters / 1000) / TimeInHours(hours, minutes, seconds);
            float milesPerHour = DistanceInMiles(distanceInMetters) / TimeInHours(hours, minutes, seconds);


            Console.WriteLine("Speed in meters per second: {0} m/s",mettersPerSecond);
            Console.WriteLine("Speed in kilometer per hour: {0} km/h", kmPerHour);
            Console.WriteLine("Speed in miles peer hour: {0} mph", milesPerHour);
        }
        static float TimeInSes (float hours, float minutes, float seconds)
        {
            float totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            return totalSeconds;
        }
        static float TimeInHours(float hours, float minutes, float seconds)
        {
            float totalHours = hours + (minutes / 60) + (seconds / 3600);
            return totalHours; 
        }
        static float DistanceInMiles (float distanceInMetters)
        {
            float distanceInMiles = distanceInMetters / 1609;
            return distanceInMiles;
        }
        
    }
}
