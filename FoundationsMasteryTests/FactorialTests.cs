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

            var expectedResult = 120;
            var actualResult = myFactorial.Iterative(5);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial myFactorial = new Factorial();

            var expectedResult = 120;
            var actualResult = myFactorial.Recursive(5);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial myFactorial = new Factorial();
            myFactorial.Recursive(0);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial myFactorial = new Factorial();
            myFactorial.Iterative(-1);
        }
    }
}
