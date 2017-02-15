using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void EnsureYouCanCreateAnInstanceOf()
        {
            // Act
            Computer computer = new Computer();
            Assert.IsNotNull(computer);
        }

        [TestMethod]
        public void EnsureDefaultRamAmount()
        {
            // Act
            Computer computer = new Computer();
            // Arrange
            int expectedResult = 2;
            int actualResult = computer.RamAmount;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        // By default the OSType is set to null
        [TestMethod]
        public void EnsureDefaultOSIsNull()
        {
            // Act
            Computer computer = new Computer();
            // Arrange
            string expectedResult = null;
            string actualResult = computer.OS;
            // Assert
            Assert.IsNull(expectedResult, actualResult);
        }
        // Invoking computer.OsType() sets the OS to "Linux"
        [TestMethod]
        public void EnsureDefaultOSIsCorrect()
        {
            // Act
            Computer computer = new Computer();
            computer.OsType();
            // Arrange
            string expectedResult = "Linux";
            string actualResult = computer.OS;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        // This ensures I can also set the name of the OS being used
        [TestMethod]
        public void EnsureOsTypeOverloadIsWorkingCorrectly()
        {
            // Act
            Computer computer = new Computer();
            computer.OsType("DoesItMatter");
            // Arrange
            string expectedResult = "DoesItMatter";
            string actualResult = computer.OS;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
