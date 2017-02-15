using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CoolFactorialTest
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CoolFactorial myCoolFactorial = new CoolFactorial();
            Assert.IsNotNull(myCoolFactorial);
        }

        [TestMethod]
        public void EnsureCoolFactorialCalcInterative()
        {
            CoolFactorial myCoolFactorial = new CoolFactorial();
            var expected = 15;
            var actual = myCoolFactorial.Iterative(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureCoolFactorialCalcRecursive()
        {
            CoolFactorial myCoolFactorial = new CoolFactorial();
            var expected = 15;
            var actual = myCoolFactorial.Recursive(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void EnsureCoolFactorialCalcRecursiveFails()
        {
            CoolFactorial myCoolFactorial = new CoolFactorial();
            var actual = myCoolFactorial.Iterative(0);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void EnsureCoolFactorialCalcIterativeFails()
        {
            CoolFactorial myCoolFactorial = new CoolFactorial();
            var actual = myCoolFactorial.Recursive(0);
        }
    }
}
