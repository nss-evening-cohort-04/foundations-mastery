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
            int actual_length = mychars.Length;

            Assert.AreEqual(expected_length, actual_length);
        }
        
        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString();


            int expected_length = 3;
            int actual_length = mychars.Length;


            Assert.IsInstanceOfType(mychars, typeof(Char[]));
            
            Assert.AreEqual(expected_length, actual_length);

        }
        
        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString();

            myString.Clear();

            int expected_length = 0;
            int actual_length = myString.Length;

            Assert.AreEqual(expected_length, actual_length);
                
            // How do you ensure your clear function works?
        }

        [TestMethod]
        public void EnsureICanGetLength()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString();

            int expected_length = 3;
            int actual_length = mychars.Length;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureICanConcat()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString();

            string expected_string = "the quick brown fox jumps over the lazy dogthis is the second string";

            string totallyNewString = String.Concat("the quick brown fox jumps over the lazy dog", "this is the second string");
  
            Assert.AreEqual(expected_string, totallyNewString);
        }

        [TestMethod]
        public void EnsureICanInterLeave()
        {
            
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            IEnumerable<char> moreChars = new char[] { '1', '2', '3' };
           
            string expectedResult = "a1b2c3";
            string actualResult = myString.Interleave(moreChars);
          
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureICanPrint()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString();

            string expected_output = "abc";
            string actual_output = String.Concat(mychars);

            Assert.AreEqual(expected_output, actual_output);
        }
    }
    
}
