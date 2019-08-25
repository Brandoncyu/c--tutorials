using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //int x;
            //int y;

            int x = 7;
            int y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            //use lightbult to rename everything.
            Console.WriteLine("What Is Your name?");
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            //Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.WriteLine("Hello, {0} {1}", myFirstName, myLastName);
        }
    }
}
