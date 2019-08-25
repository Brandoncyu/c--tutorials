using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare new class below.
            Car myCar = new Car();
            myCar.Make = "Hyundai";
            myCar.Model = "Accent";
            myCar.Year = 2013;
            myCar.Color = "Desert Blonde";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());


            Car myCar2 = new Car();
            myCar2.Make = "Pontiac";
            myCar2.Model = "Montana";
            myCar2.Year = 1989;
            myCar2.Color = "Beige";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar2.Make,
                myCar2.Model,
                myCar2.Year,
                myCar2.Color);
            Console.WriteLine("{0:C}", myCar2.DetermineMarketValue());

            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;

            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public object Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
        }
    }

}
