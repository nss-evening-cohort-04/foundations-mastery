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
            int expectedResult = 3628800;
            int actualResult = factorial.Iterative(10);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive1()
        {
            Factorial factorial = new Factorial();
            int expectedResult = 3628800;
            int actualResult = factorial.Recursive(10);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive2()
        {
            Factorial factorial = new Factorial();
            int expectedResult = 24;
            int actualResult = factorial.Recursive(4);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial factorial = new Factorial();
            factorial.Recursive(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial factorial = new Factorial();
            factorial.Iterative(0);
        }
    }
}
