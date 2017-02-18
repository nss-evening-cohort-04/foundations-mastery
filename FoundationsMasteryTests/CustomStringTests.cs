using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;
using FoundationsMastery.Interfaces;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CustomStringTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            //Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //Act (nothing to Act for this)

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
            int expected_length_other = mychars.Length;
            int actual_length = myString.Length;


            //Assert
            Assert.AreEqual(expected_length, actual_length);
            Assert.AreEqual(expected_length_other, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            // 1. Assert that the Contents property is the correct 'type'
            // 2. Assert that the returned Contents is the coorect length
            /* #2 is redudant to tests above */

            //Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //Act
            int expected_length = mychars.Length;
            int actual_length = myString.Length;

            //Assert
            Assert.AreEqual(expected_length, actual_length);
            Assert.IsInstanceOfType(mychars, typeof(Char[]));            
        }

        [TestMethod]
        public void EnsureICanConcatinate()
        {
            //Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            char[] newchars = new char[] { '1', '2', '3' };

            //Act
            string expected_string = "abc123";
            string actual_string = myString.Concat(newchars);

            //Assert
            Assert.AreEqual(expected_string, actual_string);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetEmptyContents()
        {
            //Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //Act
            myString.Clear();

            //Assert
            Assert.AreEqual(null, myString.Contents);
            //better way of saying it:
            Assert.IsNull(myString.Contents);
        }

        [TestMethod]
        public void EnsureInterleaving()
        {
            //Arrange
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //Act
            string expected_interleave = "axbycz";
            string actual_interleave = myString.Interleave(new char[] { 'x', 'y', 'z' });


            //Assert
            Assert.AreEqual(expected_interleave, actual_interleave);
        }
    }
}
