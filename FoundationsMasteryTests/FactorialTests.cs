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
            Factorial iterate = new Factorial();
            Assert.IsNotNull(iterate);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            Factorial iterate = new Factorial();

            var expectedResult = 24;
            var actualResult = iterate.Iterative(4);

            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {

            Factorial iterate = new Factorial();

            var expectedResult = 24;
            var actualResult = iterate.Recursive(4);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException),
        "Expecting value above zero.")]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial iterate = new Factorial();
            iterate.Recursive(0);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial iterate = new Factorial();
            iterate.Iterative(0);
        }

    }
}
