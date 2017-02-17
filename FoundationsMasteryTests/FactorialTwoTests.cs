using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTwoTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            FactorialTwo factorial = new FactorialTwo();

            Assert.IsNotNull(factorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            FactorialTwo factorial = new FactorialTwo();

            int expectedResult = 24;
            int actualResult = factorial.Iterative(4);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            FactorialTwo factorial = new FactorialTwo();

            int expectedResult = 24;
            int actualResult = factorial.Recursive(4);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            FactorialTwo factorial = new FactorialTwo();

            int actualResult = factorial.Recursive(0);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            FactorialTwo factorial = new FactorialTwo();

            int actualResult = factorial.Iterative(0);
        }
    }
}
