using FoundationsMastery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class MotorcycleTests
    {
        [TestMethod]
        public void EnsureICanCreateMotorcycleInstance()
        {
            Motorcycle motorcycle = new Motorcycle();

            Assert.IsNotNull(motorcycle);
        }

        [TestMethod]
        public void EnsureICanGetMotorcycleFuelCapacity()
        {
            Motorcycle motorcycle = new Motorcycle();

            var expectedResult = 20;
            var actualResult = motorcycle.GetFuelTankCapacity();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanSetMotorcycleFuelCapacity()
        {
            Motorcycle motorcycle = new Motorcycle();

            motorcycle.SetFuelTankCapacity(30);

            var expectedResult = 30;
            var actualResult = motorcycle.GetFuelTankCapacity();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetMotorcycleFuelType()
        {
            Motorcycle motorcycle = new Motorcycle();

            var expectedResult = "gasoline";
            var actualResult = motorcycle.GetFuelType();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanSetMotorcycleFuelType()
        {
            Motorcycle motorcycle = new Motorcycle();

            motorcycle.SetFuelType("diesel");

            var expectedResult = "diesel";
            var actualResult = motorcycle.GetFuelType();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNumberOfWheels()
        {
            Motorcycle motorcycle = new Motorcycle();

            var expectedResult = 2;
            var actualResult = motorcycle.GetNumberOfWheels();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanSetNumberOfWheels()
        {
            Motorcycle motorcycle = new Motorcycle();

            motorcycle.SetNumberOfWheels(3);

            var expectedResult = 3;
            var actualResult = motorcycle.GetNumberOfWheels();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureBadMotorcycleFuelTypeFails()
        {
            Motorcycle motorcycle = new Motorcycle();

            motorcycle.SetFuelType("ethanol");
        }
    }
}
