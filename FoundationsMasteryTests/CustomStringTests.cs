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
        // Contents is not null when passing in ienumerable
        // .Length gives accurate count of ienumerable
        // .Clear removes all characters from .Content
        // .Clear leaves you with a list/array/ienumerable (NOT NULL)
        // concat makes expected string
        // interleave makes expected string
        // print makes correct string

        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            // Arrange
            CustomString myString = new CustomString(new List<char>());

            // Assert
            Assert.IsNotNull(myString);
        }

        [TestMethod]
        public void EnsureContentsIsNotNull()
        {
            // Arrange
            // Act
            // Assert
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

    }
}
