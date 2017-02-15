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
            CustomString testString = new CustomString(new List<char>());

            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myOtherString = new CustomString(mychars);

            Assert.IsNotNull(testString);
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

            //public IEnumerable<char> Contents;
            //Contents testContents = new Contents;
            var expected = typeof(IEnumerable<char>);
            var actual = myString.Contents.GetType();


            //// 1. Assert that the Contents property is the correct 'type'
            Assert.IsInstanceOfType(myString.Contents, typeof(IEnumerable<char>));

            //// 2. Assert that the returned Contents is the correct length
            Assert.AreEqual(myString.Length, mychars.Length);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            CustomString myString = new CustomString();

            myString.Clear();

            // How do you ensure your clear function works?
        }
    }
}
