using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine("ToString: " + myValue.ToString());
            //Console.WriteLine("ToShortDateString: " + myValue.ToShortDateString());
            //Console.WriteLine("ToShortTimeString: " + myValue.ToShortTimeString());
            //Console.WriteLine("ToLongDateString: " + myValue.ToLongDateString());
            //Console.WriteLine("ToLongTimeString: " + myValue.ToLongTimeString());

            //Console.WriteLine("AddDays: " + myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine("AddHours: " + myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine("AddDays (Negative): " + myValue.AddDays(-3).ToLongDateString());

            //Console.WriteLine("Month: " + myValue.Month);

            //Year, Month, Day.
            //DateTime myBirthday = new DateTime(1989, 3, 5);
            DateTime myBirthday = DateTime.Parse("3/5/1989");
            Console.WriteLine("Birthday: " + myBirthday);

            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine("Total Days: " + myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
