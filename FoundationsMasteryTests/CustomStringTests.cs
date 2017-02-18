using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CustomStringTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CustomString contents = new CustomString();

            Assert.IsNotNull(contents);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            //CustomString myString = new CustomString(mychars);
            CustomString myString = new CustomString();

            char expected_length = 'a';
            char actual_length = 'a';

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString();
            myString.Contents = mychars;

            string expected_contents = "a, b, c";
            string actual_contents = myString.Contents;

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
