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
            //arrange
            Factorial factorial = new Factorial();

            //assert
            Assert.IsNotNull(factorial);

        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            //arrange
            Factorial factorial = new Factorial();

            //act
            int expected_result = 120;
            int actual_result = factorial.Iterative(5);

            //assert
            Assert.AreEqual(expected_result, actual_result);

        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {

        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcRecursiveFails()
        {
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcIterativeFails()
        {
        }
    }
}
