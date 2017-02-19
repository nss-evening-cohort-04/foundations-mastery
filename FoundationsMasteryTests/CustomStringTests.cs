using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery.Classes;
using System.Collections.Generic;

namespace FoundationsMasteryTests.Classes
{
    [TestClass]
    public class CustomStringTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CustomString customString = new CustomString(new List<char>());
            Assert.IsNotNull(customString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            int expected_length = myString.Length;
            int actual_length = 3;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            var charType = myString.Contents.GetType().ToString();

            // 1. Assert that the Contents property is the correct 'type'
            Assert.AreEqual("System.Char[]", charType);

            //2.Assert that the returned Contents is the coorect length
            int expected_length = myString.Length;
            int actual_length = 3;
            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            myString.Clear();

            // How do you ensure your clear function works?
            var expected = myString.Length;
            var actual = 0;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void EnsureConcatWorks()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            char[] otherchars = new char[] { 'x', 'y', 'z' };
            CustomString otherstring = new CustomString(otherchars);

            var expected = myString.Concat(otherchars).ToString();
            var actual = "abcxyz";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureInterleaveWorks()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            char[] myOtherchars = new char[] { 'x', 'y', 'z' };
            CustomString myOtherString = new CustomString(mychars);

            var expected = myString.Interleave(myOtherchars);
            var actual = "axbycz";
            Assert.AreEqual(expected, actual);
        }
    }
}
