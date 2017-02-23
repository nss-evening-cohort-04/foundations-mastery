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
            //arrange
            CustomString createinstance = new CustomString();
            
            //act

            //assert
            Assert.IsNotNull(createinstance);
        }
        
        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            //arrange
            //act
            //assert
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString instance = new CustomString(mychars);
            int expected_length = 3;
            //int actual_length = instance.Length;
           // Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            //arrange
            //act
            //assert
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            // 1. Assert that the Contents property is the correct 'type'
            //Assert.AreEqual(myString.Contents.GetType(),typeof(IEnumerable<char>));

        // 2. Assert that the returned Contents is the correct length
            int expected_length = 3;
            //int actual_length = myString.Contents.ToString; // not length - look up other methods;
            //Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            //arrange
            //act
            //assert
            CustomString myString = new CustomString(null);
            //myString.Clear();
            

        // How do you ensure your clear function works?
    }
    }
}
