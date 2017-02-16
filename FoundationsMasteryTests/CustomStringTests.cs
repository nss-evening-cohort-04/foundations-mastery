using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMasteryTests;
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
            // Arrange
            CustomString myString = new CustomString(new List<char>());

            //Act
            //Assert
            Assert.IsNotNull(myString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            //Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //Act
            int expected_length = 3;
            int actual_length = myString.Length;

            //Assert
            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            //Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //Assert and Act Combined need to fix to make more clear
            Assert.IsInstanceOfType(myString.Contents,typeof(IEnumerable<char>));
            Assert.AreEqual(myString.Length, mychars.Length);
            Assert.IsNotNull(myString.Contents);
            Assert.IsNotNull(mychars);
            
            // Better version of test
            CollectionAssert.AreEqual(mychars.ToList(), myString.Contents.ToList());// Another way to test 
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            //Arrange
            CustomString myString = new CustomString();

            ////Act
            myString.Clear();

            ////Assert
            Assert.IsNull(myString.Contents);
        }

        [TestMethod]
        public void EnsureIcanPrint()
        {
            //Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //Act
            var expectedResult = "abc";
            var actualResult = myString.Print();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureInterleave()
        {
            //Arrange
            CustomString myString = new CustomString(new char[] { 'a', 'b', 'c' });

            //Act
            var expectedResult = "adbecf";
            var actualResult = myString.Interleave(new char[] { 'd', 'e', 'f'}); 

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureConcat()
        {
            //Arrange
            CustomString myString = new CustomString(new char[] { 'a', 'b', 'c' });

            //Act
            var expectedResult = "abcdef";
            var actualResult = myString.Concat(new char[] { 'd', 'e', 'f' }); ;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
