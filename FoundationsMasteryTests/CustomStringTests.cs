using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery.Interfaces;
using FoundationsMastery;
using System.Collections.Generic;
using System.Collections;

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

        [TestMethod]
        public void EnsureStringConcatenation()
        {
            //Arrange
            
            var theFirst = new char[] { 'd', 'i', 'n', 'o'};
            var theSecond = new char[] {'5', '6', '7', '8' };
            CustomString baseString = new CustomString(theFirst);
            CustomString stringToAdd = new CustomString(theSecond);

            //Act
            string concatString = baseString.Concat(stringToAdd.Contents);

            //Assert
            Assert.AreEqual("dino5678", concatString);


        }
    }
}
