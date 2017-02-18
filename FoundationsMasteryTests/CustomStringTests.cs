using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;
using System.Collections.Generic;
using System.Linq;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CustomStringTests
    {

        //Instance of is not null
        //Contents is not null with empty constructor
        //Contents is not null when passing in ienumerable for contents
        //.Length gives accurate count of ienumerable
        //.Clear removes all char from .Content
        //.Clear leaves you with a list/array/ienumerable (not null) for .Contents
        //Concat makes correct string
        //Interleave makes correct string
        //Print makes correct string

        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CustomString customString = new CustomString();
            Assert.IsNotNull(customString);
        }

        [TestMethod]
        public void EnsureICanCreateAnInstanceCustom()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString customString = new CustomString(mychars);
            Assert.IsNotNull(customString);
            Assert.IsNotNull(customString.Contents);
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

            int expectedLength = mychars.Length;
            int actualLength = myString.Length;

            // 1. Assert that the Contents property is the correct 'type'
            Assert.IsInstanceOfType(myString.Contents, typeof(IEnumerable<char>));
            
            // 2. Assert that the returned Contents is the correct length
            Assert.AreEqual(expectedLength, actualLength);
            Assert.IsNotNull(myString.Contents);

            CollectionAssert.AreEqual(mychars.ToList(), myString.Contents.ToList());
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            myString.Clear();

            int expectedLength = 0;
            int actualLength = myString.Length;

            Assert.AreEqual(expectedLength, actualLength);
            // How do you ensure your clear function works?
            Assert.IsNotNull(myString.Contents);
        }

        [TestMethod]
        public void EnsureConcatReturnsCorrectString()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            char[] newChars = new char[] { 'x', 'y', 'z' };

            var expectedResult = "abcxyz";
            var actualResult = myString.Concat(newChars);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureInterleaveReturnsCorrectString()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            char[] newChars = new char[] { 'x', 'y', 'z', '1' };

            var expectedResult = "axbycz";
            var actualResult = myString.Interleave(newChars);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintReturnsCorrectString()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            var expectedResult = "abc";
            var actualResult = myString.Print();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
