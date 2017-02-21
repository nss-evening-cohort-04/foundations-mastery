using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class PetsTest
    {
        [TestMethod]
        public void EnsureICanCreateInstanceOfPets()
        {
            Pets myPet = new Pets();
            Assert.IsNotNull(myPet);    
        }
    }
}
