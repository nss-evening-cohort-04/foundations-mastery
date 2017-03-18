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
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString instance = new CustomString(mychars);
            //act

            //assert
            Assert.IsTrue(instance.Contents.Any());
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            //arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            // 1. Assert that the Contents property is the correct 'type'
            //Assert.AreEqual(myString.Contents.GetType(),typeof(IEnumerable<char>));

            // 2. Assert that the returned Contents is the correct length
            
            //int actual_length = myString.Contents.ToString; // not length - look up other methods;
            Assert.IsTrue(myString.Contents.Any());
        }



        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            //arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            
            //act
            myString.Clear();

            //assert
            Assert.IsFalse(myString.Contents.Any());
    }
    }
}
