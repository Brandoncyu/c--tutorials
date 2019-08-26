using System;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Example.txt");
                Console.WriteLine(content);
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the directory is named correctly");
            }
            catch(Exception ex)
            {
                Console.WriteLine("There Was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Code to finalize
                //Setting objects to null
                //Closing Database connections.
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();
        }
    }
}
