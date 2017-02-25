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
            Factorial myFactorial = new Factorial();

            Assert.IsNotNull(myFactorial);
        }

       [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
 
            Factorial myFactorial = new Factorial();
            int iterativeAnswer = myFactorial.Iterative(5);
            Assert.AreEqual(120, iterativeAnswer);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial myFactorial = new Factorial();
            int recursiveAnswer = myFactorial.Recursive(6);
            Assert.AreEqual(720, recursiveAnswer);
        }

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
