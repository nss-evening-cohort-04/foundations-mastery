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
            Factorial factorial = new Factorial();

            //assert
            Assert.IsNotNull(factorial);

        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {

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
