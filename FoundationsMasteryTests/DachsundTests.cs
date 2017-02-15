using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class DachsundTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            Dachsund maggie = new Dachsund();

            Assert.IsNotNull(maggie);
        }

        [TestMethod]
        public void EnsureICanGetLength()
        {
            Dachsund maggie = new Dachsund();

            maggie.Length = "extremely very super duper long";

            Assert.IsNotNull(maggie.Length);
        }
        
        [TestMethod]
        public void EnsureICanGetHeight()
        {
            Dachsund maggie = new Dachsund();

            maggie.Height = 2;

            int expectedResult = 2;
            int actualResult = maggie.Height;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetColorOfFur()
        {
            Dachsund maggie = new Dachsund();

            maggie.ColorOfFur = "black";

            Assert.IsNotNull(maggie.ColorOfFur);
        }
      

        [TestMethod]
        public void EnsureICanGetHasTheDogGrownOrNot()
        {
            Dachsund maggie = new Dachsund();

            int newerHeight = 3;

            int hasGrown = maggie.Height + newerHeight;

            int expectedResult = 3;
            int actualResult = hasGrown;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
