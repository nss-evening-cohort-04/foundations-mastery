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
            Factorial factorialTest = new Factorial();

            Assert.IsNotNull(factorialTest);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            Factorial interativeTest = new Factorial();

            int expected_sum = 1;
            int actual_sum = interativeTest.Iterative(1);

            Assert.AreEqual(expected_sum, actual_sum);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial recursiveTest = new Factorial();

            int expected_sum = 6;
            int actual_sum = recursiveTest.Recursive(3);

            Assert.AreEqual(expected_sum, actual_sum);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(ArgumentException), "n = 0")]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial interativeTest = new Factorial();

            int expected_sum = 0;
            int actual_sum = interativeTest.Iterative(0);

            Assert.AreEqual(expected_sum, actual_sum);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(ArgumentException), "n = 0")]
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial recursiveTest = new Factorial();

            int expected_sum = 0;
            int actual_sum = recursiveTest.Recursive(0);

            Assert.AreEqual(expected_sum, actual_sum);
        }
    }
}
