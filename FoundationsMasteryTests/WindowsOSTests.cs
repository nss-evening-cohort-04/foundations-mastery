using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class WindowsOSTests
    {
        [TestMethod]
        public void EnsureYouCanCreateAnInstanceOf()
        {
            // Act
            WindowsOS windowsos = new WindowsOS();
            Assert.IsNotNull(windowsos);
        }

        [TestMethod]
        public void EnsureDefaultProcessorIsISeven()
        {
            // Act
            WindowsOS windowsos = new WindowsOS();
            // Arrange
            string expectedResult = "I7";
            string actualResult = windowsos.ProcessType;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        // By default the OSType is set to null
        [TestMethod]
        public void EnsureOSIsWindows()
        {
            // Act
            WindowsOS windowsos = new WindowsOS();
            // Arrange
            string expectedResult = "Windows";
            // set os to windows
            windowsos.OS = expectedResult;
            string actualResult = windowsos.OS;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        // This ensures I can also set the name of the OS being used
        [TestMethod]
        public void EnsureNumOfCoresIsWorkingCorrectly()
        {
            // Act
            WindowsOS windowsos = new WindowsOS();
            windowsos.NumOfCores(4);
            // Arrange
            int expectedResult = 4;
            int actualResult = windowsos.ProcessCores;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanReverseAString()
        {
            // Act
            WindowsOS windowsos = new WindowsOS();
            // Arrange
            string expectedResult = "pleH";
            string actualResult = windowsos.ReverseString("Help");
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureSomeoneLookedAtAssignment()
        {
            // Act
            WindowsOS windowsos = new WindowsOS();
            // Arrange
            bool expectedResult = true;
            bool actualResult = Convert.ToBoolean(windowsos.ReverseString("eslaf"));
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
