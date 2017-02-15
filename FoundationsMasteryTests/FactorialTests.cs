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
            Factorial myFactorial = new Factorial();
            Assert.IsNotNull(myFactorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            Factorial myFactorial = new Factorial();
            var expected = 120;
            var actual = myFactorial.Iterative(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial myFactorial = new Factorial();
            var expected = 120;
            var actual = myFactorial.Recursive(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial myFactorial = new Factorial();
            var actual = myFactorial.Iterative(0);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial myFactorial = new Factorial();
            var actual = myFactorial.Recursive(0);
        }
    }
}
