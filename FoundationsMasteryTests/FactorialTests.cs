using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;
using FoundationsMastery.Interfaces;
using System.Collections;
using System.Collections.Generic;

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

       /* [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            //Assert
            Factorial factorial = new Factorial();
            int n = 5;

            //Act
            int expected_result = 120;
            int actual_result = Iterative(n);

            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }*/

        /*[TestMethod]
        public void EnsureFactorialCalcRecursive()
        {

        }*/

        /*[TestMethod]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcRecursiveFails()
        {
        }*/

        /*[TestMethod]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcIterativeFails()
        {
        }*/
    }
}
