using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // iterate through arguments
            for (int i = 0; i < args.Length; i++)
            {
                
                if (File.Exists(args[i])) // Checks to see if the file really exists
                {
                    StreamReader stream_reader = new StreamReader(args[i]); // Creates a file stream
                    string content = stream_reader.ReadToEnd(); // Reads the content into a variable
                    stream_reader.Close(); // Free the stream reader to allow read/write on the file again
                    Console.WriteLine(content); // Writes the content on screen
                    //Console.ReadLine(); // Awaits for a user input so the message can be seen
                } 
            }
        }
    }
}
