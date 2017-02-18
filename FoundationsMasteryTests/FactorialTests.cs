using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery.Interfaces;

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

        /*[TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            //Assert
            Factorial factorial = new Factorial();
            int n = 5;

            //Act
            expected_result = 120;

            //Assert
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
