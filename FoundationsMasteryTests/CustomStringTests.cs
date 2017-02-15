﻿using System;
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
            CustomString myCustomString = new CustomString(new char[] { 'a', 'b', 'c' });
            Assert.IsNotNull(myCustomString);
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

            // 1. Assert that the Contents property is the correct 'type'
            var expectedType = "System.Char[]";
            var actualType = myString.Contents.GetType().ToString();
            Assert.AreEqual(expectedType, actualType);
            // 2. Assert that the returned Contents is the coorect length
            Assert.AreEqual(3, myString.Length);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            CustomString myString = new CustomString(new char[] { 'a', 'b', 'c' });

            myString.Clear();

            // How do you ensure your clear function works?
            Assert.IsNull(myString.Contents);
        }

        [TestMethod]
        public void testConcat()
        {
            CustomString myString = new CustomString(new char[] { 'a', 'b', 'c' });
            var expected = "abcdef";
            var actual = myString.Concat(new char[] { 'd', 'e', 'f' });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testInterleave()
        {
            CustomString myString = new CustomString(new char[] { 'a', 'b', 'c' });
            var expected = "adbecfgh";
            var actual = myString.Interleave(new char[] { 'd', 'e', 'f', 'g', 'h' });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testPrint()
        {
            CustomString myString = new CustomString(new char[] { 'a', 'b', 'c' });
            var expected = "abc";
            var actual = myString.Print();
            Assert.AreEqual(expected, actual);
        }
    }
}
