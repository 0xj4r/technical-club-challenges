using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using CodingChallenge; 


namespace CodingChallengeTest
{
    /// <summary>
    /// Summary description for InputReaderTests
    /// </summary>
    [TestClass]
    public class InputReaderTests
    {
        public InputReaderTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ReadSingleInputFile()
        {
            var writer = new StreamWriter(@"C:\temp\input_1.txt");
            writer.WriteLine("input\r\ntest\r\none"); 
            writer.Close();
            var reader = new InputReader();
            var readerString = reader.readFile(@"C:\temp\input_1.txt");
            Assert.AreEqual("input\r\ntest\r\none\r\n", readerString);
            File.Delete(@"C:\temp\input_1.txt"); 



        }
    }
}
