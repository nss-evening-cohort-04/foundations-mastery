using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery.models;

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
            
            int expectedResult = 120;

            int actualResult = factorial.Iterative(5);

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

        //Good when n >= 1
        //so should throw exception if input less than 1
        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial factorial = new Factorial();

            int actualResult = factorial.Recursive(0);
        }


        //Good when n >= 1
        //so should throw exception if input less than 1
        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial factorial = new Factorial();

            int actualResult = factorial.Iterative(0);
        }
    }
}
