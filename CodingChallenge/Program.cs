using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using CodingChallenge; 

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
                    InputReader reader = new InputReader();
                    TextParser parser = new TextParser();   
                    OutputPrinter printer = new OutputPrinter();
                    printer.printOutputList(parser.ParseSortedList(reader.readFile(args[i])), args[i].ToString());
                } 
            }
        }
    }
}
