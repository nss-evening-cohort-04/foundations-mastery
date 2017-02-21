using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class TruckTest
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            Truck truck = new Truck();
            Assert.IsNotNull(truck);
        }
    }
}
