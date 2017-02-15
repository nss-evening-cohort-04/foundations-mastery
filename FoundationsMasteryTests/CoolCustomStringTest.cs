using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;


namespace FoundationsMasteryTests
{
    [TestClass]
    public class CoolCustomStringTest
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CoolCustomString myCoolCustomString = new CoolCustomString(new char[] { 'a', 'b', 'c', 'd' });
            Assert.IsNotNull(myCoolCustomString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c', 'd' };
            CoolCustomString myString = new CoolCustomString(mychars);

            int expected_length = 4;

            int actual_length = myString.Length;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c', 'd' };
            CoolCustomString myString = new CoolCustomString(mychars);

            // 1. Assert that the Contents property is the correct 'type'
            var expectedType = "System.Char[]";
            var actualType = myString.Contents.GetType().ToString();
            Assert.AreEqual(expectedType, actualType);
            // 2. Assert that the returned Contents is the coorect length
            Assert.AreEqual(4, myString.Length);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            CoolCustomString myString = new CoolCustomString(new char[] { 'a', 'b', 'c', 'd' });

            myString.Clear();

            // How do you ensure your clear function works?
            Assert.IsNull(myString.Contents);
        }

        [TestMethod]
        public void testConcat()
        {
            CoolCustomString myString = new CoolCustomString(new char[] { 'a', 'b', 'c', 'd' });
            var expected = "gefabcd";
            var actual = myString.Concat(new char[] { 'g', 'e', 'f' });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testInterleave()
        {
            CoolCustomString myString = new CoolCustomString(new char[] { 'a', 'b', 'c', 'd' });
            var expected = "aebfcgdhi";
            var actual = myString.Interleave(new char[] { 'e', 'f', 'g', 'h', 'i' });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testPrint()
        {
            CoolCustomString myString = new CoolCustomString(new char[] { 'a', 'b', 'c', 'd' });
            var expected = "abcd";
            var actual = myString.Print();
            Assert.AreEqual(expected, actual);
        }
    }
}
