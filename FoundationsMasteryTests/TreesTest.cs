using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class TreesTest
    {
        [TestMethod]
        public void TestInstanceExist()
        {
            Trees myTrees = new Trees();
            Assert.IsNotNull(myTrees);
        }

        [TestMethod]
        public void TestGrow()
        {
            Trees myTrees = new Trees();
            myTrees.grow(3.5);
            var expected = 13.5;
            var actual = myTrees.height;
            Assert.AreEqual(expected, actual);
        }
    }
}
