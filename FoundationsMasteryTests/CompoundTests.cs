using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CompoundTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            Compound compound = new Compound();
            Assert.IsNotNull(compound);
        }

        [TestMethod]
        public void EnsureCompoundHasTwoCams()
        {
            Compound compound = new Compound();
            int expectedResult = 2;
            int actualResult = compound.NumberOfCams;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureCompoundDefaultFPS()
        {
            Compound compound = new Compound();
            int expectedResult = 100;
            int actualResult = compound.FPS;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanSetFPS()
        {
            Compound compound = new Compound(335);
            int expectedResult = 335;
            int actualResult = compound.FPS;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureThatProduceStringLengthIsOverridden()
        {
            Compound compound = new Compound();

            string expectedResult = "Arrow goes pew pew really fast and makes beautiful string music";
            string actualResult = compound.ProduceStringMusic();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
