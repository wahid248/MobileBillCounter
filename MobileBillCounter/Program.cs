using System;
using System.Text.RegularExpressions;

namespace MobileBillCounter
{
    class Program
    {
        static void Main()
        {
            string start = string.Empty;
            string end = string.Empty;
            var regex = @"(\d{4})-(\d{2})-(\d{2}) (\d{2}):(\d{2}):(\d{2}) ([aApP][mM])";
            double bill = 0;

            Console.WriteLine("Please enter the times in a 12 hour format e.g: yyyy-MM-dd hh:mm:ss tt\n");
            do
            {
                if(!string.IsNullOrEmpty(start)) Console.WriteLine("Not a valid input format. Please try again");
                Console.Write("Start Time: ");
                start= Console.ReadLine();
            } while (!Regex.Match(start, regex, RegexOptions.IgnoreCase).Success);

            do
            {
                if (!string.IsNullOrEmpty(end)) Console.WriteLine("Not a valid input format. Please try again");
                Console.Write("End Time: ");
                end= Console.ReadLine();
            } while (!Regex.Match(end, regex, RegexOptions.IgnoreCase).Success);

            var startTime = DateTime.ParseExact(start, "yyyy-MM-dd hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            var endTime = DateTime.ParseExact(end, "yyyy-MM-dd hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            var totalSeconds = (endTime - startTime).TotalSeconds;
            var currentTime = startTime;

            for(int i = 0; i < Math.Truncate(totalSeconds / 20) + 1; i++)
            {
                currentTime = currentTime.AddSeconds(20);

                if (9 <= currentTime.Hour && currentTime.Hour <= 22)
                {
                    bill += 30;
                }
                else
                {
                    bill += 20;
                }
            }

            Console.WriteLine($"{bill/100} Taka");
        }
    }
}
