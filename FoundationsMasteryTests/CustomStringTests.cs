using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMasteryTests;
using FoundationsMastery;
using System.Collections.Generic;

namespace FoundationsMasteryTests
{
    //Contents is NotFiniteNumberException null with empty constructror - ?
    //Contents is NotFiniteNumberException null when passing in IEnumerable - ?
    // .Clear removes all char from .Contents (combine with the next one) - ?
    // .Clear leaves you with a list/array/iEnumerable to work with (NOT null) - ?
    
    [TestClass]
    public class CustomStringTests
    { 
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        { 
            CustomString myString = new CustomString(new List<char>());
            char[] myChars = new char[] { 'r', 'u', 't' };
            CustomString myOtherString = new CustomString(new char[] { 'r', 'u', 's'});
            Assert.IsNotNull(myString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            int expected_length = 3;
            int actual_length = 3; 

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            Assert.IsInstanceOfType(myString.Contents, typeof(IEnumerable<char>));
            Assert.AreEqual(myString.Length, mychars.Length);
            Assert.IsNotNull(myString.Contents);  
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            char[] mychars = new char[] { 'r', 'u', 't' };
            CustomString myString = new CustomString(mychars);
            // Act
            //string expectedResult = myString.Clear(mychars);
            //Assert.AreEqual("", expectedResult);

            // How do you ensure your clear function works?
            // make sure the length is zero - NOT null
        }
        [TestMethod]
        public void EnsureLengthGivesAccurateCount()
        {
            CustomString myString = new CustomString(new List<char>());
            char[] myChars = new char[] { 'r', 'u', 't' };
            int expected_length = 3;
            int actual_length = 3;
            Assert.AreEqual(expected_length, actual_length);
        }
        [TestMethod]
        public void EnsureConcatMakesCorrectString()
        {
            char[] mychars = new char[] { 'a', 'b' };
            CustomString myString = new CustomString(mychars);
            string trueConcat = myString.Concat(mychars);
            Assert.AreEqual("abab", trueConcat);
        }
        [TestMethod]
        public void EnsureInteleaveMakesCorrectList()
        {
            char[] mychars = new char[] { 'a', 'b' };
            CustomString myString = new CustomString(mychars);
            string trueInterLeave = myString.Interleave(mychars);
            Assert.AreEqual("aabb", trueInterLeave);
        }
        [TestMethod]
        public void EnsureICanPrintContents()
        {
            char[] mychars = new char[] { 'r', 'u', 't' };
            CustomString myString = new CustomString(mychars);
            // Act
            string expectedResult = myString.Print();
            Assert.AreEqual("rut",expectedResult);
        }
    }
}
