using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;
using System.Collections.Generic;

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

            //Act
            //Assert
            Assert.IsNotNull(myFactorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            // DONT THINK THIS TEST IS WORKING PROPERLY
            // Arrange
            Factorial myFactorial = new Factorial();

            //Act
            int expectedResult = 0;
            int actualResult = myFactorial.Iterative(4);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            // Arrange
            Factorial myFactorial = new Factorial();

            //Act
            int expectedResult = 24;
            int actualResult = myFactorial.Recursive(4);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcRecursiveFails()
        {
            // Arrange
            Factorial myFactorial = new Factorial();

            //Act
            var actualResult = myFactorial.Recursive(0);

        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            // Arrange
            Factorial myFactorial = new Factorial();

            //Act
            var actualResult = myFactorial.Iterative(0);

        }
    }
}
