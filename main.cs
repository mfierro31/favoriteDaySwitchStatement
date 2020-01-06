using System;

namespace Csharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your favorite day of the week (as a number, 1 - 7.  1 being Sunday, 2 being Monday, etc.)? ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num <= 0 || num > 7)
            {
                Console.WriteLine("That's not a valid day of the week.  Try again.  Remember, 1 - 7 only.");
            } else
            {
                Console.WriteLine(GetDay(num) + " is your favorite day of the week!");
            }

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }

            return dayName;
        }
    }
}
