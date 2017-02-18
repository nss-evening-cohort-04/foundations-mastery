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
            //Arrange
            Factorial myFactorial = new Factorial();
            
            //Act (not needed here)

            //Assert
            Assert.IsNotNull(myFactorial);            
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            //Arrange
            Factorial myFactorial = new Factorial();
            
            //Act
            //4*3*2*1
            int expected_value = 24;
            int actual_value = myFactorial.Iterative(4);

            //Assert
            Assert.AreEqual(expected_value, actual_value);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            //Arrange
            Factorial myFactorial = new Factorial();

            //Act
            //4*3*2*1
            int expected_value = 24;
            int actual_value = myFactorial.Recursive(4);

            //Assert
            Assert.AreEqual(expected_value, actual_value);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcRecursiveFails()
        {
            //Arrange
            Factorial myFactorial = new Factorial();

            //Fail
            //int failureResult = myFactorial.Recursive(0);
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        public void EnsureFactorialCalcIterativeFails()
        {
            //Arrange
            Factorial myFactorial = new Factorial();

            //Fail
            //int failureResult = myFactorial.Iterative(-3);
        }
    }
}
