using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace CodingChallenge
{
    public class TextParser
    {
        public TextParser()
        {

        }

        public string Parse(string tempString)
        {
            var localString = tempString;
            return localString; 
        }

        public List<string> ParseString(string tempString)
        {
            var cleanString = Regex.Replace(tempString, "[^0-9a-zA-Z']+", " ");
            return cleanString.Split().Distinct().ToList(); 
        }

        public List<string> ParseSortedList(string listString)
        {
            List<string> parsedList = ParseString(listString);
            parsedList.Sort();
            return parsedList; 
        }

      
    }
}
