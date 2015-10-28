using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CodingChallenge
{
    public class OutputPrinter
    {
        public OutputPrinter()
        {

        }

        public void printOutputList(List<string> inputFileList, string inputFileId)
        {
            var inputId = Int32.Parse(inputFileId.Substring(6, inputFileId.IndexOf('.') - 6));
            var outputWriter = new StreamWriter(@"output_" + inputId + ".txt");
            foreach (string s in inputFileList)
            {
                outputWriter.WriteLine(s);
            }

            outputWriter.Close(); 

        }
    }
}
