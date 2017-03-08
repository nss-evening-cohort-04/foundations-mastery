using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery.Classes;

namespace FoundationsMasteryTests.Classes
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
            int expectedResult = 24;
            int actualResult = factorial.Iterative(4);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial factorial = new Factorial();
            int expectedResult = 120;
            int actualResult = factorial.Recursive(5);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected? 
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial factorial = new Factorial();
            var result = factorial.Recursive(-5);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial factorial = new Factorial();
            var result = factorial.Recursive(-5);
        }
    }
}
