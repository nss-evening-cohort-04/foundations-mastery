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
            //arrange
            Factorial factorial = new Factorial();

            //act
            int expected_result = 120;
            int actual_result = factorial.Recursive(5);

            //assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            //arrange
            Factorial factorial = new Factorial();

            //act
            factorial.Recursive(-1);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFactorialCalcIterativeFails()
        {   
            //arrange
            Factorial factorial = new Factorial();

            //act
            var result = factorial.Iterative(0);
        }
    }
}
