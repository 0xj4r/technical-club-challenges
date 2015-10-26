using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 


namespace CodingChallenge
{
    public class InputReader
    {
        public InputReader()
        {

        
        }


        public string readFile(string filePath)
        {
            var reader = new StreamReader(@filePath);
            var fileText = reader.ReadToEnd();
            reader.Close();
            return fileText; 
        }
    }
}
