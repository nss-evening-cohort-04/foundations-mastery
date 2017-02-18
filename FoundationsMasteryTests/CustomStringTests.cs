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

            int expectedLength = 3;
            int actualLength = myString.Length;

            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            var expected = typeof(IEnumerable<char>);
            var actual = myString.Contents.GetType();

            Assert.IsInstanceOfType(myString.Contents, typeof(IEnumerable<char>));
            Assert.AreEqual(myString.Length, mychars.Length);

            Assert.IsNotNull(myString.Contents);
            CollectionAssert.AreEqual(mychars.ToList(), myString.Contents.ToList());
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            CustomString myString = new CustomString();

            myString.Clear();

        }

        [TestMethod]
        public void EnsureICanConcat()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            var expectedResult = "abcdef";
            var actualResult = myString.Concat(new char[] {'d', 'e', 'f' });

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanInterleave()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            var expectedResult = "adbecf";
            var actualResult = myString.Interleave(new char[] { 'd', 'e', 'f' });

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrint()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            var expectedResult = "abc";
            var actualResult = myString.Print();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
