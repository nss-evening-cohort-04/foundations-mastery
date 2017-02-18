﻿using FoundationsMastery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class MotorVehicleTests
    {
        [TestMethod]
        public void EnsureICanCreateMotorVehicleInstance()
        {
            MotorVehicle motorVehicle = new MotorVehicle();

            Assert.IsNotNull(motorVehicle);
        }

        [TestMethod]
        public void EnsureICanGetFuelCapacity()
        {
            MotorVehicle motorVehicle = new MotorVehicle();

            var expectedResult = 20;
            var actualResult = motorVehicle.GetFuelTankCapacity();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanSetFuelCapacity()
        {
            MotorVehicle motorVehicle = new MotorVehicle();

            motorVehicle.SetFuelTankCapacity(30);

            var expectedResult = 30;
            var actualResult = motorVehicle.GetFuelTankCapacity();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetFuelType()
        {
            MotorVehicle motorVehicle = new MotorVehicle();

            var expectedResult = "gasoline";
            var actualResult = motorVehicle.GetFuelType();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanSetFuelType()
        {
            MotorVehicle motorVehicle = new MotorVehicle();

            motorVehicle.SetFuelType("diesel");

            var expectedResult = "diesel";
            var actualResult = motorVehicle.GetFuelType();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintMotorVehicleFacts()
        {
            MotorVehicle motorVehicle = new MotorVehicle();

            var expectedResult = "A motor vehicle is a self-propelled road vehicle and off-road vehicle, commonly wheeled, that does not operate on rails, such as trains or trams and used for commercial purposes on the highways in the transportation of passengers, or passengers and property.";
            var actualResult = motorVehicle.PrintFacts();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureBadFuelTypeFails()
        {
            MotorVehicle motorVehicle = new MotorVehicle();

            motorVehicle.SetFuelType("ethanol");
        }
    }
}
