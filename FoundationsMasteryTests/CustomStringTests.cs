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
            CustomString myString = new CustomString();

            Assert.IsNotNull(myString);
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
            var content = myString.Contents;
            var contentLength = myString.Length;

            Assert.AreEqual(content.GetType(), typeof(char[]));

            // 2. Assert that the returned Contents is the coorect length
            int expected_length = 3;

            Assert.AreEqual(expected_length, contentLength);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            myString.Clear();

            // How do you ensure your clear function works?
            var myContents = myString.Contents;

            Assert.IsNull(myContents);
        }

        [TestMethod]
        public void EnsureICanPrint()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            var expectedResults = "abc";
            var actualResults = myString.Print();

            Assert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        public void EnsureConcatIsFunctioning()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            char[] mychars2 = new char[] { 'd', 'e', 'f' };
            CustomString myString = new CustomString(mychars);

            var expectedResults = "abcdef";
            var actualResults = myString.Concat(mychars2);

            Assert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        public void EnsureInterleaveIsFunctioning()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            char[] mychars2 = new char[] { 'd', 'e', 'f' };
            CustomString myString = new CustomString(mychars);

            var expectedResults = "adbecf";
            var actualResults = myString.Interleave(mychars2);

            Assert.AreEqual(expectedResults, actualResults);
        }
    }
}
