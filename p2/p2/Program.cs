using System;

namespace p2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("inter the total days that u were in this earth : ");
            var days = Convert.ToInt32(Console.ReadLine());
            var getYears = GetYear(days);
            int getMonths = GetMonth(days, getYears);
            int getWeeks = GetWeek(days, getMonths, getYears);
            int getdays = GetDays(days, getMonths, getYears, getWeeks);
            Console.WriteLine($"you were in this world for about {getYears} years and {getMonths} months and {getWeeks} weeks and {getdays} days ");

        }
        private static int GetDays(int days, int getMonths, int getYears, int getWeeks)
        {
            return (days - ((getYears * 365) + (getMonths * 30) + (getWeeks * 7)));
        }

        private static int GetWeek(int days, int getMonths, int getYears)
        {
            var week = days - ((getMonths * 30) + (getYears * 365));
            var re = Math.DivRem(week, 7);
            return re.Quotient;
        }

        private static int GetMonth(int days, int getYears)
        {
            var month = days - getYears * 365;
            var re = Math.DivRem(month, 30);
            return (re.Quotient);
        }

        private static int GetYear(int days)
        {
            var age = Math.DivRem(days, 365);
            return age.Quotient;
        }
    }
}//کدش درسته ولی چرا نمیشناسه برا تو نمیدونم رو سیستم من ران بگیر وصل شو به من 
