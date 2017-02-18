using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class BowTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            Bow bow = new Bow();
            Assert.IsNotNull(bow);
        }

        [TestMethod]
        public void EnsureBowHasNoCams()
        {
            Bow bow = new Bow();
            int expectedResult = 0;
            int actualResult = bow.NumberOfCams;
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureConstructorCanSetNumberOfCams()
        {
            Bow bow = new Bow(2);
            int expectedResult = 2;
            int actualResult = bow.NumberOfCams;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureThatProduceStringMusicReturnsProperValue()
        {
            Bow bow = new Bow();

            string expectedResult = "Arrow goes pew pew and makes some music";
            string actualResult = bow.ProduceStringMusic();

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFailOfSettingNumberOfCams()
        {
            Bow bow = new Bow(-1);

        }
    }
}
