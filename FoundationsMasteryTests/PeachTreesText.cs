using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class PeachTreesText
    {
        [TestMethod]
        public void TestInstanceExist()
        {
            PeachTrees myTrees = new PeachTrees();
            Assert.IsNotNull(myTrees);
        }

        [TestMethod]
        public void TestGrow()
        {
            PeachTrees myTrees = new PeachTrees();
            myTrees.grow(3.5);
            var expected = 12.7;
            var actual = myTrees.height;
            Assert.AreEqual(expected, actual);
        }
    }
}
