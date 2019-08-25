using System;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = " ";
        //private means it can be used within the class.
        //public method means it can be called outside the class.

        static void Main(string[] args)
        {
            string j = " ";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i;
                }
                //Console.WriteLine(l);
            }
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }
    }

    class Car
    {
        //private means it can be used within the class.
        //public method means it can be called outside the class. Do Something
        //will be called outside the Car Class, helper method will not.
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}
