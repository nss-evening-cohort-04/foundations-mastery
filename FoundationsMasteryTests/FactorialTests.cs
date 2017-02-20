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
            Factorial myIterative = new Factorial();
            var product = myIterative.Iterative(4);

           int expectedResult = 24;
           int actualResult = product;

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial myRecursive = new Factorial();
            var product = myRecursive.Recursive(4);

            int expectedResult = 24;
            int actualResult = product;

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial myRecursive = new Factorial();
            var product = myRecursive.Recursive(-1);

            string expectedResult = "error";
            var actualResult = new System.ArgumentOutOfRangeException();

            Assert.Fail(expectedResult, actualResult);

        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial myIterative = new Factorial();
            var product = myIterative.Iterative(0);

            string expectedResult = "error";
            var actualResult = new System.ArgumentOutOfRangeException();

            Assert.Fail(expectedResult, actualResult);
        }
    }
}
