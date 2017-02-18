using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class SamsungTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstanceOfSamsung()
        {
            Samsung myCellphone = new Samsung(16, true, "Galaxy S7");
            Assert.IsNotNull(myCellphone);
        }

        [TestMethod]
        public void EnsureOperatingSystemReturnsProperString()
        {
            Samsung myCellphone = new Samsung(16, true, "Galaxy S7");

            var expectedResult = "Operating System used: Android";
            var actualResult = myCellphone.OperatingSystem();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureMemoryRecallReturnsProperInt()
        {
            Samsung myCellphone = new Samsung(16, true, "Galaxy S7");

            var expectedResult = 16;
            var actualResult = myCellphone.MemoryRecall();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
