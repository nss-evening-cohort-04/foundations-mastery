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
        // Instance of is not null ----- DONE
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            // Arrange
            CustomString myString = new CustomString(new List<char>());

            // Assert
            Assert.IsNotNull(myString);
        }

        // Contents is not null when passing in ienumerable
        [TestMethod]
        public void EnsureContentsIsNotNull()
        {
            // Arrange
            CustomString myString = new CustomString(new List<char>());
            var testContents = myString.Contents;
            // Assert
            Assert.IsNotNull(testContents);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            Assert.IsInstanceOfType(myString.Contents, typeof(IEnumerable<char>));
            Assert.AreEqual(myString.Length, mychars.Length);
            Assert.IsNotNull(myString.Contents);
            CollectionAssert.AreEqual(mychars.ToList(), myString.Contents.ToList());
        }

        // .Length gives accurate count of ienumerable
        [TestMethod]
        public void EnsureCanGrabLength()
        {
            CustomString myString = new CustomString(new List<char> { 'o', 'h', 'i'});
            // Assert
            Assert.AreEqual(3, myString.Length);
        }

        // .Clear removes all characters from .Content
        // .Clear leaves you with a list/array/ienumerable (NOT NULL)
        [TestMethod]
        public void EnsureClearMakesEmpty()
        {
            CustomString myString = new CustomString(new List<char> { 'o', 'h', 'i', 'o' });
            myString.Clear();
            Assert.AreEqual(0, myString.Length);
            Assert.IsNotNull(myString.Contents);
        }

        // concat makes expected string
        [TestMethod]
        public void EnsureConcatMakesString()
        {
            CustomString myString = new CustomString(new List<char> { 'o', 'h', 'i', 'o' });
            CustomString anotherString = new CustomString(new List<char> { 'r', 'i', 'v', 'e', 'r' });
            var answer = myString.Concat(anotherString.Contents);
            Assert.AreEqual("ohioriver", answer);
        }
        // interleave makes expected string
        public void EnsureInterleaveMakesZipper()
        {
            CustomString myString = new CustomString(new List<char> { 'o', 'h', 'i', 'o' });
            CustomString anotherString = new CustomString(new List<char> { 'r', 'i', 'v', 'e', 'r' });
            var answer = myString.Interleave(anotherString.Contents);
            Assert.AreEqual("orhiivor", answer);
        }

        // print makes correct string
        public void EnsureCanPrintString()
        {
            CustomString myString = new CustomString(new List<char> { 'o', 'h', 'i', 'o' });
            var answer = myString.Print();
            Assert.AreEqual("ohio", answer);
        }

    }
}
