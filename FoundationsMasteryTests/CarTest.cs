using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void EnsureICanCreateCar()
        {
            Car car = new Car();
        }
    }
}
