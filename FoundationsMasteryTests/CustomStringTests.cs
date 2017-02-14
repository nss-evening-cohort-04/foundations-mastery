﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            CustomString testString = new CustomString();

            Assert.IsNotNull(testString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            int expected_length = 3;
            int actual_length = myString.Length;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            //public IEnumerable<char> Contents;
            //Contents testContents = new Contents;

            //int expected_length = 3;
            //int actual_length = myString.Length;

            //// 1. Assert that the Contents property is the correct 'type'
            //Assert.IsInstanceOfType(Contents.GetType(), typeof(contents));

            //// 2. Assert that the returned Contents is the correct length
            //CollectionAssert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            CustomString myString = new CustomString();

            myString.Clear();

            // How do you ensure your clear function works?
        }
    }
}
