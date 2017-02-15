using System;
using FoundationsMastery;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            int expected_length = mychars.Length;
            int actual_length = myString.Length;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            int expected_length = mychars.Length;
            int actual_length = myString.Length;
            string expected_type = "System.Char";
            string actual_type = myString.Contents.GetType().GetElementType().ToString();

            Assert.AreEqual(expected_length, actual_length);
            Assert.AreEqual(expected_type, actual_type);

        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            //char[] mychars = new char[] { 'a', 'b', 'c' };
            //CustomString myString = new CustomString(mychars);

            //int expected_sum = 0;
            //myString.Clear();
            //int actual_sum = (from content in myString.Contents select content).Cout

            //Assert.AreEqual(expected_sum, test);
        }

        [TestMethod]
        public void EnsureICanConcat ()
        {
            char[] mychars = new char[] { 'a', 'b', 'c', 'd' };
            CustomString myString = new CustomString(mychars);

            string expected_string = "abcdefgh";
            string actual_string = myString.Concat(new char[] { 'e', 'f', 'g', 'h' });

            Assert.AreEqual(expected_string, actual_string);
        }

        [TestMethod]
        public void EnsureICanInterleave()
        {
            char[] mychars = new char[] { 'a', 'e','b','f','c','g','d','h' };
            CustomString myString = new CustomString(mychars);

            string expected_string = "abcdefgh";
            string actual_string = myString.Interleave(mychars);

            Assert.AreEqual(expected_string, actual_string);
        }

        [TestMethod]
        public void EnsureICanPrint()
        {
            char[] mychars = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            CustomString myString = new CustomString(mychars);

            string expected_string = "abcdefgh";
            string actual_string = myString.Print();

            Assert.AreEqual(expected_string, actual_string);
        }
    }
}
