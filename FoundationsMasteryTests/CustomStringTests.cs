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
            CustomString myString = new CustomString();
            Assert.IsNotNull(myString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            Assert.IsNotNull(myString);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            Assert.IsInstanceOfType(myString.Contents, typeof(IEnumerable<char>));
         
            // 1. Assert that the Contents property is the correct 'type'

       
            // 2. Assert that the returned Contents is the coorect length
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            CustomString myString = new CustomString();

            myString.Clear();

            //Assert.AreEqual(myString.Clear(), "");

            // How do you ensure your clear function works?
        }
    }
}
