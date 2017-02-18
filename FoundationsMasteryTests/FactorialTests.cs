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
            Factorial factorial = new Factorial();
            Assert.IsNotNull(factorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            Factorial factorial = new Factorial();
            int expected = 120;

            int actual = factorial.Iterative(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial factorial = new Factorial();
            int expected = 120;

            int actual = factorial.Recursive(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial factorial = new Factorial();
            int result = factorial.Recursive(0);
        }

        [TestMethod]
       [ExpectedException(typeof(InvalidOperationException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial factorial = new Factorial();
            int result = factorial.Iterative(0);
        }
    }
}
