using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CellphoneTests
    {
        [TestMethod]
        public void EnsureICanCreateInstanceOfCellphone()
        {
            Cellphone myCellphone = new Cellphone();
            Assert.IsNotNull(myCellphone);
        }

        [TestMethod]
        public void EnsureICanCreateInstanceOfCustomCellphone()
        {
            Cellphone myCellphone = new Cellphone(16,true, "IPhone 7");

            var expectedMemory = 16;
            var actualMemory = myCellphone.MemoryGB;
            Assert.AreEqual(expectedMemory, actualMemory);

            var expectedScreen = true;
            var actualScreen = myCellphone.Touchscreen;
            Assert.AreEqual(expectedScreen, actualScreen);

            var expectedModel = "IPhone 7";
            var actualModel = myCellphone.Model;
            Assert.AreEqual(expectedModel, actualModel);
        }

        [TestMethod]
        public void EnsureOperatingSystemReturnsCorrectString()
        {
            Cellphone myCellphone = new Cellphone();

            var expectedResult = "Operating System used:";
            var actualResult = myCellphone.OperatingSystem();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureMemoryRecallReturnsProperValue()
        {
            Cellphone myCellphone = new Cellphone();

            var expectedResult = 0;
            var actualResult = myCellphone.MemoryGB;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
