using System;
using System.Collections.Generic;
using System.Linq;

//Language INtegrated Query Syntax. Filter and Sort data types.
namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() {VIN="A1", Make="BMW", Model="550i", StickerPrice=55000, Year=2009},
                new Car() {VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() {VIN="C3", Make="BMW", Model="745li", StickerPrice=75000, Year=2008},
                new Car() {VIN="D4", Make="Ford", Model="Escape55i", StickerPrice=25000, Year=2008},
                new Car() {VIN="E5", Make="BMW", Model="4Runner", StickerPrice=57000, Year=2010}
            };

            // LINQ query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            */

            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            // LINQ method
            //var bmws = myCars.Where(car => car.Make == "BMW" && car.Year ==2010);
            ////(car => car.Make) is a lambda expression - a mini-method.

            //Order By Descending
            //var orderedCars = myCars.OrderByDescending(car => car.Year);



            //foreach (var car in orderedCars)
            //{
            //    Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            //}

            //First
            /*
            //var first = myCars.First(car => car.Make == "BMW");
            var first = myCars.OrderByDescending(p=> p.Year).First(car => car.Make == "BMW");

            Console.WriteLine(first.VIN);
            */

            //True for All
            /*
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));
            */

            //Reduce a bunch
            /*
            myCars.ForEach(car => car.StickerPrice -= 3000);
            myCars.ForEach(car => Console.WriteLine("{0} {1:C}", car.VIN, car.StickerPrice));
            */

            //Exists
            /*
            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            */

            //Sum
            /*
            Console.WriteLine(myCars.Sum(p => p.StickerPrice));
            */

            //finds the type.
            /*
            Console.WriteLine(myCars.GetType());

            var orderedCars = myCars.OrderByDescending(car => car.Year);
            Console.WriteLine(orderedCars.GetType());

            var bmws = myCars.Where(car => car.Make == "BMW" && car.Year == 2010);
            Console.WriteLine(bmws.GetType());

            var newCars = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());
            */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
