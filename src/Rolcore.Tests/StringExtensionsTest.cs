﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rolcore;
using Rolcore.Geography;
using Rolcore.Text.RegularExpressions;
using System.Text.RegularExpressions;

namespace Rolcore.Tests
{
    
    
    /// <summary>
    ///This is a test class for StringExtensionMethodsTest and is intended
    ///to contain all StringExtensionMethodsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StringExtensionsTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for First
        ///</summary>
        [TestMethod()]
        public void FirstTest()
        {
            int numberOfCharacters = 10;
            string inString = "12345678901";
            string expected = "1234567890";
            string actual = inString.First(numberOfCharacters);
            Assert.AreEqual(expected, actual);

            inString = "12345";
            expected = "12345";
            actual = inString.First(numberOfCharacters);
            Assert.AreEqual(expected, actual);
        }

        #region Repeat tests
        /// <summary>
        ///A test for Repeat
        ///</summary>
        [TestMethod(), ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RepeatNegativeTest()
        {
            string s = "Hello world!";
            int numberOfTimes = -1;
            string expected = string.Empty;
            string actual = StringExtensions.Repeat(s, numberOfTimes);
            Assert.Fail("Should not reach this code.");
        }

        /// <summary>
        ///A test for Repeat
        ///</summary>
        [TestMethod()]
        public void Repeat0Test()
        {
            string expected = string.Empty;
            string actual = "Hello world!".Repeat(0);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Repeat
        ///</summary>
        [TestMethod()]
        public void Repeat1Test()
        {
            string expected = "Hello world!";
            string actual = expected.Repeat(1);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Repeat
        ///</summary>
        [TestMethod()]
        public void Repeat2Test()
        {
            string s = "Hello world!";
            string expected = s + s;
            string actual = s.Repeat(2);
            Assert.AreEqual(expected, actual);
            s = "Hello world!";
            expected = s + s + s;
            actual = s.Repeat(3);
            Assert.AreEqual(expected, actual);
        }
        #endregion Repeat tests

        /// <summary>
        ///A test for IsInUsa5DigitPostalCodeFormat
        ///</summary>
        [TestMethod()]
        public void IsInUsaPostalCodeFormatTest()
        {
            Assert.IsFalse("aaaaa".IsInUsaPostalCodeFormat());
            Assert.IsFalse("aaaaa-aaaa".IsInUsaPostalCodeFormat());

            Assert.IsFalse("12345-".IsInUsaPostalCodeFormat());
            Assert.IsFalse("-1234".IsInUsaPostalCodeFormat());

            Assert.IsFalse("aaaaa-1234".IsInUsaPostalCodeFormat());
            Assert.IsFalse("12345-aaaa".IsInUsaPostalCodeFormat());

            Assert.IsTrue("12345".IsInUsaPostalCodeFormat());
            Assert.IsTrue("12345-1234".IsInUsaPostalCodeFormat());
        }

        /// <summary>
        ///A test for ToRegEx
        ///</summary>
        [TestMethod()]
        public void HtmlTag_ToRegExTest()
        {
            Regex actual = CommonExpressions.HtmlTag.ToRegEx(RegexOptions.IgnoreCase);

            bool isValidRegex = actual.IsMatch("<html>");
            Assert.IsTrue(isValidRegex);

            isValidRegex = actual.IsMatch("<>");
            Assert.IsFalse(isValidRegex);

            isValidRegex = actual.IsMatch("<\"\">");
            Assert.IsFalse(isValidRegex);

            isValidRegex = actual.IsMatch("<br \\>");
            Assert.IsFalse(isValidRegex);
        }
    }
}
