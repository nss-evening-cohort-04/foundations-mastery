using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CustomStringTests 
    {


        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {   //arrange
            CustomString myCustomString = new CustomString();

            //assert
            Assert.IsNotNull(myCustomString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            //arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            //CustomString myString = new CustomString(mychars);

            //act
            int expected_length = 3;
            int actual_length = mychars.Length;

            //assert
            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            //arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //act
            int expected_length = 3;
            int actual_length = mychars.Length;

            //assert
            Assert.AreEqual(expected_length, actual_length);
            Assert.AreNotSame(mychars, myString);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            //arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            CustomString myStringNotNull = new CustomString(mychars);

            //act
            myString.Clear();

            //assert
            Assert.IsNull(myString.Contents);
            Assert.IsNotNull(myStringNotNull.Contents);
        }
    }

        public interface ICustomString
        {
    } 
}
