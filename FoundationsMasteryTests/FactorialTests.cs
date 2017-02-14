using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            // Arrange
            var iterative = new Iterative(int 5);

            // Assert
            Assert.IsNotNull(iterative);
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
