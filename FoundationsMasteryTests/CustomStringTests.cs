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
            var charType = myString.GetType();

            // 1. Assert that the Contents property is the correct 'type'
            char[] newChars = new char[] { 'x', 'y', 'z' };
            var newType = newChars.GetType();

            Assert.AreEqual(charType, newType);

            // 2. Assert that the returned Contents is the coorect length
            //int expected_length = myString.Length;
            //int actual_length = 4;
            //Assert.AreEqual(expected_length, actual_length); 
        }

        //[TestMethod]
        //public void EnsureClearAlwaysSetsEmptyContents()
        //{
        //    CustomString myString = new CustomString(mychars);

        //    myString.Clear();

        //    // How do you ensure your clear function works?
        //}

        [TestMethod]
        public void EnsureConcatWorks()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            char[] otherchars = new char[] { 'x', 'y', 'z' };
            var expected = myString.Concat(otherchars);
            var actual = "axbycz";

            Assert.AreEqual(expected, actual);
        }
    }
}
