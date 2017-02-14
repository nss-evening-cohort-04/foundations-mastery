using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            // Arrange
            Factorial myFactorial = new Factorial();

            // Assert
            Assert.IsNotNull(myFactorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            // Arrange
            Factorial myFactorial = new Factorial();
            // Act
            int theAnswer = myFactorial.Iterative(3);
            // Assert
            Assert.AreEqual(theAnswer, 6);

        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            // Arrange
            Factorial myFactorial = new Factorial();
            // Act
            int theAnswer = myFactorial.Recursive(4);
            // Assert
            Assert.AreEqual(theAnswer, 24);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            // Arrange
            
            // Act
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            // Arrange
            
            // Act
            
        }
    }
}
