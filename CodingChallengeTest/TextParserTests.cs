using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge;
using System.Collections.Generic; 
namespace CodingChallengeTest
{
    [TestClass]
    public class TextParserTests
    {
        [TestMethod]
        public void TestReadString()
        {
            var runner = new TextParser(); 
            var tempString = "this"; 
            var parsedString = runner.Parse(tempString); 
            Assert.AreEqual(tempString, parsedString);
        }

        [TestMethod]
        public void ParseList()
        {
            var runner = new TextParser();
            var listString = "first second third"; 
            var parsedList = runner.ParseString(listString); 
            Assert.AreEqual(parsedList.Count, 3);
            Assert.AreEqual(parsedList[1], "second");     
        }

        [TestMethod]
        public void ParseWithDelimeters()
        {
            var runner = new TextParser();
            var listString = @"first, second, / \ + = . , & third";
            var parsedList = runner.ParseString(listString);
            Assert.AreEqual(3, parsedList.Count);
            Assert.AreEqual(parsedList[1], "second");
        }
        
        [TestMethod]
        public void ParseStringsWithApostraphe()
        {
            var runner = new TextParser();
            var listString = "we're coding";
            var parsedList = runner.ParseString(listString);
            Assert.AreEqual(2, parsedList.Count);
            Assert.AreEqual(parsedList[0], "we're");
        }

        [TestMethod]
        public void ParseSortedList()
        {
            var runner = new TextParser();
            var listString = "we're coding";
            var parsedList = runner.ParseSortedList(listString);
            Assert.AreEqual(2, parsedList.Count);
            Assert.AreEqual(parsedList[1], "we're");
        }

        [TestMethod]
        public void ParseUniqueList()
        {
            var runner = new TextParser();
            var listString = "we're coding coding coding we're";
            var parsedList = runner.ParseSortedList(listString);
            Assert.AreEqual(2, parsedList.Count);
            Assert.AreEqual(parsedList[1], "we're");
        }

    }
}
