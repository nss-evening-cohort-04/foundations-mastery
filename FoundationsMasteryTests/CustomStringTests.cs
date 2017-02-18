using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;
using System.Collections.Generic;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CustomStringTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CustomString customString = new CustomString();

            Assert.IsNotNull(customString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            int expected_length = 3;
            int actual_length = myString.Length;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            // 1. Assert that the Contents property is the correct 'type'
            Assert.IsInstanceOfType(myString.Contents, typeof(IEnumerable<char>));

            // 2. Assert that the returned Contents is the coorect length
            int expectedLength = 3;
            int actualLength = myString.Length;
            Assert.AreEqual(expectedLength, actualLength);
        }


        [TestMethod]
        public void EnsureICanInterleaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c', 'c' };
            CustomString myString = new CustomString(mychars);

            string expectedResult = "aabbccc";
            string actualResult = myString.Interleave(new char[] { 'a', 'b', 'c' });

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c', 'c' };
            CustomString myString = new CustomString(mychars);

            myString.Clear();

            // How do you ensure your clear function works?
            int expectedLength = 0;
            int actualLength = myString.Length;
            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void EnsurePrintReturnsAString()
        {
            char[] mychars = new char[] { 'a', 'b', 'c', 'c' };
            CustomString myString = new CustomString(mychars);

            string expectedResult = "abcc";
            string actualResult = myString.Print();

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
