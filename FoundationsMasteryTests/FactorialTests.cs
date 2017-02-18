using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMasteryTests;
using FoundationsMastery;
using System.Collections.Generic;
using FoundationsMastery.Interfaces;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            Factorial myFactorial = new Factorial();
            Assert.IsNotNull(myFactorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            Factorial myFactorial = new Factorial();
            int myAnswer = myFactorial.Iterative(5);
            Assert.AreEqual(myAnswer, 24); 
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial myFactorial = new Factorial();
            int myAnswer = myFactorial.Recursive(5);
            Assert.AreEqual(myAnswer, 120); 
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
            Factorial myFactorial = new Factorial();
            int myAnswer = myFactorial.Recursive(0);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureFactorialCalcIterativeFails()
        {
            Factorial myFactorial = new Factorial();
            int myAnswer = myFactorial.Iterative(0);
        }
    }
}
