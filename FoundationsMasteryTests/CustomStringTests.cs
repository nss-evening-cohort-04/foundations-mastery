﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoundationsMasteryTests.Classes
{
    [TestClass]
    public class CustomStringTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            
        }
        /*
        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //int expected_length = ??
            //int actual_length = ??

            Assert.AreEqual(expected_length, actual_length);
        }*/

        //[TestMethod]
        //public void EnsureIHaveContents()
        //{
        //    char[] mychars = new char[] { 'a', 'b', 'c' };
        //    CustomString myString = new CustomString(mychars);

        //    // 1. Assert that the Contents property is the correct 'type'
        //    // 2. Assert that the returned Contents is the coorect length
        //}

        //[TestMethod]
        //public void EnsureClearAlwaysSetsEmptyContents()
        //{
        //    CustomString myString = new CustomString();

        //    myString.Clear();

        //    // How do you ensure your clear function works?
        //}
    }
}
