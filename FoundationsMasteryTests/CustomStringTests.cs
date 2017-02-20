using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;
using System.Linq;

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
            CustomString myString = new CustomString(mychars);

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
            int actual_length = myString.Length;

            //assert
            Assert.AreEqual(expected_length, actual_length);
            Assert.AreNotEqual(mychars, myString);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            //arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            Assert.IsNotNull(myString.Contents);
            Assert.AreEqual(3, myString.Length);

            //act
           // int expectedContents = 0;
            myString.Clear();

            //assert
            Assert.AreEqual(0, myString.Length);
        }

        [TestMethod]
        public void EnsureCanConcat()
        {   
            ////arrange
            //CustomString myString = new CustomString(new char[] { 'a', 'b', 'c' });
           
            ////act
            //var expecting = "abcdef";
            //var actuality = myString.Concat(new char[] { 'd', 'e', 'f' });

            ////assert
            //Assert.AreEqual(expecting, actuality);
        }

        [TestMethod]
        public void EnsureCanInterleave()
        {

        }

        [TestMethod]
        public void EnureCanPrint()
        {

        }



        public interface ICustomString
        {
        }
    } 
}
