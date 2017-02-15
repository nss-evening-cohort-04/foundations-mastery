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
        //ensure Contents is never null, ensure instance of contents for both constructors

            //INSTANCE OF IS NOT NULL
            //CONTENTS IS NOT NULL WITH EMPTY CONSTRUCTOR
            //CONTENTS IS NOT NULL WHEN PASSING IN IENUMERABLE FOR CONTENTS
            //.LENGTH GIVES ACCURATE COUNT OF IENUMERABLE
            //.CLEAR REMOVES ALL CHARS FROM .CONTENTS
            //.CLEAR LEAVES YOU WITH A LIST/ARRAY/IENUMERABLE TO WORK WITH, NOT NULL
            //CONCAT MAKES CORRECT STRING
            //INTERLEAVE MAKES CORRECT STRING
            //PRINT MAKES CORRECT STRING

        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CustomString testString = new CustomString(new List<char>());

            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myOtherString = new CustomString(mychars);

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
            var expected = typeof(IEnumerable<char>);
            var actual = myString.Contents.GetType();


            // 1. Assert that the Contents property is the correct 'type'
            Assert.IsInstanceOfType(myString.Contents, typeof(IEnumerable<char>));

            // 2. Assert that the returned Contents is the correct length
            Assert.AreEqual(myString.Length, mychars.Length);

            Assert.IsNotNull(myString.Contents);
            CollectionAssert.AreEqual(mychars.ToList(), myString.Contents.ToList());
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
