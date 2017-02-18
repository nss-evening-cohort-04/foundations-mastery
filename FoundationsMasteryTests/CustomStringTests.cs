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
        [TestMethod]
        public void CreateAnInstance()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            Assert.IsNotNull(myString);
        }

        [TestMethod]
        public void PassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            //CustomString myString = new CustomString();

            int expected_length = 3;
            int actual_length = myString.Length;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void ContentsTest()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            List<char> actual_contents = myString.Contents.ToList();

            

            CollectionAssert.AreEqual(mychars.ToList(), actual_contents);

            // 1. Assert that the Contents property is the correct 'type'
            // 2. Assert that the returned Contents is the coorect length
        }

        [TestMethod]
        public void EmptyContentsTest()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);
            myString.Clear();

            // How do you ensure your clear function works?
            // Contest set to null?

            int expected_length = 0;
            int actual_length = myString.Length;
            //call contents

            Assert.AreEqual(expected_length, actual_length);
            
        }

        [TestMethod]
        public void ConcatTest()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //var rhs = myString.Concat(new char[] { 'x', 'y', 'z' });
            string expected_result = "abcxyz";
            string concat_result = myString.Concat(new char[] { 'x', 'y', 'z' });

            //Assert test of expected and concat result.
            Assert.AreEqual(concat_result, expected_result);
        }

        [TestMethod]
        public void InterleaveTest()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            string expected_result = "axbycz";
            string inter_result = myString.Interleave(new char[] { 'x', 'y', 'z' });

            Assert.AreEqual(inter_result, expected_result);
        }

        [TestMethod]
        public void PrintTest()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            string expected_result = "abc";
            string print_result = myString.Print();

            Assert.AreEqual(print_result, expected_result);
        }
    }
}
