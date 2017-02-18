using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstanceofFactorial()
        {
            Factorial myFactorial = new Factorial();

            Assert.IsNotNull(myFactorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcIterative()
        {
            // Arrange 
            Factorial myFactorial = new Factorial();
            // Act
            int actualResult = 24;
            int expectedResult = myFactorial.Iterative(4);
            // Assert
            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial myFactorial = new Factorial();

            int actualResult = 24;
            int expectedResult = myFactorial.Recursive(4);
            
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial myFactorial = new Factorial();

            int actualResult = myFactorial.Recursive(0);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial myFactorial = new Factorial();

            int actualResult = myFactorial.Iterative(0);

        }
    }
}
