using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery.Factorial;


namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            Factorial factorial = new Factorial();
            Assert.IsNotNull(factorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            // Act
            Factorial factorial = new Factorial();
            // Arrange
            int expectedResult = 24;
            int actualResult = factorial.Iterative(4);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            // Act
            Factorial factorial = new Factorial();
            // Arrange
            int expectedResult = 24;
            int actualResult = factorial.Recursive(4);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        // Still needs to be worked on......
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            // Act
            Factorial factorial = new Factorial();
            // Arrange
            int actualResult = factorial.Recursive(-1);
            // Should Fail....
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            // Act
            Factorial factorial = new Factorial();
            // Arrange
            int actualResult = factorial.Iterative(0);
            // Should Fail....
        }
    }
}
