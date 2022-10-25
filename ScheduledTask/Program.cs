using System;
using System.IO;
using System.Text;

namespace ScheduledTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now; //Time now 
            var nextTime = DateTime.Now.AddMinutes(2); //Add 2 minutes
            CreateTextFile();            
            Console.WriteLine("Hi! This is ScheduledTask. Now is "+time+ ". The next time the program is launched will be in 2 minutes at "+nextTime);
            Console.ReadKey();
        }
        static void CreateTextFile()
        {
            string testFile = @"C:\Temp\TestFile.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(testFile))
                {
                    File.Delete(testFile);
                }

                // Create a new TestFile.txt file     
                using (FileStream fs = File.Create(testFile))
                {
                    // Ask user to type text into text file
                    string userText = Console.ReadLine();
                    byte[] text = new UTF8Encoding(true).GetBytes(userText);
                    fs.Write(text, 0, text.Length);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
    }
}
