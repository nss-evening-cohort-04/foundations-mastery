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
        {
            CustomString myCustomString = new CustomString();
            Assert.IsNotNull(myCustomString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            //CustomString.Contents myString = new CustomString.Contents(mychars);

            int expected_length = 3;
            int actual_length = mychars.Length;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            int expected_length = 3;
            int actual_length = mychars.Length;

            // 1. Assert that the Contents property is the correct 'type'
            // 2. Assert that the returned Contents is the coorect length
            Assert.AreEqual(expected_length, actual_length);
            Assert.AreNotSame(mychars, myString);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
       
            myString.Clear();

            // How do you ensure your clear function works?
            Assert.Equals(0, myString.Length);
        }
    }

    public interface ICustomString
    {
    }
}
