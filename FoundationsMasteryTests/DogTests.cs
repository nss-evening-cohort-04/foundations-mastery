using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            Dog dog = new Dog();

            Assert.IsNotNull(dog);
        }

        [TestMethod]
        public void EnsureICanGetLength()
        {
            Dog dog = new Dog();

            dog.Length = "extremely long";

            Assert.IsNotNull(dog.Length);
        }

        [TestMethod]
        public void EnsureICanGetHeight()
        {
            Dog dog = new Dog();

            dog.Height = 5;

            Assert.IsNotNull(dog.Height);
        }

        [TestMethod]
        public void EnsureICanGetColorOfFur()
        {
            Dog dog = new Dog();

            dog.ColorOfFur = "black";

            Assert.IsNotNull(dog.ColorOfFur);
        }

        [TestMethod]
        public void EnsureICanGetHasTheDogGrownOrNot()
        {
            Dog dog = new Dog();

            int newHeight = 4;
            dog.Height = 5;

            dog.HasGrown = dog.Height + newHeight;

            int expectedResult = 9;
            int actualResult = dog.HasGrown;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
