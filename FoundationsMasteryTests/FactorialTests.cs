using FoundationsMastery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CustomFactorial factorial = new CustomFactorial();

            Assert.IsNotNull(factorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            CustomFactorial factorial = new CustomFactorial();

            var expectedResult = 120;
            var actualResult = factorial.Iterative(5);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            CustomFactorial factorial = new CustomFactorial();

            var expectedResult = 24;
            var actualResult = factorial.Recursive(4);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            CustomFactorial factorial = new CustomFactorial();

            var actualResult = factorial.Recursive(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            CustomFactorial factorial = new CustomFactorial();

            var actualResult = factorial.Iterative(0);
        }
    }
}
