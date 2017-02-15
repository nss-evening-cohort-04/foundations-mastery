using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstanceofFactorial()
        {
            Factorial myFactorial = new Factorial();

            Assert.IsNotNull(myFactorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcIterative()
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
