using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;
using FoundationsMastery.Factorial;

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
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial factorial = new Factorial();

            int actualResult = factorial.Recursive(0);

        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial factorial = new Factorial();

            int actualResult = factorial.Iterative(0);
        }
    }
    
}
