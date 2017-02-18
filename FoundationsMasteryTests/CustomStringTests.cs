using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery.Interfaces;
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
            //Arrange
            CustomString customString = new CustomString();

            //Assert
            Assert.IsNotNull(customString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            //Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //Act
            int expected_length = 3;
            int actual_length = mychars.Length;

            //Assert
            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            //Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //Act
            int expected_length = 3;
            int actual_length = mychars.Length;

            // 1. Assert that the Contents property is the correct 'type'
            Assert.IsInstanceOfType(myString.Contents, typeof(IEnumerable<char>));
            // 2. Assert that the returned Contents is the corect length
            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            //Arrange
            CustomString myString = new CustomString();

            //Act
            //myString.Clear();

            //Assert
            Assert.IsNull(myString.Contents);
        }

        /*[TestMethod]
        public void EnsureStringConcatenation()
        {
            //Arrange

            //Act

            //Assert
        }*/
    }
}
