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
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            Assert.IsNotNull(myString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            //CustomString myString = new CustomString();

            int expected_length = 3;
            int actual_length = myString.Length;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            myString.Contents = mychars;

            string expected_contents = "a, b, c";
            IEnumerable<char> actual_contents = myString.Contents;

            Assert.AreEqual(expected_contents, actual_contents);

            // 1. Assert that the Contents property is the correct 'type'
            // 2. Assert that the returned Contents is the coorect length
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            //CustomString myString = new CustomString();

            //myString.Clear();

            // How do you ensure your clear function works?
        }
    }
}
