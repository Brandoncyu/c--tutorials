using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //use /" to insert quotations.
            //string myString = "My \"so-called\" life";

            //use /n to insert a lie.
            //string myString = "What if I need a\nnew line?";

            //string myString = "Got to your c:\\ drive";
            //string myString = @"Got to your c:\ drive";

            //string myString = String.Format("{0} = {1}", "First", "Second");

            //Currency
            //string myString = string.Format("Currency: {0:C}", 123.45);

            //Decimals and Commas
            //string myString = string.Format("Decimals and Commas {0:N}", 1234567890);

            //Percentage
            //string myString = string.Format("Percentage {0:P}", .123);

            //Phone Number
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);

            //various others
            //string myString = " That summer we took threes across the board ";
            //myString = myString.Trim();
            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "-");
            //myString = myString.Remove(6, 15);

            //myString = String.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            /*
            string myString = "";
            for(int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
