using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void CreateAnInstance()
        {
            Factorial factorialTest = new Factorial();

            Assert.IsNotNull(factorialTest);
        }

        [TestMethod]
        public void FactorialCalcInterative()
        {
            Factorial interativeTest = new Factorial();

            int expected_sum = 24;
            int actual_sum = interativeTest.Iterative(4);

            Assert.AreEqual(expected_sum, actual_sum);
        }

        [TestMethod]
        public void FactorialCalcRecursive()
        {
            Factorial recursiveTest = new Factorial();

            int expected_sum = 6;
            int actual_sum = recursiveTest.Recursive(3);

            Assert.AreEqual(expected_sum, actual_sum);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "n = 0")]
        public void FactorialCalcRecursiveFails()
        {
            Factorial interativeTest = new Factorial();
            int actual_sum = interativeTest.Iterative(0);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "n = 0")]
        public void FactorialCalcIterativeFails()
        {
            Factorial recursiveTest = new Factorial();
            int actual_sum = recursiveTest.Recursive(0);
        }
    }
}
