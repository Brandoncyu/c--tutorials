using System;
using System.IO;
using System.Net;

namespace AssembliesAndNameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //full name is System.Console.WriteLine("Hello World!");
            //looks inside System.
            Console.WriteLine("Hello World!");

            
            //WebClient is from System.net
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.miscorsoft.com");

            //File is from System.IO
            File.WriteAllText(@"C:\Lesson17\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
