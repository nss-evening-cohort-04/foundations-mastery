using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery.CustomString;
using System.Collections.Generic;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CustomStringTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            // Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            // Act
            int expectedLength = 3;
            int actualLength = myString.Length;

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            // Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            // Act
            Type type = typeof(FoundationsMastery.CustomString.CustomString);
            int expectedLength = 3;
            int actualLength = myString.Length;

            // Assert
            // 1. Assert that the Contents property is the correct 'type'
            Assert.IsInstanceOfType(myString, type);
            // 2. Assert that the returned Contents is the correct length
            Assert.AreEqual(expectedLength, actualLength);

        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            // Arrange
            // Set Contents to a value
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            CustomString myStringNotNull = new CustomString(mychars);

            // Act
            // Set Contents to null
            myString.Clear();

            // Assert
            // How do you ensure your clear function works?
            // Test to see if Contents is null
            Assert.IsNull(myString.Contents);
            // To Prove it works I created a NotNullAssert
            Assert.IsNotNull(myStringNotNull.Contents);
        }

        [TestMethod]
        public void EnsureConcatIsCreatingCorrectString()
        {
            // Act
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            // Arrange
            string expectedResult = "abc";
            string actualResult = myString.Concat(myString.Contents);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureInterleaveIsCreatingCorrectString()
        {
            // Act
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            IEnumerable<char> moreChars = new char[] { 'd', 'e', 'f' };
            // Arrange
            string expectedResult = "adbecf";
            string actualResult = myString.Interleave(moreChars);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintIsWorkingCorrectly()
        {
            // Act

            // Arrange

            // Assert
        }
    }
}
