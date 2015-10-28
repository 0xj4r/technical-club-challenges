using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using CodingChallenge; 


namespace CodingChallengeTest
{
    /// <summary>
    /// Summary description for OutputPrinterTests
    /// </summary>
    [TestClass]
    public class OutputPrinterTests
    {
        public OutputPrinterTests()
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
        public void WriteOutputFile()
        {
            var inputFileId = "input_1.txt"; 
            var printer = new OutputPrinter();
            var inputFileList = new List<string> { "test", "input", "text" }; 
            printer.printOutputList(inputFileList, inputFileId);
            var reader = new StreamReader(@"output_1.txt");
            var outputText = reader.ReadToEnd();
            reader.Close();
            Assert.AreEqual("test\r\ninput\r\ntext\r\n", outputText);
            File.Delete(@"output_1.txt"); 
        }
    }
}
