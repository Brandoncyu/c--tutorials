using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            //string message = "";
            //
            //decision statement. double equals. "==" is true or false
            //if (userValue == "1") //don't need squigly if you just have one line.
            //    message = "You won a new car!";
            //else if (userValue == "2")
            //    message = "You won a new boat!";
            //else if (userValue == "3")
            //    message = "You don't win shit.";
            //else
            //{
            //    //need squigglies if you have more than one line.
            //    message = "Put in 1, 2 or 3, you dumbass. ";
            //    message += "You Lose.";
            //}
            //Console.WriteLine(message);

            string message = (userValue == "1") ? "boat" : "strand of lint";
            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");

            //you can enter variables in the WriteLine method.
            //Console.WriteLine("You won a {0}.", message);
            //Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);

            Console.ReadLine();

        }
    }
}
